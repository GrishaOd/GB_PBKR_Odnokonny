string[] FullArray (string[] array, int arlength)
{
for (int i = 0; i < arlength; i++)
{
    Console.Write($"Введите {i+1}ый элемент массива: ");
    array[i] = Console.ReadLine();
}
return array;
}

string[] PrintArray (string[] array)
{
for(int i = 0; i < array.Length; i++)
{
    
    Console.Write($"{array[i]} ");
}
return array;
}

string[] FilterArrayByLength(string[] array, int length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.length; i++)
    {
        if (array[i].Length <= length)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}