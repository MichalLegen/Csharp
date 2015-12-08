using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        // reading input from console
        string inputString = Console.ReadLine();

        // initializing int variable which will count number of groups with odd number of letters
        // even string cant have a single odd group, odd string can have one
        int noOfOddGroups = (inputString.Length % 2 == 0) ? 0 : -1;

        // using linq to group letters and then count number of letter in each group
        var agg =
        inputString.GroupBy(c => c).Select(g =>
        new {
            Count = g.Count(),
        });

        // iterate over groups and count number of groups with odd number of letters
        foreach (var item in agg)
        {
            if (item.Count % 2 == 1)
            {
                noOfOddGroups++;
            }
        }

        // logic for deciding whether we can create a palindrome or not
        if (noOfOddGroups > 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("YES");
        }
        Console.ReadKey();
    }


}