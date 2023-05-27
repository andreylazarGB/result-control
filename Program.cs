
//string[] array = { "hello", "2", "world", ":-)" };
string[] array = {"1234", "1567", "-2", "computer science"};
//string[] array = { "Russia", "Denmark", "Kazan"};

string[] GetArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        char[] arr = Array[i].ToCharArray();
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr.Length > 3) Array[i] = "";
        }
    }
    return Array;
}

void PrintArray(string[] array)
{
    Array.Sort(array);
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i]!="")
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

PrintArray(GetArray(array));
