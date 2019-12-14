using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode
{
    public class Day3
    {
        public int LowestDistance(string path1, string path2)
        {
            var path1Points = GetPath(path1);
            var path2Points = GetPath(path2);

            return path1Points.Intersect(path2Points).Select(p => Math.Abs(p.X) + Math.Abs(p.Y)).Min();
        }

        public int ShortestPath(string path1, string path2)
        {
            var path1Points = GetPath(path1).ToList();
            var path2Points = GetPath(path2).ToList();

            return path1Points.Intersect(path2Points).Select(p => path1Points.IndexOf(p) + path2Points.IndexOf(p) + 2).Min();
        }

        IEnumerable<Point> GetPath(string path)
        {
            var x = 0;
            var y = 0;

            var segments = path.Split(",");

            foreach (var segment in segments)
            {
                var direction = segment[0];
                var steps = int.Parse(string.Join("", segment.Skip(1).ToArray()));
                for (var i = 0; i < steps; i++)
                {
                    yield return direction switch
                    {
                        'R' => new Point(++x, y),
                        'L' => new Point(--x, y),
                        'U' => new Point(x, ++y),
                        'D' => new Point(x, --y),
                    };
                }
            }
        }

    }
}