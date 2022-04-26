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
    }
}
