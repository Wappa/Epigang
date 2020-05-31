namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
    }

    static double DaysToRotations(double days)
    {
      return days / 365;
    }

    static void Welcome(string planet)
    {
      Console.WriteLine($"Welcome to {planet}!");
    }
  }
}

