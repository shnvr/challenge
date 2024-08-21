//https://app.codility.com/programmers/lessons/4-counting_elements/
public class MaxCounters
{
    public int[] solution(int N, int[] A) {

        if(N <= A.Length)
        {
            A[N-1]++;
        }
        else
        {
            int maxValue = A.Max();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = maxValue;
            }
        }
        return A;
    }

}
