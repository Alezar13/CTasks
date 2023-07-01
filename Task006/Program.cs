//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int Prompt (string message)
{
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int res = Convert.ToInt32(Inputed);
return res;
}
int GetThirdRank (int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
bool ValidateNum (int num)
{
    if (num < 100)
    {
        System.Console.WriteLine("Третей цифры нет");
        return false;
    }
    return true;
}
int num = Prompt ("Введите число =>");
if (ValidateNum (num))
{
    System.Console.WriteLine(GetThirdRank (num));
}