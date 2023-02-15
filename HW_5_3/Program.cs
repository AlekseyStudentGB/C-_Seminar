/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


void GetArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.WriteLine(array[i]);
    }

}

(int, int) GetMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return (max, min);
}


int[] array = new int[4];
GetArray(array);
(int max, int min) = GetMaxMin(array);
Console.WriteLine($"Max({max}) - Min({min}) = {max-min}");