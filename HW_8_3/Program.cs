/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void GetMatrResult(int[,] matr1, int[,] matr2, int[,] matrResult)
{
    for (int i = 0; i < matrResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrResult.GetLength(1); j++)
        {
            matrResult[i, j] = GetResult(matr1, matr2, i, j);
            Console.Write($"{matrResult[i, j]} ");
        }
        Console.WriteLine();
    }
}
int GetResult(int[,] matr1, int[,] matr2, int i, int j)
{
    int[] arr = new int[2];
    int summ = 0;
    for (int k = 0; k < matr1.GetLength(0); k++)
    {
        arr[k] = matr1[i, k] * matr2[k, j];
    }
    for (int l = 0; l < matr1.GetLength(0); l++)
    {
        summ = summ + arr[l];
    }
    //Console.WriteLine(summ);
    return summ;
}

int[,] matr1 = new int[,]
{
{2,4},
{3,2},
};
int[,] matr2 = new int[,]
{
{3,4},
{3,3},
};

int[,] matrResult = new int[matr1.GetLength(0), matr1.GetLength(1)];
GetMatrResult(matr1, matr2, matrResult);


