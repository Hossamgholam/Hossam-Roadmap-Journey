using System;
namespace ConsoleApp1
{
    internal class Program
    {
        public class ClsPerson
        {
            public virtual  string Print()
            {
                return "my name is person  and iam bas class";
            }
            public string Greeting()
            {
                return "hello person";
            }
        }
        public class ClsEmployee : ClsPerson
        {
            public override  string Print()
            {
                return "my name is employee and i am drived class";
                
            }
            public new string Greeting()
            {
                return "hello employee";
            }
        }
        static void Main(string[] args)
        {
            ClsPerson peson =new ClsPerson();
            ClsEmployee employee=new ClsEmployee();

            Console.WriteLine(peson.Print());
            Console.WriteLine(employee.Print());
            Console.WriteLine(peson.Greeting());
            Console.WriteLine(employee.Greeting());

//upcasting
            ClsPerson pPointer=employee;
            Console.WriteLine(pPointer.Print());
            Console.WriteLine(pPointer.Greeting());//hello person
            /*
            withe virtual and override  he  acte as employee 
            without he he acte as person
            */
            
//dowcasint

           ClsPerson person=new ClsEmployee();
           ClsEmployee empointer=(ClsEmployee)person;
           Console.WriteLine(empointer.Print());
            

            
        }
    
    }
}
