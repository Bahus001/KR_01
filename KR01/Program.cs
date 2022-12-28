string[] FilterArrayString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[k]= array[j];
            k++;
        }
    }
    return newArray;
}

string[] CreateStrArray(int size)
{   string enter = String.Empty;
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        enter = Console.ReadLine()!;
        array[i] = enter;
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i += 1)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array2D = CreateStrArray(sizeArray);
string[] newArrayForFilter = FilterArrayString(array2D);
PrintArray(newArrayForFilter);