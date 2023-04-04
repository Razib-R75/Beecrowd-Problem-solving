using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            double x, y, z, Triangle, Circle,Trapezium, Square, Rectangle, pi = 3.14159;
            line = Console.ReadLine();
            x = Convert.ToDouble(line.Split(' ')[0]);
            y = Convert.ToDouble(line.Split(' ')[1]);
            z = Convert.ToDouble(line.Split(' ')[2]);
            
            Triangle = 0.5 * x * z;
            Circle = pi * Math.Pow(z, 2);
            Trapezium = ((x + y) / 2) * z;
            Square = Math.Pow(y, 2);
            Rectangle = x * y;

            Console.WriteLine("TRIANGULO: " + Triangle.ToString("f3"));
            Console.WriteLine("CIRCULO: " + Circle.ToString("f3"));
            Console.WriteLine("TRAPEZIO: " + Trapezium.ToString("f3"));
            Console.WriteLine("QUADRADO: " + Square.ToString("f3"));
            Console.WriteLine("RETANGULO: " + Rectangle.ToString("f3"));

            Console.ReadKey();
        }
    }
}