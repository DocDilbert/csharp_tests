using NLog;

public class A
{
  Logger log = LogManager.GetCurrentClassLogger();
  public
  A() {

  }

  public void Execute() {
    log.Info("Class A");
    Console.WriteLine("DFDFD");
  }
}