//Напишите программу, которая принимает на вход число "N" и проверяет, является ли оно палиндромом.
Console.Clear();
UInt64 Prompt (string message)
{
Console.Write("Введите число =>");
String Inputed = Console.ReadLine();
UInt64 res = Convert.ToUInt64(Inputed);
return res;
}
UInt64 num = Prompt("Введите число =>");
UInt64 left = num;
UInt64 rev = 0;
while(Convert.ToBoolean(left)) 
{
   UInt64 r = left % 10;   
   rev = rev * 10 + r;
   left = left / 10;  
}
if(num==rev)
{
    System.Console.WriteLine($"Число {num} палиндром");
}
else
{
    System.Console.WriteLine($"Число {num} не палиндром");
} 

