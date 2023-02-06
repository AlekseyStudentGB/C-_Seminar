/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
q
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23
*/

int[] Coordinat(string msg)
{
    int[] array = new int[3];
    Console.WriteLine(msg);

    int i = 0;
    while (true)
    {
        Console.Write("x-> ");
        if (int.TryParse(Console.ReadLine(), out array[0]) && i < array.Length)
        {
            i++;
            Console.Write("y-> ");
            if (int.TryParse(Console.ReadLine(), out array[1]) && i < 3) i++;
            Console.Write("z-> ");
            if (int.TryParse(Console.ReadLine(), out array[2]) && i < 3) i++;
            break;
        }
        else
        {
            Console.WriteLine("не верное число");
        }
    }
    return array;
}

double Distance(int[] array1, int[] array2)
{
    double res = 0;
    
res = Math.Sqrt(Math.Pow((array2[0]-array1[0]),2)+Math.Pow((array2[1]-array1[1]),2) + Math.Pow((array2[2]-array1[2]),2));
return res;

}



int[] array1 = Coordinat("Первая Точка");
int[] array2 = Coordinat("Вторая точка");
Console.WriteLine($"{Distance( array1, array2):0.##}");