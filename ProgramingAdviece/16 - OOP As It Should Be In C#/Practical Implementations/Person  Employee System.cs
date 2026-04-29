using System;
namespace ConsoleApp1
{
    internal class Program
    {
        public class ClsPerson{
            public int Id{get; set;}
            public string FristName{get; set;}
            public string LastName{get; set;}
            public string  Title{get; set;}

            public ClsPerson(int id,string fristname,string lastname,string Title)
            {
                this.Id=id;
                this .FristName=fristname;
                this.LastName=lastname;
                this.Title=Title;
            }
            public string Greeting()
            {
                return $"hello {Title} {FristName}";
            }
            public string Fullname()
            {
                return FristName+" "+ LastName;
            }
        }
        public class ClsEmployee:ClsPerson
        {
            public float Salary{get; set;}
            public string Department{get; set;}
            public string company{get; set;}
            public ClsEmployee(int id,string fristname,string lastname,string Title,float salary,string department,string company="IT company")
            : base(id, fristname, lastname, Title)
            {
                this.Salary=salary;
                this.Department=department;
                this.company=company;
            }
            public string work()
            {
                return $"hello {Fullname()} you work in {company} in {Department} department";
            }
            public void AddBounus(float bonus)
            {
                Salary+=bonus;
            }
        }
        static void Main(string[] args)
        {
            ClsPerson p1=new ClsPerson(1,"hossam","mohamed","mr");
            Console.WriteLine($"hello {p1.Fullname()}");

            ClsEmployee e1=new ClsEmployee(2,"ali","mohamed","mr",120000000,"IT");
            Console.WriteLine($"hello {e1.Fullname()} your salary is {e1.Salary} in {e1.Department} department");
            e1.AddBounus(10000000); 
            Console.WriteLine($"hello {e1.Fullname()} your salary is {e1.Salary} in {e1.Department} department");


            /////////upcasting /////////
            ClsEmployee employee1=new ClsEmployee(3,"ahmed","mohamed","mr",120000000,"IT");
            ClsPerson person1=employee1;

            Console.WriteLine(employee1.work());

            //person point to employee but access only what is in person
             //Console.WriteLine(person1.work());


            ///downcasting/////////////
            ClsPerson p2=new ClsEmployee(5,"mohamed","ali","mr",120000000,"IT");
            ClsEmployee e2=(ClsEmployee) p2;

            //p2 is person so it can not work()
            //Console.WriteLine(p2.work());

            //e2 is employee so can access work() and greet()
            Console.WriteLine(e2.Greeting());
            Console.WriteLine(e2.work());
       



            ClsPerson p3 =new ClsPerson(4,"mohamed","ali","mr");
            //run time error and don give output
            //ClsEmployee em=(ClsEmployee)p;
           // Console.WriteLine(em.work());
        }
    }
}