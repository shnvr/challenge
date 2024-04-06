//https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
//Detected time complexity:O(1)
public class FrogJmp
{
    public int solution(int X, int Y, int D)
    {
        // Implement your solution here
        if ((Y - X) % D == 0)
        {
            return (Y - X) / D;
        }
        return (Y - X) / D + 1;
    }
    public int solution2(int X, int Y, int D)
    {
        int result = 1;
        int total = X + D;
        while (total <= Y)
        {
            total += D;
            result++;
        }
        return result;
    }
    public int solution3(int X, int Y, int D)
    {
        int remainder;
        int result = Math.DivRem(Y - X, D, out remainder);
        return remainder == 0 ? result : result + 1;
    }
}
