//https://www.hackerrank.com/challenges/diagonal-difference/
class DiagonalDifference {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int sum = 0;
        int sum2 = 0;
        for(int i = 0; i< n; i++)
        {
            
            sum = sum +a[i][i] ;
                sum2 = sum2 + a[i][n-i-1];
            
            
            
            
        }
       Console.WriteLine(Math.Abs(sum2-sum));
        
       
    }
}
