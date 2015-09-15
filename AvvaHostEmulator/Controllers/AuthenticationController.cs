using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AvvaHostEmulator.Controllers
{
    public class AuthenticationController : ApiController
    {
        // POST: api/Authentication
        public bool Post([FromBody]string secret)
        {
            return true;
        }
    }
}
