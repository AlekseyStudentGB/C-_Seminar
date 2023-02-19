/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

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
