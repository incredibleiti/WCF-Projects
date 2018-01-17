using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class FibonacciController : ApiController
    {
        public long GET(long n)
        {
            var num = Math.Pow((1.0 + Math.Sqrt(5.0)), n) - Math.Pow((1.0 - Math.Sqrt(5.0)), n);
            var den = Math.Pow(2.0, n) * Math.Sqrt(5.0);
            var result = num / den;
            var fresult = Math.Round(result);
            return (long)fresult;
        }
    }
}
