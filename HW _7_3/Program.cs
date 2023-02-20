/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] InitMatrix(int m, int n)
{
    int[,] array = new int[m, n];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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

void GetResult(int[,] matr, int m, int n, double[] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[j] += matr[i, j];
        }
    }
    for (int ii = 0; ii < m; ii++)
    {
        arr[ii] = arr[ii] / m;
    }
}

void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i].ToString("F1")}/");

    }
}


int m = GetNumber("M = ");
int n = GetNumber("N = ");
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
double[] arr = new double[m];
GetResult(matrix, m, n, arr);
PrintArr(arr);
*/
/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
int[,] InitMatrix(int m, int n)
{
    int[,] array = new int[m, n];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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
