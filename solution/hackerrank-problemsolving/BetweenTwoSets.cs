//https://www.hackerrank.com/challenges/between-two-sets

class BetweenTwoSetsResult
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        
       
        int lcmValue = LCM(a.ToArray());
        int gcdValue = GCD(b.ToArray());
        int count = 0;
        for(int i = lcmValue, j=2; i<=gcdValue; i=lcmValue*j,j++)
        {
            if(gcdValue%i==0)
            { 
                count++;
            }
        }
        
        return count;
    }
    static int GCD(int[] numbers)
    {
        return numbers.Aggregate(GCD);
    }
    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
    static int LCM(int[] numbers)
    {
        return numbers.Aggregate(LCM);
    }
    static int LCM(int a, int b)
    {
        return (a / GCD(a, b)) * b;
    }

}

class BetweenTwoSets
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = BetweenTwoSetsResult.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
