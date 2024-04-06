namespace  codility.lessons.iterations;
using System;
//https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
public class BinaryGap {
    public int solution(int N) {
        // Implement your solution here
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
}
