//https://www.hackerrank.com/challenges/30-interfaces
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            //if n divides by i "evenly" with no remainder, count it up
            if (n % i == 0)
            {
                counter = counter + i;
            }
        }
        return counter;
    }
}

class InterfaceExample{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}