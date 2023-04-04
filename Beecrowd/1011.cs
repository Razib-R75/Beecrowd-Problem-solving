using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R;
            Double Res, pi = 3.14159;
            R = Convert.ToInt32(Console.ReadLine());
            Res = (4/3.0) * pi * Math.Pow(R,3);
            Console.WriteLine($"VOLUME = {Res.ToString("f3")}");
            Console.ReadKey();
        }
    }
}