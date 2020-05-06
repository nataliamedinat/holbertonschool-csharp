using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CheckPalindrome()
        {
            // Arrage
            string str = "civic";

            // Act
            var result = Text.Str.IsPalindrome(str);

            // Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void SpacePoli()
        {
            string str = " ";
            var result = Text.Str.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }

         [Test]
        public void PoliFalse()
        {
            string str = "Lola";
            bool result = Text.Str.IsPalindrome(str);
            Assert.AreEqual(false, result);
        }
    }
}