//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки (только / и % используем)
Console.Clear();
int Prompt (string message)
{
Console.Write("Введите пятизначное число =>");
String Inputed = Console.ReadLine();
int res = Convert.ToInt32(Inputed);
return res;
}
int num = Prompt("Введите пятизначное число =>");
if (num < 10000 || num > 99999)
{
    System.Console.WriteLine("Не пятизначное число");
    return;
}
int num1 = num % 10;
int num2 = num / 10 % 10;
int num3 = num / 1000 % 10;
int num4 = num /10000;
if (num1 == num4 && num2 == num3)
{
    System.Console.WriteLine($"Число {num} палиндром");
}
else 
System.Console.WriteLine( $"Число {num} не палиндром");
