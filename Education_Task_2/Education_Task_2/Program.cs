namespace Education_Task_2
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        Console.WriteLine($"GC Total Memory: {GC.GetTotalMemory(false) / 1024.0 / 1024.0:F2} MB");

                        // Выделение памяти в HEAP.
                        // GC учавствует.
                        int[] numsarray = new int[5] { 1, 2, 3, 4, 5 };
                        numsarray[2] = 100;

                        // SPAN - непрерывный участок памяти.
                        // Хранится ТОЛЬКО НА STACK. НЕ МОЖЕТ ХРАНИТСЯ В HEAP.
                        // stackalloc СОЗДАЕТ ПАМЯТЬ НА СТЕКЕ.
                        // Span<int> БЕЗОПАСНО ЕЕ ОБОРАЧИВАЕТ.
                        Span<int> expSpan = stackalloc int[5] { 1, 2, 3, 4, 5 };
                        expSpan[2] = 777;

                        foreach (int i in expSpan)
                                Console.WriteLine($"{i}");

                        // ReadOnlySpan - НЕИЗМЕНЯЕМЫЙ SPAN.
                        ReadOnlySpan<int> sliceSpan = expSpan.Slice(1, 3);
                        foreach (int i in sliceSpan)
                                Console.WriteLine($"{i}");

                        // MEMORY - HEAP-SAFE версия.
                        // Хранится ТОЛЬКО НА HEAP. НЕ МОЖЕТ ХРАНИТСЯ В STACK.
                        Memory<int> expMem = new int[5] { 1, 2, 3, 4, 5 };

                        // From Memory to Span.
                        Span<int> expSpanMem = expMem.Span;

                        // ReadOnlyMemory - НЕИЗМЕНЯЕМЫЙ MEMORY.
                        ReadOnlyMemory<char> text = "hello world".AsMemory();
                        Console.WriteLine(text.Span.Slice(6).ToString());

                        // Examples for SPAN.
                        // Выделили память.
                        int[] eatingKrakenGR =
                        {
                                100, 200, 100, 150, 200, 100, 150,
                                200, 200, 500, 150, 200, 50, 150,
                                100, 200, 100, 150, 200, 100, 150,
                                50, 200, 100, 450, 200, 100, 150,
                                300, 200, 100, 150, 200, 100, 150
                        };

                        int[] firstHalf = new int[10];
                        int[] secondHalf = new int[10];

                        Array.Copy(eatingKrakenGR, 0, firstHalf, 0, 10);        // Выделяем память.
                        Array.Copy(eatingKrakenGR, 11, secondHalf, 0, 10);      // Выделяем память.
                        
                        eatingKrakenGR[1] = 777;
                        foreach (int i in firstHalf)
                        {
                                Console.WriteLine($"ARRAY: {i}"); // firstHalf[1] = 200!
                        }

                        Span<int> eatingKrakenGRSPAN = eatingKrakenGR.AsSpan();
                        Span<int> firstHalfSPAN = eatingKrakenGRSPAN.Slice(0, 10);      // НЕТ выделения памяти.                        
                        Span<int> secondtHalfSPAN = eatingKrakenGRSPAN.Slice(11, 10);   // НЕТ выделения памяти.
                        
                        eatingKrakenGRSPAN[1] = 777;
                        foreach (int i in firstHalfSPAN)
                        {
                                Console.WriteLine($"SPAN: {i}"); // firstHalfSPAN[1] = 777!
                        }


                        Console.ReadLine();
                }
        }
}
