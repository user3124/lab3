using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class SquareMatrix
    {
        public int Size { get; }
        public int[,] Matrix { get; }

        public SquareMatrix(int size, int minValue = 0, int maxValue = 10)
        {
            if (size <= 0)
                throw new ArgumentException("Размер матрицы должен быть положительным числом.");

            Size = size;
            Matrix = new int[Size, Size];
            FillMatrixWithRandomValues(minValue, maxValue);
        }

        // Метод для заполнения матрицы случайными числами
        private void FillMatrixWithRandomValues(int minValue, int maxValue)
        {
            Random randomGenerator = new Random();

            for (int row = 0; row < Size; ++row)
            {
                for (int column = 0; column < Size; ++column)
                {
                    Matrix[row, column] = randomGenerator.Next(minValue, maxValue + 1);
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int row = 0; row < Size; ++row)
            {
                for (int column = 0; column < Size; ++column)
                {
                    result += $"{Matrix[row, column],5}";
                }
                result += "\n";
            }
            return result;
        }

        public static SquareMatrix operator +(SquareMatrix matrixA, SquareMatrix matrixB)
        {
            if (matrixA == null || matrixB == null)
                throw new ArgumentNullException("Обе матрицы должны быть инициализированы.");

            if (matrixA.Size != matrixB.Size)
                throw new MatrixSizeMismatchException();

            SquareMatrix resultMatrix = new SquareMatrix(matrixA.Size, 0, 0);

            for (int row = 0; row < matrixA.Size; ++row)
            {
                for (int column = 0; column < matrixA.Size; ++column)
                {
                    resultMatrix.Matrix[row, column] = matrixA.Matrix[row, column] + matrixB.Matrix[row, column];
                }
            }

            return resultMatrix;
        }
    }
}
