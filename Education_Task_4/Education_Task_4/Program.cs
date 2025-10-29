using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Education_Task_4
{
        class Program
        {
                static void Main(string[] args)
                {
                        // Фиксированный размер.
                        // O(1) - доступ по индексу.
                        // O(n) - поиск, вставка, удаление.
                        // ИСПОЛЬЗОВАТЬ: РАЗМЕР ИЗВЕСТЕН ЗАРАНЕЕ И РЕДКО МЕНЯЕТСЯ.
                        int[] array = { 31, 21, 3, 14, 5, 26, 17 };

                        // ICollection IEnumerable Ilist
                        List<int> list = new List<int> { 1 };
                        // По умолчанию 0. Если хоть один элемент, то 4.
                        Console.WriteLine(list.Capacity); // 4

                        // ICollection IDictionary IEnumerable
                        Dictionary<int,string> keyValuePairs = new Dictionary<int,string>()
                        {
                                [1] = "one",
                                [2] = "two"
                        };

                        // ICollection IEnumerable
                        Queue<int> queue = new Queue<int>();

                        // ICollection IEnumerable
                        Stack<int> stack = new Stack<int>();

                        // IComparer ICollection IDictionary
                        SortedList<int, string> keyValuePairs1 = new SortedList<int, string>();

                        NameValueCollection keyValuePairs2 = new NameValueCollection
                        {
                                { "key1", "value1" },
                                { "key2", "value2" },
                                { "key1", "value3" }
                        };

                        Console.WriteLine(keyValuePairs2.Count);        // 2
                        Console.WriteLine(keyValuePairs2["key1"]);      //value1, value3

                        Console.ReadKey();
                }
        }
}