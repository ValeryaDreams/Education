namespace Education
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        // Ограничивание значения заданным диапазоном: возвращает min, если value < min.
                        Console.WriteLine("Example Clamp()");
                        Console.WriteLine(Int32.Clamp(30, 20, 50));
                        Console.WriteLine(Int32.Clamp(-10, 20, 50));
                        Console.WriteLine(Int32.Clamp(100, 20, 50));

                        // Умножение без переполнения.
                        Console.WriteLine("\nExample BigMul()");
                        int maxInt = int.MaxValue;
                        Console.WriteLine(maxInt * 2);
                        Console.WriteLine(Int32.BigMul(maxInt, 2));

                        Console.WriteLine("\nExample CopySign()");
                        double original = 765 - 987;
                        double resultABS = double.Abs(original);
                        Console.WriteLine($"original: {original}\t" +
                                $"ABS: {resultABS}\t" +
                                $"res: {double.CopySign(resultABS, original)}");

                        // Аналог checked((int)value), но универсальный, типобезопасный.
                        Console.WriteLine("\nExample CreateChecked()");
                        Console.WriteLine(int.CreateChecked(100));
                        Console.WriteLine(int.CreateChecked(100.923));
                        //Console.WriteLine(int.CreateChecked(9_000_000_000L)); ОШИБКА КОМПИЛЯЦИИ

                        try
                        {
                                int res = int.CreateChecked(9_000_000_000L);
                        }
                        catch (OverflowException)
                        {
                                Console.WriteLine("Error LONG");
                        }

                        try
                        {
                                int res = int.CreateChecked(double.PositiveInfinity);
                        }
                        catch (OverflowException)
                        {
                                Console.WriteLine("Error Infinity");
                        }

                        try
                        {
                                int res = int.CreateChecked(double.NaN);
                        }
                        catch (OverflowException)
                        {
                                Console.WriteLine("Error NAN");
                        }

                        // Преобразует значение с насыщением: при переполнении возвращает MinValue или MaxValue. Без исключений.
                        Console.WriteLine("\nExample CreateSaturating()");
                        long x = 9_000_000_000L;
                        Console.WriteLine(int.CreateSaturating(x));
                        Console.WriteLine(int.CreateSaturating(double.NegativeInfinity));

                        // Преобразует значение в int с усечением.
                        // Аналогично unchecked-приведению, но в универсальной, типобезопасной форме.
                        Console.WriteLine("\nExample CreateTruncating()");
                        
                        int resTruncating = (int)x;
                        Console.WriteLine(resTruncating);
                        // АНАЛОГИЧНО.
                        Console.WriteLine(int.CreateTruncating(x));

                        // Замена / и %. ДЕЛАЕТ ЗА ОДНУ CPU операцию
                        Console.WriteLine("\nExample DivRem()");
                        var resDivRem = int.DivRem(100, 3);
                        Console.WriteLine($"{resDivRem} {resDivRem.Quotient} {resDivRem.Remainder}");

                        Console.ReadKey();
                }
        }
}
