/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


int Getnumber(string message)
{
Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int number2 = number / 100;
//int result = number1 - (number2 * 10);
return (number1 - (number2 * 10)); 
}
int result = Getnumber("число");
Console.Write($"xbckj {result}");
