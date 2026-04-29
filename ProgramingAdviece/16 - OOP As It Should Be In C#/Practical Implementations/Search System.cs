using System;
namespace ConsoleApp1
{
        class Person
    {
        public int Id{get;set;}
        public string username{get;set;}    
        public string password{get;set;}
        public string name{get;set;}
        public int age{get;set;}
        

        public Person(int id,string username,string password,string name,int age)
        {
            this.Id=id;
            this.username=username;
            this.password=password;
            this.name=name;
            this.age=age;
        }
        public static Person? Find(int Id,List<Person> list)
        {
            foreach(Person p in list)
            {
                if (p.Id == Id)
                {
                    return p;
                }
            }
                return null;
        }
        public static Person? Find(string username,string passowerd,List<Person> list)
        {
            foreach(Person p in list)
            {
                if (p.password == passowerd && p.username == username)
                {
                    return p;
                }
            }
            return null;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons=new List<Person>();
            persons.Add(new Person(1,"hossam","1234","hossam mohamed",22));
            persons.Add(new Person(2,"ali","1234","ali mohamed",25));

            Person? p=Person.Find(4,persons);
            if (p != null)
            {
            Console.WriteLine($"hello {p.name}, you age {p.age},");
                
            }
            else
            {
                Console.WriteLine("user note exsite");
            }
        }
    }
}