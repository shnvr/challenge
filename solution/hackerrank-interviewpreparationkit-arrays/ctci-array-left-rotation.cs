//https://www.hackerrank.com/challenges/ctci-array-left-rotation
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
namespace ctciarrayleftrotation;
public class Result
{
    public static void Run(){
        int n = 5; //size of a
        int d = 4;
        List<int> a = new List<int> {1,2,3,4,5};

        List<int> output = new List<int> {5,1,2,3,4};

        List<int> result = rotLeft(a,d);
        if(output == result){
            Console.WriteLine("correct");
        }
    }

    public static List<int> rotLeft(List<int> a, int d)
    {
        int size = a.Count;
        int[] result = new int[a.Capacity];
        for(int i = 0; i<size; i++){
            result[i] = a[(i+d)%size];
        }
        return result.ToList();
    }

}
