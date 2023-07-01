//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("ВВедите число=>");
String Inputed1 = Console.ReadLine();
int A = Convert.ToInt32(Inputed1);
Console.Write("ВВедите число=>");
String Inputed2 = Console.ReadLine();
int B = Convert.ToInt32(Inputed2);
int max = A;
if (A > B) max = A;
if (B > A) max = B;
Console.Write ("max =");
Console.WriteLine (max);