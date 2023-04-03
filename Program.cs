using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };
        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Невозможно умножить матрицы");
            return;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }


        Console.WriteLine("Первая матрица:");
        PrintMatrix(matrix1);
        Console.WriteLine("Вторая матрица:");
        PrintMatrix(matrix2);
        Console.WriteLine("Результирующая матрица:");
        PrintMatrix(resultMatrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
