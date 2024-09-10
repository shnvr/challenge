//https://www.hackerrank.com/challenges/plus-minus
class PlusMinus {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int poz = 0;
        int neg = 0;
        int zero= 0;
        foreach(int i in arr)
        {
            if(i>0)
                poz++;
            else if(i<0)
                neg++;
            else zero++;
        }
        Console.WriteLine(String.Format("{0:0.000000}", (double)poz/n));
        Console.WriteLine(String.Format("{0:0.000000}",(double)neg/n));
        Console.WriteLine(String.Format("{0:0.000000}",(double)zero/n));
    }
}
