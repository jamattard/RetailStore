using Microsoft.AspNet.Identity;
using RSDataManager.Library.DataAccess;
using RSDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RSDataManager.Controllers
{
    [System.Web.Http.Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();
            return data.GetUserById(userId).First();

        }
    }
}