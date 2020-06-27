using System;

namespace LearnInterfaces
{
    interface IAutomobile
    {
      string LicensePlate { get;};
      double Speed {get;};
      int Wheels {get;};
      void Honk();
    }
}

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
    public string LicensePlate
    { get; }

    public double Speed
    { get; }

    public int Wheels
    { get; }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}

namespace LearnInterfaces
{
  interface IAutomobile
  {
    string LicensePlate { get; }
    double Speed { get; }
    int Wheels { get; }
    void Honk();
  }
}
