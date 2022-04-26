using System;

namespace NullCoalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = null;
            (person ??= new Person { Name = "John", LastName = "Smith" })?.PrintFullName();

            string str = null;
            string someValue = str ?? "Default value";
            Console.WriteLine(someValue?.ToUpper()); // DEFAULT VALUE
            string someValue2 = str ??= someValue;
            Console.WriteLine(someValue2); // Default value
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"Name: {Name}, LastName: {LastName}");
        }
    }
}
