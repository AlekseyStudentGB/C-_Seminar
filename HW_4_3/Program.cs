

void GetArray(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 8);
    }
}



int[] array = new int[8];
GetArray(array);
int size = array.Length;
int i = 0;
while (i < size)
{
    if (i < size - 1)
    {
        Console.Write($"{array[i]}, ");
        i++;
    }
    else
    {
        Console.Write(array[i]);
        break;
    }
}
return i;

