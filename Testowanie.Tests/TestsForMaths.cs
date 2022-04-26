using NUnit.Framework;
using SomeClasses;

namespace TestsForSomeClasses
{
    [TestFixture]
    public class TestsForMaths
    {
        [TestCase(3, 7, 10)]
        public static void IfAddFirstNumAndSecoundNumResultWillBeTen(int a, int b, int expected)
        {
            //Act
            int result = new SimpleMath().Add(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public static void IfSumAllParamsResultWillBeTen()
        {
            //Act
            double result = new SimpleMath().SumAllParams(3,7,0);

            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
