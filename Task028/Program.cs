// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
{
    System.Console.WriteLine($"Число {m} отрицательное невозможно запустить программу.");
    return;
}
Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    System.Console.WriteLine($"Число {n} отрицательное невозможно запустить программу.");
    return;
}
AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}