/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int Numb(string msg)
{
int num = 0;
Console.Write(msg);
while(true)
{
if(int.TryParse(Console.ReadLine(), out num))
{
break;
}
else Console.WriteLine("Elese");

}
return num;
}



int a = Numb("A = >");
int b = Numb("B = >");
Console.WriteLine(Math.Pow(a, b));



