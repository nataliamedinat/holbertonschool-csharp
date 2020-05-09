using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Empty()
        {
            {
            string str = "";
            var result = Str.CamelCase(str);
            Assert.AreEqual(0, result);
        }
        }

        [Test]
        public void ReturnNumber()
        {
            string str = "lifeIsBeatiful";
            var result = Str.CamelCase(str);
            Assert.AreEqual(3, result);

        }

        [Test]
        public void WhenNull()
        {
            string str = null;
            var result = Str.CamelCase(str);
            Assert.AreEqual(0, result);
        }
    }
}