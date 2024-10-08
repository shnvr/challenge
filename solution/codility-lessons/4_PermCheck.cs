// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class PermCheck {
    public int solution(int[] A) {
        // Implement your solution here
        int result = 0;
        int length = A.Length;
        bool [] perm_map = new bool [length];
        for(int i = 0; i<length; i++)
        {
            int curr = A[i];

            if(curr > length || perm_map[curr-1])
            {
                result = 0;
                break;
            }
            else
            {
                perm_map[curr-1] = true;
            }
        }
        for(int i = 0; i<length; i++)
        {
            if(!perm_map[i])
            {
                result = 0;
                break;
            }
            result = 1;
        }
        return result;
    }
}
