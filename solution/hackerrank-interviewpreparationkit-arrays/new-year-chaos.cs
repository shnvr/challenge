//https://www.hackerrank.com/challenges/new-year-chaos/


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

namespace newyearchaos;
public class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        int result = 0;
        int allowedBribeCount = 2;

        for (int i = 0; i < q.Count; i++)
        {
            if (q[i] - (i + 1) > allowedBribeCount)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            for (int j = Math.Max(0, q[i] - allowedBribeCount); j < i; j++)
            {
                if (q[j] > q[i])
                {
                    result++;
                }
            }
        }

        Console.WriteLine(result);

    }
    public static void minimumBribes2(List<int> q)
    {
        int result = 0;
        for (int i = 0; i < q.Count; i++)
        {
            if ((q[i] - i) > 3)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            int currentMoves = 0;
            for (int j = 0; j < i; j++)
            {

                if (q[j] > q[i])
                {
                    currentMoves++;
                }

            }

            result += currentMoves;

        }

        Console.WriteLine(result);

    }

}

public class Solution
{
    public static void Main(string[] args)
    {
        String line;
        try
        {
            System.Console.WriteLine(DateTime.Now);
            var appDataDir = AppContext.BaseDirectory;


            // Go up two levels by combining with ".."
            string twoLevelsUp = Path.Combine(appDataDir, "..", "..", "..", "..", 
            "solution", 
            "hackerrank-interviewpreparationkit-arrays", 
            "new-year-chaos-input09.txt");

            // Normalize the path to get the absolute path
            string testPath = Path.GetFullPath(twoLevelsUp);
            //string taskFolder = Path.Combine(normalizedPath, "solution", "hackerrank-interviewpreparationkit-arrays", "new-year-chaos-input09.txt");
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(testPath);
            //Read the first line of text
            int t = Convert.ToInt32(sr.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(sr.ReadLine().Trim());

                List<int> q = sr.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                Result.minimumBribes2(q);
            }
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            System.Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

    }
}


