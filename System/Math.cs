using System;
using System.Collections.Generic;
using System.Text;

namespace HackLib.System {
  public static class Math {

    /// <summary>Round a whole number down, e.g., 2369 to 2360, 2300, or 2000 </summary>
    /// <param name="number"></param>
    /// <param name="pos">ten, hundreds, thousands position, etc. e.g. 10, 100, 1000</param>
    /// <returns>roundedNumber</returns>
    public static int RoundDown(int number, int pos) {
      int roundedNumber;
      roundedNumber = ((int)(number / pos)) * pos;
      return roundedNumber;
    }
   }
}
