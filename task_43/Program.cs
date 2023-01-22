// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double getUserData(string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}
void findIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if(k1 == k2)
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
    double x = Math.Round((b2 - b1)/(k1-k2), 2);
    double y = Math.Round(k1 * ((b2 -b1)/(k1-k2)) + b1, 2);
    Console.Write($"Координаты точки пересечения прямых равны: ({x},{y})");
    }
}
double b1 = getUserData("Введите координату прямой b1: ");
double k1 = getUserData("Введите координату прямой k1: ");
double b2 = getUserData("Введите координату прямой b2: ");
double k2 = getUserData("Введите координату прямой k2: ");
findIntersectionPoint(b1, k1, b2, k2);
