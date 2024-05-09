using TestTask;

namespace Notes.Tests
{
    public class MatrixConverterTests
    {
        [Fact]
        public void ConvertToSpiralArray_ConvertsMatrixToSpiralArray()
        {
            // Arrange
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] expectedSpiralArray = { 1, 4, 7, 8, 9, 6, 3, 2, 5 };

            // Act
            int[] result = MatrixConverter.ConvertToSpiralArray(matrix);

            // Assert
            Assert.Equal(expectedSpiralArray, result);
        }
    }
}
