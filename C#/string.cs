using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length

      int passwordLength = password.Length; 


      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];

      // Get last name
      charPosition = name.IndexOf("Abbasi");
      string lastName = name.Substring(charPosition);

      // Print results
      Console.WriteLine($"{firstLetter}. {lastName}");

    }
  }
}

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, length);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase
      cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      sceneDescription = sceneDescription.ToLower();

      // Print results
      Console.WriteLine($"{cameraDirections} {sceneDescription}");
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

      DATA TYPES: char, string
      STRING INTERPOLATION: $"blah blah"
      STRING INFO: .Length, .IndexOf()
      PARTS OF STRINGS: bracketNotation[], .Substring()
      STRING MANIPULATION: .ToUpper(), .ToLower()

      Good luck! */


    }
  }
}
