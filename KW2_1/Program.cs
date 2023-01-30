/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23. 

14 -> нет 
46 -> нет 
161 -> да*/

int Getnumber(string message)
{
Console.Write(message);
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
int number1 = Getnumber("введите первое число :");
if (number1 % 7 == 0 && number1 % 23 == 0) Console.WriteLine($"число {number1} кратно обоим числам");
else Console.WriteLine($"число {number1} не кратно обоим числам");

