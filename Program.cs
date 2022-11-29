string[] array = new string[] { "hello", "2", "world", ":-)" };

PrintArray(array);
string[] findArray = FindResultArray(array);
PrintArray(findArray);

string[] FindResultArray(string[] array)
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
    string[] resultArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        char[] arrayChar = array[i].ToCharArray();
        if (arrayChar.Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
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