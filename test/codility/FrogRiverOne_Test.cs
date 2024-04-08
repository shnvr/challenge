namespace codility;
public class FrogRiverOne_Test
{
    private FrogRiverOne frogRiverOne;
    
    [SetUp]
    public void SetUp()
    {
        frogRiverOne = new FrogRiverOne();
    }

    [TestCase(5, new int[]{1,3,1,4,2,3,5,4}, ExpectedResult = 6)]
    [TestCase(5, new int[]{3}, ExpectedResult = -1)]
    public int CorrectnessTest(int param1, int[] param2)
    {
        return frogRiverOne.solution(param1, param2);
    }

}