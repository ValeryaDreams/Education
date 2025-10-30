namespace Education_task_5
{
        internal class DoubleExample
        {
                public void Calculation()
                {
                        double d = 10.12;
                        Console.WriteLine($"Original D = {d}");

                        byte[] bytes = BitConverter.GetBytes(d);
                        Array.Reverse(bytes);

                        //foreach (byte b in bytes)
                        //        Console.WriteLine(b);


                        string bits = string.Join("", Array.ConvertAll(bytes, b => Convert.ToString(b, 2).PadLeft(8, '0')));
                        Console.WriteLine($"Bytes: {bits}");

                        string signBits = bits.Substring(0, 1);
                        string expBits = bits.Substring(1, 11);
                        string mantissaBits = bits.Substring(12);

                        Console.WriteLine($"Sign = {signBits}\n" +
                                $"Exponenta = {expBits}\n" +
                                $"Mantisa = {mantissaBits}");

                        int sign = signBits == "0" ? 1 : -1;
                        // 1 + 11 + 52. 1- sign 11 - exp 52 - mantissa. BIAS = 2^(exp-1)-1. BIAS = 2^(11-1)-1 = 1023.
                        int exp = Convert.ToInt32(expBits, 2) - 1023;
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
