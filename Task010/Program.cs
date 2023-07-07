// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
int ReadInt(string message)
{
    System.Console.Write(message);              
        return Convert.ToInt32(Console.ReadLine()); 
}
int N = ReadInt("Введите число => ");
int count = 1;
while (count <= N)
{
    System.Console.WriteLine(count*count*count);
    count++;
}