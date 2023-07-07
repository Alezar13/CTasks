// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
Console.Clear();
int Prompt (string message)
{
Console.Write(message);
String Input = Console.ReadLine();
int res = int.Parse(Input);
return res;
}
int Sum (int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
int num = Prompt ("Введите положительное число не более 2147483647=>");
System.Console.WriteLine($"Сумма всех цифр в числе {num} = {Sum(num)}");