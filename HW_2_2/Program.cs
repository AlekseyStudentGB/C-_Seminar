/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 
*/
///// 
int WorkNumber(int number, int countsigns)
{
  int indexWN = countsigns;
  int worknumber = number;
  while (indexWN > 2)
  {
    worknumber = worknumber / 10;
    indexWN --;
  }
return worknumber;
}

int CountNull(int number)
{
  int index = 0;
  while (number > 9) 
  {
    number = number / 10;
    index ++;
  }
  return index;
}

Console.Write("введите чило для работы -> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
int countsigns = CountNull(number);
if (number < 100) Console.WriteLine("У заданного числа нет третьего знака :(");
else
{
 Console.WriteLine(WorkNumber(number, countsigns) % 10);
}


/* Первый вариант
Console.Write("введите чило для работы -> ");
int number = Convert.ToInt32(Console.ReadLine());
int again = 0;
int none = 0;
int number1 = 0;
int searchnumber = 0;
if (number < 0) number = number * -1;
if (number > 99999) again = number;
if (number < 100000 && number > 9999)  number1 = number;
if (number < 10000 && number > 999) number1 = number * 10;
if (number < 1000 && number > 99) number1 = number * 100;
if (number < 100 ) none = number; 

if(again > 0) Console.WriteLine("Ваше число больше допустимого диапазона");
  else
  {
  if(none > 0) Console.WriteLine("у числа нет третьей цифры");
else {searchnumber = number1 / 100 - number1 / 1000 * 10;
Console.WriteLine($"третья цифра числа {number} -> {searchnumber}");
     }
  }
*///////////////////////////////////////////////////////////////

/* Второй вариант
Console.Write("введите чило для работы -> ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number < 0) number = number * -1;
int result = 0;
if (number < 100000) 
{
  if (number < 10000)
  {
      if (number < 1000)
      {
        if (number < 100)
        {
        Console.WriteLine(" aaaaaa");
        
        }
        else 
        {
        result = number - number / 10 * 10;
        Console.WriteLine(result);
        }
      }
      else 
      {
      result = number / 10 - number / 100 * 10;
      Console.WriteLine(result);
      }
  }
  else 
  {
  result = number / 100 - number / 1000 * 10;
  Console.WriteLine(result);
  }
}
else Console.WriteLine("ybpz");
*///////////////////////////////////////////////////////////////////

/* Третий Вариант

int WorkNumber(int number)
{
int numberWork = 0;
if (number < 100000 && number > 9999) numberWork = number;
if (number < 10000 && number > 999) numberWork = number * 10;
if (number < 1000 && number > 99) numberWork = number * 100;
return numberWork;
} 

Console.Write("введите чило для работы -> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
if (number > 99999) Console.Write("Ваше число больше допустимого диапазона");
else
{
   if (number < 100) 
   {
   Console.Write("у числа нет третьей цифры");
   }
   else Console.Write($"третья цифра заданного числа -> {WorkNumber(number) / 100 - WorkNumber(number) /1000 * 10}" ); 
}
*/