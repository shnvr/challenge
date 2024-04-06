namespace codility;
public class FrogJmp_Test
{
    private FrogJmp _FrogJmp;

    [SetUp]
    public void SetUp()
    {
        _FrogJmp = new FrogJmp();
    }

    [TestCase(10, 850000000, 30, ExpectedResult = 28333333),MaxTime(100)]
    [Repeat(10000)]
    public int CorrectnessTest(int x, int y, int z)
    {
        return _FrogJmp.solution(x,y,z);
    }
    [TestCase(10, 850000000, 30, ExpectedResult = 28333333), MaxTime(100)]
    [Repeat(10000)]
    public int PerformanceTest(int x, int y, int z)
    {
        return _FrogJmp.solution3(x,y,z);
    }
}

