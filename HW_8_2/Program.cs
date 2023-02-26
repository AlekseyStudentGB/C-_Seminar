/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Initmatr(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(0, 10);

        }
    }
}

void PrintMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("________");
}

void MaxRow(int[,] matr)
{
    int minSum = 100;
    int positonMinSum = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        int sumRow = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRow = sumRow + matr[i, j];
        }
        if (minSum > sumRow)
        {
            minSum = sumRow;
            positonMinSum = i;
        }

    }
    Console.WriteLine(positonMinSum + 1);
}






int[,] matr = new int[5, 4];
Initmatr(matr);
PrintMatr(matr);
MaxRow(matr);