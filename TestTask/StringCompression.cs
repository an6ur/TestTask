using System.Text;

namespace TestTask
{
    public class StringCompression
    {
        // Метод для компрессии строки
        public static string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder compressedString = new StringBuilder();
            int count = 1;

            for (int i = 1; i <= input.Length; i++)
            {
                if (i < input.Length && input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        compressedString.Append(input[i - 1]);
                        compressedString.Append(count);
                    }
                    else
                    {
                        compressedString.Append(input[i - 1]);
                    }
                    count = 1;
                }
            }

            return compressedString.ToString();
        }

        // Метод для декомпрессии строки
        public static string Decompress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder decompressedString = new StringBuilder();
            int index = 0;

            while (index < input.Length)
            {
                char currentChar = input[index];
                index++;

                if (index < input.Length && char.IsDigit(input[index]))
                {
                    int count = int.Parse(input[index].ToString());
                    decompressedString.Append(new string(currentChar, count));
                    index++;
                }
                else
                {
                    decompressedString.Append(currentChar);
                }
            }

            return decompressedString.ToString();
        }
    }
}
