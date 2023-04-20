Console.Write($"Введите элементы массива через пробел: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Введено {array.Length} элементов, элементы длинее 3 символов: [{String.Join(" ", PickElementsWithLenghtUpperThen3(array))}]");

string[] PickElementsWithLenghtUpperThen3(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 3) count++;
    }

    string[] NewArray = new string[count];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}