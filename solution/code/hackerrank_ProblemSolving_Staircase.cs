//https://www.hackerrank.com/challenges/staircase

class StairCaseResult
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for(int i =0; i<n;i++){
            for(int j = n-1; j>=0; j-- ){
                if(j>i)
                    Console.Write(' ');
                else
                    Console.Write('#');
            }
            Console.Write("\n");
        }

    }

}

class StairCase
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        StairCaseResult.staircase(n);
    }
}
