using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input1, Input2;
            double X1, Y1, X2, Y2, Distance;
            Input1 = Console.ReadLine();
            Input2 = Console.ReadLine();

            X1 = Convert.ToDouble(Input1.Split()[0]);
            Y1 = Convert.ToDouble(Input1.Split()[1]);
            X2 = Convert.ToDouble(Input2.Split()[0]);
            Y2 = Convert.ToDouble(Input2.Split()[1]);

            Distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            Console.WriteLine(Distance.ToString("f4"));

            Console.ReadKey();
        }
    }
}