
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
    }
        string[] result = new string[count];
        int index = 0;
            // Заполняем новый массив строками длиной ≤ 3
        foreach (string str in array)
        {
            if (str.Trim().Length <= 3)
            {
                result[index] = str.Trim();
                index++;
            }
        }

        return result;
    }




