//https://www.hackerrank.com/challenges/30-arrays

class Arrays {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        
        for(int i=0;i<n;i++)
        {
            Console.Write(arr[n-i-1] + " ");
        }
    }
}
