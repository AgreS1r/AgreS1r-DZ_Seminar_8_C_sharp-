// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] array = new int[4, 4];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
FindMinSumRow(array);

void FindMinSumRow(int[,] matr)
{
    int result = 0, sum = 0, minRow = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minRow += matr[0, j];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        if (sum < minRow)
        {
            minRow = sum;
            result = i;
        }
        sum = 0;    
    }
    Console.Write($"Строка с минимальной суммой элементов - {result+1}");
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