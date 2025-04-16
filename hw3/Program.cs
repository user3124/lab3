using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер квадратной матрицы:");
                int matrixSize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите минимальное значение:");
                int minimumValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите максимальное значение:");
                int maximumValue = Convert.ToInt32(Console.ReadLine());

                SquareMatrix testMatrix = new SquareMatrix(matrixSize, minimumValue, maximumValue);

                Console.WriteLine("\nСгенерированная матрица:");
                Console.WriteLine(testMatrix.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение.");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Произошло непредвиденное исключение: {exception.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
