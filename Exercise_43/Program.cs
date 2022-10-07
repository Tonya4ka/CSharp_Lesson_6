// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Type a value of b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Type a value of k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Type a value of b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Type a value of k2: ");
double k2 = double.Parse(Console.ReadLine()!);
double[] pointCross = LineCross(b1,k1,b2,k2);
if (k1==k2)
   Console.WriteLine("No crossing");
else
   Console.WriteLine($"The lines are crossing at the point ({pointCross[0]},{pointCross[1]})");

double[] LineCross(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}
 
 
