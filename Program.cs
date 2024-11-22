{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:" );
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');
        string[] resultArray = GetShortStrings(inputArray);
        Console.WriteLine($"Результат: [{string.Join(", ", resultArray)}]");
    }