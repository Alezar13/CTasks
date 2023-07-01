Console.Clear();
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int A = Convert.ToInt32(Inputed);
for (int count = 2; count <= A; count+=2)
{
    System.Console.WriteLine(count);
}