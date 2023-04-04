using System;

class URI {
static void Main(string[] args) {
int[] arr = new int[300];


int n, c = 1, a, b, ta, tp, fp;
bool bo = false;

while((n = int.Parse(Console.ReadLine())) != 0) {
  if(bo) Console.WriteLine();
  bo = true;

  ta = tp = 0;
  Array.Clear(arr, 0, arr.Length);

  for (int i = 0; i < n; ++i) {
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    ta += b;
    tp += a;
    arr[b/a] += a;
  }

  Console.WriteLine($"Cidade# {c}:"); c++;

  for(int i = 0, j = 0; i < 300; i++) {
    if(arr[i] > 0) {
      if(j != 0)
        Console.Write(" ");
      Console.Write($"{arr[i]}-{i}");
      j++;   
    }  
  }
  Console.WriteLine();

  fp = (int) (Math.Truncate((double)ta/tp * 100) % 100);

  if(fp < 10) Console.WriteLine($"Consumo medio: {(int)(ta/tp)}.0{fp} m3.");
  else Console.WriteLine($"Consumo medio: {(int)(ta/tp)}.{fp} m3.");
}
}
}