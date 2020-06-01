using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
    }
  }
}

namespace BasicClasses
{
  class Forest
  {

  }
}

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Congo";
      f.trees = 0;
      f.age = 0;
      f.biome = "Tropical";

      Console.WriteLine(f.name);
    }
  }
}

namespace BasicClasses
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

  }

}

using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.biome = "Tropical";

      Console.WriteLine(f.Name);
    }
  }
}

namespace BasicClasses
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Trees
    {
      get { return trees; }
      set { trees = value; }
    }

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
  }
}

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Desert";

      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;

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
  }
}

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.Age = 0;
      f.Biome = "Desert";

      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}

namespace BasicClasses
{
  class Forest
  {
    public int age;
    public int Age
    {
      get{ return age; }
      private set {age = value;}
    }
    private string biome;

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
  }
}

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;

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
    public int Grow()
    {
      Trees += 30;
      Age +=1;
      return Trees;
    }

    public int Burn()
    {
      Trees -= 20;
      Age +=1;
      return Trees;
    }
  }
}
