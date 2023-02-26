/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*//*
int[,] InitMatrix(int m, int n)
{
    int[,] array = new int[m, n];

    Random rnd = new Random();
    int ir=1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(ir,ir+5);
            ir+=5;
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("_______");
}

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

void GetResult(int[,] matr, int m, int n, int[,] resultmatr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j < m && i< n)
                resultmatr[i, j] = matr[j, i];
            else Console.WriteLine($"занчение {matr[j, i]} утерянно");
        }

    }
        
}


int m = GetNumber("Кол-во строк = ");
int n = GetNumber("Кол-во столбцов = ");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);

int[,] resultmatr =new int[m, n];
GetResult(matrix, n, m, resultmatr);
PrintMatrix(resultmatr);
*/
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

string WriteNubers(int m, int n)
{
    if (n == m) return ($"{m} ");
    else 
    {
       return WriteNubers(m,n - 1) + " " + n.ToString();
    }
}







int m = GetNumber("Введите M -> ");
int n = GetNumber("Введите N -> ");
Console.WriteLine(WriteNubers(m,n));