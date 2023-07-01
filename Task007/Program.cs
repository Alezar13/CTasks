//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
int Prompt (string message)
{
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int res = Convert.ToInt32(Inputed);
return res;
}
bool IsWeek (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday (int num)
{
    if (num > 0 && num <=7)
    {
        return true;
    }
    System.Console.WriteLine("К сожалению в неделе 7 дней.");
    return false;
}
int weekDay = Prompt ("Ведите день недели =>");
if (ValidateWeekday(weekDay))
{
    if (IsWeek(weekDay))
    {
        System.Console.WriteLine("Ура выходной!");
    }
    else
    {
        System.Console.WriteLine("Ещё работаем.");
    }
}