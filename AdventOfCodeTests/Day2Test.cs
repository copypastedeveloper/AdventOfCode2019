using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day2Test
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {new List<int> {1,0,0,0,99}, new List<int> {2,0,0,0,99} },
                new object[] {new List<int> {2,3,0,3,99}, new List<int> {2,3,0,6,99} },
                new object[] {new List<int> {2,4,4,5,99,0}, new List<int> {2,4,4,5,99,9801} },
                new object[] {new List<int> {1,9,10,3,2,3,11,0,99,30,40,50}, new List<int> {3500,9,10,70,2,3,11,0,99,30,40,50} }
            };

        [Theory, MemberData(nameof(Data))]
        public void Test1(List<int> intCode, List<int> expectedOutput)
        {
            var day2 = new Day2();
            //Assert.True(expectedOutput.SequenceEqual(day2.RunProgram(intCode)));
        }
    }
}