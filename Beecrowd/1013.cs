using System;

namespace Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int x, y, z, MajorAB, Major;

            x = Convert.ToInt32(inp.Split()[0]);
            y = Convert.ToInt32(inp.Split()[1]);
            z = Convert.ToInt32(inp.Split()[2]);

            MajorAB = (x +y + Math.Abs(x - y)) / 2;
            Major = (MajorAB + z + Math.Abs(MajorAB - z)) / 2;

            Console.WriteLine(Major + " eh o maior");

            Console.ReadKey();
        }
    }
}