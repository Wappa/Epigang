using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Jupiter"));
    }
    static string DecoratePlanet(string planet)
    {
      return $" *.*.* Welcome to {planet} *.*.*";
    }
  }
}

namespace ReturnErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Mars"));
      Console.WriteLine("Is Pluto really a dwarf...?");
      Console.WriteLine(IsPlutoADwarf());
      Console.WriteLine("Then how many planets are there in the galaxy...?");
      Console.WriteLine(CountThePlanets());
    }

    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }

    static bool IsPlutoADwarf()
    {
      bool answer = true;
      return answer;
    }

    static string CountThePlanets()
    {
      return "8 planets, usually";
    }
  }
}

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;
      bool outcome;
      outcome = Int32.TryParse(ageAsString ,out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);

      //Second Method
      int nameAsInt;
      bool outcome2;
      outcome2 = Int32.TryParse(nameAsString ,out nameAsInt);
      Console.WriteLine(outcome2);
      Console.WriteLine(ageAsString);
    }
  }
}
