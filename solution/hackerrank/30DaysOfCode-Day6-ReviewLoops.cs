//https://www.hackerrank.com/challenges/30-review-loop
class ReviewLoop {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            string text =Console.In.ReadLine();
            string odd = "";
            string even = "";
            for (int j = 0; j < text.Length; j++){
                if(j%2==0)
                    odd += text[j];
                else
                    even += text[j];
            }
            
            Console.WriteLine(odd + " " + even);
            
            
        }
    }
}
