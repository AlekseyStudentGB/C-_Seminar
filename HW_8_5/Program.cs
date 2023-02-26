/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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