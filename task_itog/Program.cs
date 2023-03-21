void SecondArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
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
string[] arrayFirst = new string[6] {"Тобол", "145", "number", "45", "Тверь", "Ок"};
string[] arraySecond = new string[arrayFirst.Length];
SecondArray(arrayFirst, arraySecond);
PrintArray(arraySecond);