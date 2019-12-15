﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Day 1");
            Console.WriteLine(new string('-',50));
            Console.WriteLine(new Day1().RunProgram(Day1Input));
            
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Day 2");
            Console.WriteLine(new string('-',50));
            var day2 = new Day2();
            Console.WriteLine(day2.RunProgram(Day2Input, 12, 2)[0]);

            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    var result = day2.RunProgram(Day2Input, i, j)[0];
                    
                    if (result != 19690720) continue;
                   
                    Console.WriteLine(i + ", " + j);
                    j = 100;
                    i = 100;
                }
            }

            Console.WriteLine(new string('-',50));
            Console.WriteLine("Day 4");
            Console.WriteLine(new string('-',50));
            var day4 = new Day4();
            Console.WriteLine(day4.GetNumberOfPossiblities(153517, 630395));



            Console.ReadLine();
        }

        static List<int> Day1Input = new List<int>
        {
            71407
            ,81197
            ,76198
            ,74252
            ,72416
            ,84763
            ,50109
            ,94285
            ,120589
            ,63022
            ,125821
            ,98807
            ,119795
            ,128182
            ,59505
            ,71577
            ,148454
            ,62504
            ,69879
            ,94627
            ,113053
            ,116212
            ,135361
            ,89835
            ,104648
            ,74343
            ,131401
            ,143696
            ,71891
            ,77750
            ,70549
            ,65354
            ,137408
            ,63526
            ,58679
            ,55834
            ,110914
            ,118013
            ,107422
            ,135027
            ,147523
            ,75502
            ,88890
            ,68982
            ,76256
            ,113357
            ,97845
            ,114557
            ,77538
            ,82036
            ,107707
            ,91224
            ,123240
            ,109997
            ,99615
            ,54872
            ,144766
            ,59363
            ,82870
            ,78971
            ,58341
            ,100286
            ,55403
            ,101399
            ,128763
            ,68876
            ,114973
            ,116935
            ,78603
            ,75321
            ,86036
            ,146089
            ,66557
            ,112169
            ,79699
            ,89839
            ,142146
            ,55840
            ,131197
            ,50455
            ,92262
            ,62094
            ,132344
            ,113253
            ,94504
            ,84757
            ,87485
            ,109422
            ,81599
            ,129372
            ,107622
            ,121506
            ,57286
            ,124121
            ,126350
            ,120381
            ,126424
            ,110346
            ,75626
            ,94308
        };
        static List<int> Day2Input = new List<int>
        {
            1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 10, 19, 1, 9, 19, 23, 1, 13, 23, 27, 1, 5, 27, 31, 2, 31, 6, 35, 1, 35, 5, 39, 1, 9, 39, 43, 1, 43, 5, 47, 1, 47, 5, 51, 2, 10, 51, 55, 1, 5, 55, 59, 1, 59, 5, 63, 2, 63, 9, 67, 1, 67, 5, 71, 2, 9, 71, 75, 1, 75, 5, 79, 1, 10, 79, 83, 1, 83, 10, 87, 1, 10, 87, 91, 1, 6, 91, 95, 2, 95, 6, 99, 2, 99, 9, 103, 1, 103, 6, 107, 1, 13, 107, 111, 1, 13, 111, 115, 2, 115, 9, 119, 1, 119, 6, 123, 2, 9, 123, 127, 1, 127, 5, 131, 1, 131, 5, 135, 1, 135, 5, 139, 2, 10, 139, 143, 2, 143, 10, 147, 1, 147, 5, 151, 1, 151, 2, 155, 1, 155, 13, 0, 99, 2, 14, 0, 0
        };
    }
}
