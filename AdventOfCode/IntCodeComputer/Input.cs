using System.Collections.Generic;

namespace AdventOfCode.IntCodeComputer
{
    public class Input : IntCodeOperation
    {
        public Input(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        protected override bool IsApplicable(int opCode) => opCode == 3;

        public override int DoOperation(int input)
        {
            IntCode[IntCode[CurrentPosition + 1]] = input;
            return CurrentPosition + 2;
        }
    }
}