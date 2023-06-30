Console.Clear();
Console.Write("ВВедите число =>");
String Inputed = Console.ReadLine();
int A = Convert.ToInt32(Inputed);
for (int count = 2; count <= A; count++){
    if (count % 2 == 0)
    System.Console.WriteLine(count);
}