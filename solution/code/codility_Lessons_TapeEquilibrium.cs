//https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
public class TapeEquilibrium {
    public int solution(int[] A) {
        int result = 0;
        int length = A.Length;

        int first_part = 0;
        int second_part = 0;
        int minimum_difference = int.MaxValue;
        int current_difference;
        int sum = A.Sum();
        for (int i = 0; i < length-1; i++)
        {
            first_part+= A[i];
            second_part = sum - first_part;
            current_difference = Math.Abs(first_part-second_part);
            if(minimum_difference>current_difference)
            {
                minimum_difference = current_difference;
            }           
        }
        result = minimum_difference;
        return result;
    }
}
