// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
System.Console.WriteLine("Введите длину массива");
String Inputed1 = Console.ReadLine();
int len = Convert.ToInt32(Inputed1);
double min = -10000;
double max = 10000;
double[] GenerateArray(int len, double min, double max)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next((int)min,(int)max + 1))/100;
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.Write("Масcив [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
double[] array = GenerateArray(len, min, max);
        Double minValue = array[0];
        Double maxValue = array[0];
        
        for (Double i = 0; i < len; i++)
        {
            if (array[(int)i] > maxValue)
            {
                maxValue = array[(int)i];
            }

            else if (array[(int)i] < minValue)
            {
                minValue = array[(int)i];
            }
        }
double deff = maxValue - minValue;
PrintArray(array);
System.Console.WriteLine($"Минимальное значение = {minValue}");
System.Console.WriteLine($"Максимальное значение = {maxValue}");
System.Console.WriteLine($"Разница ={deff}");