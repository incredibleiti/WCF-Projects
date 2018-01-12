using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TestReadifyChallenge.Implemt_Services;

namespace TestReadifyChallenge
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ImpReadifyRedPillService : IRedPill
    {
        protected Guid gtoken = new Guid("bad28c7a-c95a-48b7-99c7-5b38dbafae8a");
        public Guid WhatIsYourToken()
        {
            var properties = new Dictionary<string, string> { { "Token", this.gtoken.ToString() } };
            return this.gtoken;
        }

        public long FibonacciNumber(long n)
        {
            long result = 0;

            try
            {
                result = new ServiceToCalcFibonacciNumber().CalculateFibonacci(n);
            }
            catch (ArgumentOutOfRangeException)
            {
                // The ArgumentOutOfRangeException is expected, therefore re-throw it further.
                throw;
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public string ReverseWords(string s)
        {
            string result = string.Empty;

            try
            {
                result = new ServiceToReverseString().ReverseString(s);
            }
            catch (ArgumentNullException)
            {
                // The ArgumentNullException is expected, therefore re-throw it further.
                throw;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            var properties = new Dictionary<string, string> { { "Argument 'a'", a.ToString() }, { "Argument 'b'", b.ToString() }, { "Argument 'c'", c.ToString() } };

            TriangleType result = TriangleType.Error;

            try
            {
                result = new ServiceToDetectTriangleShape().DetectShape(a, b, c);
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public Task<Guid> WhatIsYourTokenAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> FibonacciNumberAsync(long n)
        {
            throw new NotImplementedException();
        }

        public Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public Task<string> ReverseWordsAsync(string s)
        {
            throw new NotImplementedException();
        }
    }
}
