using System;

class A
{
  public
  A() {

  }
}

interface IB {
  void execute();
}
class B : IB{
  public B(A b) {

  }

  public void execute()
  {
    throw new NotImplementedException();
  }
}

internal class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    private static void Main(string[] args)
    {
      Logger.Info("Hello wojjjrld");
        Console.WriteLine("Hello, World!");
        var blabla = new A();
        var B = new B(blabla);
        B b;

    }
}