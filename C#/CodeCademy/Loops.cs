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

namespace ForEachLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

      foreach(string task in todo)
      {
          CreateTodoItem(task);
      }
    }

    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
  }
}

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };

      foreach(string site in websites)
      {
        Console.WriteLine(site);
      }
    }
  }
}

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int ring = 0;

      do
      {
        Console.WriteLine("BLARRRRR");
        ring += 1;
        if(ring ==3){
          break;
        }
      } while(!buttonClick && ring <3);
    }
  }
}

namespace LoopsReview
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program!
      Here's what you learned:

      while loop: while(){..}
      do...while loop: do{...}while();
      for loop: for(int i=0; i<x; i++){}
      foreach loop: foreach(int item in list){}
      jump statements: break, continue, return

      Good luck! */
    }
  }
}
