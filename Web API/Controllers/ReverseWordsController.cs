using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ReverseWordsController : ApiController
    {
        public string GET(string sentence)
        {
            if (sentence == null)
            {
                throw new ArgumentNullException(nameof(sentence), "String is null.");
            }
            else
            {
                char[] charArray = sentence.ToCharArray();
                Array.Reverse(charArray);

                return new string(charArray);
            }
        }
    }
}
