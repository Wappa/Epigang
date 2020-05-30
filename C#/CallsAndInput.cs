namespace CallAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      Math.Min(5,2);
      Console.WriteLine(msg);
      msg.Substring(0,1);
    }
  }
}

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
      int indexOfSpace = designer.IndexOf(" ");
      string secondName = designer.Substring(indexOfSpace, designer.length);
      Console.WriteLine(secondName);
    }
  }
}

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
    }
    static void VisitPlanets()
      {
        Console.WriteLine("You visited many new planets…");
      }
  }
}

using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(1);
      VisitPlanets(-1);
      VisitPlanets(72);
    }

    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets();
      VisitPlanets();
    }

    static void VisitPlanets(int numberOfPlanets=0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(numberOfPlanets: 2, name: "Farfel");

    }

    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut",
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }

    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }

    static void NamePets(string pet1, string pet2, string pet3)
    {
      Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
    }

    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}
