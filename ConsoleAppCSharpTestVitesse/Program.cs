using System;

namespace ConsoleAppCSharpTestVitesse
{
  internal class Program
  {
    static void Main()
    {
      double result = 0;

      for (int i = 0; i < 1_000_000_000; ++i)
      {

        result += i * 0.5;

      }

      Console.WriteLine(result);
      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
