
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
  
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return WriteNubers(m - 1, 1);
    if (m > 0 && n > 0) return WriteNubers(m - 1, WriteNubers(m, n - 1));
return WriteNubers(m, n);
}




int m = GetNumber("Введите M -> ");
int n = GetNumber("Введите N -> ");
Console.WriteLine($" A({m},{n}) = {WriteNubers (m, n)}");