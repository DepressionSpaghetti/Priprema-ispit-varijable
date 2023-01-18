using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_var4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string broj;
            int x;
            double y;

            Console.WriteLine("Upisite jedan cijeli i jedan decimalni broj, odvojite ih razmakom.");
            broj = Console.ReadLine();

            x = Convert.ToInt32(broj.Substring(0, 1)) * 2;
            y = Convert.ToDouble(broj.Substring(2)) * 2;

            Console.WriteLine("x = {0}\ny = {1}", x, y);
            Console.ReadKey();
        }
    }
}
