namespace codility;
public class OddOccurrencesInArray_Test
{
    private OddOccurrencesInArray oddOccurrencesInArray;

    [SetUp]
    public void SetUp()
    {
        oddOccurrencesInArray = new OddOccurrencesInArray();
    }

    [TestCase(new int[] {9, 3, 9, 3, 9, 7, 9}, ExpectedResult = 7)]
    public int CorrectnessTest(int[] value)
    {
        return oddOccurrencesInArray.solution(value);
    }
    

}