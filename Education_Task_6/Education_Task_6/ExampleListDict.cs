namespace Education_Task_6
{
        class ExampleListDict
        {
                public void Example()
                {
                        /*
                                Создать консольное приложение, где пользователь вводит числа, сохраняет их в List и Dictionary, 
                                выводит отсортированный список и подсчитывает количество уникальных элементов.
                         */
                        List<int> list = new List<int>();
                        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

                        Console.WriteLine("введите числа через пробел");
                        string input = Console.ReadLine();

                        string[] inputs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in inputs)
                        {
                                if (int.TryParse(item, out int number))
                                {
                                        list.Add(number);

                                        if (keyValuePairs.ContainsKey(number))
                                        {
                                                keyValuePairs[number]++;
                                        }
                                        else
                                        {
                                                keyValuePairs[number] = 1;
                                        }
                                }
                                else
                                {
                                        Console.WriteLine("Not a Number");
                                }
                        }

                        list.Sort();

                        Console.WriteLine("Array after sorts");
                        foreach (var item in list)
                        {
                                Console.Write(item + "\t");
                        }

                        int uniq = keyValuePairs.Count;
                        Console.WriteLine($"\nCount of uniq: {uniq}");

                        Console.WriteLine("Dictionary");
                        foreach (var item in keyValuePairs)
                        {
                                Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                }
        }
}
