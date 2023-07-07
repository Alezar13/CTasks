// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int ReadInt(string message)
{
    System.Console.Write(message);              
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = ReadInt("Введите x1 =>");
int y1 = ReadInt("Введите y1 =>");
int z1 = ReadInt("Введите z1 =>");
int x2 = ReadInt("Введите x2 =>");
int y2 = ReadInt("Введите y2 =>");
int z2 = ReadInt("Введите z2 =>");
int rangex = x1 - x2;
int rangey = y1 - y2;
int rangez = z1 -z2;
double range = Math.Sqrt(rangex*rangex + rangey*rangey + rangez*rangez);
System.Console.WriteLine($"Расстояние между координатами равно {range}");