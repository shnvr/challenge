//https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
//Detected time complexity: O(N) or O(N * log(N))
public class PermMissingElem
{
    public int solution(int[] A)
    {
        // Implement your solution here
        int length = A.Length;
        if (length == 0) return 1;

        int result = 0;
        for (int i = 1; i <= length + 1; i++)
            result ^= i;
        for (int i = 0; i < length; i++)
            result ^= A[i];
        return result;
    }
    public int solution2(int[] A)
    {
        // Implement your solution here
        long n = A.Length + 1;
        var sumOfAllElements = (n * (1 + n)) / 2;
        var missingElement = sumOfAllElements - A.Select(x => (long)x).Sum();
        return (int)missingElement;
    }
}