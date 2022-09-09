string[] NewStringArrayInput(int length)
{
    string[] newStringArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        newStringArray[i] = Console.ReadLine();
    }
    return newStringArray;
}

void ResizeStringArray(ref string[] stringArray, int newLength)
{
    string[] newStringArray = new string[newLength];
    for (int i = 0; i < stringArray.Length && i < newLength; i++)
    {
        newStringArray[i] = stringArray[i];
    }
    stringArray = newStringArray;
}

string[] NewStringArrayByLength(string[] stringArray, int lengthLimit)
{
    int length = stringArray.Length;
    int newLenght = 0;
    int j = 0;
    string[] newStringArray = new string[newLenght];

    for (int i = 0; i < length; i++)
    {
        if (stringArray[i].Length <= lengthLimit)
        {
            newLenght++;
            ResizeStringArray(ref newStringArray, newLenght);
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}