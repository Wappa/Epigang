namespace IfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int socks = 6;
      if(socks <= 3)
      {
          Console.WriteLine("Time to do laundry!");
      }
    }
  }
}

namespace IfElseStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int people = 12;
      string weather = "bad";
      if(people <= 10 && weather== "nice")
      {
        Console.WriteLine("SaladMart");
      }
      else
      {
          Console.WriteLine("Soup N Sandwich");
      }
    }
  }
}

namespace ElseIfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int guests = 0;
      if (guests >= 4)
      {
        Console.WriteLine("Catan");
      }
      else if(guests >= 1 && guests <= 4)
      {
        Console.WriteLine("Innovation");
      }
      else
      {
          Console.WriteLine("Solitaire");
      }
    }
  }
}

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      string genre = "Horror";
      switch(genre)
      {
        case "Drama":
        Console.WriteLine("Citizen Kane");
        break;
        case "Comedy":
        Console.WriteLine("Duck Soup");
        break;
        case "Adventure":
        Console.WriteLine("King Kong");
        break;
        case "Science Fiction":
        Console.WriteLine("2001: A Space Odyssey");
        break;
        case "Horror":
        Console.WriteLine("Psycho");
        break;
        default:
        Console.WriteLine("No movie found");
        break;
      }
    }
  }
}

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      int pepperLength = 4;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
      Console.WriteLine(message);
    }
  }
}
namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      CONDITIONALS: if, if...else, else if
      SWITCH STATEMENT: switch (condition)
      TERNARY OPERATOR: (condition) ? true : false

      Good luck! */


    }
  }
}


