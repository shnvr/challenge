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
//https://www.hackerrank.com/challenges/counting-valleys/
namespace CountingValley;
class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int result = 0;
        int high = 0;
        int seaLevel = 0;
        bool isValley;

        foreach (var step in path)
        {
            isValley = high < seaLevel; 
            high = (step == 'U') ? (high + 1) : ( high - 1);
            if(high == seaLevel && isValley){ 
                result++;
            }
        }

        return result;
    }
    public static int countingValleys_2(int steps, string path)
    {

                int result = 0;

        int high = 0;
        bool isValley = false;

        for (int i = 0; i < path.Length; i++)
        {
            var step = path[i];
            if(step == 'U'){
                high++;
            }
            else{
                high--;
            }
            if(high>0){
                isValley = false;
            }
            else if (high<0){
                isValley = true;
            }
            else{
                if(isValley && high == 0){
                    result++;
                }
            }
            
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
