namespace codility;
public class OddOccurrencesInArray_Test
{
    private OddOccurrencesInArray _OddOccurrencesInArray;

    [SetUp]
    public void SetUp()
    {
        _OddOccurrencesInArray = new OddOccurrencesInArray();
    }

    [TestCase(new int[] {9, 3, 9, 3, 9, 7, 9}, ExpectedResult = 7)]
    public int CorrectnessTest(int[] value)
    {
        return _OddOccurrencesInArray.solution(value);
    }
    

}