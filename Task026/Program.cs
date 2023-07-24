// Задайте значение N. Напишите программу, которая выведет все ЧЕТНЫЕ натуральные числа в промежутке от 1 до N.
Console.Clear();
int m = 2;
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2)
{
    System.Console.WriteLine("Натуральных четных чисел нету");
}
void che(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
System.Console.WriteLine($" {m} ");
}
che(m+1,n);

}
che(m,n);