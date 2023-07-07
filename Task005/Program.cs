//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int Prompt (string message)
{
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int res = Convert.ToInt32(Inputed);
return res;
}

int num = Prompt ("Введите трехзначное число =>");
if (num < 100 || num >= 1000)
{
    System.Console.WriteLine("Не трехзначное число");
    return;
}
System.Console.WriteLine($"Введеное число {num}");
int secNum = num / 10 % 10;
System.Console.WriteLine($"Вторая цифра числа {num} это {secNum}");