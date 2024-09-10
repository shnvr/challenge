//https://www.hackerrank.com/challenges/30-regex-patterns
using System.Text.RegularExpressions;



class RegularExpressionExample
{
    public static void Main(string[] args)
    {
        List<string> returnList = new List<string>();
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];
            
            if(Regex.IsMatch(emailID, @".+@gmail\.com$"))
                returnList.Add(firstName);
                
            
            
            
        }
        
        returnList.Sort();
        
        foreach(var item in returnList)
        {
            Console.WriteLine(item);
        }
    }
}
