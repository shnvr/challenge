//https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
public class CyclicRotation
{
    public int[] solution(int[] A, int K) 
    {
        int lenght = A.Length;
        var result = new int[lenght];
        
        for (int i = 0; i < lenght; i++)
        {
            result[(i + K) % lenght] = A[i];
        }
        return result;
    }

}

