using System;

namespace FactoryPatternDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      string reportName = $"FactoryPatternDemo.{Report.StaffShiftPattern}Report";
      Console.WriteLine(Type.GetType(reportName));
      var factory = Activator.CreateInstance(
        Type.GetType(reportName) ?? throw new InvalidOperationException()
      ) as IReportFactory;
      factory?.Run();
    }
  }
}
