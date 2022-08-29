// Напишите программу, которая 
// 1. найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2. значения b1, k1, b2 и k2 задаются пользователем.
// Например: 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение для k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double xInters = 0;
double yInters = 0;

if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
else
{
    xInters = (b2 - b1) / (k1 - k2);
    yInters = k1 * xInters + b1;
    Console.WriteLine("Точка пересечения " + " (" + xInters + " ;" + yInters + ")");
}