using System;

class MainClass 
{

  public static void Main (string[] args)
   {
    string[] start = Console.ReadLine().Split(' ');
    int startDay = int.Parse(start[1]);

    string[] startTime = Console.ReadLine().Split(':');
    int startHour = int.Parse(startTime[0]);
    int startMinute = int.Parse(startTime[1]);
    int startSecond = int.Parse(startTime[2]);

    string[] end = Console.ReadLine().Split(' ');
    int endDay = int.Parse(end[1]);

    string[] endTime = Console.ReadLine().Split(':');
    int endHour = int.Parse(endTime[0]);
    int endMinute = int.Parse(endTime[1]);
    int endSecond = int.Parse(endTime[2]);

    int totalSeconds = (endDay - startDay) * 86400 +
        (endHour - startHour) * 3600 +
        (endMinute - startMinute) * 60 +
        (endSecond - startSecond);

    int days = totalSeconds / 86400;
    totalSeconds %= 86400;

    int hours = totalSeconds / 3600;
    totalSeconds %= 3600;

    int minutes = totalSeconds / 60;
    totalSeconds %= 60;

    Console.WriteLine($"{days} dia(s)");
    Console.WriteLine($"{hours} hora(s)");
    Console.WriteLine($"{minutes} minuto(s)");
    Console.WriteLine($"{totalSeconds} segundo(s)");
  }
}