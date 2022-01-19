using System;

namespace Code_KY_SP22
{
    class Program
    {


        static void Main(string[] args)
        {
            Emailable emailable = new Emailable() { Email = "fake@fake.com" };

            IPerson person1 = new Person() { };

            Console.WriteLine(person1.Id);

            IPerson person2 = new Employee()
            {
                FirstName = "John",
                LastName = "Wick"
            };
            static void PrintName(IPerson person)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");



            }

        }
    }

    public class Person : IPerson, IEmailable
    {
        public Person()
        {
        }

        public Person(IEmailable emailable) { Email = emailable.Email; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }






        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string id, string email, string firstName = "", string lastName = "")
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(Employee emp) { Id = emp.Id; FirstName = emp.FirstName; }

        public string Id { get; set; }
        public DateTime BirthDay { get; set; }
    }

    public class Employee : IPerson, IEmailable
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public long Salary { get; set; }
    }

   public class Emailable : IEmailable
    {
        public string Email { get; set; }
    }


   public interface IPerson
    {
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime BirthDay { get; set; }
    }
   public interface IEmailable
    {
        string Email { get; set; }
    }
}





