using System;

namespace StaticMembers
{
  class Forest
  {
    // FIELDS
    
    public int age;
    private string biome;
    private int forestCreated;
    
    // CONSTRUCTORS
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }

    
    public Forest(string name) : this(name, "Unknown")
    {
      ForestsCreated += 1;
     }
    
    // PROPERTIES
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public  static int ForestsCreated 
    {get; private set;}

    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    public int Age
    {
      get { return age; }
      private set { age = value; }
    }

    // METHODS

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    private static int forestsCreated;
  }
}

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {

    }
  }
}

namespace StaticMembers
{
  class Forest
  {
    // FIELDS

    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;

    // CONSTRUCTORS

    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }

    public Forest(string name) : this(name, "Unknown")
    { }

    // PROPERTIES

    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    public int Age
    {
      get { return age; }
      private set { age = value; }
    }

    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }

    public static string TreeFacts
    {
      get { return treeFacts; }
    }

    // METHODS

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }

    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }

  }

}

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {

    }
  }
}

namespace StaticMembers
{
  class Forest
  {
    // FIELDS

    public int age;
    private string biome;
    private static int forestsCreated;
    private static string treeFacts;

    // CONSTRUCTORS

    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
      ForestsCreated++;
    }

    static Forest()
    {
      this.treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      this.ForestsCreated = 0;
    }

    public Forest(string name) : this(name, "Unknown")
    { }


    // PROPERTIES

    public string Name
    { get; set; }

    public int Trees
    { get; set; }

    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    public int Age
    {
      get { return age; }
      private set { age = value; }
    }

    public static int ForestsCreated
    {
      get { return forestsCreated; }
      private set { forestsCreated = value; }
    }

    public static string TreeFacts
    {
      get { return treeFacts; }
    }

    // METHODS

    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }

    public static void PrintTreeFacts()
    {
      Console.WriteLine(TreeFacts);
    }

  }

}

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest.PrintTreeFacts();
    }
  }
}


namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Math.PI);
      Console.WriteLine(Math.Abs(-32));
    }
  }
}
