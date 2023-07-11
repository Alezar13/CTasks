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
    System.Console.Write("Масcив [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int Length = Prompt ("Длина массива:");
int min = Prompt ("Начальное значение, для диапазона случайного числа:");
int max = Prompt ("Конечное значение, для диапазона случайного числа:");
int sum = 0;
int[] array = GenerateArray (Length, min, max);
for (int i = 1; i < Length; i+=2)
{
    sum += array[i];
}
 PrintArray(array);
 System.Console.WriteLine($"Сумма нечетных индексов массива равна {sum}");