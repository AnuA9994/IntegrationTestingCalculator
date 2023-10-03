using Calculator;
namespace IntegrationTestingCalculator
{
    public class integration_test
    {
        [Test]
        public void Addition()
        {
            int num1 = 5;
            int num2 = 10;
           Assert.AreEqual(15,CalculationMethods.Add(num1,num2));
        }
        [Test]
        public void Subtraction()
        {
            int num1 = 25;
            int num2 = 3;
            Assert.AreEqual(22, CalculationMethods.Subtract(num1, num2));
        }
        [Test]
        public void  Multiplication()
        {
            int num1 = 3;
            int num2 = 6;
            Assert.AreEqual(18, CalculationMethods.multiply(num1, num2));
        }
        [Test]
        public void DivisionPositive()
        {
            int num1 = 9;
            int num2 = 3;
            Assert.AreEqual(3, CalculationMethods.divide(num1, num2));
        }
        [Test]
        public void DivisionNegative()
        {
            int num1 = 9;
            int num2 = 0;
            string expectedErrorMessage = "Divide By Zero Error";
            var ex = Assert.Throws<ArithmeticException>(() => CalculationMethods.divide(num1, num2));
            Assert.AreEqual(expectedErrorMessage, ex.Message);
        }
    }
}