using System;

class Program
{
    static void Main()
    {
        int winInter = 0, winGremio = 0, draws = 0, totalMatches = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int interGoals = int.Parse(input[0]);
            int gremioGoals = int.Parse(input[1]);

            totalMatches++;

            if (interGoals > gremioGoals)
                winInter++;
            else if (gremioGoals > interGoals)
                winGremio++;
            else
                draws++;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 2)
                break;
        }

        Console.WriteLine($"{totalMatches} grenais");
        Console.WriteLine($"Inter:{winInter}");
        Console.WriteLine($"Gremio:{winGremio}");
        Console.WriteLine($"Empates:{draws}");

        if (winInter > winGremio)
            Console.WriteLine("Inter venceu mais");
        else if (winGremio > winInter)
            Console.WriteLine("Gremio venceu mais");
        else
            Console.WriteLine("Nao houve vencedor");
    }
}

