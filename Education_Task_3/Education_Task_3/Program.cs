using System.Xml;

namespace Education_Task_3
{
        class Person
        {
                public string Name { get; set; }
                public int Age { get; set; }
        }

        internal class Program
        {
                static void Main(string[] args)
                {                        
                        Person p = new Person { Name = "Ivan", Age = 10 };
                        Console.WriteLine($"Name: {p.Name} Age: {p.Age}");

                        ChangePerson(p);
                        Console.WriteLine($"Name: {p.Name} Age: {p.Age}");

                        ChangePerson(ref p);
                        Console.WriteLine($"Name: {p.Name} Age: {p.Age}");

                        string text = "Hello";
                        ChangeStr(text); 
                        Console.WriteLine($"Change Text{text}");

                        ChangeStr(ref text);
                        Console.WriteLine($"Change Text{text}");

                        Console.ReadKey();
                }

                static void ChangePerson(Person p)
                {
                        p = new Person { Name = "No Name" };
                }

                static void ChangePerson(ref Person p)
                {
                        p = new Person { Name = "No Name" };
                }

                static void ChangeStr(string newText)           // Link Copy.
                {
                        newText += "!";
                }

                static void ChangeStr(ref string newText)       // Original Link.
                {
                        newText += "!";
                }
        }
}
