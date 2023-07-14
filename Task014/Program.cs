// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
System.Console.WriteLine("Введите длину массива");
String Inputed1 = Console.ReadLine();
int len = Convert.ToInt32(Inputed1);
int min = 100;
int max = 1000;
int count = 0;
int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max + 1);
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
int[] array = GenerateArray(len, min, max);
for (int i = 0; i < len; i++)
            {
            
                if ((array[i] % 2) == 0)
                count++;
            }
 PrintArray(array);
 System.Console.WriteLine($"Количество четных чисел {count}");
        