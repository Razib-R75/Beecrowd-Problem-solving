using System;

    class Program
    {
        static void Main(string[] args)
        {
        int age,remain, YEAR, DAY,MONTH;
        age = Convert.ToInt32(Console.ReadLine());
        YEAR = age / 365;
        remain = age - (YEAR * 365);
        MONTH = remain / 30;
        DAY  = remain - (MONTH * 30);
         


        Console.WriteLine(YEAR +" ano(s)");
        Console.WriteLine(MONTH +" mes(es)");
        Console.WriteLine(DAY + " dia(s)");

        Console.ReadKey();
        }
    }