//https://www.hackerrank.com/challenges/30-exceptions-string-to-integer
class ExceptionStringToInteger {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        int result = 0;
        try
        {
            result = Int32.Parse(S);
            Console.WriteLine(result);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Bad String");
        }
    }
}
