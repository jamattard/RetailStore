﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }


        private string _itemQuantity;

        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => _itemQuantity);
            }
        }


        public string SubTotal
        {
            // TODO: replace with calculation
            get { return "€0.00"; }
        }

        public string Tax
        {
            // TODO: replace with calculation
            get { return "€0.00"; }
        }

        public string Total
        {
            // TODO: replace with calculation
            get { return "€0.00"; }
        }


        public bool CanAddToCart
        {
            get
            {
                // something must be selected and item quantiy set


                return false;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                // something must be selected and item quantiy set


                return false;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                // something must be selected and item quantiy set


                return false;
            }
        }

        public void CheckOut()
        {

        }


    }
}
