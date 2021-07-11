using System;

namespace Intro
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("What is your name? ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
      Console.WriteLine("What are your plans today? ");
      string plans = Console.ReadLine();
            Console.WriteLine($"Nice! Hope you have a good time while you {plans}");
    }
  }
}
