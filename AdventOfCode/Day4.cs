using System.Linq;

namespace AdventOfCode
{
    public class Day4
    {
        public int GetNumberOfPossiblities(int start, int end)
        {
            return Enumerable.Range(start, end - start)
                        .Select(x => x.ToString())
                        .Count(IsPossibility);
        }

        public bool IsPossibility(string password)
        {
            if (password.IndexOf("0") >= 0)
                return false;

            var lookBack = 0;
            var repeatCount = 0;
            var hasRepeat = false;

            foreach (var number in password)
            {
                if (number < lookBack) return false;

                if (!hasRepeat)
                {
                    if (number == lookBack)
                    {
                        repeatCount++;
                    }
                    else
                    {
                        hasRepeat = repeatCount == 1;
                        repeatCount = 0;
                    }
                }

                lookBack = number;
            }

            return hasRepeat || repeatCount == 1;
        }
    }
}