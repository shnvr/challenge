//https://www.hackerrank.com/challenges/30-running-time-and-complexity
class RunningTimeAndComplexity
{
    static bool isPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

        for (int i = 2; i <= limit; ++i)
            if (number % i == 0)
                return false;
        return true;

    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numberOfInputs = Convert.ToInt32(Console.ReadLine());
        int i, j, inputNumber;
        string output;

        for (i = 1; i <= numberOfInputs; i++)
        {
            inputNumber = Convert.ToInt32(Console.ReadLine());
            output = isPrime(inputNumber) ? "Prime" : "Not prime";
            Console.WriteLine(output);
        }
    }
}
