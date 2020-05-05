using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CheckIfItsEmpty()
        {
            //Arrange
            List<int> mylist = new List<int> ();

            // Act
            int r = MyMath.Operations.Max(mylist);

            //Asset
            Assert.AreEqual(0, r);
        }

        [Test]
        public void ReturnTheMax()
        {
            //Arrange
            List<int> mylist = new List<int> () {0, 2, 3, 8};

            // Act
            int r = MyMath.Operations.Max(mylist);

            // Asset
            Assert.AreEqual(8, r);
        }

        [Test]
        public void MaxInNegative()
        {
            //Arrange
            List<int> mylist = new List<int> () {98, -32, 120, -700};

            //Act
            int r = MyMath.Operations.Max(mylist);

            //Asset
            Assert.AreEqual(120, r);
        }
    }
}