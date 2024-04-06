using solution;

namespace codility;

public class CyclicRotation_Test
{
        private CyclicRotation _CyclicRotation;

        [SetUp]
        public void SetUp()
        {
            _CyclicRotation = new CyclicRotation();
        }

        [TestCase(new int[] {3, 8, 9, 7, 6}, 3, ExpectedResult = new int[] {9, 7, 6, 3, 8})]
        [TestCase(new int[] {0, 0, 0}, 1, ExpectedResult = new int[] {0, 0, 0})]
        [TestCase(new int[] {1, 2, 3, 4}, 3, ExpectedResult = new int[] {1, 2, 3, 4})]

        public int[] CorrectnessTest(int[] value, int k)
        {
            return _CyclicRotation.solution(value, k);
        }
}
