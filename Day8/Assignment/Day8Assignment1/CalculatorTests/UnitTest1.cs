using Day8Assignment1;

namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        private Calculator _calculator;

        // Set up the Calculator instance before each test
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Test case for addition
        [Test]
        public void Add_WhenCalled_ReturnsCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        // Test case for subtraction
        [Test]
        public void Subtract_WhenCalled_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        // Test case for multiplication
        [Test]
        public void Multiply_WhenCalled_ReturnsCorrectProduct()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        // Test case for division with valid input
        [Test]
        public void Divide_WhenCalled_ReturnsCorrectQuotient()
        {
            var result = _calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        // Test case for division by zero
        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }

        // Test case for adding zero
        [Test]
        public void Add_Zero_ReturnsSameValue()
        {
            var result = _calculator.Add(0, 5);
            Assert.AreEqual(5, result);
        }

        // Test case for subtracting zero
        [Test]
        public void Subtract_Zero_ReturnsSameValue()
        {
            var result = _calculator.Subtract(5, 0);
            Assert.AreEqual(5, result);
        }
    }
}