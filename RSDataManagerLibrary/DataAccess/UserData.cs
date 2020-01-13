using RSDataManager.Library.Internal.DataAccess;
using RSDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSDataManager.Library.DataAccess
{
    // Information from the User table
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            // attribute "Id" is named the same as table field name
            var p = new { Id = id };

            var output =  sql.LoadData<UserModel, dynamic>("[dbo].[spUserLookup]", p, "RSDataConnection");
            return output;
        }
    }
}
