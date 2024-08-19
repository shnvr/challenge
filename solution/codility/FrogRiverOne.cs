//https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
public class FrogRiverOne
{
    public int solution(int X, int[] A) 
    {
        int result = -1;
        int length = A.Length;
        int step = X;
        bool[]step_progress = new bool[X+1];
        for (int i = 0; i < length; i++)
        {
            if(!step_progress[A[i]])
            {
                step_progress[A[i]] = true;
                step--;
            }

            if(step == 0)
            {
                result = i;
                break;
            }
        }       
        return result;
    }
}