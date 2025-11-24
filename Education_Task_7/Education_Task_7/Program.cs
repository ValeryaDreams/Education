namespace Education_Task_7
{
        record Person(string name, int age);

        internal class Program
        {
                static void Main(string[] args)
                {
                        //string[] people = { "Zhenya", "ZKraken", "Olaya", "Valerya", "ZIvan" };

                        //var selectedPeople = new List<string>();

                        //foreach (var person in people)
                        //{
                        //        if (person.ToUpper().StartsWith("Z"))
                        //        {
                        //                selectedPeople.Add(person);
                        //        }
                        //}

                        //selectedPeople.Sort();

                        //var selectedPeople = from p in people
                        //                     where p.ToUpper().StartsWith("Z")
                        //                     orderby p
                        //                     select p;

                        //var selectedPeople = people.Where(p => p.ToUpper().StartsWith("Z")).OrderBy(p => p);

                        //foreach (var person in selectedPeople)
                        //{
                        //        Console.WriteLine(person);
                        //}

                        var people = new List<Person>
                        {
                                new Person("Tom", 123 ),
                                new Person("Tom", 123),
                                new Person("Tom", 123)
                        };

                        var names = from p in people
                                    select p.name;

                        foreach (var p in names)
                        {
                                Console.WriteLine(p);
                        }

                        Console.ReadKey();
                }
        }
}
