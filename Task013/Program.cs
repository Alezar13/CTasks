// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Сделать через функции.
Console.Clear();
int Prompt (string message)
{
Console.Write(message);
String Input = Console.ReadLine();
int res = int.Parse(Input);
return res;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next (minValue, maxValue +1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.WriteLine($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int Length = 8; // или "Prompt ("Длина массива:")" Для выбора длины пользователем.
System.Console.WriteLine($"Длинна массива {Length}");
int min = Prompt ("Начальное значение, для диапазона случайного числа:");
int max = Prompt ("Конечное значение, для диапазона случайного числа:");
int[] array = GenerateArray (Length, min, max);
PrintArray(array);