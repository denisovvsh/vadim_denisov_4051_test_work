Console.Clear();

string[] arrayStrings = CreateArrayStrings();

PrintArray(arrayStrings);

int searchLength = Prompt($"Введите искомую длину строки: ");

string[] result = SearchElemntsByStringLength(arrayStrings, searchLength);

Console.WriteLine($"Массив из эелементов, длинной <= {searchLength}: ");

PrintArray(result);

string[] SearchElemntsByStringLength(string[] arr, int strLength)
{
    string[] newArr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > strLength) continue;
        newArr[count] = arr[i];
        count++;
    }
    Array.Resize(ref newArr, count);
    return newArr;
}

string[] CreateArrayStrings()
{
    Console.Write("Введите элементы массива, через запятую: ");
    string[] arr = Console.ReadLine().Split(',');
    return arr; 
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}