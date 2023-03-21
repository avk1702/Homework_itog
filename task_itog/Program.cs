void SecondArray(string[] array_first, string[] array_second)
{
    int count = 0;
    for (int i = 0; i < array_first.Length; i++)
    {
    if(array_first[i].Length <= 3)
        {
        array_second[count] = array_first[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array_first = new string[6] {"Тобол", "145", "number", "45", "Тверь", "Ок"};
string[] array_second = new string[array_first.Length];
SecondArray(array_first, array_second);
PrintArray(array_second);