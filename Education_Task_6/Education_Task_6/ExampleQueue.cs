namespace Education_Task_6
{
        class ExampleQueue
        {
                public void Example()
                {
                        /*
                                Реализовать Queue и симулировать обработку задач (например, очередь печати документов).
                         */

                        Queue<string> queue = new Queue<string>();

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
                                                Console.WriteLine($"Печать документа {queue.Dequeue()}");
                                        else
                                                Console.WriteLine("очередь пуста");

                                }
                                else
                                {
                                        queue.Enqueue(input);
                                        Console.WriteLine($"Документ {input} добавлен в очередь");
                                }
                        }
                }
        }
}
