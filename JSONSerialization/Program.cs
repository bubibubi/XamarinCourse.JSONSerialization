using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                Id = 12,
                Name = "Mario Rossi",
                Age = 92
            };

            Person p2 = new Person
            {
                Id = 14,
                Name = "Giorgio Bianchi",
                Age = 87
            };

            List<Person> persons = new List<Person>(new[] { p1, p2 });

            string jsonString = JsonConvert.SerializeObject(persons);


            Console.WriteLine(jsonString);

            Person d = JsonConvert.DeserializeObject<Person>("{\"Id\":12,\"Name\":\"Mario Rossi\",\"Age\":92}");
            Console.WriteLine(d.Id);
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Age);

            Console.ReadLine();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
