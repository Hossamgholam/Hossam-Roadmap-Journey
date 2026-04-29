using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace Name
{
    internal class Program
    {
        class Person
        {
            private string _id;
            private string _name;
            private decimal _salary;
            public Person(string id, string name, decimal salary)
            {
                _id = id;
                _name = name;
                _salary = salary;
            }
            public Person()
            {
                _id = "";
                _name = "";

            }
            public string Id
            {
                get
                {

                    return _id;
                }
                set
                {
                    if (value.Length != 3)
                    {
                        Console.WriteLine("ID must be 3 characters");
                        return;
                    }
                    _id = value;
                }
            }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value.Length < 3)
                    {
                        Console.WriteLine("Name must be at least 3 characters");
                        return;
                    }
                    ChangeNameHistory.Push(value);
                    _name = value;
                }
            }

            public decimal salary
            {
                get
                {
                    return _salary;
                }
            }
            public string? Department
            { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine("                  Employ info              ");
                Console.WriteLine($"Name:{Name} my id {Id} and my salary {salary}");
                Console.WriteLine("___________________________________________________");
            }
            public Stack<string> ChangeNameHistory = new Stack<string>();
        }

        static class Settings
        {
            public static int DayNumber
            {
                get
                {
                    return DateTime.Today.Day;
                }
            }
            public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }
            public static string? ProjectPathe
            {
                get;
                set;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person p1 = new Person("A11", "hossam", 120000000);
            p1.DisplayInfo();

            p1.Name = "Ali";
            p1.DisplayInfo();

            p1.Name = "mahmode";
            p1.DisplayInfo();

            for (int i = 0; i < p1.ChangeNameHistory.Count; i++)
            {
                Console.WriteLine($"change number {i + 1} is {p1.ChangeNameHistory.ElementAt(i)}");

            }

            Console.WriteLine("seting day number:" + Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            Settings.ProjectPathe = @"C:\p\";
            Console.WriteLine(Settings.ProjectPathe);
        }
    }

}