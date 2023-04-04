using System;

class Program
{
    static void Main(string[] args)
    {
        int password;

        while (true)
        {
            password = int.Parse(Console.ReadLine());

            if (password == 2002)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
                Console.WriteLine("Senha Invalida");
        }
    }
}
