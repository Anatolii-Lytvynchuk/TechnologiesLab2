using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologiesLab2.Tests
{
    [TestClass()]
    public class IntegralCalculatorTests
    {
        [TestMethod()]
        public void CalculateTest1()
        {
            double result = new IntegralCalculator().Calculate(1, 4, 100, new Function(), 2,2);
            Assert.AreEqual(result, 4.714, 0.001);
        }
        [TestMethod()]
        public void CalculateTest2()
        {
            double result = new IntegralCalculator().Calculate(1, 4, 500, new Function(), 7, 2);
            Assert.AreEqual(result, 4.714, 0.001);
        }
    }
}
