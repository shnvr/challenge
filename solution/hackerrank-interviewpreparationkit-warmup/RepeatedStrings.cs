//https://www.hackerrank.com/challenges/repeated-string
namespace RepeatedStrings;
class Result
{
    public static long repeatedString(string s, long n)
    {
        long result = 0;
        long repeatedCount = n / s.Length;
        long remainCount = n % s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        result = result * repeatedCount;

        for (int i = 0; i < remainCount; i++)
        {
            if (s[i] == 'a')
            {
                result++;
            }
        }
        return result;

    }

}
