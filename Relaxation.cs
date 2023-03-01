using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLaba1
{
    public class Relaxation
    {
        double eps;
        public Relaxation(double e = 1e-3) 
        {
            eps = e;
            RelaxationMethod();
        }

        double func(double x)
        {
            return Math.Pow(x, 3) + 3 * Math.Pow(x, 2) - x - 3;
        }

        double Dfun(double x) 
        {
            return 3 * Math.Pow(x, 2) + 6 * x - 1;
        }

        void RelaxationMethod()
        {
            double a = -3.5f;
            double b = -2.5f;
            double min, max, t;
            min = Dfun(b);
            max = Dfun(a);
            t = 2 / (max + min);

            double x0 = a;
            double xn;
            double sub = 0;

            int i = 1;
            Console.WriteLine($" Iteration 1: x = {x0}\tf(x) = {func(x0)}");
            do
            {
                xn = x0 - t * func(x0);
                sub = Math.Abs(xn - x0);
                x0= xn;
                Console.WriteLine($" Iteration {++i}: x = {x0}\tf(x) = {func(x0)}");
            } while (sub > eps);
        }
    }
}
