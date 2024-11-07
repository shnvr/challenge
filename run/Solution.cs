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

                //Result.minimumBribes2(q);
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