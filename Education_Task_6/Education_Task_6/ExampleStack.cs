namespace Education_Task_6
{
        internal class ExampleStack
        {
                public void Example()
                {
                        /*
                                Реализовать Stack и симулировать обработку задач (например, очередь печати документов).
                         */

                        Stack<string> queue = new Stack<string>();

                        while (true)
                        {
                                Console.WriteLine("Введите название документа для печати" +
                                        "\nprint - печать следующий документ" +
                                        "\nexit - Выйти\n");
                                string input = Console.ReadLine();
                                input = input.ToLower();

                                if (input == "exit")
                                        break;
                                if (input == "print")
                                {
                                        if (queue.Count > 0)
                                                Console.WriteLine($"Печать документа {queue.Pop()}");
                                        else
                                                Console.WriteLine("очередь пуста");

                                }
                                else
                                {
                                        queue.Push(input);
                                        Console.WriteLine($"Документ {input} добавлен в очередь");
                                }
                        }
                }
        }
}
