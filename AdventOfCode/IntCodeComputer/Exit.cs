using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode.IntCodeComputer
{
    public class Exit : IntCodeOperation
    {
        public Exit(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        protected override bool IsApplicable(int opCode) => opCode == 99;

        public override int DoOperation(int input)
        {
            return -1;
        }
    }
}