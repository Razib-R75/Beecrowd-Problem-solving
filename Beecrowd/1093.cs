using System;

class Program {
    static double foo(int x, int n2, int at) {
        double d;

        if(at == 3) {
            return (double)x/(double)(x + n2);
        }else{
            d = 1.0 - (6 - at)/6.0;
            d = (1 - d)/d;
            return (1.0 - Math.Pow(d, x))/(1.0 - Math.Pow(d, x + n2));
        }
    }

    static void Main(string[] args) {
        int ev1, ev2, at, d, tmp;
        double p;

        while (true) {
            string[] line = Console.ReadLine().Split();
            ev1 = int.Parse(line[0]);
            ev2 = int.Parse(line[1]);
            at = int.Parse(line[2]);
            d = int.Parse(line[3]);

            if (ev1 == 0 && ev2 == 0 && at == 0 && d == 0) break;

            tmp = ev1; ev1 = 0;
            while(tmp > 0) {
                tmp -= d;
                ev1++;
            }
            tmp = ev2; ev2 = 0;
            while(tmp > 0) {
                tmp -= d;
                ev2++;
            }

            p = foo(ev1, ev2, at);
            Console.WriteLine("{0:f1}", p * 100);
        }
    }
}
