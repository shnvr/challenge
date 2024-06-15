namespace codility;
public class PermCheck_Test
{
    private PermCheck permCheck;

    [SetUp]
    public void SetUp()
    {
        permCheck = new PermCheck();
    }
    [TestCase(new int[] {4, 1, 3, 2}, ExpectedResult = 1)]
     [TestCase(new int[] {4, 1, 3}, ExpectedResult = 0)]
    public int CorrectnessTest(int[] value)
    {
        return permCheck.solution(value);
    }
}

