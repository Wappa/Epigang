using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
       string[] summerStrut = new string[]  {"Juice", "Missing U", "Raspberry Beret" , "Los Angeles" , "New York Groove","Make Me Feel","Rebel Rebel" , "Despacito"};
       int[] ratings = new int[] {1,2,3,4,5};
    }
  }
}

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      if(summerStrut.Length == 8)
      {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      }
      else if(summerStrut.Length > 8)
      {
        Console.WriteLine("Too many songs");
      }
      else
      {
        Console.WriteLine("Add some songs!");
      }
    }
  }
}

namespace AccessingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      string Missing_U = summerStrut[1];
      int Star = ratings[1];
      Console.WriteLine($" You rated the song {Missing_U} {Star} stars.");
    }
  }
}

namespace EditingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      summerStrut[7] = "Cardi B";

      ratings[7]=1; 
    }
  }
}

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      int threeRating = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");

      string findName = Array.Find(summerStrut, song => song.Length > 10);

      Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");

      Array.Sort(summerStrut);
      string firstSong = summerStrut[0];
      string lastSong = summerStrut[7];
      Console.WriteLine($"The first song in the playlist is now {firstSong}.");
      Console.WriteLine($"The last song in the playlist is now {lastSong}.");

    }
  }
}

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      string[] summerStrutCopy = new string[summerStrut.Length];
      Array.Copy(summerStrut, summerStrutCopy , summerStrut.Length);
      Array.Reverse(summerStrut);
      Array.Clear(ratings,0,ratings.Length);
    }
  }
}

namespace ArraysReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program!
      Here's what you learned:

      Building Arrays
      .Length Property
      Accessing and Editing Arrays using bracketNotation[]
      Built-in-Methods: Sort(), IndexOf(), Find()

      Good luck! */
    }
  }
}
