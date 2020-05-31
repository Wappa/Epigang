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

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {

    }
    static string Whisper(string weez,out bool flip)
    {
        flip = true;
        return weez.ToLower();
        string message = "AAAAAAAPERO";
        Whisper(message, out bool flag);
    }
  }
}

namespace OutErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GARRRR";
      bool marker;
      string murmur = Whisper(statement, out marker);
      Console.WriteLine(murmur);
    }

    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
 }
}

namespace ReviewMethodOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      // Define variables
      string destination = "Neptune";
      string galaxyString = "8";
      int galaxyInt;
      string welcomeMessage;
      bool outcome;

      // Call DecoratePlanet() and TryParse() here
      welcomeMessage = DecoratePlanet(destination);
      outcome = Int32.TryParse(galaxyString, out galaxyInt);

      // Print results
      Console.WriteLine(welcomeMessage);
      Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");

    }

    // Define a method that returns a string
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }

    // Define a method with out
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
    }
}
