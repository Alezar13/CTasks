﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("ВВедите число 1=>");
String Inputed1 = Console.ReadLine();
int A = Convert.ToInt32(Inputed1);
Console.Write("ВВедите число 2=>");
String Inputed2 = Console.ReadLine();
int B = Convert.ToInt32(Inputed2);
Console.Write("ВВедите число 3=>");
String Inputed3 = Console.ReadLine();
int C = Convert.ToInt32(Inputed3);
int max = A;
if (B > A) max = B;
if (C > B) max = C;
Console.Write ("max =");
Console.WriteLine (max);