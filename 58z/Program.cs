// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int[,] array = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] resultArray = new int[2, 2];
Console.WriteLine("I матрица");
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("II матрица");
FillArray(array2, 1, 10);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("I*II");
MatrixMultiplication(array, array2, resultArray);
PrintArray(resultArray);

void MatrixMultiplication(int[,] matr1, int[,] matr2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(0); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

void FillArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max-1);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}