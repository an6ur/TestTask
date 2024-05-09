using TestTask;

namespace Notes.Tests
{
    public class StringCompressionTests
    {
        [Fact]
        public void Compress_ReturnsCompressedString()
        {
            // Arrange
            string input = "aaabbcccc";

            // Expected compressed string: "a3b2c4"
            string expected = "a3b2c4";

            // Act
            string result = StringCompression.Compress(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decompress_ReturnsDecompressedString()
        {
            // Arrange
            string input = "a3b2c4";

            // Expected decompressed string: "aaabbcccc"
            string expected = "aaabbcccc";

            // Act
            string result = StringCompression.Decompress(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}