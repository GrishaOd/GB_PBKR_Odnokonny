string[] FullArray (string[] array, int arlength)
{
for (int i = 0; i < arlength; i++)
{
    Console.Write($"Введите {i+1}ый элемент массива: ");
    array[i] = Console.ReadLine();
}
return array;
}