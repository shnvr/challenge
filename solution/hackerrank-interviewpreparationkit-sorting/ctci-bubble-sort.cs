//https://www.hackerrank.com/challenges/ctci-bubble-sort
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace ctcibubblesort;
public class Result
{

    /*
     * Complete the 'countSwaps' function below.
     *
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static void countSwaps(List<int> a)
    {
        int swapCount = 0;
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count - 1; j++)
            {
                if(a[j]>a[j+1]){
                    (a[j],a[j+1]) = (a[j+1],a[j]);
                    swapCount++;
                }
            }
        }
        System.Console.WriteLine($"Array is sorted in {swapCount} swaps.");
        System.Console.WriteLine($"First Element: {a.FirstOrDefault()}");
        System.Console.WriteLine($"Last Element: {a.LastOrDefault()}");
    }

}

public class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        Result.countSwaps(a);
    }
}
