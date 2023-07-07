// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Сделать через функции.
Console.Clear();
int Prompt (string message)
{
Console.Write(message);
String Input = Console.ReadLine();
int res = int.Parse(Input);
return res;
}
int Power(int powerBase, int exponent)
{
    int Power = 1;
    for (int i = 0; i < exponent; i++)
    {
        Power *= powerBase;
    }
    return Power;
}
bool ValidateExponent (int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель должен быть больше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt ("Введите основание: ");
int exponent = Prompt ("Введите показатель: ");
if (ValidateExponent (exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}");
}