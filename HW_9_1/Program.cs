/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
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

string WriteNubers(int n)
{
    if (n == 1) return ($"{n} ");
    else
    {
        return n.ToString() + "," + WriteNubers(n - 1);
    }
}


int n = GetNumber("Введите N -> ");
Console.WriteLine(WriteNubers(n));