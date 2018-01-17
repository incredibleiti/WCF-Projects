using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class TokenController : ApiController
    {
        protected Guid gtoken = new Guid("bad28c7a-c95a-48b7-99c7-5b38dbafae8a");
        public Guid GET()
        {
            return this.gtoken;
        }
    }
}
