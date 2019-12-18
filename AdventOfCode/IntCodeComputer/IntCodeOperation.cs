using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.IntCodeComputer
{
    public abstract class IntCodeOperation
    {
        protected readonly List<int> IntCode;
        protected readonly int CurrentPosition;

        static readonly List<Type> Operations = typeof(IntCodeOperation).Assembly.GetTypes()
            .Where(t => typeof(IntCodeOperation).IsAssignableFrom(t) && !t.IsAbstract).ToList();

        protected IntCodeOperation(List<int> intCode, int currentPosition)
        {
            this.IntCode = intCode;
            this.CurrentPosition = currentPosition;
        }

        public abstract int DoOperation(int input);

        protected abstract bool IsApplicable(int opCode);

        List<int> GetOpCodeParameterModes()
        {
            var notTheOpCode = (IntCode[CurrentPosition] / 100).ToString();
            var currentPositionMode = string.Join("", notTheOpCode.Reverse().ToArray())
                .PadRight(3, '0')
                .Select(c => int.Parse(c.ToString())).ToList();
            return currentPositionMode;
        }

        protected int GetParameterValueByPosition(int parameterPosition ,bool forceImmediate = false)
        {
            return GetOpCodeParameterModes()[parameterPosition-1] == 1 || forceImmediate
                ? IntCode[CurrentPosition + parameterPosition]
                : IntCode[IntCode[CurrentPosition + parameterPosition]];
        }

        public static IntCodeOperation GetOperation(List<int> intCode, int currentPosition)
        {
            IntCodeOperation CreateInstance(Type type)
            {
                return ((IntCodeOperation)Activator.CreateInstance(type, intCode, currentPosition));
            }

            var opCode = intCode[currentPosition] % 100;

            return Operations.Select(CreateInstance).First(x => x.IsApplicable(opCode));
        }
    }
}