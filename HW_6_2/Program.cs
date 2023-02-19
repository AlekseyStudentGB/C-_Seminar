/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("НЕ КОРРЕКТНОЕ ЗНАЧЕНИЕ");

    }
    return result;
}
double b1 = GetNumber(" b1 = ");
double b2 = GetNumber(" b2 = ");
double k1 = GetNumber(" k1 = ");
double k2 = GetNumber(" k2 = ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"{x}, {y}");