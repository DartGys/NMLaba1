using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMLaba1
{
    public class Newton
    {
        double eps;
        public Newton(double e = 1e-3) 
        {
            eps = e;
            NewtonMethod();
        }

        double func(double x)
        {
            return Math.Pow(x, 3) + Math.Pow(x, 2) - 4 * x - 4;
        }

        double Dfun(double x)
        {
            return 3 * Math.Pow(x, 2) + 2 * x - 4;
        }

        void NewtonMethod()
        {
            double a = -2.5f;
            double b = -1.5f;
            double x = a;
            
            int i = 1;
            Console.WriteLine($" Iteration 1: x = {x}\tf(x) = {func(x)}");
            do
            {
                x -= func(x) / Dfun(x);
                Console.WriteLine($" Iteration {++i}: x = {x}\tf(x) = {func(x)}");
            } while(Math.Abs(func(x)) > eps);
        }
    }
}
