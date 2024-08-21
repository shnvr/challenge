//https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
public class BinaryGap {
    public int solution(int N) {
        int max = 0;
        int current_max = 0;
        string binary_N = Convert.ToString(N,2);
        int length = binary_N.Length;

        for(int i = 0; i<length; i++)
        {
            if(binary_N[i]=='0')
            {
                current_max++;
            }
            else
            {
                max = current_max>max?current_max:max;
                current_max = 0;
            }
        }
        return max;
    }
    public int BinaryGap2(int N)
{
    string binary = Convert.ToString(N, 2);
    binary = binary.TrimEnd('0');
    int maxCount = 0;
    int longest = 0;
    for (int i = 0; i < binary.Length; i++)
    {
        if (binary[i] == '1')
        {
            if (maxCount > longest)
            {
                longest = maxCount;
            }
            maxCount = 0;
        }
        else
        {
            maxCount++;
        }
    }


    return longest;
}
}
