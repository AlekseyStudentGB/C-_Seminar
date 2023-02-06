/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Number(string msg)
{
int n = 0;
Console.WriteLine(msg);
while(true)
{
    if(int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
    break;
    }
    else Console.WriteLine("-----");      
}
return n; 
}

void GetArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = i + 1;  
}


}

void PrintT(int[] array)
{ 
int result = 0;

for(int i = 0; i < array.Length; i++)
{
    result =Convert.ToInt32(Math.Pow(array[i],3));
    Console.WriteLine($"{array[i]} в степени 3 -> {result}");
}



}

int n = Number("введите число");
int[] array = new int [n];
GetArray(array);
PrintT(array);
