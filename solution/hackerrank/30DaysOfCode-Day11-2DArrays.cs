//https://www.hackerrank.com/challenges/30-2d-arrays
class TwoDArray {

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int best=int.MinValue;
        
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                int current = 0;
                for (int k = 0; k < 3; k++){
                    for (int l = 0; l < 3; l++){   
                        current += arr[i+k][j+l];
                    }
                }
                current -= arr[i+1][j];
                current -= arr[i+1][j+2];
            
                if(current>best)
                    best = current;
                
            }
            
        }
        
        Console.WriteLine(best);
    }
}
