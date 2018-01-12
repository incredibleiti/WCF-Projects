using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadifyChallenge.Implemt_Services
{
    public class ServiceToReverseString
    {
        public string ReverseString(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word), "String is null.");
            }
            else
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);

                return new string(charArray);
            }
        }
    }
}
