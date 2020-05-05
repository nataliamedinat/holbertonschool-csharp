using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMethod1()
        {
            // Arrange
            int Eresult = 5;

            // Act 
            int sum = MyMath.Operations.Add(2, 3);

            // Assert
            Assert.AreEqual(Eresult, sum);
        }
    }
}