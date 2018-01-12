using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReadifyChallenge.Implemt_Services
{
    public class ServiceToDetectTriangleShape
    {
        public TriangleType DetectShape(int a, int b, int c)
        {
            var result = TriangleType.Error;

            if (!this.IsValidTriangle(a, b, c))
            {
                return TriangleType.Error;
            }
            else if (this.IsEquilateral(a, b, c))
            {
                result = TriangleType.Equilateral;
            }
            else if (this.IsScalene(a, b, c))
            {
                result = TriangleType.Scalene;
            }
            else if (this.IsIsosceles(a, b, c))
            {
                result = TriangleType.Isosceles;
            }

            return result;
        }
        protected bool IsValidTriangle(int a, int b, int c)
        {
            bool bExist = true;
            if (a <= 0 || b <= 0 || c <= 0)
            {
                bExist = false;
            }
            else if (((long)a + b) <= c)
            {
                bExist = false;
            }
            else if (((long)a + c) <= b)
            {
                bExist = false;
            }
            else if (((long)b + c) <= a)
            {
                bExist = false;
            }

            return bExist;
        }

        protected bool IsEquilateral(int a, int b, int c)
        {
            return (a == b && a == c);
        }

        protected bool IsIsosceles(int a, int b, int c)
        {
            return (a == b || a == c || b == c);
        }

        protected bool IsScalene(int a, int b, int c)
        {
            return (a != b && a != c && b != c);
        }
    }
}
