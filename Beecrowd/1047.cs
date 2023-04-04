using System; 

class MainClass {
  public static void Main (string[] args) {
    string[] input = Console.ReadLine().Split();
    int startHour = int.Parse(input[0]);
    int startMin = int.Parse(input[1]);
    int endHour = int.Parse(input[2]);
    int endMin = int.Parse(input[3]);

    int totalMinutes = ((endHour * 60) + endMin) - ((startHour * 60) + startMin);
    if (totalMinutes <= 0) {
        totalMinutes += 24 * 60; // add 24 hours if end time is before start time
    }
    int durationHour = totalMinutes / 60;
    int durationMin = totalMinutes % 60;

    Console.WriteLine($"O JOGO DUROU {durationHour} HORA(S) E {durationMin} MINUTO(S)");
  }
}