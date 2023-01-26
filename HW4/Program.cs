// See Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 

Console.Write("Введите число ->");
string aStr = Console.ReadLine();
int a = Convert.ToInt32(aStr);
int index = 0;
while(index < (a - 1))
if (index < (a - 1))
{
    index +=2;
    Console.WriteLine(index);
}
else {
Console.WriteLine("THE END!!!");
}


