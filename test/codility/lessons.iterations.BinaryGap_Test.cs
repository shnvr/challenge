namespace codility.lessons.iterations;
using codility.lessons.iterations;

public class BinaryGap_Test
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private BinaryGap _binaryGap;

        [SetUp]
        public void SetUp()
        {
            _binaryGap = new BinaryGap();
        }
        //Document
        [TestCase(9,ExpectedResult = 2)]
        [TestCase(529,ExpectedResult = 4)]
        [TestCase(20,ExpectedResult = 1)]
        //Example
        [TestCase(1041,ExpectedResult = 5)]
        [TestCase(15,ExpectedResult = 0)]
        [TestCase(32,ExpectedResult = 0)]
        //Correctness
        [TestCase(1,ExpectedResult = 0)]
        [TestCase(5,ExpectedResult = 1)]
        [TestCase(1376796946, ExpectedResult =5)]

        public int CorrectnessTest(int value)
        {
            return _binaryGap.solution(value);
        }

        [TestCase(31,ExpectedResult = 0)]
        public int PowTest(int value)
        {
            int converted_value = (int) Math.Pow(2,value);

            return _binaryGap.solution(converted_value-1);
        }

    }

}
