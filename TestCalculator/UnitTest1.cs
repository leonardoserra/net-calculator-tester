using net_calculator_tester;

namespace TestCalculator
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description="AddTestDifferentValues")]
        [TestCase(-2,34)]
        [TestCase(0,-34)]
        [TestCase(0.44f,-34.352f)]
        public void Add_Test(float num1,float num2)
        {
            Calculator.Add(num1, num2);
            Assert.Pass();
        }

        [Test(Description = "SubtractTestDifferentValues")]
        [TestCase(-2, 34)]
        [TestCase(0, -34)]
        [TestCase(0.44f, -34.352f)]
        public void Subtract_Test(float num1, float num2)
        {
            Calculator.Subtract(num1, num2);
            Assert.Pass();
        }
    }
}