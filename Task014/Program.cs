// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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
int count = 0;
int Length = Prompt ("Длина массива:");
int min = 100;
int max = 999;
int[] array = GenerateArray (Length, min, max);
for (int i = 0; i < Length; i++)
            {
            
                    if ((array[i] % 2) == 0)
                    count++;
            }
            PrintArray(array);
            System.Console.WriteLine($"Количество четных чисел {count}");
        