//https://www.hackerrank.com/challenges/30-data-types
namespace DataTypes;
class Solution{
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        int j = Convert.ToInt32(Console.ReadLine());
        double e = Convert.ToDouble(Console.ReadLine());
        string t = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i+j);
        Console.WriteLine(String.Format("{0:0.0}",Convert.ToDouble(d) + e) );
        Console.WriteLine(s + t);
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}