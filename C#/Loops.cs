using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;
      while (emails > 0)
      {
        emails--;
        Console.WriteLine($"one email deleted, {emails} left");
      }
      Console.WriteLine("INBOX ZERO ACHIEVED!");
    }
  }
}

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      do{
        Console.WriteLine("BLARRRRRRR");
      }while (!buttonClick);
      Console.WriteLine("Time for a five minute break.");
    }
  }
}

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i=0 ; i<= 16 ; i++)
      {
          CreateTemplate(i);
      }
    }

    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
  }
}
