using System;
namespace Calculate {
    class Program { 
        static void Main(string[] args)
        { 
            string fLine, lLine; 
            int A, B, X, Y;
            double C, Z, result;
            fLine = Console.ReadLine();
            lLine = Console.ReadLine();
            A = Convert.ToInt32(fLine.Split(' ')[0]);
            B = Convert.ToInt32(fLine.Split(' ')[1]); 
            C = Convert.ToDouble(fLine.Split(' ')[2]); 
            X = Convert.ToInt32(lLine.Split(' ')[0]); 
            Y = Convert.ToInt32(lLine.Split(' ')[1]); 
            Z = Convert.ToDouble(lLine.Split(' ')[2]); 
            result= (B * C) + (Y * Z); 
            Console.WriteLine("VALOR A PAGAR: R$ " + result.ToString("f2"));
            Console.ReadKey(); 
        
        }
    } 
}