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


string yesNo = string.Empty;
Console.Write("Вводим массив с клавиатуры? yes/no: ");
yesNo = Console.ReadLine();

if (yesNo.ToLower() == "yes")
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = NewStringArrayInput(size);
    Console.WriteLine('[' + string.Join(", ", array) + ']');

    Console.WriteLine("Максимум символов в элементе нового массива?: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] newArray = NewStringArrayByLength(array, length);
    Console.WriteLine('[' + string.Join(", ", newArray) + ']');
}

else
{
    string[] defaultStringArray = { "hello", "2", "world", ":-)" };
    Console.WriteLine('[' + string.Join(", ", defaultStringArray) + ']');

    Console.WriteLine("Максимум символов в элементе нового массива?: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] newArray = NewStringArrayByLength(defaultStringArray, length);
    Console.WriteLine('[' + string.Join(", ", newArray) + ']');
}