using System;

namespace _1037_Intervalo
{
   class Program
    {
        static void Main(string[] args)
        {
            string input;
            int X, Y;
            double Price, Total;
            input = Console.ReadLine();
            string[] inpAr = input.Split(' ');
            X = Convert.ToInt32(inpAr[0]);
            Y = Convert.ToInt32(inpAr[1]);
            if (X == 1)
            {
                Price = 4.00;
            }
            else if (X == 2)
            {
                Price = 4.50;
            }
            else if (X == 3)
            {
                Price = 5.00;
            }
            else if (X == 4)
            {
                Price = 2.00;
            }
            else
            {
                Price = 1.50;
            }
            Total = Y * Price;
            Console.WriteLine("Total: R$ " + Total.ToString("f2"));

            Console.ReadKey();
        }
     }
}
