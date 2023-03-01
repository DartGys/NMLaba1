using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLaba1
{
    public class SimpleIteration
    {
        double eps;
        public SimpleIteration(double e = 1e-3)
        { 
            eps = e;
            SimpleIterationMethod();
        }
        double func(double x)
        {
            return Math.Pow(x, 3) - 4 * Math.Pow(x, 2) - 4 * x + 16;
        }

        double Gfun(double x)
        {
            return Math.Pow(4 * Math.Pow(x, 2) + 4 * x -16, (double)1/3);
        }

        void SimpleIterationMethod()
        {
            double xn = 4.5f;
            double xnext;
            int i = 0;
            while(true)
            {
                xnext = Gfun(xn);
                if (Math.Abs(xnext - xn) < eps) break;
                xn = xnext;
                Console.WriteLine($" Iteration {++i}: x = {xnext}\tf(x) = {func(xnext)}");
            }
        }
    }
}
