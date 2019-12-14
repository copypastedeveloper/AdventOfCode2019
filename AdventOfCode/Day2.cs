using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class Day2
    {
        public List<int> RunProgram(List<int> intCode, int noun, int verb)
        {

            var localCopyIntCode = new List<int>(intCode);
            localCopyIntCode[1] = noun;
            localCopyIntCode[2] = verb;

            var currentOpCodePosition = 0;
            int currentOp;
            while (( currentOp = localCopyIntCode[currentOpCodePosition]) != 99)
            {
                if (currentOp == 1)
                {
                    var placement = localCopyIntCode[currentOpCodePosition + 3];
                    var result = localCopyIntCode[localCopyIntCode[currentOpCodePosition + 1]] +
                                 localCopyIntCode[localCopyIntCode[currentOpCodePosition + 2]];
                    localCopyIntCode[placement] = result;
                }
                
                if (currentOp == 2)
                {
                    var placement = localCopyIntCode[currentOpCodePosition + 3];
                    var result = localCopyIntCode[localCopyIntCode[currentOpCodePosition + 1]] *
                                 localCopyIntCode[localCopyIntCode[currentOpCodePosition + 2]];
                    localCopyIntCode[placement] = result;
                }

                currentOpCodePosition += 4;
            }

            return localCopyIntCode;
        }
    }
}
