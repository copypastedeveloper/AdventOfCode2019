using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.IntCodeComputer;

namespace AdventOfCode
{
    public class Day5
    {
        public List<int> RunProgram(List<int> intCode, int input)
        {
            var localCopyIntCode = new List<int>(intCode);

            var currentOpCodePosition = 0;
            while (currentOpCodePosition != -1)
            {
                var operation = IntCodeOperation.GetOperation(localCopyIntCode, currentOpCodePosition);
                currentOpCodePosition =  operation.DoOperation(input);
            }

            return localCopyIntCode;
        }
    }
}