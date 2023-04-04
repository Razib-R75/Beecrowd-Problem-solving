using System;

class Program
{
    static void Main(string[] args)
    {
        float n, s = 0, p = 0, k = 0;
        while (true)
        {
            if (k == 1)
            {
                s = p = 0;
                k = 0;
            }
            if (float.TryParse(Console.ReadLine(), out n))
            {
                if (n < 0.0 || n > 10.0)
                    Console.WriteLine("nota invalida");
                else
                {
                    s += n;
                    p++;
                    if (p == 2)
                    {
                        s /= 2;
                        Console.WriteLine("media = {0:0.00}", s);
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        while (true)
                        {
                            if (float.TryParse(Console.ReadLine(), out n))
                            {
                                if ((int)n == 1)
                                {
                                    s = p = 0;
                                    k = 1;
                                    break;
                                }
                                else if ((int)n == 2)
                                    return;
                                else
                                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                            }
                            else
                                Console.WriteLine("novo calculo (1-sim 2-nao)");
                        }
                    }
                }
            }
            else
                Console.WriteLine("valor invalido");
        }
    }
}
