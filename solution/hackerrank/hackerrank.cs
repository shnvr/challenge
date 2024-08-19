
# HAckerrank
// Rotate Array 

public int[] RotateArray(int[] A, int K)
{
    for (int i = 0; i < K; i++)
    {
        int lastIndex = A[A.Length - 1];
        for (int j = A.Length - 1; j > 0; j--)
        {
            A[j] = A[j - 1];
        }

        A[0] = lastIndex;
    }
    return A;
}

// Binary Graph

public int BinaryGap(int N)
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

// Circular Printer

public static long CircularPrinter(string s)//HackerRank
{
    int moveCount = 0;
    for (int i = 0; i < s.Length - 1; i++)
    {
        int start = (int)s[i];
        int end = (int)s[i + 1];
        int distance = Math.Abs(start - end);
        int currentMove = distance <= 13 ? distance : 26 - distance;
        moveCount += currentMove;

    }

    return moveCount;
}

// Fibonacci Numbers Algoryhtm

- https://www.youtube.com/watch?v=oIQdb93xewE&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN&index=14


public FibonacciNumbers()
{
    var fibonacciNumbers = new List<int> { 1, 1 };
    for (int i = 0; i < 20; i++)
    {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
    }

    foreach (var item in fibonacciNumbers)
    {
        Console.WriteLine(item);
    }

}

internal class Matrix
{
    public Matrix()
    {
        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }

    }
}

// String Operations


public static int CamelCase(string s)
{
    int count = 1;
    for (int i = 0; i < s.Length; i++)
    {
        if (Char.IsUpper(s[i]))
        {
            count++;
        }
    }

    return count;
}
public static void StairCase(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1; j >= 0; j--)
        {
            if (j > i)
                Console.Write(' ');
            else
                Console.Write('#');
        }
        Console.Write("\n");
    }

}

// Permutation

public static IList<IList<string>> Permute(string[] words)
{
    var list = new List<IList<string>>();
    return DoPermute(words, 0, words.Length - 1, list);
}
static IList<IList<string>> DoPermute(string[] words, int start, int end, IList<IList<string>> list)
{
    if (start == end)
    {
        list.Add(new List<string>(words));
    }
    else
    {
        for (var i = start; i <= end; i++)
        {
            Swap(ref words[start], ref words[i]);
            DoPermute(words, start + 1, end, list);
            Swap(ref words[start], ref words[i]);
        }
    }
    return list;
}
static void Swap(ref string a, ref string b)
{
    var temp = a;
    a = b;
    b = temp;
}



