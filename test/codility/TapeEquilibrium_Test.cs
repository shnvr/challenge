namespace codility;

public class TapeEquilibrium_Test
{
    private TapeEquilibrium tapeEquilibrium;
    [SetUp]
    public void SetUp()
    {
        tapeEquilibrium = new TapeEquilibrium();
    }
    [TestCase(new int[]{3,1, 2, 4, 3}, ExpectedResult = 1)]
    [TestCase(new int[]{-1,1}, ExpectedResult = 2)]
    public int CorrectnessTest(int [] value)
    {
        return tapeEquilibrium.solution(value);

    }


}