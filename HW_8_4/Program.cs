/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void Initmatr(int[,,] matr)
{int indtxRnd = 1;
    Random rnd = new Random();
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                matr[k, i, j] = rnd.Next(indtxRnd, indtxRnd +5);
                indtxRnd += 5;

            }
        }
    }
}

void PrintMatr(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                Console.Write($"{matr[k, i, j]} ({k},{i},{j}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("__________________");
    }
}

int[,,] matr = new int[2, 2, 2];
Initmatr(matr);
PrintMatr( matr);

