//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int A = Convert.ToInt32(Inputed);
if (A % 2 == 0)
{
    Console.WriteLine ("Четное число");
}
else
{
    System.Console.WriteLine("Число нечетное");
}