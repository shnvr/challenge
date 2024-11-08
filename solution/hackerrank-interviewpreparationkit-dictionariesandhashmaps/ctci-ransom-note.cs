//https://www.hackerrank.com/challenges/ctci-ransom-note
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
namespace ctciransomnote;
public class Result
{

    /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        Dictionary<string, int> magazineKeys = new Dictionary<string, int>();
        for (int i = 0; i < magazine.Count; i++)
        {
            if (magazineKeys.ContainsKey(magazine[i]))
            {
                magazineKeys[magazine[i]]++;
            }
            else
            {
                magazineKeys[magazine[i]] = 1;
            }
        }
        for (int i = 0; i < note.Count; i++)
        {
            if (magazineKeys.ContainsKey(note[i]))
            {
                magazineKeys[note[i]]--;
                if (magazineKeys[note[i]] < 0)
                {
                    System.Console.WriteLine("No");
                    return;
                }
            }
            else
            {
                System.Console.WriteLine("No");
                return;
            }
        }
        System.Console.WriteLine("Yes");
        return;
    }
    public static void checkMagazine2(List<string> magazine, List<string> note)
    {
        var magazineKeys = magazine.GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
        foreach (var item in note)
        {
            if(!magazineKeys.ContainsKey(item) || magazineKeys.Count == 0){
                System.Console.WriteLine("No");
                return;
            }
            magazineKeys[item]--;     
        }
        System.Console.WriteLine("Yes");
    }

}

public class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        Result.checkMagazine(magazine, note);
    }
}
