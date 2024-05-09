namespace TestTask
{
    public class MatrixConverter
    {
        public static int[] ConvertToSpiralArray(int[,] matr)
        {
            var m = matr.GetLength(0);
            var n = matr.GetLength(1);
            var totalLength = m * n;

            var spiralArray = new int[totalLength];

            var topRow = 0;
            var bottomRow = m - 1;
            var leftCol = 0;
            var rightCol = n - 1;
            var currentIndex = 0;
            var currentRow = 0;
            var currentCol = 0;

            while (currentIndex < totalLength)
            {
                while (currentRow <= bottomRow)
                {
                    spiralArray[currentIndex++] = matr[currentRow, currentCol];
                    currentRow++;
                }
                currentRow--;
                currentCol++;
                leftCol++;

                if (currentIndex < totalLength)
                {
                    while (currentCol <= rightCol)
                    {
                        spiralArray[currentIndex++] = matr[currentRow, currentCol];
                        currentCol++;
                    }
                    currentCol--;
                    currentRow--;
                    bottomRow--;

                    if (currentIndex < totalLength)
                    {
                        while (currentRow >= topRow)
                        {
                            spiralArray[currentIndex++] = matr[currentRow, currentCol];
                            currentRow--;
                        }
                        currentCol--;
                        currentRow++;
                        rightCol--;

                        if (currentIndex < totalLength)
                        {
                            while (currentCol >= leftCol)
                            {
                                spiralArray[currentIndex++] = matr[currentRow, currentCol];
                                currentCol--;
                            }
                            currentCol++;
                            currentRow++;
                            topRow++;
                        }
                    }
                }
            }

            return spiralArray;
        }
    }
}
