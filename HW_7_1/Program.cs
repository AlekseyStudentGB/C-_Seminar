/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

double[,] InitMatrix(int m, int n)
{
    double[,] array = new double[m, n];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = -10 + rnd.NextDouble()*20;
        }
    }

    return array;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j].ToString("F1")} ");
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

void GetPosishen(double[,] matr)
{
int i =GetNumber("строка = ")-1;
int j =GetNumber("столбец = ")-1;
if (i <= matr.GetLength(0) &&  j <=  matr.GetLength(1)) Console.WriteLine (matr[i,j]);
else Console.WriteLine("Такого числа нет"); 
}

int m =GetNumber("M = ");
int n =GetNumber("N = ");
double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
GetPosishen(matrix);