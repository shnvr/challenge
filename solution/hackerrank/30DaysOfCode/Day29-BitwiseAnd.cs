//https://www.hackerrank.com/challenges/30-bitwise-and
class Result
{

    /*
     * Complete the 'bitwiseAnd' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER N
     *  2. INTEGER K
     */

    public static int bitwiseAnd(int N, int K)
    {
            int max = 0;

            for (int j = 1; j < N; j++)
            {
                for (int k = j + 1; k <= N; k++)
                {
                    int h = j & k;
                    if (h < K && max < h) max = h;
                }
            }

            return max;
    }

}

class BitwiseAnd
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
