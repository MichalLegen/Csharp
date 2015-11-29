using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        var n = Double.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split(' ').Select(val => Int32.Parse(val));

        Console.WriteLine(a.Count(val => val > 0) / n);
        Console.WriteLine(a.Count(val => val < 0) / n);
        Console.WriteLine(a.Count(val => val == 0) / n);
        Console.Read();
    }
}