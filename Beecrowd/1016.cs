using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            X = Convert.ToInt32(Console.ReadLine());
            Y = 2*X;
            Console.WriteLine(Y + " minutos");

            Console.ReadKey();
        }
    }
}