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
//https://www.hackerrank.com/challenges/jumping-on-the-clouds
namespace JumpingOnTheClouds;
public class Result
{
    public Result(){
        int result;
        int solution;

        result = jumpingOnClouds(new List<int>{0,0,1,0,0,1,0});
        solution = 4;
        result = jumpingOnClouds(new List<int>{0,0,0,1,0,0});
        solution = 3;
        result = jumpingOnClouds(new List<int>{0,0,1,0,0,0,0,1,0,0});
        solution = 6;

        bool solved = result == solution;
    }
    public static int jumpingOnClouds(List<int> c)
    {        
        int result = 0;
        int i = 0;
        while(i < c.Count -1){
            if(c[i]==0){
                result++;
                i += 2;
            }
            else{
                i--;
            }            
        }
        return result;

    }
    public static int jumpingOnClouds2(List<int> c)
    {
        int result = 0;
        for (int i = 0; i < c.Count - 1; i++) {
            if (c[i] == 0) i++;
            result++;
        }
        return result;

    }

}

