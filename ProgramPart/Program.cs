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