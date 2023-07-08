//Напишите программу, которая принимает на вход число "N" и проверяет, является ли оно палиндромом.
Console.Clear();
int Prompt (string message)
{
Console.Write("Введите число =>");
String Inputed = Console.ReadLine();
int res = Convert.ToInt32(Inputed);
return res;
}
int num = Prompt("Введите число =>");
int left = num;
int rev = 0;
while(Convert.ToBoolean(left)) 
{
   int r = left % 10;   
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

