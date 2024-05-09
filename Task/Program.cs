class Program
{
    static string[] FilterStrings(string[] arr)
    {
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

    static void Main()
    {
        int n;
        Console.Write("Введите количество строк: ");
        n = int.Parse(Console.ReadLine()!);

        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку: ");
            arr[i] = Console.ReadLine()!;
        }

        string[] filteredArr = FilterStrings(arr);

        Console.WriteLine("Результат:");
        foreach (string str in filteredArr)
        {
            Console.WriteLine(str);
        }
    }
}
