/*
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}


int[] GetResult(int number)
{
    List<int> result = new List<int>();
    while (number > 0)
    {
        result.Add(number % 2);
        number /= 2;

    }
    return result.ToArray();
}

int num = GetNumber("Введите число: ");
int[] arr = GetResult(num);
Array.Reverse(arr);
Console.Write(String.Join(" ", arr));*/

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3


int[] InitArray(string msg)
{
    Console.WriteLine(msg);
    string[] arr = Console.ReadLine().Split(",");
    int[] workArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        workArr[i] = int.Parse(arr[i]);
    }
    return workArr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

int GetCountpositiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = InitArray("Введите числа через запятую");
//PrintArr(array);
Console.WriteLine();
Console.WriteLine(GetCountpositiv(array));
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
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
double b1 = GetNumber(" b1 = ");
double b2 = GetNumber(" b2 = ");
double k1 = GetNumber(" k1 = ");
double k2 = GetNumber(" k2 = ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"{x}, {y}");
*/
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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


int m =GetNumber("M = ");
int n =GetNumber("N = ");
double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);