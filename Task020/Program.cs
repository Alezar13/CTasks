// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число масива: ");
int rowsin = ReadInt("Введите индекс строки: ");
int columsin = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rowsin < numbers.GetLength(0) && columsin < numbers.GetLength(1)) Console.WriteLine(numbers[rowsin, columsin]);
else Console.WriteLine($"{rowsin},{columsin} -> такого числа в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}