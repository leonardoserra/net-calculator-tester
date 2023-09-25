using net_calculator_tester;
using System;

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
            
            
            Assert.DoesNotThrow(()=>Calculator.Add(num1, num2));
        }

        [Test(Description = "SubtractTestDifferentValues")]
        [TestCase(-2, 34)]
        [TestCase(0, -34)]
        [TestCase(0.44f, -34.352f)]
        public void Subtract_Test(float num1, float num2)
        {
            Assert.DoesNotThrow(() => Calculator.Subtract(num1, num2));
        }

        [Test(Description = "MultiplyTestDifferentValues")]
        [TestCase(-2, 34)]
        [TestCase(0, -34)]
        [TestCase(0.44f, -34.352f)]
        public void Multiply_Test(float num1, float num2)
        {
            Assert.DoesNotThrow(()=>Calculator.Multiply(num1, num2));
        }

        [Test(Description = "DivideTestDifferentValues")]
        [TestCase(-2, 34)]
        [TestCase(0, -34)]
        [TestCase(0.44f, -34.352f)]
        [TestCase(0.44f, 0)]

        public void Divide_Test(float num1, float num2)
        {
            Calculator.Divide(num1, num2);
            Assert.DoesNotThrow(() => Calculator.Divide(num1, num2));
        }
    }
}