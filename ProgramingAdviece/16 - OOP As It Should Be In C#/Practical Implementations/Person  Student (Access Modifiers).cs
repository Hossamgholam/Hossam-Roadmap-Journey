using System;
using System.Security.Cryptography;

namespace Notes
{
    class Person
    {
        public string name;
        protected string surname;
        private int age;

        public Person()
        {
            name = "hossam";
            surname = "mohamed";
            age = 30;
        }
        public string fullName()
        {
            return surname + " " + name;
        }
        protected void displaySurname()
        {
            Console.WriteLine("Surname: " + surname);
        }
        private void displayAge()
        {
            Console.WriteLine("Age: " + age);
        }
    }
    class Student : Person
    {
        // not accessible because it's private
        public void displayInfo()
        {

            Console.WriteLine("Name: " + name); // accessible because it's public
            Console.WriteLine("Surname: " + surname); // accessible because it's protected
                                                      // Console.WriteLine("Age: " + age); // not accessible because it's private

            displaySurname(); // accessible because it's protected
            // displayAge(); // not accessible because it's private
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.Write(p1.fullName());

            Student s1 = new Student();

            s1.displayInfo();

        }
    }
}