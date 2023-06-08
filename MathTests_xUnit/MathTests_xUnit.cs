using MyMath;

namespace MathTests_xUnit
{
    public class MathTests_xUnit
    {
        [Fact]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double result = 5.0;
            double input = result * result;

            input = rooter.SquareRoot(input);

            Assert.Equal(result, input, .001);
        }

        [Fact]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();

            for (double expect = 1e-8; expect < 1e+8; expect *= 3.0)
                RooterOneValue(rooter, expect);
        }

        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.Equal(expectedResult, actualResult, expectedResult / 1000);
        }

        [Fact]
        public void RooterTestNegativeInput()
        {
            Rooter rooter = new Rooter();
            Assert.Throws<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-9));
        }
    }
}