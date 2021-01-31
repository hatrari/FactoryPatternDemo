using System;

namespace FactoryPatternDemo
{
  public class StaffShiftPatternReport : IReportFactory
  {
    public void Run()
    {
      Console.WriteLine("Running Staff Shift Pattern Report.");
    }
  }
}
