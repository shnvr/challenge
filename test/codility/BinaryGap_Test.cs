using solution;

namespace codility;
    public class BinaryGap_Test
    {
        private BinaryGap _BinaryGap;

        [SetUp]
        public void SetUp()
        {
            _BinaryGap = new BinaryGap();
        }

        [TestCase(9,ExpectedResult = 2)]
        [TestCase(529,ExpectedResult = 4)]
        [TestCase(20,ExpectedResult = 1)]
        [TestCase(1041,ExpectedResult = 5)]
        [TestCase(15,ExpectedResult = 0)]
        [TestCase(32,ExpectedResult = 0)]
        [TestCase(1,ExpectedResult = 0)]
        [TestCase(5,ExpectedResult = 1)]
        [TestCase(1376796946, ExpectedResult =5)]

        public int CorrectnessTest(int value)
        {
            return _BinaryGap.solution(value);
        }
        
        [TestCase(31,ExpectedResult = 0)]
        public int ExtremeTest(int value)
        {
            int converted_value = (int) Math.Pow(2,value);

            return _BinaryGap.solution(converted_value-1);
        }

    }