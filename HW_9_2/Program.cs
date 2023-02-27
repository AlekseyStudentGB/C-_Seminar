/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

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

int WriteNubers(int m,int n)
{
    if (n == m) return (n);
    else 
    {
        
       return n + WriteNubers(m,n-1) ;
    }
}


int m = GetNumber("Введите M -> ");
int n = GetNumber("Введите N -> ");
Console.WriteLine(WriteNubers(m,n));
