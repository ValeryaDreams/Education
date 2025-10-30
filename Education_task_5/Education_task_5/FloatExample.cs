namespace Education_task_5
{
        internal class FloatExample
        {
                public void Calculation()
                {
                        float f = 10.12f;
                        Console.WriteLine($"Original F = {f}");

                        byte[] bytes = BitConverter.GetBytes(f);
                        Array.Reverse(bytes);

                        //foreach (byte b in bytes)
                        //        Console.WriteLine(b);


                        string bits = string.Join("", Array.ConvertAll(bytes, b => Convert.ToString(b, 2).PadLeft(8, '0')));
                        Console.WriteLine($"Bytes: {bits}");

                        string signBits = bits.Substring(0, 1);
                        string expBits = bits.Substring(1, 8);
                        string mantissaBits = bits.Substring(9);

                        Console.WriteLine($"Sign = {signBits}\n" +
                                $"Exponenta = {expBits}\n" +
                                $"Mantisa = {mantissaBits}");

                        int sign = signBits == "0" ? 1 : -1;
                        // 1 + 8 + 23. 1- sign 8 - exp 23 - mantissa. BIAS = 2^(exp-1)-1. BIAS = 2^(8-1)-1 = 127.
                        int exp = Convert.ToInt32(expBits, 2) - 127;
                        double mantissa = 1.0;

                        for (int i = 0; i < mantissaBits.Length; i++)
                        {
                                if (mantissaBits[i] == '1')
                                {
                                        mantissa += Math.Pow(2, -(i + 1));
                                        //Console.WriteLine($"{i} - {mantissa}");
                                }
                        }

                        double res = sign * mantissa * Math.Pow(2, exp);
                        Console.WriteLine($"Result = {res} REAL Result = {(float)res}");
                }
        }
}
