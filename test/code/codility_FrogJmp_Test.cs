namespace codility;
public class FrogJmp_Test
{
    private FrogJmp frogJmp;

    [SetUp]
    public void SetUp()
    {
        frogJmp = new FrogJmp();
    }

    [TestCase(10, 850000000, 30, ExpectedResult = 28333333),MaxTime(100)]
    [Repeat(10)]
    public int CorrectnessTest(int x, int y, int z)
    {
        return frogJmp.solution(x,y,z);
    }
    [TestCase(10, 850000000, 30, ExpectedResult = 28333333), MaxTime(100)]
    [Repeat(10000)]
    public int PerformanceTest(int x, int y, int z)
    {
        return frogJmp.solution3(x,y,z);
    }
}

