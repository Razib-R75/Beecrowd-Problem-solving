using System;

namespace uri_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Name;
            float H, P;
            Double S;
            Name = Console.ReadLine();
            H = float.Parse(Console.ReadLine());
            P = float.Parse(Console.ReadLine());
            S = (H+(P*0.15));
       
            Console.WriteLine($"TOTAL = R$ {S.ToString("f2")}");
            Console.ReadKey();

        }
    }
}