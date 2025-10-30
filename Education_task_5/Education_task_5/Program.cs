namespace Education_task_5
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        FloatExample example1 = new FloatExample();
                        example1.Calculation();

                        Console.WriteLine("\n");

                        DoubleExample example2 = new DoubleExample();
                        example2.Calculation();

                        Console.ReadKey();

                }
        }
}
