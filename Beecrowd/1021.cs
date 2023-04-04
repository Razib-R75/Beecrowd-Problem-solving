using System;

class Program
{
    static void Main(string[] args)
    {
        double[] note = { 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

        int i, t, l=0, h,y;
        double cost, temp;

        cost = double.Parse(Console.ReadLine());

        double te = cost;
        
        Console.WriteLine("NOTAS:");
        for (i = 0; i <= 5; i++)
        {
            t = (int)(cost / note[i]);
            cost = cost - (t * note[i]);

            Console.WriteLine(t + " nota(s) de R$ " + note[i].ToString("0.00"));
            l =  l + (int)(t * note[i]);
        }
        temp = te - l;
       
        Console.WriteLine("MOEDAS:");




        for (i = 6; i <= 11; i++)
        {
            y = (int)(temp / note[i]);
            temp -=  (y * note[i]);

            temp = Math.Round(temp, 2);
          
            Console.WriteLine(y + " moeda(s) de R$ " + note[i].ToString("0.00"));
          
        }
        Console.ReadKey();
    }
}
