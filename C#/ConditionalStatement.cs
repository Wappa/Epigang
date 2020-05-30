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


