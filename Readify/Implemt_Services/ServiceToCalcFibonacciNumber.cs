using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadifyChallenge.Implemt_Services
{
    public class ServiceToCalcFibonacciNumber
    {
        public long CalculateFibonacci(long n)
        {
            //if (n <= 1)
            //{
            //    return n;
            //}
            //return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);

            var num = Math.Pow((1.0 + Math.Sqrt(5.0)), n) - Math.Pow((1.0 - Math.Sqrt(5.0)), n);
            var den = Math.Pow(2.0, n) * Math.Sqrt(5.0);
            var result = num / den;

            var fresult = Math.Round(result);

            return (long)fresult;
        } 

        public async void CalculateFibonacciAsync(long n)
        {
            await Task.Run(() =>
            {
                CalculateFibonacci(n);

            }).ContinueWith((task) =>
            {

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
