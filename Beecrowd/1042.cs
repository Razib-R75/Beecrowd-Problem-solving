using System;
using System.Linq;

namespace _1042_Simple_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int w, y, z;
            inp = Console.ReadLine();
            string[] inpArray = inp.Split(' ');
            w = Convert.ToInt32(inpArray[0]);
            y = Convert.ToInt32(inpArray[1]);
            z = Convert.ToInt32(inpArray[2]);
            int[] intArray = new int[] { w, y, z };
            int[] newInt = intArray.OrderBy(x => x).ToArray();

            for (int i = 0; i < newInt.Length; i++)
            {
                Console.WriteLine(newInt[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < inpArray.Length; i++)
            {
                Console.WriteLine(inpArray[i]);
            }

            Console.ReadKey();
        }
    }
}