/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int Getsum(int num)
{
    int i = 0;
    int sum = 0;
    int numwork = num;
    while (numwork > 0)
        if (numwork > 0)
        {
            sum += numwork % 10;
            numwork = numwork / 10;
            i++;
        }
        else break;
    return sum;
}
int Numb(string msg)
{
    int num = 0;
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out num))
        {
            break;
        }
        else Console.WriteLine("Elese");

    }
    return num;
}

int num = Numb("Число дайте пж -> ");
int size = Getsum(num);

Console.WriteLine(size);