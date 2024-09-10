//https://www.hackerrank.com/challenges/30-binary-numbers
class Binary {

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string baseofN = Convert.ToString(n,2);
        int count = 1;
        int best = 1;
        for(int i=0;i<baseofN.Length-1;i++)
        {
            if(baseofN[i]==baseofN[i+1])
                count++;
            else
                count = 1;            
                
            if(best<count)
                best = count;   
        }
        
        Console.WriteLine(best);
    }
}
