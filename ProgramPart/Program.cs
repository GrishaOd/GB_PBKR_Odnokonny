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

string[] FilterArrayByLength(string[] array, int filter_length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= filter_length)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= filter_length)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

Console.Write("Введите количество элементов массива: ");
int len = int.Parse(Console.ReadLine());
string[] first_array = new string[len];
System.Console.WriteLine("Заполняем массив");
FullArray(first_array, len);
System.Console.WriteLine("Массив заполнен");
System.Console.Write("Первоначальный массив: ");
PrintArray(first_array);
System.Console.WriteLine();
System.Console.Write("Итоговый массив: ");
PrintArray(FilterArrayByLength(first_array, 3));