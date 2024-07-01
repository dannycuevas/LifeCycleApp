using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifecycleLibrary
{
  public static class Calculator
  {
    public static double Divide(double x, double y)
    {
      double output = 0;

      if (y != 0)
      {
        output = x / y;
      }

      return output;
    }
  }
}
