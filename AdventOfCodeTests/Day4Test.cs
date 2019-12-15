using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day4Test
    {
        [Theory]
        [InlineData("111111",false)]
        [InlineData("223450",false)]
        [InlineData("123789",false)]
        [InlineData("112233",true)]
        [InlineData("111122",true)]
        [InlineData("123444",false)]
        [InlineData("228999",true)]
        public void CheckValidityOfOption(string option, bool expectedResult)
        {
            var result = new Day4().IsPossibility(option);

            Assert.Equal(expectedResult, result);
        }
    }
}
