using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_var1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            double c = 34;
            double d = 4;
            double x = (a*2 + b*2 + c*2 + d*2) / ((a+b)*2 + (c+d)*2);

            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
