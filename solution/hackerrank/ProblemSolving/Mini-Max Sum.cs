//https://www.hackerrank.com/challenges/mini-max-sum
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class MiniMaxSum {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        Int64[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        Int64 [] sums = new Int64 [5] ;
        for(int i = 0; i<5; i++)
        {
            for(int j = 0; j<5; j++)
            {
                
                if(i!=j)
                {
                    sums[i] += arr[j];
                    /*Console.Write(arr[j]);*/
                }
                
            }
            /*Console.WriteLine();*/
        }
        
        Console.WriteLine(sums.Min()+" "+sums.Max());
    }
}
