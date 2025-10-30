namespace Education_Task_6
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        ExampleListDict exampleListDict = new ExampleListDict();
                        exampleListDict.Example();

                        ExampleQueue exampleQueue = new ExampleQueue();
                        exampleQueue.Equals(exampleQueue);

                        ExampleStack exampleStack = new ExampleStack();
                        exampleStack.Example();

                        Console.ReadKey();
                }
        }
}
