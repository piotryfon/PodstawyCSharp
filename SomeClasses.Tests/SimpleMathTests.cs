using NUnit.Framework;


namespace SomeClassesTests
{
    [TestFixture]
    internal class SimpleMathTests
    {
        [TestCase(5,5)]
        public static void IfAdd5to5Return10(int a, int b)
        {
            //Act
            int result = new SimpleMath().Add(a, b);
           
            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
