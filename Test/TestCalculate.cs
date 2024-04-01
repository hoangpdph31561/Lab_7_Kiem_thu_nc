using Code;

namespace Test
{
    public class TestCalculate
    {
        private Calculate calculate;
        [SetUp]
        public void Setup()
        {
            calculate = new();
        }
        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(2, calculate.Divide(4, 2));
        }
        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculate.Divide(4, 0));
        }
        [Test]
        public void TestDivideNegative()
        {
            Assert.AreEqual(-2, calculate.Divide(-4, 2));
        }
        [Test]
        public void TestDevideNegativeByNegative()
        {
            Assert.AreEqual(2, calculate.Divide(-4, -2));
        }
        [Test]
        public void TestDevideZeroByNegative()
        {
            Assert.AreEqual(0, calculate.Divide(0, -2));
        }
        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(8, calculate.Multiply(4, 2));
        }
        [Test]
        public void TestMultiplyNegative()
        {
            Assert.AreEqual(-8, calculate.Multiply(-4, 2));
        }
        [Test]
        public void TestMultiplyNegativeByNegative()
        {
            Assert.AreEqual(8, calculate.Multiply(-4, -2));
        }
        [Test]
        public void TestMultiplyZero()
        {
            Assert.AreEqual(0, calculate.Multiply(0, 2));
        }
        [Test]
        public void TestMultiplyZeroByZero()
        {
            Assert.AreEqual(0, calculate.Multiply(0, 0));
        }
    }
}
