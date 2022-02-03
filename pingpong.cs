using System;

public class PingPong
{

  public static void Main() 
  {
  Console.WriteLine("Enter a number: ");
  string stringPingPong = Console.ReadLine();
  PingPong.PingPongSounds(stringPingPong);
  }
  
  public static void PingPongSounds(string stringPingPong)
  {

    string PingPongString = stringPingPong;
    int PingPongNumber = int.Parse(PingPongString);

    for (int number = PingPongNumber; number >=0; number--)
    {
      if (number % 5 == 0 && number % 3 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (number % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (number % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
  }
}