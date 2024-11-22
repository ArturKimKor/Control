{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:" );
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        string[] resultArray = GetShortStrings(inputArray);
        Console.WriteLine($"Результат: [{string.Join(", ", resultArray)}]");
    }
    static string[] GetShortStrings(string[] array)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Trim().Length <= 3)
                count++;
        }

