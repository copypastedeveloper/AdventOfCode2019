using System.Collections.Generic;

namespace AdventOfCode.IntCodeComputer
{
    public class Equals : IntCodeOperation
    {
        public Equals(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        public override int DoOperation(int input)
        {
            var firstPart = GetParameterValueByPosition(1);
            var secondPart = GetParameterValueByPosition(2);
            var placement = GetParameterValueByPosition(3, true);

            IntCode[placement] = firstPart == secondPart ? 1 : 0;

            return CurrentPosition + 4;
        }

        protected override bool IsApplicable(int opCode) => opCode == 8;
    }
}