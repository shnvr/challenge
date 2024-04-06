namespace codility;
public class PermMissingElem_Test
{
    private PermMissingElem _PermMissingElem;

    [SetUp]
    public void SetUp()
    {
        _PermMissingElem = new PermMissingElem();
    }
    [TestCase(new int[] {2, 3, 1, 5}, ExpectedResult = 4)]
    public int CorrectnessTest(int[] value)
    {
        return _PermMissingElem.solution(value);
    }
}

