using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day1
    {
        public int RunProgram(List<int> Input)
        {
            int FuelCalculator(int x)
            {
                var fuel = (int) (Math.Floor(x / 3m) - 2);
                fuel += (fuel > 6 ? FuelCalculator((int)fuel) : 0);
                return fuel;
            }
            
            return Input.Select(FuelCalculator).Sum();
        }
    }
}