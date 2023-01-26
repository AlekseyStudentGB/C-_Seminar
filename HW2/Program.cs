// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


int [] num;
num = new int[3];

Console.Write("Введите первое чило : ");
string aStr = Console.ReadLine();
int a = Convert.ToInt32(aStr);
num[0] = a;

Console.Write("Введите второе чило : ");
string bStr = Console.ReadLine();
int b = Convert.ToInt32(bStr);
num[1] = b;

Console.Write("Введите третье чило : ");
string cStr = Console.ReadLine();
int c = Convert.ToInt32(cStr);
num[2] = c;


int index = 0;
int size = 3;
int max = num[0];

while(index < size) 
{
    if (num[index] > max) 
 {
      max = num[index];
    index = index + 1;
   }
   
    else
   {
     index = index + 1; 
    }   
}


Console.WriteLine($"Из представленных максимальным  чилом является : {max}");