//https://www.hackerrank.com/challenges/30-scope
class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] a)
    {
        this.elements = a;
    }
    public void computeDifference()
    {
        maximumDifference = 0;
        for(int i = 0; i<elements.Length;i++)
        {
            for(int j = 0; j<elements.Length;j++)
            {
                int current = Math.Abs(elements[i]-elements[j]);
                if(current>maximumDifference)
                    maximumDifference = current;
            }
        }
        
    }

} // End of Difference Class

class Scope {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}