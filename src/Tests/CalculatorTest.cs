using App;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Two_Positive_Numbers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(4, 9);
            Assert.AreEqual(13, result);
        }

        [Test]
        public void Add_Two_Negative_Numbers()
        {
            var calculator = new Calculator();
            var result = calculator.Add(-1, -4);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Add_A_Positive_And_A_Negative_Number()
        {
            var calculator = new Calculator();
            var result = calculator.Add(4, -9);
            Assert.AreEqual(-5, result);
        }

    }
}
