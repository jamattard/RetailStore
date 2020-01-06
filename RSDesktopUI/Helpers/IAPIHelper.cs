using System.Threading.Tasks;
using RSDesktopUI.Models;

namespace RSDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}