using System.Collections.Generic;

namespace AdventOfCode.IntCodeComputer
{
    public class JumpIfTrue : IntCodeOperation
    {
        public JumpIfTrue(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        public override int DoOperation(int input)
        {
            var check = GetParameterValueByPosition(1);

            if (check != 0)
            {
                return GetParameterValueByPosition(2);
            }

            return CurrentPosition + 3;
        }

        protected override bool IsApplicable(int opCode) => opCode == 5;
    }
}