using System;
using System.Security.Cryptography;

namespace Notes
{
    class Ticket
    {
        public static  int id=0;
        public static int counter = 0;
        public string? name;
        public string? from;
        public string? to;
        public int price=100;
        
        public Ticket(string? name, string? from, string? to, int price=100)
        {
            Ticket.id++;
            this.name = name;
            this.from = from;
            this.to = to;
            this.price = price;
            Ticket.counter++; // increment the counter for each new ticket created
        }
        public void displayInfo()

        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("From: " +this. from);
            Console.WriteLine("To: " +this. to);
            Console.WriteLine("Price: " + price);
        }
        public static void ReadInfo(ref string? name, ref string? from, ref string? to)
        {

           
                
            Console.WriteLine("Enter Name:");
            name =Console.ReadLine();
            
            Console.WriteLine("Enter From:");
            from = Console.ReadLine();
            Console.WriteLine("Enter To:");
            to = Console.ReadLine();
           
        }
        public static void displayCounter()
        {
            Console.WriteLine("Total Tickets Booked: " + counter);
        }
    }
   
     class Program
    {
        static void Main(string[] args)
        {
            char answer;
            do
            {
                
                string? name="" ,from="",to="";
                Ticket.ReadInfo( ref name,  ref from,  ref to);
                Ticket t1 = new Ticket(name, from, to);
                Console.WriteLine("_________________________________________________________");
                t1.displayInfo();
                Console.WriteLine("_________________________________________________________");
                Ticket.displayCounter();

                Console.WriteLine("do you want to book another ticket? (y/n)");
                answer = char.TryParse(Console.ReadLine(), out answer) ? answer : 'n';
            }while (answer == 'y' || answer == 'Y');


        }
    }
}