using System;

namespace BooleanDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answerOne = true;
            bool answerTwo = false;
        }
    }
}

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      double timeToDinner = 4;

      double distance = 95;

      double rate = 30;

      double tripDuration = distance/rate;

      bool answer = (tripDuration <= timeToDinner);

      Console.WriteLine(answer);

    }
  }
}

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;
      bool yourNeeds = beach && city ;
      bool friendNeeds = beach || hiking ;
      bool tripDecision = yourNeeds && friendNeeds;
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

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

      Good luck! */
    }
  }
}
