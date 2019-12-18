using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.IntCodeComputer
{
    public class Multiplication : IntCodeOperation
    {
        public Multiplication(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        protected override bool IsApplicable(int opCode) => opCode == 2;

        public override int DoOperation(int input)
        {
            var placement = GetParameterValueByPosition(3, true);

            var firstParameter = GetParameterValueByPosition(1);

            var secondParameter = GetParameterValueByPosition(2);

            
            var result = firstParameter * secondParameter;

            IntCode[placement] = result;
            return CurrentPosition + 4;

        }
    }
}