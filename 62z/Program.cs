// Задача 62. Напишите программу, которая заполнит спирально массив. Размер вводит юзер

Console.Clear();
Console.Write("Введите кол-во строк: ");
int r = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int c = int.Parse(Console.ReadLine());
int[,] array = new int[r, c];
FillArray(array, r, c);
PrintArray(array);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int r, int c)
{
    int value = 1, top = 0, bottom = c - 1, left = 0, right = r - 1;

    while (value <= r * c) 
    {
        for (int i = left; i <= right; i++)
            matr[top, i] = value++;
            top++;
        for (int i = top; i <= bottom; i++) 
            matr[i, right] = value++;
            right--;
        for (int i = right; i >= left; i--) 
            matr[bottom, i] = value++;
            bottom--;
        for (int i = bottom; i >= top; i--) 
            matr[i, left] = value++;
            left++;
    }
}
