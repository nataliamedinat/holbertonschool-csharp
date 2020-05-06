using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MatrixDivide()
        {
            //Arrage
            int[,] matrix = {
            {6, 8, 12},
            {14, 16, 2},
            {20, 18, 4}
            };

            int[,] result = {
            {3, 4, 6},
            {7, 8, 1},
            {10, 9, 2}
            };

            //Act
            int [,] final = MyMath.Matrix.Divide(matrix, 2);

            // Assert
            Assert.AreEqual(result, final);
        }

        [Test]
        public void MatrixNull()
        {
            // Arrage
            int [,] matrix = null;

            // Act
            int [,] newmatrix = MyMath.Matrix.Divide(matrix, 2);

            // Assert 
            Assert.AreEqual(null, newmatrix);
        }
    }
}