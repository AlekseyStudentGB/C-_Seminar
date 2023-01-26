// See https://aka.ms/new-console-template for more information
Console.Write("Введите чило а : ");
string  aStr = Console.ReadLine();
int a = Convert.ToInt32(aStr);

Console.Write("Введите чило b : ");
string bStr = Console.ReadLine();
int b = Convert.ToInt32(bStr);

int max = 0;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.WriteLine(max);