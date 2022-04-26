using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Franiek", 19);

            List<Person> people = new List<Person>()
            {
            new Person("Piotr", 45),
            new Person("Zosia", 12),
            new Person("Asia", 22),
            new Person("Darek", 14),
            new Person("Ania", 34)
            };
            people.Add(p1);

            string[] adultsTab = people.Where(p => p.Age > 18).Select(p => $"{p.Name} {p.Age}").ToArray();
         
            Print(adultsTab);

            Console.ReadKey();
        }
        public static void Print<T>(IEnumerable<T> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
