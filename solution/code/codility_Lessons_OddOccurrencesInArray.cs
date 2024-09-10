//https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/

public class OddOccurrencesInArray
{
    public int solution(int[] A)
    {
        return A.Aggregate((x, y) => x ^ y);
    }
}
