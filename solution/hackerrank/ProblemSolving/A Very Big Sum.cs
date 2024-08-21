//https://www.hackerrank.com/challenges/a-very-big-sum
class Solution {

    static long aVeryBigSum(int n, long[] ar) {
        // Complete this function
        long sum = 0;
        foreach(long i in ar)
        {
            sum = sum + i;
        }
        
        return sum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp,Int64.Parse);
        long result = aVeryBigSum(n, ar);
        Console.WriteLine(result);
    }
}
