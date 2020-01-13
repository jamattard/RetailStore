using RSDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RSDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);

    }
}