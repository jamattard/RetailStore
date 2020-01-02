using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace RSDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            // we can return the proper http return code - e.g. OK (200), CONTENT NOT FOUND (400), SERVER ERROR (500), etc
            return Ok( new string[] { "value1", "value2", userId });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
