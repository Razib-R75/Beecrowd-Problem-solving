using System;

class Program {
    static void Main(string[] args) {
        float a, b, c, perimeter, area;
        string[] input = Console.ReadLine().Split();

        a = float.Parse(input[0]);
        b = float.Parse(input[1]);
        c = float.Parse(input[2]);

        if ((a + b) > c && (b + c) > a && (c + a) > b) {
            perimeter = a + b + c;
            Console.WriteLine("Perimetro = {0:F1}", perimeter);
        } else {
            area = 0.5f * (a + b) * c;
            Console.WriteLine("Area = {0:F1}", area);
        }
    }
}
