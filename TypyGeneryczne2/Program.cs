using System;
using System.Collections.Generic;
using System.Linq;

namespace TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Repository<User> userRepo = new Repository<User>();
            userRepo.AddElement(new User { Id = 1, Email = "test.wp.pl", Name = "Jan Testowy" });
            var firstElementInUserRepo = userRepo.GetElement(0);
            Console.WriteLine($"Id: {firstElementInUserRepo.Id}, Name: {firstElementInUserRepo.Name}, Email: {firstElementInUserRepo.Email}");
            var elementById = userRepo.GetElementById(1);
            Console.WriteLine($"Element by id {elementById.Id}, Name: {elementById.Name}, Email: {elementById.Email}");


            Repository<string, User> userRepository = new Repository<string, User>();
            userRepository.AddElement("pierwszy", new User { Email = "email.onet.pl", Name = "Bill" });
            User firstElementInUserRepoDic = userRepository.GetElement("pierwszy");
            Console.WriteLine($"Name: {firstElementInUserRepoDic.Name}, Email: {firstElementInUserRepoDic.Email}");

            int[] intArray = new int[] {1,2,3};
            Utils.Swap<int>(ref intArray[0], ref intArray[2]);
            Console.WriteLine(string.Join(", ", intArray));
        }
    }
    class Repository<T> where T : IEntity, new()
    {
        private List<T> data = new List<T>();

        public void AddElement(T element)
        {
            var newElement = new T();
            newElement.Id = 3;

            data.Add(element);
        }
        public T GetElementById(int id)
        {
            var element = data.FirstOrDefault(e => e.Id == id);
            return element;
        }
        public T GetElement(int index)
        {
            if (index < data.Count)
            {
                return data[index];
            }
            else
            {
                return default;
            }
        }
    }
    class Repository<TKey, TValue>
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();
        public void AddElement(TKey key, TValue element)
        {
            data.Add(key, element);
        }
        public TValue GetElement(TKey key)
        {
            if (data.TryGetValue(key, out TValue result))
            {
                return result;
            }
            else
            {
                return default;
            }
        }
    }
    class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public interface IEntity
    {
        public int Id { get; set; }
    }
    class Utils
    {
        public static void Swap<T>(ref T first, ref T secound)
        {
            T temp = first;
            first = secound;
            secound = temp;
        }
    }
}
