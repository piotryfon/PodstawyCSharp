using System;

namespace Mapowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person()
            {
                FirstName = "Jan",
                LastName = "Testowy",
                Email = "testowy@wp.pl",
                PersonAddress = new Address()
                {
                    Country = "Polska",
                    City = "Warszawa",
                    Street = "Narwik 17/24",
                    PostCode = "01-470"
                }
            };

            Console.WriteLine($"Person one: {person.FirstName} {person.LastName} - {person.PersonAddress.Country}");

            PersonDto personDto = new PersonDto(person);
            Console.WriteLine($"Person two: {personDto.FirstName} {personDto.LastName} - {personDto.City}");

        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address PersonAddress { get; set; }
    }
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
    class PersonDto
    {
        public PersonDto(Person p)
        {
            FirstName = p.FirstName;
            LastName = p.LastName;
            City = p.PersonAddress.City;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
