using System;

class Program {
    static void Main(string[] args) {
        string line;
        while ((line = Console.ReadLine()) != "-1") {
            if (line.StartsWith("0x")) {
                int dec = Convert.ToInt32(line, 16);
                Console.WriteLine("{0}", dec);
            }
            else {
                int hex = int.Parse(line);
                Console.WriteLine("0x{0:X}", hex);
            }
        }
    }
}