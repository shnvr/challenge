//https://www.hackerrank.com/challenges/apple-and-orange

class AppleAndOrange {

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int apple_count = 0;    
        int orange_count = 0;
        for (int i =0; i < apples.Length; i++) 
        {
            int region = apples[i] + a;
            if(s<=region && region<=t)
                apple_count++;
        }
        
        for (int i =0; i < oranges.Length; i++) 
        {
            int region = oranges[i] + b;
            if(s<=region && region<=t)
                orange_count++;
        }
        
        Console.WriteLine(apple_count);
        Console.WriteLine(orange_count);
        

    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
