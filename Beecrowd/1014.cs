using System;


namespace ur__1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            float Y, Ml;
            X = Convert.ToInt32(Console.ReadLine());
            Y = float.Parse(Console.ReadLine());
            Ml = X/Y;
           Console.WriteLine($"{Ml.ToString(("f3"))} km/l");
            Console.ReadKey();
        } 
    }
}
