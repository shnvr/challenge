//https://app.codility.com/programmers/lessons/4-counting_elements/
public class MaxCounters
{
    public int[] solution(int N, int[] A) {
        int[] operation = new int[N];
            int max = 0, globalMax = 0;
            foreach (var item in A)
            {
                if (item > N)
                {
                    globalMax = max;
                }
                else
                {
                    if (operation[item - 1] < globalMax)
                    {
                        operation[item - 1] = globalMax;
                    }
                    operation[item - 1]++;
                    if (max < operation[item - 1])
                    {
                        max = operation[item - 1];
                    }
                }
            }
            for (int i = 0; i < operation.Length; i++)
            {
                if (operation[i] < globalMax)
                {
                    operation[i] = globalMax;
                }
            }

            return operation;
}

}
