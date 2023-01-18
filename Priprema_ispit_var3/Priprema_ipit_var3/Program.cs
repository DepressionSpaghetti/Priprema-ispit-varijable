using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ipit_var3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;

            Console.WriteLine("Napisite recenicu.\n");
            s1 = Console.ReadLine();

            string []rijec = s1.Split(' ');

            s2 = rijec.First() + "\n" + rijec.Last();

            Console.WriteLine(s2);
            Console.ReadKey();
            
        }
    }
}
