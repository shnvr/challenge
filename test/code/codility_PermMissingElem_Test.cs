namespace codility;
public class PermMissingElem_Test
{
    private PermMissingElem permMissingElem;

    [SetUp]
    public void SetUp()
    {
        permMissingElem = new PermMissingElem();
    }
    [TestCase(new int[] {2, 3, 1, 5}, ExpectedResult = 4)]
    public int CorrectnessTest(int[] value)
    {
        return permMissingElem.solution(value);
    }
}

