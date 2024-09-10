//https://www.hackerrank.com/challenges/30-conditional-statements

namespace IntrotoConditionalStatements;
class Solution {



    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        if(N%2==1)
            Console.WriteLine("Weird");
        else if(N%2==0)
        {
            if(2<=N && N<=5)
                Console.WriteLine("Not Weird");
            else if(6<=N && N<=20)
                Console.WriteLine("Weird");
            else if(20<N)
                Console.WriteLine("Not Weird");
        }
            
    }
}
