using System;
using CommandLine;

interface IB
{
  void execute();
}
class B : IB
{
  public B(A b)
  {

  }

  public void execute()
  {
    throw new NotImplementedException();
  }
}

record MyData
{
  public string Name { get; init; }
  public string Ort { get; init; }
}




class SerialKiller {
  public int BLABLA{get;set;}
}
namespace QuickStart
{
  class Program
  {
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public class Options
    {
      [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
      public bool Verbose { get; set; }
    }

    static void Main(string[] args)
    {
      Logger.Info("Hello wojjjrld");
      Console.WriteLine("Hello, World!");
      var blabla = new A();
      var B = new B(blabla);
      B b;
      blabla.Execute();
      var data = new MyData
      {
        Name = "DFF",
        Ort = "ORT"
      };

      var json_str = Newtonsoft.Json.JsonConvert.SerializeObject(data);

      
      Console.WriteLine(json_str);

      var serial  = new SerialKiller();
      var json_serial = Newtonsoft.Json.JsonConvert.SerializeObject(serial);

      Console.WriteLine(json_serial);


      Parser.Default.ParseArguments<Options>(args)
             .WithParsed<Options>(o =>
             {
               if (o.Verbose)
               {
                 Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                 Console.WriteLine("Quick Start Example! App is in Verbose mode!");
               }
               else
               {
                 Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                 Console.WriteLine("Quick Start Example!");
               }
             });
    }
  }
}