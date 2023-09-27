using Calculator;
using IntegrationTestingCalculator;
namespace IntegrationTestingCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int num1 = 5;
            int num2 = 10;
           Assert.AreEqual(15,CalculationMethods.Add(num1,num2));
        }


    }
}