//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
const int cof = 0;
const int con = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;
double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);
if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений y= {lineData1[cof]}*x+{lineData1[con]} и y= {lineData2[cof]}*x+{lineData2[con]}");
System.Console.WriteLine($"имеет координаты({coord[X_COORD]} : {coord[Y_COORD]})");
}
double Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[cof] = Prompt ($"Введите коофициент для {numberOfLine} прямой =>");
    lineData[con] = Prompt ($"Введите константу для {numberOfLine} прямой =>");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[con] - lineData2[con]) / (lineData2[cof] - lineData1[cof]);
    coord[Y_COORD] = lineData1[con] * coord[X_COORD] + lineData1[con];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[cof] == lineData2[cof])
    {
        if (lineData1[con] == lineData2[con])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}