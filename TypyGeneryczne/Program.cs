using System.Collections.Generic;

namespace TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurants = new List<Restaurant> 
            { 
                new Restaurant("KFC", "Warszawa"),
                new Restaurant("McDonald", "Warszawa"),
                new Restaurant("Ahmed-Kebab", "Warszawa"),

            };
            var result = new PaginatedResult<Restaurant>();
            result.Results = restaurants;
            
            var users = new List<User>();
        }
    }
    class PaginatedResult<T>
    {
        public List<T> Results { get; set; }
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
    public class User
    {

    }
    public class Restaurant
    {
        public Restaurant(string name, string city)
        {
            Name = name;
            City = city;
        }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
