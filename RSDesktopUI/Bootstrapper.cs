using Caliburn.Micro;
using RSDesktopUI.Helpers;
using RSDesktopUI.Library.Api;
using RSDesktopUI.Library.Models;
using RSDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RSDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        // Simple Container is part of Caliburn and is a a container for dependency injection
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();

            ConventionManager.AddElementConvention<PasswordBox>(
            Helpers.PasswordBoxHelper.BoundPasswordProperty,
            "Password",
            "PasswordChanged");
        }

        // override to use our DI container
        protected override void Configure()
        {
            // whenever we ask for the container, it will return THIS container
            _container.Instance(_container);

            _container
                .Singleton<IWindowManager, WindowManager>()  // service to manage windows
                .Singleton<IEventAggregator, EventAggregator>() // for event handling - singleton
                .Singleton<ILoggedInUserModel, LoggedInUserModel>()
                .Singleton<IAPIHelper, APIHelper> ();           // http client created and ready to use

            // refelction to rope in view models on start up 
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // startup view model using caliburn and micro -  application will launch correct VM on startup
            DisplayRootViewFor<ShellViewModel>();
        }

        // override to use our DI container
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        // override to use our DI container
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        // override to use our DI container
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
