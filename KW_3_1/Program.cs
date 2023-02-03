/*
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result  > 0 && result < 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}
string Getrange(int quarter)
{
    if (quarter == 1)
        return "x от нуля до плюс бесконечности, y от нуля до плюс беспконечности";
        else if (quarter == 2)
        return "x от нуля до минус бесконечности, y от нуля до плюс беспконечности";
         else if (quarter == 3)
        return "x от нуля до минус бесконечности, y от нуля до минус беспконечности";
         else 
        return "x от нуля до плюс бесконечности, y от нуля до минус беспконечности";
}

int number = GetNumber("Введите число четверти");
string range = Getrange(number);
Console.WriteLine(range);
//////////////////////////
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))//23
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

double Distance (int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt (Math.Pow((x1-x2),2) +Math.Pow((y1-y2),2));
    return dist; 
}

int x1 = GetNumber ("Введите значение x1");
int y1 = GetNumber ("Введите значение y1");
int x2 = GetNumber ("Введите значение x2");
int y2 = GetNumber ("Введите значение y2");

double result = Distance(x1, y1, x2, y2);
Console.WriteLine($"расстояние между ними в 2D пространстве {result:0.###}"); */



