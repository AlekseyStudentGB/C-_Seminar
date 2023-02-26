/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18




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

*/////////////
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


int[,] matr = new int[4, 4];


int s = 4;
int num = 0;
int 
for (int m = 0; m < 1; m++)
{ 
    for (int k = 0; k < s; k++)
    {
        num++;
        matr[m, k] = num;
      

    }
}


for (int i = 3; i< 4; i++)
{ 
    for (int j = 1; j < s; j++)
    {
        num++;
        matr[j, i] = num;
      

    }
}



MatrPrint(matr);









void MatrPrint(int[,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {

            Console.Write($"{matr[k, m]} ");
        }
        Console.WriteLine();
    }
}
*/

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2


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
}

void Select(int[,] matr, int[] arr)
{
    int temp = 0;
    int max = 0;



    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[j] = matr[i, j];
        }
        
        //PrArr(arr);
        SelectArr(arr);
        //PrArr(arr);
        OutArr(i, matr, arr);

    }
    
}

void SelectArr(int[] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxP = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxP])
            {
                maxP = j;
            }
        }
        temp = arr[i];
        arr[i] = arr[maxP];
        arr[maxP] = temp;

    }

}

void PrArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

void OutArr(int i, int[,] matr, int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        matr[i, j] = arr[j];
    }
}

int[,] matr = new int[4, 4];
int[] arr = new int[matr.GetLength(1)];
Initmatr(matr);
PrintMatr(matr);
Select(matr, arr);
Console.WriteLine("_______");
PrintMatr(matr);
*////////////////////////////
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*//*

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
*///////////////////////
/*
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
*/
void Initmatr(int[,] matr, int n)
{
    int num = 1;
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            
            matr[i, j] = num++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            
            matr[k, n - i-1] = num++;
        }
        for (int j = n-i-2; j >=i; j--)
        {
            
            matr[n-1-i, j] = num++;
        }
         for (int k = n-2-i; k > i ; k--)
        {
            
            matr[k,i] = num++;
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

int[,] matr = new int[4, 4];
Initmatr(matr, 4);
PrintMatr(matr);


