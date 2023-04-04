using System;

class Program
{
    static void Main(string[] args)
    {
        double first, second, third, fourth, last, sum;
        first = double.Parse(Console.ReadLine());
        second = double.Parse(Console.ReadLine());
        third = double.Parse(Console.ReadLine());
        fourth = double.Parse(Console.ReadLine());
        sum = (first * 2 + second * 3 + third * 4 + fourth) / 10;
        Console.WriteLine("Media: " + sum.ToString("F1"));
        if (sum >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (sum >= 5.0)
        {
            Console.WriteLine("Aluno em exame.");
            last = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + last.ToString("F1"));
            if (last + sum / 2.0 > 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: " + ((last + sum) / 2.0).ToString("F1"));
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
