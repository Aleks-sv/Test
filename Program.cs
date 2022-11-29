string[] array = new string[] { "hello", "2", "world", ":-)" };

PrintArray(array);
int countElementArray = FindResultArray(array);
Console.WriteLine($"{countElementArray}");

int FindResultArray(string[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        char[] arrayChar = array[i].ToCharArray();
        if (arrayChar.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
    Console.WriteLine("]");
}