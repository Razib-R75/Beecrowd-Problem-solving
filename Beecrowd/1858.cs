using System;

class MainClass {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] times = Console.ReadLine().Split();

    int minTimeIndex = 0;
    int minTime = int.Parse(times[0]);
    for (int i = 1; i < n; i++) {
      int currentTime = int.Parse(times[i]);
      if (currentTime < minTime) {
        minTime = currentTime;
        minTimeIndex = i;
      }
    }

    Console.WriteLine(minTimeIndex + 1);
  }
}