using System;
using System.Collections.Generic;

namespace AdventOfCode.IntCodeComputer
{
    public class Output : IntCodeOperation
    {
        public Output(List<int> intCode, int currentPosition) : base(intCode, currentPosition)
        {}

        protected override bool IsApplicable(int opCode) => opCode == 4;
        
        public override int DoOperation(int input)
        {
            var output = IntCode[IntCode[CurrentPosition + 1]];
            Console.WriteLine(output);
            return CurrentPosition + 2;
        }
    }
}