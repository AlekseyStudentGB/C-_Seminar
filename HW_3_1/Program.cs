/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumber (string message)
{
    int result = 0;
    Console.Write(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result <100000)
        break;

        else Console.WriteLine("ВВЕДИТЕ КОРРЕКТНОЕ ЧИСЛО");


    }
    return result;
}

void YesNo(int number)
{
if (number / 10000 == number % 10 && number / 1000 % 10 == (number / 10) % 10) 
{
    Console.WriteLine("Да!");
}
else Console.WriteLine("Нет!");    
}

int number = GetNumber("Введите число -> ");
YesNo(number);
