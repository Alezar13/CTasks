// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
System.Console.WriteLine("Введите длину массива");
String Inputed1 = Console.ReadLine();
int len = Convert.ToInt32(Inputed1);
System.Console.WriteLine("Ведите минимальное число массива");
String Inputed2 = Console.ReadLine();
int min = Convert.ToInt32(Inputed2);
System.Console.WriteLine("Ведите максимальное число массива");
String Inputed3 = Console.ReadLine();
int max = Convert.ToInt32(Inputed3);
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
int sum = 0;
for (int i = 1; i < len; i+=2)
{
    sum += array[i];
}
 PrintArray(array);
 System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива равна {sum}");