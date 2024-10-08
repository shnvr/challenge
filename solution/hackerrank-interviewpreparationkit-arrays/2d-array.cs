//https://www.hackerrank.com/challenges/2d-array
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
namespace twodarray;

public class Result
{

    /*
    * Complete the 'hourglassSum' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts 2D_INTEGER_ARRAY arr as parameter.
    */

    public static void Run()
    {
        string input = @"
0 -4 -6 0 -7 -6
-1 -2 -6 -8 -3 -1
-8 -4 -2 -8 -8 -6
-3 -1 -2 -5 -7 -4
-3 -5 -3 -6 -6 -6
-3 -6 0 -8 -6 -7
";
        int output = -19;

        var lines = input.Trim().Split(new[] { '\r', '\n' });
        List<List<int>> arr = new List<List<int>>();
        for (int i = 0; i < 6; i++)
        {
            arr.Add(lines[i].Trim().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);
        if(result == output){
            Console.WriteLine("correct");
        }
    }


    public static int hourglassSum(List<List<int>> arr)
    {
        int result = int.MinValue;
        List<int> pattern = new List<int> { };
        int M = 6;
        int N = 3;
        for (int i = 0; i < M - N; i++)
        {
            for (int j = 0; j < M - N; j++)
            {

                for (int k = 0; k < N; k++)
                {
                    for (int l = 0; l < N; l++)
                    {
                        //1,0; 1,2
                        if (!((k == 1 && l == 0) || (k == 1 && l == 2)))
                        {
                            pattern.Add(arr[i + k][j + l]);
                        }

                    }
                }
                int sum = pattern.Sum();
                if (sum > result)
                {
                    result = sum;
                }
                pattern.Clear();

            }

        }

        return result;
    }

}