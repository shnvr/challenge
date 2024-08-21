//https://www.hackerrank.com/challenges/breaking-best-and-worst-records

class BreakingtheRecordsResult
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int firstScore = scores.First();
        scores.RemoveAt(0);
        int minScore= firstScore,maxScore= firstScore, minCount= 0, maxCount = 0;
        foreach(int i in scores)
        {
            if(i<minScore)
            {
                minScore=i;
                minCount++;
                
            }
            else if(maxScore<i)
            {
                maxScore = i;
                maxCount++;
            }
            
        }
        
        return new List<int>(){maxCount,minCount};

    }

}

class BreakingtheRecords
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = BreakingtheRecordsResult.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
