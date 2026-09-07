using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;


namespace DataSturctureLevel2
{
    internal class Program
    {
        enum EnPersmission:int
        {
           Read=0,
            Write=1,
            Delete = 2,
            update = 3,
            print = 4,
            Export = 5,
            import = 6,
            admin = 7
            
        }
        static void Main(string[] args)
        {
            #region linq
            /*
             * #################### LINQ Functions Learned ####################

                Filtering:
                    Where()
                
                Projection:
                    Select()
                
                Sorting:
                    OrderBy()
                    OrderByDescending()
                
                Grouping:
                    GroupBy()
                
                Existence:
                    Any()
                
                Finding:
                    FirstOrDefault()
                
                Aggregation:
                    Sum()
                    Average()
                    Max()
                    Min()
                
                Set Operations:
                    Union()
                    Intersect()
                    Except()

               Joining and Projection
                   Join()
            */
            #endregion

            #region quick Review
            /*
             * program = agortim(steps) + Ds
             
             * what is Data structure? 
               -is way of organizing data in memory


             * diffrences between DS and DB?
              -mange data in ram for fast and reduce complexitites of program use program languge
              -mange date in desk storge large date permantl 

             *what are the classificatioin of Ds
               -primitive  build into languge
               -non primitive 
                 -linear 
                   -static array 
                   -non static  stack queu linkedlist
                 -non linear tree grap
             
             * */
            #endregion

            #region lesson 2 Boxing and unboxing
            /*
             * boxing
               -is process of convert value type(int,float..) in stack
                to reference type(object) in heap
               -affect on performance 
             *unboxing 
               -is reverse process of boxing where value type extract from object
             * */
            /*
             var     compily time     should assing value no change
             object  compily time     need to casting
             dynamcy run time         not need casting
             */

            #region code
            //int value = 10;
            //object valueObject = value;

            //Console.WriteLine(valueObject);
            //Console.WriteLine(value);

            //Console.WriteLine((int)valueObject+10);
            #endregion

            #endregion

            #region lesson 3 intro to collections
            /*
             * what is collection ?
               -are data structure uset to store and mange data
               -common operation(adding removing ,modifiying ,sorting ,searching, 
               -common collection in C#
                .list .sortedlist .arraylist .linkedlist .dictionary .concurrentDictionary
                 .hastable .hashset .stack .queue .ovservablecollection .bitarray
            
             *Generic Vs non-Generic
               -generic 
                 .are part of system.collection.generic namespact 
                 .the allow you to specify the type of objecs they store list<int> so it:
                   1.type safety 
                   2.performance
                   3.reduce memory overhead
                   4 code reusability
                    becuse  no boxing or unboxing is needed for value types.  so no runtime error
              -non genric
                  . part of system.collection
             
             */



            #endregion

            //no automatically Sorted so (slower for search fater for addition


            /*
             * Array = fixed-size same-type collection.
               List<T> = dynamic, type-safe(same-type) collection.
               ArrayList = dynamic, non-generic collection that can hold different types.
             */

            #region lesson 4 list
            /*
             * what are list?
               -generic collection   -dynamic sizing   -zero based index  -strongly typed
             *linq 
               -feature in .NET  provides convenient and efficient way to query and manipulate data collection
             
             *count vs  capacity 
              -Count = actual elements
              -Capacity = allocated storage

             *adding
              -Add()      insert()    insertRange
             
             *removing
              -remove()   removeAt()  removeAll()    clear()

             *Looping
              -for        foreach     list.forEach  [is just a local copy.)
           
             * Linq Riltering 
              - where  always returns IEnumerable<T> use var

             *sorting 
              -sort()change original lsit     reverse()    orderBy() return new sequenc use var     orderbyDescending()

             *Contains vs Exists vs Any
              -exists  witl list
              -any     with  ienumerable

             */



            #region Code Of List

            //*working with list
            //List<int> number=new List<int>();   
            //number.Add(10);
            //number.Add(20);
            //number.Add(30);
            //number.Add(40);

            //Console.WriteLine($"count of element in the list: {number.Count}");

            //Console.WriteLine("the element of index 0: "+ number[0]);
            //Console.WriteLine("the element of index 1: "+ number[1]);

            //Console.WriteLine("++++++++++++++++++ change value +++++++++++++++++++++++");
            //number[0]=500;
            //Console.WriteLine("the element of index 0 "+ number[0]);






            //################inserting Element into  list##########################
            ////initialization
            //List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            ////insert at end
            //number.Add(11);

            //Console.WriteLine($"the insert at end of list:{string.Join(",", number)}");

            ////insert at specific index
            //number.Insert(7, 8);
            //Console.WriteLine($"the insert at specific index:{string.Join(",", number)}");

            ////insert list insid list 
            //number.InsertRange(8, new List<int> { 9, 10 });
            //Console.WriteLine($"the insert range :{string.Join(",", number)}");





            //################remove Items From List##########################

            // -remove by valu       -remove by index   -remove multiple items     -clear list


            //List<int> number = new List<int> { 0,1,1, 2, 3, 4, 5,5, 6, 7, 8, 9,9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

            //number.Remove(5);
            //number.Remove(9);
            //Console.WriteLine($"the list After remove specific Number:{string.Join(", ", number)}");

            //number.RemoveAt(0);
            //number.RemoveAt(1);
            //Console.WriteLine($"the list After remove specific number by index:{string.Join(",", number)}");

            //number.RemoveAll(N => N%2==0);
            //Console.WriteLine($"the list after remove all even number:{string.Join(", ", number)}");
            //number.RemoveAll(n=>n%3==0);
            //Console.WriteLine($"the list after remove all number that divid by 3:{string.Join(",", number)}");

            //number.Clear();
            //Console.WriteLine($"the list After clear all number:{number.Count}");





            //################loop through list##########################

            //List<int> number = new List<int>
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            ////print all number using for loop 
            //Console.WriteLine("print all number using for loop ");
            //for (int i = 0; i<number.Count; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            ////print all number using forEach loop 
            //Console.WriteLine("//print all number using forEach loop ");
            //foreach (int n in number)
            //{
            //    Console.WriteLine(n);

            //}

            ////print all number using list.forEach
            //Console.WriteLine("print all number using list.forEach");
            //number.ForEach(n=>Console.WriteLine(n));

            ////it is copy
            //number.ForEach(n => n++);
            //Console.WriteLine("print all number after increment by 1:");
            //number.ForEach(n => Console.WriteLine(n));





            //################  aggregating data using linq  ##########################
            //List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////sum
            //Console.WriteLine($"the sum of number of list: {number.Sum()} ");

            ////average 
            //Console.WriteLine($"the average of number of list: {number.Average()}");

            ////min
            //Console.WriteLine($"the min number in list is :{number.Min()}");

            ////max
            //Console.WriteLine($"the max number in list is:{number.Max()}");

            ////count
            //Console.WriteLine($"the number of number in list:{number.Count}");




            //################  aggregating data using linq  ##########################
            //List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////filtering Even Numbe
            //Console.WriteLine($"Filtering Even number:{string.Join(",", number.Where(n => n%2==0))}");
            ////Filtering Odd Number
            //Console.WriteLine($"Filtering Odd Number:{string.Join(", ", number.Where(n=>n%2!=0))}");
            ////Numbers Greater Than A certain value
            //Console.WriteLine($"Filtering Numbers Greater Than A certain value:{string.Join(", ", number.Where(n =>n>5))}");
            ////Filtering Based on Position
            //Console.WriteLine($"Filtering Based on Position:{string.Join(", ", number.Where((n,indexer) => indexer%2==0))}");
            ////Filtering withe Compound Conditions
            //Console.WriteLine($"Filtering withe Compound Conditions:{string.Join(", ", number.Where(n => n>3 && n<5))}");//###################### LINQ Where() Practice Questions ######################




            //################  Sorting a list Using Various method  ##########################
            //List<int> numbers = new List<int> { 5, 12, 7, 200, -6, 155, 8, 255, 10, 1 };

            ////sort asc
            //numbers.Sort();
            //Console.WriteLine($"sorting Ascending:{string.Join(",", numbers)}");
            ////sort des
            //numbers.Reverse();
            //Console.WriteLine($"sorting descinding:{string.Join(",", numbers)}");
            ////sort by linq
            //Console.WriteLine($"sorting Ascending by linq:{string.Join(",", numbers.OrderBy(n=>n))}");
            //Console.WriteLine($"sorting Ascending by linq:{string.Join(",", numbers.OrderByDescending(n => n))}");




            //################  Contains Exsit Any Find FindAll  #############################
            //List<int> numbers = new List<int> { 5, 12, 7, 200, -6, 155, 8, 255, 10, 1 };

            //Console.WriteLine("is lis contain number 9:"+numbers.Contains(9));
            //Console.WriteLine($"is list has number>0:{numbers.Exists(n => n>0)}");
            //Console.WriteLine($"is list has number<0:{numbers.Any(n => n<0)}");


            //Console.WriteLine($"find all even number:{string.Join(",",numbers.FindAll(n => n%2==0))}");


            //################  Working with alist of Custome object  #############################

            //List<Person> people = new List<Person>
            // {
            //     new Person("Hossam",21),
            //     new Person("Ahmed",25),
            //     new Person("Ali",30),
            //     new Person("Mohamed",28),
            //     new Person("Omar",35),
            //     new Person("Sara",22),
            //     new Person("Mona",27),
            //     new Person("Nour",24),


            // };

            //Console.WriteLine("the list of people:");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
            //}

            //Person person1 = people.Find(p => p.Name=="Hossam");
            //if (person1 == null)
            //{
            //    Console.WriteLine("\nPerson not found:");
            //}
            //else
            //{
            //    Console.WriteLine($"\nperson withe name {person1.Name} and his age is {person1.Age} is found  ");
            //}

            //Person person2 = people.FirstOrDefault(p => p.Name=="Ali");
            //if (person2 == null)
            //{
            //    Console.WriteLine("\nPerson not found:");
            //}
            //else
            //{
            //    Console.WriteLine($"\nperson withe name {person2.Name} and his age is {person2.Age} is found  ");
            //}

            //List<Person> PeopleOfAgeLess30 = people.FindAll(p => p.Age<30);
            //Console.WriteLine("\nthe list of people age less 30:");
            //foreach (Person person in PeopleOfAgeLess30)
            //{
            //    Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
            //}


            //Console.WriteLine($" there is person with name : Ahmed:{people.Any(p => p.Name=="Ahmed")}");
            //Console.WriteLine($" there is person with age > 40:{people.Exists(p => p.Age>40)}");

            //people.RemoveAll(p => p.Age<30);
            //Console.WriteLine("\nthe list of people:");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
            //}



            //List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            //int[]array=number.ToArray();

            //Console.WriteLine($"the lis after conver to Arra:{array}: {string.Join(",",array)}");

            //int[] arrayOfElement = new int[4] { 1, 23, 4, 3 };
            //List<int>list=arrayOfElement.ToList();
            //Console.WriteLine($"the lis after conver to Arra:{list}: {string.Join(",", list)}");


            #endregion
            #endregion



            /*
             * I need:

                      Key → Value, maximum average lookup speed, sorting doesn't matter.
                      Dictionary<TKey,TValue>

                      I need:
                      Key → Value + sorted keys + frequent insertion/removal.
                      SortedDictionary<TKey,TValue>


                      I need:
                      Key → Value + sorted keys + index access + memory efficiency.
                      SortedList<TKey,TValue>
                      
                      But remember that insertion/removal can be expensive.
             * */

            //key value not sorted
            #region Lesson 6  Dictionary
            #region Lesson 5 HashTable
            /*
            ==================== Hashtable ====================

                     - Non-generic collection
                     - Namespace: System.Collections
                     - Stores data as Key → Value
                     - Key must be unique
                     - No guaranteed order
                     - Fast lookup: O(1) average
                     - Uses a hash function

                     Think:

                     Key
                     ↓
                     Hash Function
                     ↓
                     Bucket
                     ↓
                     Value
            */

            #region Code
            //Hashtable Table =new Hashtable();
            //Table.Add("Hossam", 22);
            //Table.Add("Ahmed", 22);
            //Table.Add("ali",23);
            //Table.Add("Emain", 27);
            //Table.Add("Salah", 35);
            //Table.Add("mohamed", 40);

            //Console.WriteLine($"my name is :hossam and my Age is:{Table["Hossam"]}");


            //foreach (DictionaryEntry item in Table)
            //{
            //    Console.WriteLine($"my name is :{item.Key} and my Age is {item.Value}");
            //}
            #endregion


            #endregion
            /*
            ==================== Dictionary ====================

                     -generic collection
                     - Namespace: System.Collections.Generic

                     - Stores data as Key → Value
                     - Key must be unique
                     - No guaranteed order
                     - Fast lookup: O(1) average
                     - Uses a hash function


                      ==================== Dictionary vs hashTable ====================

                        1- type safety    dictionary
                        2- performance    dictionary
                        3- thread safety hashtable
                        
            */
            #region Code
            ////working with dictionary

            //Dictionary<string,int> Fruit=new Dictionary<string,int>();
            //Fruit.Add("Appl", 10);
            //Fruit.Add("Orange", 23);
            //Fruit.Add("Banana", 5);
            //Fruit.Add("waterMeloin", 21);
            //Fruit.Add("Mango", 3);
            //Fruit.Add("mango", 3);

            ////I Do not ned to make unboxing
            //int ApplQuintity = Fruit["Appl"];
            //Console.WriteLine($"The number of appl is {ApplQuintity}");

            //if (Fruit.ContainsKey("mango"))
            //{
            //    Console.WriteLine($"the mango is exsit and we have {Fruit["mango"]} ");
            //    Fruit["mango"]=33;
            //    Console.WriteLine($"the mango After update: {Fruit["mango"]} ");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exsit");
            //}

            //Fruit.Remove("waterMeloin");
            //Fruit.Remove("mango");

            //Console.WriteLine("\nthe Dictionary After removing waterMeloin , mango");
            //foreach (KeyValuePair<string, int> kvp in Fruit)
            //{

            //    Console.WriteLine($"Fruit is {kvp.Key} and quintity {kvp.Value}");
            //}
            ////tryGetValue method
            //Console.WriteLine("\nworking with try get value");
            //if (Fruit.TryGetValue("mango",out int quantity))
            //{
            //    Console.WriteLine($"the mango is exsit withe value{Fruit["mango"]}");
            //}
            //else
            //{
            //    Console.WriteLine("not exsit");
            //}

            ////linq wit dictionary

            //Console.WriteLine("\n==============using select with dictionary==================");
            //var FruitInfo = Fruit.Select(kvp =>new { kvp.Key, kvp.Value });
            //foreach (var item in FruitInfo)
            //{
            //    Console.WriteLine($"Fruit is {item.Key} and quintity {item.Value}");
            //}
            //Console.WriteLine();
            //var FruitInfo1 = Fruit.Select(item => $"Fruit is {item.Key} and quintity {item.Value}");
            //foreach (var item in FruitInfo1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n==============using where with dictionary==================");
            //var FruitFilter = Fruit.Where(item => item.Value>10);
            //foreach(var item in FruitFilter)
            //{
            //    Console.WriteLine($"Fruit is {item.Key} and quintity {item.Value}");
            //}

            //Console.WriteLine("\n==============using order with dictionary==================");
            //var FruitOrder=Fruit.OrderBy(item => item.Value);
            //foreach (var item in FruitOrder)
            //{
            //    Console.WriteLine($"Fruit is {item.Key} and quintity {item.Value}");
            //}
            //Console.WriteLine("\n desinding");
            //FruitOrder=Fruit.OrderByDescending(item => item.Value);
            //foreach (var item in FruitOrder)
            //{
            //    Console.WriteLine($"Fruit is {item.Key} and quintity {item.Value}");
            //}
            //Console.WriteLine("\n==============using aggregating with dictionary==================");
            //Console.WriteLine($"the sume of value {Fruit.Sum(item => item.Value)}");
            //Console.WriteLine($"the average of valu:{Fruit.Average(item => item.Value)}");
            //Console.WriteLine($"the max of value:{Fruit.Max(item => item.Value)}");
            //Console.WriteLine($"the min of value:{Fruit.Min(item => item.Value)}");

            //Console.WriteLine("\n==============using Multiple qurey with dictionary==================");
            //var SortFilterFruit = Fruit.Where(item => item.Value>3).OrderBy(item => item.Value);
            //foreach (var item in SortFilterFruit)
            //{
            //    Console.WriteLine($"Fruit is {item.Key} and quintity {item.Value}");
            //}

            //Console.WriteLine("\n==============using group qurey with dictionary==================");
            //Dictionary<string, string> Fruits = new Dictionary<string, string>
            //                                     {
            //                                         { "Apple", "Pome" },
            //                                         { "Pear", "Pome" },
            //                                         { "Peach", "Stone Fruit" },
            //                                         { "Cherry", "Stone Fruit" },
            //                                         { "Mango", "Tropical" },
            //                                         { "Banana", "Tropical" },
            //                                         { "Pineapple", "Tropical" },
            //                                         { "Orange", "Citrus" },
            //                                         { "Lemon", "Citrus" },
            //                                         { "Lime", "Citrus" },
            //                                         { "Strawberry", "Berry" },
            //                                         { "Blueberry", "Berry" }
            //                                     };

            //var groupFruits =Fruits.GroupBy(item => item.Value);
            //foreach(var group in groupFruits)
            //{
            //    Console.WriteLine($"****group of {group.Key}*****");

            //    foreach(var item in group)
            //    {
            //        Console.WriteLine($"Fruit is : {item.Key}");
            //    }
            //}





            #endregion

            #endregion

            //sorted Dictionary  with index 
            #region lesson 8 Sorted List
            /*###################sorted list##########################
             * found in system.collection and system.collection.Generic
             * Automatically sorted so( Slower for addtion faster for searching and using binary search)
             * similary to dictionary use key-value pair(key is unique
             * ######################################################
             * ################# ####################################
             *                  SortedList vs  List
             * purpose    :use for stored key-value pair                      ,while list used for simple list item
             * Ordering   :sortedlist sorted autommically usin binary by key  ,while list as they are add
             * performance:search fast adding remove not                      ,adding rmoving from end fast
             */


            #region Codeing
            //SortedList NoGinaricSorted =new SortedList();
            //SortedList<string,int> sortedList=new SortedList<string,int>();

            //NoGinaricSorted.Add("Apply", 3);
            //NoGinaricSorted.Add("banana", 4);
            //NoGinaricSorted.Add("orange", 9);


            //sortedList.Add("Apply", 3);
            //sortedList.Add("banana", 4);
            //sortedList.Add("orange", 9);
            //sortedList.Add("Lemon", 1);
            //sortedList.Add("Citrus", 2);
            //sortedList.Add("Strawberry", 9);
            //sortedList.Add("Berry", 12);


            //Console.WriteLine("============Acessing sortedList===========");
            //int ApplyQueantity = (int)NoGinaricSorted["Apply"];
            //Console.WriteLine($"apply quantity:{ApplyQueantity}");

            //Console.WriteLine($"Apply Quantity:{sortedList["Apply"]}");

            //Console.WriteLine("============iteration sortedList===========");
            //foreach (DictionaryEntry entry in NoGinaricSorted)
            //{
            //    Console.WriteLine(entry.Key+" : " +entry.Value);
            //}
            //Console.WriteLine();

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item.Key+" : " +item.Value);
            //}

            //Console.WriteLine("============removing sortedList===========");
            //NoGinaricSorted.Remove("Apply");
            //foreach (DictionaryEntry entry in NoGinaricSorted)
            //{
            //    Console.WriteLine(entry.Key+" : " +entry.Value);
            //}
            //Console.WriteLine();

            //Console.WriteLine("============linq sortedList===========");
            ////query expretioin
            //var queryExprestion = from item in sortedList where item.Value>1 select item;
            //foreach (var item in queryExprestion)
            //{
            //    Console.WriteLine(item.Key+" : " +item.Value);
            //}
            //Console.WriteLine("******Mehtod expression*****");
            //var methodExpresstion = sortedList.Where(item => item.Value>1);
            //foreach (var item in methodExpresstion)
            //{
            //    Console.WriteLine(item.Key+" : " +item.Value);
            //}

            //Console.WriteLine("******Grouping *****");
            /////
            //var grouingLenght = sortedList.GroupBy(item => item.Key.Length);
            //foreach (var group in grouingLenght)
            //{
            //    Console.WriteLine(group.Key+" : "+string.Join(",",group.Select(item=>item.Key)));
            //}

            //Console.WriteLine("******costom object *****");
            //SortedList<int, Employee> employeeSortedList = new SortedList<int, Employee>()
            //{
            //    {1,new Employee("Hossam","IT",6000) },
            //    {2,new Employee("Ahmed","HR",4000) },
            //    {3,new Employee("Ali","Finance",6000) },
            //    {4,new Employee("Mohamed","IT",5500) },
            //    {5,new Employee("Omar","HR",4500) },
            //    {6,new Employee("Sara","Finance",7000) },
            //    {7,new Employee("Mona","IT",5200) },
            //    {8,new Employee("Nour","HR",4800) }

            //};

            //var ITEmployeeList =
            //    employeeSortedList
            //    .Where(Employee => Employee.Value.department=="IT")
            //    .OrderByDescending(Employee => Employee.Value.salary)
            //    .Select(Employee => Employee.Value.name);

            //foreach (var employee in ITEmployeeList)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region practice
            ////######################## Lesson 8 - SortedList Practice ########################

            //SortedList<int, Employee> employees = new SortedList<int, Employee>
            //                                     {
            //                                         { 1, new Employee("Hossam", "IT", 6000) },
            //                                         { 2, new Employee("Ahmed", "HR", 4000) },
            //                                         { 3, new Employee("Ali", "Finance", 6000) },
            //                                         { 4, new Employee("Mohamed", "IT", 5500) },
            //                                         { 5, new Employee("Omar", "HR", 4500) },
            //                                         { 6, new Employee("Sara", "Finance", 7000) },
            //                                         { 7, new Employee("Mona", "IT", 5200) },
            //                                         { 8, new Employee("Nour", "HR", 4800) }
            //                                     };


            //// Q1: Find the employee whose ID is 4.
            //var Employee = employees.Where(emp => emp.Key==4);


            //// Q2: Check whether an employee with ID 10 exists.
            //bool found = employees.ContainsKey(10);
            //found=employees.Any(emp => emp.Key==10);


            //// Q3: Add a new employee with ID 9:
            ////     Name: Khaled
            ////     Department: IT
            ////     Salary: 5800
            //employees.Add(9, new Employee("Khaled", "IT", 5800));

            //// Q4: Remove the employee whose ID is 2.
            //employees.Remove(2);

            //// Q5: Find all employees who work in the IT department.
            //var EmployessIT = employees.Where(emp => emp.Value.department=="IT");
            //foreach (var item in EmployessIT)
            //{
            //    Console.WriteLine(item.Key+" : "+item.Value.name);
            //}

            //// Q6: Find all employees whose salary is greater than 5000.
            //var EployeesSalary = employees.Where(emp => emp.Value.salary>5000);
            //// Q7: Find all employees who work in HR
            ////     and sort them by salary in descending order.
            //var EmployeesHrSort = employees.Where(emp => emp.Value.department=="HR").OrderByDescending(em => em.Value.salary);


            //// Q8: Find all employees who work in IT
            ////     and select only their names.
            //var EmployyeesItSelcetName = employees.Where(emp => emp.Value.department=="IT").Select(emp => emp.Value.name);

            //// Q9: Find the employee with the highest salary.
            //double HighestSalary = employees.Max(emp => emp.Value.salary);
            //var employeeWithHighestSalary = employees.Where(emp => emp.Value.salary==HighestSalary);

            //// Q10: Find the employee with the lowest salary.
            //double LowestSalary = employees.Min(emp => emp.Value.salary);
            //var EmployeeWithLowestSalary = employees.Where(emp => emp.Value.salary==LowestSalary);

            //// Q11: Calculate the average salary of all employees.
            //double AverageSalary = employees.Average(emp => emp.Value.salary);

            //// Q12: Group employees by their department
            ////      and print the names inside each department.
            //var DepartmentEmployeeGrouping = employees.GroupBy(emp => emp.Value.department);
            //foreach (var dept in DepartmentEmployeeGrouping)
            //{
            //    Console.WriteLine("The Departemt:"+dept.Key);
            //    foreach(var emp in dept)
            //    {
            //        Console.WriteLine(emp.Value.name);
            //    }
            //}
            //Console.WriteLine();
            //// Q13: Group employees by salary
            ////      and print the names of employees who have the same salary.
            //var SalaryEmployeeGrouping = employees.GroupBy(emp => emp.Value.salary);
            //foreach (var Salary in SalaryEmployeeGrouping)
            //{
            //    Console.WriteLine("The Departemt:"+Salary.Key);
            //    foreach (var emp in Salary)
            //    {
            //        Console.WriteLine(emp.Value.name);
            //    }
            //}
            //// Q14: Find all employees whose name has more than 4 characters,
            ////      then sort them alphabetically by name.
            //var EmployeeNameLeigh = employees.Where(emp => emp.Value.name.Length>4).OrderBy(emp => emp.Value.name);

            //// Q15: Find all IT employees whose salary is greater than 5000,
            ////      sort them by salary descending,
            ////      and select only their names.
            //var EmployeeITSortSelect = employees
            //    .Where(emp => emp.Value.department=="IT")
            //    .OrderByDescending(emp => emp.Value.salary)
            //    .Select(emp => emp.Value.name);
            //    ;

            #endregion

            #endregion

            //fast in operation
            #region lesson 10 SortedDictionary
            /**
             * sorted dictionary
                 .implement as binary serch tree so( more memory)
                 .effectionat key-based so (in all O(longn)
                 
             * SortedList                     
                 .implement as array so(less memory                    .
                 .effectionant index access so (search O(logn)  ,insert delete O(n))
                 
             * */

            #region code
            //SortedDictionary<string,int> sortedDic=new SortedDictionary<string,int>();
            //sortedDic.Add("Apple", 12);
            //sortedDic.Add("Banana", 10);
            //sortedDic.Add("orange", 8);

            //Console.WriteLine("=================Print content of SortedDictionary================");
            //foreach(var item in sortedDic)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Console.WriteLine("=================Access================");
            //Console.WriteLine($"The value of Apple:{sortedDic["Apple"]}");
            //Console.WriteLine($"The value of Apple:{sortedDic["Banana"]}");

            //Console.WriteLine("=================content================");
            //string redsul= sortedDic.ContainsKey("Apple") ? "Yess" : "no";
            //Console.WriteLine(redsul);

            //Console.WriteLine("=================remove================");
            //sortedDic.Remove("Apple");
            //foreach (var item in sortedDic)
            //{
            //    Console.WriteLine($"{item}");
            //}


            #endregion

            #region practices
            #endregion

            #endregion



            /* no index*/
            //valu unique not sorted
            #region Lesson7 Hashset
            /*
             * what are Hashset
               -system.Collections.Generic
               -Uniqueness is primry feature (no indexing no order)

               -set operation with hashtable

             * */




            #region Code
            /*****working with hashset***/
            //HashSet<string> Fruit = new HashSet<string>()
            //{
            //    "Apple","Banana","orange"

            //};


            ////Add
            //Fruit.Add("Mango");
            //Fruit.Add("Apple");

            ////print 
            //foreach (string item in Fruit)
            //{
            //    Console.WriteLine(item);
            //}


            ////Check for exsit in Hashset (contain)
            //if (Fruit.Contains("Apple"))
            //{
            //    Console.WriteLine($"the appl exsit in hashset");
            //}
            //else
            //{
            //    Console.WriteLine("apple note exsit");
            //}

            ////removing item from Hashset remove and clear
            //Fruit.Remove("Banana");

            //Console.WriteLine("the HashSet After removing Banana");
            //foreach (string item in Fruit)
            //{
            //    Console.WriteLine(item);
            //}


            //using Hashset to remove duplicate
            //int[] arry = new int[] { 1, 2, 3, 4, 5, 6, 3, 4, 5, 6, 7, 8 };

            //HashSet<int> removeDublicate = new HashSet<int>(arry);
            //HashSet<int> has = arry.ToHashSet();

            //Console.WriteLine("=======conver to hash set:===========");
            //foreach (int item in removeDublicate) { Console.WriteLine(item); }
            //Console.WriteLine();
            //foreach (int item in has) { Console.WriteLine(item); }


            ////using linq (where even and grater than >5)
            //Console.WriteLine("======= using linq ==========");

            //var FilterEven = has.Where(item => item%2==0);
            //Console.Write("even number:");
            //foreach (var item in FilterEven)
            //{
            //    Console.Write(item+",");
            //}


            //Console.WriteLine($"\nNumber grater then:{string.Join(",", has.Where(item => item>5))}");


            ////creating hashset string name  (where start wit   , where length>4)

            //HashSet<string> names = new HashSet<string>
            //                                           {
            //                                               "Ahmed",
            //                                               "Ali",
            //                                               "Hossam",
            //                                               "Mohamed",
            //                                               "Omar",
            //                                               "Sara",
            //                                               "Mona",
            //                                               "Youssef",
            //                                               "Nour",
            //                                               "Khaled",
            //                                               "Hany",
            //                                               "Amr"
            //                                           };

            //var filteringNameStartWith = names.Where(item => item.StartsWith("A"));

            //var FilteringNameWithLength = names.Where(item => item.Length>4);

            //Console.WriteLine($"\nname start with A:{string.Join(",", filteringNameStartWith)}");
            //Console.WriteLine($"name lenth>4:{string.Join(",", FilteringNameWithLength)}");

            ///*###########set operation on hashset(unionWith-intersection-except -symetricExept)#########*/
            //HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            //HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            //Console.WriteLine("======= using Set operation ==========");

            //var UnionSet = set1.Union(set2);
            //Console.WriteLine($"Union two set:{string.Join(",", UnionSet)}");

            //var InterSectionSet = set1.Intersect(set2);
            //Console.WriteLine($"intersection two set:{string.Join(",", InterSectionSet)}");

            ////element exsit in set1 not in set2
            //var ExceptSet = set1.Except(set2);
            //Console.WriteLine($"element exsit in set1 not in set2:{string.Join(",", ExceptSet)}");

            //set1.SymmetricExceptWith(set2);
            //Console.WriteLine($"element exsit in set1 not in set2 union element exsit in set2 not in set1:{string.Join(",", set1)}");


            ///*#################Comparing Sets With hashTable(SetEqual-IsSubset-IsSupersSet-Overlaps)###################*/
            //Console.WriteLine("======= using Set operation ==========");
            //HashSet<int> Set3 = new HashSet<int>() { 3, 4, 5 };
            //Console.WriteLine($"is Set 1 is Equal to set 3:{set1.SetEquals(Set3)}");
            //Console.WriteLine($"is set2 is Equal tot set 3:{set2.SetEquals(Set3)}");

            //HashSet<int> Set4 = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine($"is set3 is subset of set4:{Set3.IsSubsetOf(Set4)}");
            //Console.WriteLine($"is set1 is subset of set 4:{set1.IsSubsetOf(Set4)}");

            //Console.WriteLine($"is set4 is super set of set 3:{Set4.IsSupersetOf(Set3)}");

            //Console.WriteLine($"is set 1 is over laps of set 2:{set1.Overlaps(set2)} ");


            ////SetEqual
            #endregion

            #region Real-World HashSet Practice 

            //            // Scenario: Course Registration

            //            HashSet<string> CSharpStudents = new HashSet<string>
            //{
            //    "Ahmed",
            //    "Ali",
            //    "Hossam",
            //    "Omar",
            //    "Sara",
            //    "Mona"
            //};

            //            HashSet<string> SQLStudents = new HashSet<string>
            //{
            //    "Hossam",
            //    "Omar",
            //    "Mohamed",
            //    "Nour",
            //    "Sara"
            //};


            //            // Q1: Find all students who are taking at least one of the two courses.
            //            var Student = CSharpStudents.Union(SQLStudents);

            //            // Q2: Find all students who are taking both C# and SQL.
            //            var StudentTakeTwo = CSharpStudents.Intersect(SQLStudents);

            //            // Q3: Find all students who are taking C# but not SQL.
            //            var StudentOfTakeCCharpOnly = CSharpStudents.Except(SQLStudents);

            //            // Q4: Find all students who are taking SQL but not C#.
            //            var StudentOfTakeSqlOnly = SQLStudents.Except(CSharpStudents);

            //            // Q5: Find all students who are taking exactly one of the two courses.
            //            HashSet<string> StudentCscharpstudentCop = new HashSet<string>(CSharpStudents);
            //               StudentCscharpstudentCop.SymmetricExceptWith(SQLStudents);
            //            // Q6: Check whether every C# student is also an SQL student.
            //            bool CSharpStudentISSqlStudent = CSharpStudents.IsSubsetOf(SQLStudents);



            //            //######################## User Permissions ########################

            //            HashSet<string> AdminPermissions = new HashSet<string>
            //{
            //    "AddUser",
            //    "ViewUsers",
            //    "UpdateUser",
            //    "DeleteUser",
            //    "ViewReports"
            //};

            //            HashSet<string> ManagerPermissions = new HashSet<string>
            //{
            //    "AddUser",
            //    "ViewUsers",
            //    "UpdateUser",
            //    "ViewReports",
            //    "ExportReports"
            //};


            //            // Q7: Find all permissions that both Admin and Manager have.
            //            var InterSectionPermissions=AdminPermissions.Intersect(ManagerPermissions);

            //            // Q8: Find all permissions that only Admin has.
            //            var EceptPermissionsAdmin=AdminPermissions.Except(ManagerPermissions);

            //            // Q9: Find all permissions that only Manager has.
            //            var EceptPermissioinsManger=ManagerPermissions.Except(AdminPermissions);

            //            // Q10: Find all permissions that belong to exactly one role.
            //            var copyAdminPersmissioin = AdminPermissions;
            //            copyAdminPersmissioin.SymmetricExceptWith(ManagerPermissions);

            //            // Q11: Check whether Admin and Manager have at least one permission in common.
            //            bool hasAtLestOneCommonPerm=AdminPermissions.Overlaps(ManagerPermissions);


            //            //######################## Extra Practice ########################

            //            // Q12: Check whether Admin has all the permissions that Manager has.
            //            bool AdminIsSuper = AdminPermissions.IsSupersetOf(ManagerPermissions);

            //            // Q13: Check whether Manager has all the permissions that Admin has.
            //            bool mangerIsSuper=ManagerPermissions.IsSupersetOf(AdminPermissions);

            //            // Q14: Check whether Admin and Manager have exactly the same permissions.
            //            bool IsEqual = AdminPermissions.SetEquals(ManagerPermissions);

            //            // Q15: Find all permissions available to the system from both roles combined.
            //            var union = AdminPermissions.Union(ManagerPermissions);
            #endregion

            #endregion

            //sorted hashset
            #region lesson 9 SortedSet
            ///*
            // * system collection.generic
            // * store unique element in sorted order so(fast in serarch[lookup} add remove)
            // * no indexting
            // * 
            // * */



            //#region Coding
            //SortedSet<int> list = new SortedSet<int>() { 1,2, 42, 32, 12, 23, 4, 3,4, 5,  };
            //list.Add(233);
            //list.Add(20);
            //Console.WriteLine("============== Element in List ===========");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("============== Contains Number ===========");
            //if (list.Contains(42)) {
            //    Console.WriteLine("Yes,It Is Exsite:");
            //        }
            //else
            //{
            //    Console.WriteLine("No,Not Exsit");
            //}


            //Console.WriteLine("============== Element in List After removing ===========");
            //list.RemoveWhere(x => x>10);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            ////linqu

            //Console.WriteLine("============== Print List Of Item Greater Then 2 ===========");
            //var ListOFNumberGreaterThen = list.Where(x => x>2);
            //foreach(var item in ListOFNumberGreaterThen)
            //{
            //    Console.WriteLine(item);
            //}

            //var Sum=list.Sum();
            //Console.WriteLine($"\nthe Sum of Element in list {Sum}");

            //double MaxNumber=list.Max();
            //Console.WriteLine($"\nthe Max number in List {MaxNumber}");

            //double minNumber=list.Min();
            //Console.WriteLine($"the Min number in list {minNumber} ");

            //var DesacindingList= list.OrderByDescending(x => x);
            //Console.WriteLine("\n============== Print List After order ===========");

            //foreach (var item in DesacindingList)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("\n============== Print List of envent number after squer ===========");
            //var EvenNumberSquere = list.Where(x => x%2==0).Select(x => x*x);
            //foreach (var item in EvenNumberSquere)
            //{
            //    Console.WriteLine(item);
            //}


            ////set Operation in Sorted list 
            //Console.WriteLine("\n============== set Operation in Sorted list ===========");

            //SortedSet<int> Set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            //SortedSet<int>set2=new SortedSet<int>() { 3,4,5,6,7};

            //Console.WriteLine($"=====the union of tow Set =======");
            //var setUnion = Set1.Union(set2);
            //Console.WriteLine("union:"+string.Join(",",setUnion));

            //var InterSectioin=Set1.Intersect(set2);
            //Console.WriteLine("\nIntersect:"+string.Join(",", InterSectioin));

            //var Deffreinces=Set1.Except(set2);
            //Console.WriteLine("\ndeffreinces:"+string.Join(",", Deffreinces));

            //SortedSet<int> copy = new SortedSet<int>(set2);
            //copy.SymmetricExceptWith(Set1); ;
            //Console.WriteLine("\ndeffreinces in two set:"+string.Join(",", copy));

            //Console.WriteLine($"\n=====comparison =======");

            //bool IsEqual = Set1.SetEquals(set2);
            //Console.WriteLine($"Set 1 and set 2 Equal:{IsEqual}");

            //bool issuper=Set1.IsSupersetOf(set2);
            //Console.WriteLine($"Set 1 is superset for set2:{IsEqual}");

            //bool issubset=set2.IsSubsetOf(Set1 );
            //Console.WriteLine($"Set 2 is subset for set1:{issubset}");

            //bool overlab=Set1.Overlaps(set2);
            //Console.WriteLine($"Set 1 have at lest on common element in set2:{overlab }");


            //#endregion



            #region practice


            #endregion
            #endregion




            #region lesson 11 ArrayList
            /*
             * is a non-generic collection that can hold elements of any data type.
             * 
             * dynamically resizable,automatically adjusts its size as elements are added but
               no automatically adjusts its size when elements are removed(trimtoSize).

             *memory Mangement:
             * */
            #region Coding
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add(8);
            //arrayList.Add(9);
            //arrayList.Add(2);
            //arrayList.Add(6);
            //arrayList.Add(7);
            //arrayList.Insert(0, 11);
            //arrayList.Insert(3, 12);

            //Console.WriteLine("========element of array==========");
            //foreach( var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(10);
            //arrayList.RemoveAt(0);
            //Console.WriteLine("================element of array =========");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("================element of array =========");
            //arrayList.Sort();
            //if (arrayList.BinarySearch(12)>0)
            //{
            //    Console.WriteLine("element exsit");
            //    foreach( var item in arrayList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            //Console.WriteLine("===============Filtering even number=============");
            //var filltering= arrayList.Cast<int>().Where(item => item%2==0);
            //foreach (var item in filltering)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=============Aggregate Function============");

            //Console.WriteLine(string.Join(",", arrayList.ToArray()));

            //var cast = arrayList.Cast<int>();
            //int count=cast.Count();
            //int sum=cast.Sum();
            //double ave=cast.Average();
            //int max=cast.Max();
            //int min=cast.Min();

            //Console.WriteLine($"number of element:{count}  the sum:{sum}  ave:{ave}  max:{max}  min:{min} ");

            //var repetable = cast.Count(item => item==8);
            //Console.WriteLine($"the 8 repete:{repetable} time");

            #endregion
            #region practice
            #region Practice

            // // Scenario: Store and analyze product prices in a small shop.

            // ArrayList prices = new ArrayList()
            //                                  {
            //                                      150, 80, 200, 50, 120, 300, 80, 250, 100, 50
            //                                  };


            // // Q1: Add a new product price of 175 to the list.
            // prices.Add(175);

            // // Q2: Insert a product price of 90 at index 2.
            // prices.Insert(2, 90);

            // // Q3: Remove the first product whose price is 50.
            // prices.Remove(50);

            // // Q4: Remove the product price at index 4.
            // prices.RemoveAt(4);

            // // Q5: Sort all product prices in ascending order.
            // prices.Sort();
            // prices.Cast<int>().OrderBy(item=>item);

            // // Q6: Check whether the price 200 exists in the list
            // //     using BinarySearch.
            // if (prices.BinarySearch(200)>0)
            // {
            //     Console.WriteLine("yes");
            // }

            // // Q7: Find all product prices that are greater than 100.
            // var castint = prices.Cast<int>();
            //var Productgreater100 =castint.Where(item=>item>200);

            // // Q8: Find all product prices that are even numbers.
            //var producteven= castint.Where(item => item%2==0);

            // // Q9: Count how many products have a price of 80.
            //var numberOfProdect= castint.Count();

            // // Q10: Calculate the total price of all products.
            // var sumtion=castint.Sum(); ;

            // // Q11: Calculate the average product price.
            // var average=castint.Average();
            // // Q12: Find the most expensive product price.
            // var maxmize=castint.Max();

            // // Q13: Find the cheapest product price.
            // var minmize=castint.Min();

            // // Q14: Find all products whose price is greater than
            // //      the average product price.
            // var ProductGraterThenAverage=castint.Where(item=>item>average);

            // // Q15: Find the total number of products,
            // //      the total price,
            // //      the average price,
            // //      the highest price,
            // //      and the lowest price,
            // //      then print all results.
            // Console.WriteLine($"number of element:{numberOfProdect}  the sum:{sumtion}  ave:{average}  max:{maxmize}  min:{minmize} ");


            #endregion
            #endregion
            #endregion


            #region lesson 12 observable collection
            /*
             * is generict and  dynamic collection in system.Collections.objectmodel namespace
             * used in data-binding scenarios, automatically notifies about any changes made to the collectioin
             * */
            #region coding
            //ObservableCollection<string> items=new ObservableCollection<string>();
            //items.CollectionChanged+=print;
            //items.Add("Hossam");
            //items.Add("Ali");
            //items.Add("mohamed");

            //items.Insert(0, "Gholam");

            //items.RemoveAt(3);

            //items[1]="Hosam";

            //items.Move(1, 2);




            #endregion


            #region Practice

            //// Scenario: Student Registration System
            //// We use ObservableCollection to store the names of students
            //// and automatically receive notifications when the collection changes.

            //ObservableCollection<string> students =
            //    new ObservableCollection<string>()
            //    {
            //       "Ahmed",
            //       "Ali",
            //       "Hossam",
            //       "Mohamed",
            //       "Omar"
            //    };

            //students.CollectionChanged += print;


            //// Q1: Add a new student named "Sara".

            //students.Add("Sara");
            //// Q2: Add two new students:
            ////     "Mona"
            ////     "Nour"
            //students.Add("Mona");
            //students.Add("Nour");


            //// Q3: Insert "Khaled" at index 2.

            //students.Insert(2, "Khaled");


            //// Q4: Remove the student named "Ali".
            //students.Remove("Ali");


            //// Q5: Remove the student at index 0.
            //students.RemoveAt(0);

            //// Q6: Replace "Hossam" with "Hossam Gholam"
            ////     using the indexer [].
            //var index=students.IndexOf("Hossam");
            //students[index]="Hossam Gholam";

            //// Q7: Move the student at index 0
            ////     to index 3.
            //students.Move(0, 3);


            //// Q8: Print all students after making
            ////     all the changes above.
            //Console.WriteLine("################################the list of students ############################");
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}


            //// Q9: Add a new student named "Youssef"
            ////     and observe what happens to the CollectionChanged event.
            //students.Add("Youssef");

            //// Q10: Remove "Mona" and observe
            ////      what happens to the CollectionChanged event.
            //students.Remove("Mona");


            //// Q11: Insert "Fatma" at index 1
            ////      and observe the event.
            //students.Insert(1, "Fatma");


            //// Q12: Replace the student at index 2
            ////      with "Mahmoud"
            ////      and observe the event.
            //students[2]="Mahmoud";


            //// Q13: Move the last student
            ////      to the first position.
            //students.Move(students.Count-1, 0);

            //// Q14: Print the final number of students
            ////      using Count.
            //Console.WriteLine(students.Count);


            //// Q15: Clear all students from the collection
            ////      and observe what happens to the CollectionChanged event.
            //students.Clear();


            #endregion



            #endregion




            #region Lesson 13 Stack<T>

            /*
             * ==================== What is Stack<T>? ====================
             *
             * - Generic collection
             * - Namespace: System.Collections.Generic
             * - Stores elements in a LIFO order
             *
             * LIFO = Last In, First Out
             *
             * Think:
             *
             *        TOP
             *        ↓
             *      ┌─────┐
             *      │  30 │ ← Last added → First removed
             *      ├─────┤
             *      │  20 │
             *      ├─────┤
             *      │  10 │
             *      └─────┘
             *
             *
             * ==================== Why use Stack<T>? ====================
             *
             * Use Stack<T> when the LAST item added
             * should be the FIRST item removed.
             *
             * Real-world examples:
             *
             * - Undo operations
             * - Browser history
             * - Backtracking
             * - Expression processing
             * - Function call stack
             *
             *
             * ==================== Important Operations ====================
             *
             * Push()      → Add item to the top
             * Pop()       → Remove and return the top item
             * Peek()      → Return the top item without removing it
             * Contains()  → Check if an item exists
             * Count       → Number of elements
             * Clear()     → Remove all elements
             *
             *
             * ==================== Main Idea ====================
             *
             * Push → Add to TOP
             * Pop  → Remove from TOP
             * Peek → Look at TOP
             *
             *
             *        Push
             *          ↓
             *        TOP
             *         ↓
             *      [30]
             *      [20]
             *      [10]
             *
             *        Pop
             *          ↓
             *      [30] ← removed
             *      [20]
             *      [10]
             *
             */

            #region Coding
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //int top=stack.Peek();
            //Console.WriteLine("the top element:"+top);


            //Console.WriteLine("removing last elemtn :"+stack.Pop());
            //Console.WriteLine("removing last elemtn :"+stack.Pop());

            //if (stack.Count == 0)
            //{
            //    Console.WriteLine("stack is empty");
            //}
            //else
            //{
            //    Console.WriteLine("top element :"+stack.Peek());
            //}


            #endregion





            #region Practice

            //// Scenario: Browser History

            //Stack<string> browserHistory = new Stack<string>();
            //browserHistory.Push("Google");
            //browserHistory.Push("YouTube");
            //browserHistory.Push("GitHub");
            //browserHistory.Push("ChatGPT");

            //// Q1: Add "Microsoft" to the browser history.
            //browserHistory.Push("Microsoft");

            //// Q2: Add "LinkedIn" to the browser history.
            //browserHistory.Push("LinkedIn");


            //// Q3: Show the current page without removing it.

            //Console.WriteLine("the top element in browserHistory:"+browserHistory.Peek());
            //// Q4: Remove the current page from the history
            ////     and print its name.

            //Console.WriteLine("++++++++++++current Stack :+++++++++++++++");
            //Console.WriteLine("rmove current Page :"+browserHistory.Pop());


            //// Q5: Show the new current page.
            //Console.WriteLine("the new current Page:"+browserHistory.Peek());

            //// Q6: Check whether "GitHub" exists in the history.
            //if (browserHistory.Contains("GitHub"))
            //{
            //    Console.WriteLine("Yes GitHub Exsit");
            //}
            //else
            //{
            //    Console.WriteLine("No GitHub not exsit");
            //}

            //// Q7: Print the number of pages in the history.
            //Console.WriteLine("the number of page in History:"+browserHistory.Count());

            //// Q8: Remove the current page two times
            ////     and print both removed pages.
            //Console.WriteLine("rmove current Page :"+browserHistory.Pop());
            //Console.WriteLine("rmove current Page :"+browserHistory.Pop());

            //// Q9: Print all remaining pages in the history.

            //Console.WriteLine(string.Join(Environment.NewLine, browserHistory));
            //// Q10: Check whether "Facebook" exists
            ////      in the browser history.
            //if (browserHistory.Contains("Facebook"))
            //{
            //    Console.WriteLine("Yes Facebook Exsit");
            //}
            //else
            //{
            //    Console.WriteLine("No Facebook not exsit");
            //}

            //// Q11: Clear the browser history.
            //browserHistory.Clear();

            //// Q12: Print the number of pages after clearing.
            //Console.WriteLine("the number of page in History:"+browserHistory.Count());

            //// ==================== Real Practice ====================

            //// Scenario: Undo System

            //Stack<string> undoActions = new Stack<string>();
            //undoActions.Push("Type Hello");
            //undoActions.Push("Add Space");
            //undoActions.Push("Type World");
            //undoActions.Push("Delete Character");


            //// Q13: Find the last action without removing it.
            //Console.WriteLine("the last Action:"+undoActions.Peek());

            //// Q14: Undo the last two actions.
            ////      Print the action that was undone each time.
            //Console.WriteLine("undo the last actioin :"+undoActions.Pop());
            //Console.WriteLine("rmove current Page :"+undoActions.Pop());

            //// Q15: Print all remaining undo actions.

            //Console.WriteLine(string.Join(Environment.NewLine,undoActions));


            #endregion


            #region Mistakes to Remember

            /*
             *
             * 1. Peek() does NOT remove the element.
             *
             *    Peek()
             *       ↓
             *    [30]  ← stays
             *
             *
             * 2. Pop() removes the element.
             *
             *    Pop()
             *       ↓
             *    [30]  ← removed
             *
             *
             * 3. Push() adds to the TOP.
             *
             *    Push(40)
             *
             *    [40] ← TOP
             *    [30]
             *    [20]
             *
             *
             * 4. Stack follows LIFO.
             *
             *    Last In
             *       ↓
             *    First Out
             *
             */

            #endregion

            #endregion

            #region Lesson 14 Queue

            /*
             * ==================== What is Queue? ====================
             *
             * - Generic collection
             * - Namespace: System.Collections.Generic
             * - Stores elements in a sequence
             * - Follows FIFO: First In, First Out
             * - The first element added is the first element removed
             * - Does not provide indexing like List
             *
             *
             * ==================== Why use Queue? ====================
             *
             * - When elements must be processed in the order they arrive
             * - Useful for:
             *      - Customer waiting lines
             *      - Print jobs
             *      - Task processing
             *      - Message processing
             *
             *
             * ==================== Important Operations ====================
             *
             * - Enqueue()   → Add an element to the end
             * - Dequeue()   → Remove and return the first element
             * - Peek()      → Return the first element without removing it
             * - Contains()  → Check if an element exists
             * - Count       → Get number of elements
             * - Clear()     → Remove all elements
             * - ToArray()   → Convert Queue to an array
             *
             *
             * ==================== Think ====================
             *
             * Queue
             *      ↓
             *   FIFO
             *      ↓
             * First In
             *      ↓
             * First Out
             *
             *
             * Example:
             *
             * Customer 1
             * Customer 2
             * Customer 3
             *
             *      ↓ Dequeue
             *
             * Customer 1 leaves first
             *
             */

            #region Coding

            #endregion


            #region Practice

            //// Scenario: Customer Service Queue

            //Queue<string> customerQueue = new Queue<string>();

            //customerQueue.Enqueue("Ahmed");
            //customerQueue.Enqueue("Ali");
            //customerQueue.Enqueue("Hossam");

            //customerQueue.Enqueue("Sara"); 
            //customerQueue.Enqueue("Mona");


            //// Q1: Add a new customer named "Omar".
            //customerQueue.Enqueue("Omar");

            //// Q2: Add two new customers:
            ////     "Nour"
            ////     "Khaled"
            //customerQueue.Enqueue("Nour");
            //customerQueue.Enqueue("Khaled");


            //// Q3: Show the first customer without removing him.
            //Console.WriteLine("the first customer Is:"+customerQueue.Peek());

            //// Q4: Serve the first customer
            ////     and print his name.
            //Console.WriteLine("i am hapy to serve you sir:"+customerQueue.Dequeue());

            //// Q5: Show the new first customer.
            //Console.WriteLine("the New customer Is:"+customerQueue.Peek());

            //// Q6: Check whether "Hossam" is waiting in the queue.
            //if (customerQueue.Contains("Hossam"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //// Q7: Print the number of customers waiting.
            //Console.WriteLine("the number of customer:"+customerQueue.Count);

            ///*
            // * Q8: Serve two customers
            // *     and print both names.
            // */
            //Console.WriteLine("i am hapy to serve you sir:"+customerQueue.Dequeue());
            //Console.WriteLine("i am hapy to serve you sir:"+customerQueue.Dequeue());

            //// Q9: Print all remaining customers.
            //Console.WriteLine(string.Join(",", customerQueue.ToArray()));

            //// Q10: Check whether "Mohamed" is waiting.

            //if (customerQueue.Contains("Mohamed"))
            //{
            //    Console.WriteLine("Yes is Waiting");
            //}
            //else
            //{
            //    Console.WriteLine("no ");
            //}
            //// Q11: Find all customers whose names
            ////      have more than 4 characters
            ////      using LINQ.

            //var CustomerNameLenght = customerQueue.Where(customer => customer.Length>4);
            //foreach(var customer in customerQueue)
            //{
            //    Console.WriteLine(customer);
            //}


            //// Q12: Find all customers whose names
            ////      start with 'A'
            ////      using LINQ.
            //var customerNameStartWith = customerQueue.Where(customer => customer.StartsWith("A"));
            //foreach (var customer in customerNameStartWith)
            //{
            //    Console.WriteLine(customer);
            //}

            //// Q13: Count how many customers
            ////      have exactly 4 characters.

            //var count = customerQueue.Count(customer => customer.Length==4);


            //// Q14: Convert the queue to an array
            ////      and print all customers.
            //var array= customerQueue.ToArray();

            //// Q15: Clear the queue
            ////      and print the number of customers
            ////      after clearing.
            //customerQueue.Clear();
            //Console.WriteLine("queue is empty");

            #endregion


            #region Mistakes

            // Mistake 1:
            // Using Dequeue() when you only want to see
            // the first element.
            //
            // Use:
            // Peek()


            // Mistake 2:
            // Thinking Queue uses LIFO.
            //
            // Queue = FIFO
            // Stack = LIFO


            // Mistake 3:
            // Trying to access an element using an index.
            //
            // Wrong:
            // customerQueue[0]
            //
            // Queue does not provide normal indexing.
            //
            // Use:
            // Peek()


            // Mistake 4:
            // Calling Dequeue() on an empty Queue.
            //
            // This causes an exception.
            //
            // Check first:
            //
            // if (customerQueue.Count > 0)
            // {
            //     customerQueue.Dequeue();
            // }


            // Mistake 5:
            // Using Count() unnecessarily.
            //
            // Prefer:
            //
            // customerQueue.Count
            //
            // Count is a property.


            #endregion

            #endregion

            #region Lesson 15 Linked List

            /*
             * ==================== What is Linked List? ====================
             *
             * A Linked List is a linear data structure made of Nodes.
             *
             * Each Node contains:
             *
             *      Data
             *        +
             *      Link(s) to other Node(s)
             *
             *
             * ==================== Why use Linked List? ====================
             *
             * - Dynamic size
             * - Easy insertion and removal when you already have the Node * - Useful when elements are frequently inserted or removed
             * - Does not require (contiguous memory) like an array
             *
             *
             * ==================== Important Characteristics ====================
             *
             * - No direct indexing like Array/List * - To find an element, we normally traverse the list
             * - Each node stores data and one or more references
             *
             *
             * ================================================================
             *                    1. Singly Linked List
             * ================================================================
             *
             * Each node has:
             *
             *      Data
             *        +
             *      Next
             *
             *
             * Example:
             *
             * Head
             *  ↓
             * [10] → [20] → [30] → null
             *
             *
             * Each node knows only the NEXT node.
             *
             *
             * ==================== Important Operations ====================
             *
             * - Add at beginning
             * - Add at end
             * - Insert after a node
             * - Remove a node
             * - Search
             * - Traverse
             *
             *
             * Think:
             *
             * Node
             *   ↓
             * Data + Next
             *
             *
             * ================================================================
             *                    2. Doubly Linked List
             * ================================================================
             *
             * Each node has:
             *
             *      Previous
             *          +
             *         Data
             *          +
             *         Next
             *
             *
             * Example:
             *
             * null ← [10] ⇄ [20] ⇄ [30] → null
             *
             *
             * Each node knows:
             *
             * - Previous node
             * - Next node
             *
             *
             * ==================== Advantages ====================
             *
             * - Can move forward
             * - Can move backward
             * - Easier removal when you have the node
             *
             *
             * ================================================================
             *                    3. Circular Linked List
             * ================================================================
             *
             * The last node points back to the first node.
             *
             *
             * Example:
             *
             *       ┌──────────────────────┐
             *       ↓                      │
             *     [10] → [20] → [30] ─────┘
             *
             *
             * There is NO null at the end.
             *
             * The list forms a circle.
             *
             *
             * ==================== Why use it? ====================
             *
             * - Round-robin scheduling
             * - Turn-based systems
             * - Circular queues
             * - Repeating processes
             *
             *
             * ================================================================
             *              C# Built-in LinkedList<T>
             * ================================================================
             *
             * Namespace:
             * System.Collections.Generic
             *
             * C# LinkedList<T> is a DOUBLY linked list.
             *
             *
             * Important Operations:
             *
             * - AddFirst()
             * - AddLast()
             * - AddBefore()
             * - AddAfter()
             * - Remove()
             * - RemoveFirst()
             * - RemoveLast()
             * - Find()
             * - FindLast()
             * - Contains()
             * - Clear()
             *
             *
             * Important:
             *
             * LinkedList<T> does NOT support:
             *
             *      list[0]
             *
             * like List<T>.
             *
             *
             * ==================== Think ====================
             *
             * LinkedList
             *      ↓
             *     Nodes
             *      ↓
             * ┌───────────────┐
             * │ Data + Links  │
             * └───────────────┘
             *
             *
             * Singly:
             *
             * [Data | Next]
             *
             *
             * Doubly:
             *
             * [Previous | Data | Next]
             *
             *
             * Circular:
             *
             * Last Node → First Node
             *
             */

            #region Coding


            #endregion


            #region Practice

            ///*
            // * ================================================================
            // * Scenario: Hospital Patient Waiting List
            // * ================================================================
            // *
            // * We have a LinkedList of patients.
            // *
            // */

            //LinkedList<string> patients = new LinkedList<string>();

            //patients.AddLast("Ahmed");
            //patients.AddLast("Ali");
            //patients.AddLast("Hossam");
            //patients.AddLast("Sara");
            //patients.AddLast("Mona");


            //// ==================== Basic Operations ====================

            //// Q1:
            //// Add a new patient "Omar" at the beginning.
            //patients.AddFirst("Omar");

            //// Q2:
            //// Add a new patient "Nour" at the end.
            //patients.AddLast("Nour");

            //// Q3:
            //// Find the patient "Hossam"
            //// and print whether he exists.
            //if (patients.Contains("Hossam"))
            //{
            //    Console.WriteLine("He Exsits");
            //}
            //else
            //{
            //    Console.WriteLine("not exsit");
            //}


            //// Q4:
            //// Add "Mohamed" AFTER "Ali".

            //LinkedListNode<string> aliNode = patients.Find("Ali");
            //patients.AddAfter(aliNode,"Mohamed");

            //// Q5:
            //// Add "Khaled" BEFORE "Sara".
            //LinkedListNode<string> SaraNode = patients.Find("Sara");
            //patients.AddBefore(SaraNode, "Khaled");

            //// Q6:
            //// Remove the patient "Mona".
            //patients.Remove("Mona");

            //// Q7:
            //// Remove the first patient.
            //patients.RemoveFirst();


            //// Q8:
            //// Remove the last patient.
            //patients.RemoveLast();

            //// ==================== Working With Nodes ====================

            //// Q9:
            //// Find the node containing "Hossam"
            //// and print its Value.
            //LinkedListNode<string> HossamNode = patients.Find("Hossam");
            //Console.WriteLine("Value of Hossam Node:"+HossamNode.Value);


            //// Q10:
            //// Find the node containing "Sara"
            //// and print the name of the previous patient.
            ////
            //// Hint:
            ////      node.Previous

            //Console.WriteLine("Value of Hossam Node:"+SaraNode.Previous.Value);


            //// Q11:
            //// Find the node containing "Ali"
            //// and print the name of the next patient.
            ////
            //// Hint:
            ////      node.Next


            //Console.WriteLine("Value of Hossam Node:"+aliNode.Next.Value);


            //// ==================== LINQ ====================

            //// Q12:
            //// Find all patients whose names
            //// have more than 4 characters.
            //var PatientsNameLinght = patients.Where(pationt => pationt.Length>4);


            //// Q13:
            //// Find all patients whose names
            //// start with "A".
            //var patientNameSatrt = patients.Where(Patient => Patient.StartsWith("A"));

            //// Q14:
            //// Count how many patients have
            //// exactly 4 characters.
            //var countPatientNameLingth = patients.Count(patient => patient.Length==4);


            //// Q15:
            //// Sort the patients alphabetically
            //// and print them.
            //var sortacs = patients.OrderBy(Patient => Patient);


            #endregion


            #region Mistakes

            // Mistake 1:
            // Trying to access LinkedList using an index.
            //
            // Wrong:
            //
            // patients[0]
            //
            // LinkedList<T> does not support indexing.
            //
            //
            // Mistake 2:
            // Confusing LinkedList with List.
            //
            // List<T>:
            //
            //      list[0]
            //
            // LinkedList<T>:
            //
            //      node.Value
            //
            //
            // Mistake 3:
            // Calling AddAfter() with a value instead of a node.
            //
            // AddAfter needs a LinkedListNode<T>:
            //
            // LinkedListNode<string> node =
            //     patients.Find("Ali");
            //
            // patients.AddAfter(node, "Mohamed");
            //
            //
            // Mistake 4:
            // Forgetting that Find() can return null.
            //
            // Always check:
            //
            // if (node != null)
            // {
            //     ...
            // }
            //
            //
            // Mistake 5:
            // Thinking C# LinkedList<T> is singly linked.
            //
            // C# LinkedList<T> is DOUBLY linked.
            //
            // It has:
            //
            // Previous
            // Value
            // Next
            //
            //
            // Mistake 6:
            // Thinking LinkedList automatically means Circular.
            //
            // C# LinkedList<T> is NOT circular.
            //
            // It is a doubly linked list:
            //
            // null ← Node ⇄ Node ⇄ Node → null
            //
            //
            // Mistake 7:
            // Confusing LinkedList operations.
            //
            // AddFirst() → beginning
            // AddLast()  → end
            // AddBefore() → before a node
            // AddAfter()  → after a node
            //
            //
            // Mistake 8:
            // Using LINQ to modify the LinkedList.
            //
            // LINQ is mainly used here for:
            //
            // Where
            // OrderBy
            // Count
            // Select
            // etc.
            //
            // Use LinkedList methods for structural changes.


            #endregion

            #endregion



            #region Lesson 16 Array

            /*
             * ==================== What is Array? ====================
             *
             * An Array is a fixed-size collection that stores
             * multiple elements of the same data type.
             *
             * Example:
             *
             * int[] numbers = { 10, 20, 30, 40 };
             *
             *
             * ==================== Why use Array? ====================
             *
             * - Store multiple values of the same type
             * - Fast access using an index
             * - Fixed size
             * - Elements are stored sequentially
             *
             *
             * ==================== Important Characteristics ====================
             *
             * - Fixed size
             * - Same data type
             * - Zero-based indexing
             * - Fast access by index: O(1)
             * - Has Length property
             * - Supports one-dimensional and multidimensional arrays
             *
             *
             * ==================== Think ====================
             *
             * Array
             *   ↓
             * Fixed Size
             *   ↓
             * Same Data Type
             *   ↓
             * Index
             *   ↓
             * Fast Access
             *
             *
             * ==================== Array Declaration ====================
             *
             * int[] numbers = new int[5];
             *
             *
             * ==================== Array Initialization ====================
             *
             * int[] numbers = { 10, 20, 30, 40 };
             *
             *
             * ==================== Important Operations ====================
             *
             * - Access element       numbers[index]
             * - Modify element       numbers[index] = value
             * - Length               numbers.Length
             * - Sort                 Array.Sort()
             * - Search               Array.IndexOf()
             * - Copy                 Array.Copy()
             *
             *
             * ================================================================
             *                     One-Dimensional Array
             * ================================================================
             *
             * Example:
             *
             * int[] numbers = { 10, 20, 30, 40 };
             *
             * Index:
             *
             *    0     1     2     3
             *   ┌────┬────┬────┬────┐
             *   │ 10 │ 20 │ 30 │ 40 │
             *   └────┴────┴────┴────┘
             *
             *
             * ================================================================
             *                     Two-Dimensional Array
             * ================================================================
             *
             * Example:
             *
             * int[,] numbers =
             * {
             *     { 1, 2, 3 },
             *     { 4, 5, 6 }
             * };
             *
             *
             * Rows    → GetLength(0)
             * Columns → GetLength(1)
             *
             */

            #region Coding

            //// ================================================================
            //// Declaration
            //// ================================================================

            //int[] ints = new int[4];


            //// ================================================================
            //// Initialization
            //// ================================================================

            //int[] numbers = { 1, 2, 5, 8, 32, 12, 4, 9 };

            //string[] names =
            //{
            //    "Hossam",
            //    "Ahmed",
            //    "Ali"
            //};


            //// ================================================================
            //// Display Array
            //// ================================================================

            //Console.WriteLine("========== Names ==========");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //// ================================================================
            //// Accessing and Modifying Elements
            //// ================================================================

            //numbers[1] = 10;

            //Console.WriteLine("========== Numbers ==========");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //// ================================================================
            //// Sorting
            //// ================================================================

            //Array.Sort(numbers);

            //Console.WriteLine("========== After Sorting ==========");

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //// ================================================================
            //// Searching
            //// ================================================================

            //int index = Array.IndexOf(numbers, 32);

            //Console.WriteLine("Index of 32: " + index);


            //// ================================================================
            //// Copying Array
            //// ================================================================

            //int[] copyArray = new int[numbers.Length];

            //Array.Copy(
            //    numbers,
            //    copyArray,
            //    numbers.Length
            //);

            //Console.WriteLine("========== Copy ==========");

            //foreach (int number in copyArray)
            //{
            //    Console.WriteLine(number);
            //}


            //// ================================================================
            //// LINQ - Where + Select
            //// ================================================================

            //var evenSquare =
            //    numbers
            //    .Where(n => n % 2 == 0)
            //    .Select(n => n * n);

            //Console.WriteLine("========== Even Squares ==========");

            //foreach (int number in evenSquare)
            //{
            //    Console.WriteLine(number);
            //}


            //// ================================================================
            //// LINQ - Aggregate
            //// ================================================================

            //int sumOfEvenSquares = evenSquare.Sum();

            //Console.WriteLine(
            //    "Sum of even squares: " + sumOfEvenSquares
            //);


            //// ================================================================
            //// Two-Dimensional Array
            //// ================================================================

            //int[,] twoDArray =
            // {
            //     { 2, 3, 4 },
            //     { 3, 4, 5 }
            // };

            //Console.WriteLine("========== 2D Array ==========");

            //for (int i = 0; i < twoDArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDArray.GetLength(1); j++)
            //    {
            //        Console.Write(twoDArray[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}


            //// ================================================================
            //// LINQ - Grouping
            //// ================================================================

            //var people = new[]
            //{
            //    new { Name = "Hossam", Age = 21 },
            //    new { Name = "Ali", Age = 22 },
            //    new { Name = "Mohamed", Age = 22 },
            //    new { Name = "Salah", Age = 35 },
            //    new { Name = "Ahmed", Age = 21 }
            //};

            //var groupByAge =
            //    people
            //    .GroupBy(p => p.Age)
            //    .Select(group => new
            //    {
            //        Age = group.Key,
            //        People = group.OrderBy(p => p.Name)
            //    });

            //foreach (var group in groupByAge)
            //{
            //    Console.Write(group.Age + ": ");

            //    foreach (var person in group.People)
            //    {
            //        Console.Write(person.Name + " ");
            //    }

            //    Console.WriteLine();
            //}


            //// ================================================================
            //// LINQ - Join
            //// ================================================================

            //var employees = new[]
            //{
            //     new { Id = 1, Name = "Hossam", Department = 1 },
            //     new { Id = 2, Name = "Ali", Department = 2 },
            //     new { Id = 3, Name = "Ahmed", Department = 1 }
            //};

            // var departments = new[]
            // {
            //     new { Id = 1, Name = "IT" },
            //     new { Id = 2, Name = "HR" }
            // };

            //var employeeDetails =
            //    employees.Join(
            //        departments,
            //        e => e.Department,
            //        d => d.Id,
            //        (e, d) => new
            //        {
            //            e.Name,
            //            Department = d.Name
            //        });

            //foreach (var employee in employeeDetails)
            //{
            //    Console.WriteLine(
            //        employee.Name + " : " + employee.Department
            //    );
            //}

            #endregion


            #region Practice

            ///*
            // * ================================================================
            // * Scenario: Employee Management & Analysis
            // * ================================================================
            // *
            // * We have an array containing employees.
            // *
            // * Each employee has:
            // *      ID
            // *      Name
            // *      Age
            // *      DepartmentID
            // *      Salary
            // *
            // */

            //var employees = new[]
            //{
            //    new { ID = 1, Name = "Hossam", Age = 21, DepartmentID = 1, Salary = 6000 },
            //    new { ID = 2, Name = "Ahmed",  Age = 25, DepartmentID = 2, Salary = 4500 },
            //    new { ID = 3, Name = "Ali",    Age = 30, DepartmentID = 1, Salary = 7000 },
            //    new { ID = 4, Name = "Mohamed",Age = 28, DepartmentID = 3, Salary = 5500 },
            //    new { ID = 5, Name = "Omar",   Age = 35, DepartmentID = 2, Salary = 8000 },
            //    new { ID = 6, Name = "Sara",   Age = 22, DepartmentID = 3, Salary = 5000 },
            //    new { ID = 7, Name = "Mona",   Age = 27, DepartmentID = 1, Salary = 6500 },
            //    new { ID = 8, Name = "Nour",   Age = 24, DepartmentID = 2, Salary = 4800 }
            //};


            //var departments = new[]
            //{
            //    new { ID = 1, Name = "IT" },
            //    new { ID = 2, Name = "HR" },
            //    new { ID = 3, Name = "Finance" }
            //};


            ///*
            // * ==================== Basic Array ====================
            // */

            //// Q1:
            //// Print all employees using foreach.
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"{emp.Name} - {emp.Age} - {emp.Salary}");
            //}
            ////
            //// Expected idea:
            //// Hossam - 21 - 6000
            //// Ahmed  - 25 - 4500
            //// ...


            ///*
            // * ==================== Search ====================
            // */

            //// Q2:
            //// Find the employee whose ID is 4
            //// using LINQ.
            //// Print his name and salary.
            //var emp4=employees.First(emp=>emp.ID==4);
            //Console.WriteLine($"{emp4.Name} - {emp4.Salary}");


            //// Q3:
            //// Check whether there is an employee
            //// whose name is "Omar".
            //// Print true or false.
            //if (employees.Any(emp => emp.Name=="Omar"))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            ///*
            // * ==================== Filtering ====================
            // */

            //// Q4:
            //// Find all employees who are older than 25.
            //// Print their names.
            //var EmployeeOlder25 = employees.Where(emp => emp.Age>25);
            //foreach (var emp in EmployeeOlder25)
            //{
            //    Console.WriteLine($"{emp.Name}");
            //}

            //// Q5:
            //// Find all employees whose salary is greater than 5000.
            //// Print their names and salaries.
            //var EmployeeSalary5000 = employees.Where(emp => emp.Salary>5000);
            //foreach (var emp in EmployeeSalary5000)
            //{
            //    Console.WriteLine($"{emp.Name} - {emp.Salary}");
            //}

            ///*
            // * ==================== Select ====================
            // */

            //// Q6:
            //// Create a new sequence containing
            //// only employee names.
            //var EmployeeName = employees.Select(emp => emp.Name);


            ///*
            // * ==================== Sorting ====================
            // */

            //// Q7:
            //// Sort employees by salary
            //// from highest to lowest.
            //// Print their names and salaries.
            //var employeesSort=employees.OrderByDescending(emp => emp.Salary);
            //foreach (var emp in employeesSort)
            //{
            //    Console.WriteLine($"{emp.Name} - {emp.Salary}");
            //}

            ///*
            // * ==================== Aggregation ====================
            // */

            //// Q8:
            //// Calculate the total salary
            //// of all employees.
            //var SumOfSalary=employees.Sum(emp => emp.Salary);

            //// Q9:
            //// Calculate the average salary
            //// of all employees.
            //var AverageOfSalary = employees.Average(emp => emp.Salary);

            //// Q10:
            //// Find the employee with the highest salary.
            //// Print his name and salary.
            //var EmployeeHighest=employees.Where(emp=>emp.Salary==employees.Max(emp1=>emp1.Salary));
            //foreach (var emp in EmployeeHighest)
            //{
            //    Console.WriteLine($"{emp.Name} - {emp.Salary}");
            //}

            ///*
            // * ==================== Multiple LINQ Operations ====================
            // */

            //// Q11:
            //// Find employees who work in DepartmentID = 1,
            //// then sort them by salary descending,
            //// then select only their names.
            ////
            //// Hint:
            //// Where → OrderByDescending → Select
            //var employeeDepartemt1 = employees
            //    .Where(emp => emp.DepartmentID==1)
            //    .OrderByDescending(emp => emp.Salary)
            //    .Select(emp => emp.Name);


            ///*
            // * ==================== Grouping ====================
            // */

            //// Q12:
            //// Group employees by DepartmentID.
            ////
            //// Print:
            ////
            //// Department 1:
            //// Hossam
            //// Ali
            //// Mona
            ////
            //// Department 2:
            //// Ahmed
            //// Omar
            //// Nour
            ////
            //// ...
            //var groupDepartemt = employees.GroupBy(emp => emp.DepartmentID);
            //foreach(var group in groupDepartemt)
            //{
            //    Console.WriteLine($"========this is departemtn of :{group.Key}");
            //    foreach (var emp in group)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }
            //}


            ///*
            // * ==================== Array Operations ====================
            // */

            //// Q13:
            //// Create a copy of the employees array
            //// using Array.Copy().
            ////
            //// Then print the copied array.

            //var copyArray=employees.ToArray();
            //Array.Copy(employees, copyArray, employees.Length);
            //foreach (var emp in copyArray)
            //{
            //    Console.WriteLine($"{emp.Name} - {emp.Salary}");
            //}


            ///*
            // * ==================== 2D Array ====================
            // */

            //// Q14:
            //// Create the following monthly sales array:
            ////
            ////          Jan  Feb  Mar
            //// Product1 100  150  200
            //// Product2 200  250  300
            //// Product3 150  100  250
            ////
            //// Print all values using nested loops.
            ////
            //// Then calculate the total sales
            //// of all products.
            //int[,] MonthlySales = { { 100, 150, 200 }, { 200, 250, 300 }, { 150, 100, 250 } };
            //int sum = 0;
            //for (int i = 0; i < MonthlySales.GetLength(0); i++)
            //{
            //    for (int j = 0; j < MonthlySales.GetLength(1); j++)
            //    {
            //        sum+= MonthlySales[i, j];
            //        Console.Write($"{MonthlySales[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);



            ///*
            // * ==================== JOIN ====================
            // */

            //// Q15:
            //// Join employees with departments
            //// using DepartmentID.
            ////
            //// Print:
            ////
            //// Hossam -> IT
            //// Ahmed  -> HR
            //// Ali    -> IT
            //// Mohamed -> Finance
            ////
            //// Hint:
            //// Join(
            ////     employees,
            ////     departments,
            ////     employee => employee.DepartmentID,
            ////     department => department.ID,
            ////     ...
            //// )
            //var EmployeeDetials = employees.Join(
            //    departments,
            //    e => e.DepartmentID,
            //    d => d.ID,
            //    (e, d) => new { e.Name, DepartmentName = d.Name }
            //    );
            //foreach (var emp in EmployeeDetials) {
            //    Console.WriteLine($"{emp.Name}-> {emp.DepartmentName}");
            //        }

            #endregion

            #region Mistakes

            /*
             * Mistake 1:
             *
             * Array has a FIXED SIZE.
             *
             * int[] numbers = new int[5];
             *
             * You cannot make it contain 6 elements directly.
             *
             *
             * Mistake 2:
             *
             * Array indexing starts from ZERO.
             *
             * numbers[0] → first element
             * numbers[1] → second element
             *
             *
             * Mistake 3:
             *
             * Array.Sort() changes the original array.
             *
             * Array.Sort(numbers);
             *
             *
             * Mistake 4:
             *
             * Array.IndexOf() returns:
             *
             * index → if found
             * -1    → if not found
             *
             *
             * Mistake 5:
             *
             * Length is a property:
             *
             * numbers.Length
             *
             * NOT:
             *
             * numbers.Length()
             *
             *
             * Mistake 6:
             *
             * For a 2D array:
             *
             * GetLength(0) → rows
             * GetLength(1) → columns
             *
             *
             * Mistake 7:
             *
             * Array is different from List<T>.
             *
             * Array:
             *      Fixed size
             *
             * List<T>:
             *      Dynamic size
             */

            #endregion

            #endregion


            #region Lesson - BitArray

            /*
             * ==================== What is BitArray? ====================
             *
             * - BitArray is a collection used to work with bits.
             * - It is located in System.Collections namespace.
             * - It is Non-Generic.
             * - Each element represents a Boolean value:
             *
             *      true  → 1
             *      false → 0
             *
             * - It is useful when dealing with binary data,
             *   bitwise operations, or when we need a compact
             *   representation of Boolean values.
             *
             *
             * ==================== Why use BitArray? ====================
             *
             * - Store a collection of true/false values.
             * - Perform bitwise operations easily.
             * - AND
             * - OR
             * - XOR
             * - NOT
             *
             *
             * ==================== Important Characteristics ====================
             *
             * - Non-Generic
             * - Namespace: System.Collections
             * - Indexed collection
             * - Zero-based index
             * - Has Length
             * - Values can be changed
             * - Works with bitwise operations
             *
             *
             * ==================== Think ====================
             *
             * BitArray
             *     ↓
             * Collection of bits
             *     ↓
             * true / false
             *     ↓
             * 1 / 0
             *     ↓
             * AND / OR / XOR / NOT
             *
             */

            #region Coding

            //// ============================================================
            //// Create BitArray with 10 bits
            //// ============================================================

            //// BitArray(int length)
            //// Creates a BitArray with the specified number of bits.
            //// By default, all bits are false.

            ////create bitarray with 10 
            //BitArray bitArray = new BitArray(10);
            //Console.WriteLine("bitArray content:"+BitArrayToString(bitArray));

            //for (int i = 0; i<bitArray.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray[i]}");
            //}


            //// ============================================================
            //// Create BitArray from bool array
            //// ============================================================

            ////create bitarray form an array of booleans
            //bool[] bools = { true, false, true, false, false };
            //BitArray bitArray2 = new BitArray(bools);

            //Console.WriteLine("\nbitArray2 content:"+BitArrayToString(bitArray2));

            //for (int i = 0; i<bitArray2.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray2[i]}");
            //}


            //// ============================================================
            //// Create BitArray from byte array
            //// ============================================================

            ////create bitarray form byte array
            //byte[] byteArray = { 0x11, 012, 0x21 };
            //BitArray bitArray1 = new BitArray(byteArray);

            //Console.WriteLine("\nbitArray1 content:"+BitArrayToString(bitArray1));

            //for (int i = 0; i<bitArray1.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray1[i]}");
            //}


            //// ============================================================
            //// Basic Operations - Set specific bits
            //// ============================================================

            ////Basic operatioina
            ////create bitArray with 8
            ////set bits 3, 4, 5, 7 to true
            ////print

            //BitArray bitArray3 = new BitArray(8);

            //bitArray3.Set(3, true);
            //bitArray3.Set(4, true);
            //bitArray3[7]=true;
            //bitArray3[5]=true;

            //Console.WriteLine("\nbitArray3 content:"+BitArrayToString(bitArray3));

            //for (int i = 0; i<bitArray3.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray3[i]}");
            //}


            //// ============================================================
            //// SetAll(true)
            //// ============================================================

            ////set all true print

            //bitArray3.SetAll(true);

            //Console.WriteLine("\nbitArray3 content:"+BitArrayToString(bitArray3));

            //for (int i = 0; i<bitArray3.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray3[i]}");
            //}


            //// ============================================================
            //// SetAll(false)
            //// ============================================================

            ////set all false print

            //bitArray3.SetAll(false);

            //Console.WriteLine("\nbitArray3 content:"+BitArrayToString(bitArray3));

            //for (int i = 0; i<bitArray3.Length; i++)
            //{
            //    Console.WriteLine($"bit at index{i}:{bitArray3[i]}");
            //}


            //// ============================================================
            //// Get value and Length
            //// ============================================================

            ////get value get length

            //bool getValue = bitArray3[2];

            //Console.WriteLine($"the value {getValue}");
            //Console.WriteLine($"the length {bitArray3.Length}");


            //// ============================================================
            //// Create Two BitArrays
            //// ============================================================

            //BitArray bitArray4 = new BitArray(
            //    new bool[] { true, false, false, true });

            //BitArray bitArray5 = new BitArray(
            //    new bool[] { true, false, true, false });


            //// ============================================================
            //// Print BitArrays
            //// ============================================================

            ////printe 

            //Console.WriteLine(
            //    "\nbitArray4 content:" + BitArrayToString(bitArray4));

            //Console.WriteLine(
            //    "\nbitArray5 content:" + BitArrayToString(bitArray5));


            //// ============================================================
            //// Bitwise AND Operation
            //// ============================================================

            ///*
            // * AND:
            // *
            // * true  AND true  = true
            // * true  AND false = false
            // * false AND true  = false
            // * false AND false = false
            // *
            // * Example:
            // *
            // * 1001
            // * 1010
            // * ----
            // * 1000
            // */

            ////bitwise and operation

            //BitArray bitAndResult = new BitArray(bitArray4);

            //bitAndResult.And(bitArray5);

            //Console.WriteLine("\nbit and operaion");

            //Console.WriteLine(BitArrayToString(bitArray4));
            //Console.WriteLine(BitArrayToString(bitArray5));

            //Console.WriteLine("---------------------------------");

            //Console.WriteLine(BitArrayToString(bitAndResult));


            //// ============================================================
            //// Bitwise OR Operation
            //// ============================================================

            ///*
            // * OR:
            // *
            // * false OR false = false
            // * true  OR false = true
            // * false OR true  = true
            // * true  OR true  = true
            // *
            // * Example:
            // *
            // * 1001
            // * 1010
            // * ----
            // * 1011
            // */

            ////bitwise or operaion

            //Console.WriteLine("\nbit or operaion");

            //BitArray bitOrResult = new BitArray(bitArray4);

            //bitOrResult.Or(bitArray5);

            //Console.WriteLine(BitArrayToString(bitArray4));
            //Console.WriteLine(BitArrayToString(bitArray5));

            //Console.WriteLine("---------------------------------");

            //Console.WriteLine(BitArrayToString(bitOrResult));


            //// ============================================================
            //// Bitwise NOT Operation
            //// ============================================================

            ///*
            // * NOT:
            // *
            // * true  → false
            // * false → true
            // *
            // * Example:
            // *
            // * 1001
            // * ----
            // * 0110
            // */

            ////bitwise not operaion

            //Console.WriteLine("\nbit not operaion");

            //BitArray bitNotResult = new BitArray(bitArray4);

            //bitNotResult.Not();

            //Console.WriteLine(BitArrayToString(bitArray4));

            //Console.WriteLine("---------------------------------");

            //Console.WriteLine(BitArrayToString(bitNotResult));


            //// ============================================================
            //// Bitwise XOR Operation
            //// ============================================================

            ///*
            // * XOR:
            // *
            // * Same values     → false
            // * Different values → true
            // *
            // * Example:
            // *
            // * 1001
            // * 1010
            // * ----
            // * 0011
            // */

            ////bitwise xor operaion

            //Console.WriteLine("\nbit xor operaion");

            //BitArray bitXorResult = new BitArray(bitArray4);

            //bitXorResult.Xor(bitArray5);

            //Console.WriteLine(BitArrayToString(bitArray4));
            //Console.WriteLine(BitArrayToString(bitArray5));

            //Console.WriteLine("---------------------------------");

            //Console.WriteLine(BitArrayToString(bitXorResult));


           

            #endregion


            #region Practice

            ///*
            // * ==================== BitArray Practice ====================
            // *
            // * Scenario:
            // *
            // * You are developing a simple Permission System.
            // *
            // * Each employee has 8 permissions.
            // *
            // * Index:
            // *
            // * 0 → Read
            // * 1 → Write
            // * 2 → Delete
            // * 3 → Update
            // * 4 → Print
            // * 5 → Export
            // * 6 → Import
            // * 7 → Admin
            // *
            // */
           

            //// Q1:
            //// Create a BitArray called permissions with 8 bits.
            //BitArray Permissions=new BitArray(8);
            //// Print all permissions.
            //foreach (bool perso in Permissions)
            //{
            //    Console.WriteLine(perso);
            //}

            //// Q2:
            //// Set Read, Write, and Update permissions to true.
            //Permissions.Set((int)EnPersmission.Read, true);
            //Permissions.Set((int)EnPersmission.Write, true);
            //Permissions.Set((int)EnPersmission.update, true);

            //// Print the BitArray.
            //Console.WriteLine("Bit Array after update som permision");
            //foreach (bool perso in Permissions)
            //{
            //    Console.WriteLine(perso);
            //}


            //// Q3:
            //// Check whether the Delete permission is enabled.
            //// Print the result.
            //if (Permissions[(int)EnPersmission.Delete])
            //{
            //    Console.WriteLine("the Permission is Enabled");
            //}
            //else
            //{
            //    Console.WriteLine("the Permission not Enabled");
            //}


            //// Q4:
            //// Enable the Delete permission using Set().
            //// Print the BitArray.
            //Permissions.Set((int)EnPersmission.Delete, true);
            //foreach (bool perso in Permissions)
            //{
            //    Console.WriteLine(perso);
            //}

            //// Q5:
            //// Disable the Write permission using the indexer.
            //// Print the BitArray.
            //Permissions[(int)EnPersmission.Write] = false;
            //foreach (bool perso in Permissions)
            //{
            //    Console.WriteLine(perso);
            //}

            //// Q6:
            //// Set all permissions to true.
            //// Print the BitArray.
            //Permissions.SetAll(true);
            //for (int i = 0; i< Permissions.Count; i++)
            //{
            //    Console.WriteLine(Permissions[i]);
            //}


            //// Q7:
            //// Set all permissions to false.
            //// Print the BitArray.
            //Permissions.SetAll(false);
            //for (int i = 0; i< Permissions.Count; i++)
            //{
            //    Console.WriteLine(Permissions[i]);
            //}



            //// Q8:
            //// Create two BitArrays representing permissions
            //// for Employee A and Employee B.
            ////
            //// Employee A:
            //// { true, true, false, true, false, true, false, false }
            //BitArray EmployeeA=new BitArray(new[] { true, true, false, true, false, true, false, false });
            ////
            //// Employee B:
            //// { true, false, true, true, false, false, true, false }
            //BitArray EmployeeB = new BitArray(new[] { true, false, true, true, false, false, true, false });
            ////
            //// Perform AND and print the result.
            //Console.WriteLine(BitArrayToString(EmployeeA));
            //Console.WriteLine(BitArrayToString(EmployeeB));
            //Console.WriteLine("_______________________________");
            //BitArray BitAndResult=new BitArray(EmployeeA);
            //BitAndResult.And(EmployeeB);
            //Console.WriteLine(BitArrayToString(BitAndResult));



            //// Q9:
            //// Using the same two employees,
            //// perform OR and print the result.
            //Console.WriteLine(BitArrayToString(EmployeeA));
            //Console.WriteLine(BitArrayToString(EmployeeB));
            //Console.WriteLine("_______________________________");
            //BitArray BitOrResult = new BitArray(EmployeeA);
            //BitOrResult.Or(EmployeeB);
            //Console.WriteLine(BitArrayToString(BitOrResult));

            //// Q10:
            //// Using the same two employees,
            //// perform XOR and print the result.
            //Console.WriteLine(BitArrayToString(EmployeeA));
            //Console.WriteLine(BitArrayToString(EmployeeB));
            //Console.WriteLine("_______________________________");
            //BitArray BitXORResult = new BitArray(EmployeeA);
            //BitXORResult.Xor(EmployeeB);
            //Console.WriteLine(BitArrayToString(BitXORResult));


            //// Q11:
            //// Create a copy of Employee A permissions.
            //// Apply NOT to the copy.
            //// Print the original and the result.
            //Console.WriteLine(BitArrayToString(EmployeeA));
           
            //Console.WriteLine("_______________________________");
            //BitArray BitNotResult = new BitArray(EmployeeA);
            //BitNotResult.Not();
            //Console.WriteLine(BitArrayToString(BitNotResult));


            //// Q12:
            //// Create a BitArray with 10 bits.
            //// Set indexes 1, 3, 5, 7, and 9 to true.
            //// Print the result.
            //BitArray bitArray = new BitArray(10);
            //bitArray[1]=true; bitArray[3]=true; bitArray[5]=true; bitArray[7]=true; bitArray[9]=true;
            //for (int i = 0; i< bitArray.Count; i++)
            //{
            //    Console.WriteLine(Permissions[i]);
            //}


            //// Q13:
            //// Count how many true values exist
            //// in the following BitArray:
            ////
            //// { true, false, true, true, false, false, true, false }
            //BitArray bitArray2 = new BitArray(new[] { true, false, true, true, false, false, true, false });
            //byte TruValueCount = 0;
            //for (int i = 0; i< bitArray2.Count; i++)
            //{
            //    if (bitArray2[i]==true)
            //    {
            //        TruValueCount++;
            //    }
            //}

            ////
            //// Hint:
            //// Use a loop.


            //// Q14:
            //// Create two BitArrays:
            ////
            //// Department A permissions
            //// Department B permissions
            ////
            
            //BitArray DepartmentA = new BitArray(new[] { true, true, false, true, false, true, false, false });
            
            //BitArray DepartmentB = new BitArray(new[] { true, false, true, true, false, false, true, false });
            
            //Console.WriteLine(BitArrayToString(DepartmentA));
            //Console.WriteLine(BitArrayToString(DepartmentB));
            //Console.WriteLine("_______________________________");
            //BitArray PermissionEnTwoDepartment = new BitArray(DepartmentA);
            //PermissionEnTwoDepartment.And(DepartmentB);
            //Console.WriteLine(BitArrayToString(PermissionEnTwoDepartment));
            //for(int i = 0; i<PermissionEnTwoDepartment.Count; i++)
            //{
            //    if (PermissionEnTwoDepartment[i])
            //    {
            //        Console.WriteLine((EnPersmission)i);
            //    }
            //}


            //// Q15:
            //// Create a simple Employee Permission System:
            ////
            //// 8 permissions:
            ////
            //// 0 → Read
            //// 1 → Write
            //// 2 → Delete
            //// 3 → Update
            //// 4 → Print
            //// 5 → Export
            //// 6 → Import
            //// 7 → Admin
            ////
            //// Create permissions for an employee.
            //// Enable at least 4 permissions.
            ////
            //// Then:
            //// - Print all permissions.
            //// - Check Admin permission.
            //// - Enable Admin.
            //// - Disable one permission.
            //// - Print the final permissions.
            //BitArray Permissions2 = new BitArray(new[]{ true,false,true,false,true,false,true,false});
            //for(int i = 0; i<Permissions2.Count; i++)
            //{
            //    Console.WriteLine(Permissions2[i]);
            //}

            //if (Permissions2[(int)EnPersmission.admin])
            //{
            //    Console.WriteLine("is Enable");
            //}
            //else
            //{
                
            //    Permissions2[(int)EnPersmission.admin] = true;
            //    Permissions2[0]=false;

            //}
            //for (int i = 0; i<Permissions2.Count; i++)
            //{
            //    Console.WriteLine(Permissions2[i]);
            //}


            #endregion


            #region Mistakes

            /*
             * Mistake 1:
             *
             * BitArray is NOT generic.
             *
             * It belongs to:
             * System.Collections
             */


            /*
             * Mistake 2:
             *
             * BitArray uses bool values:
             *
             * true / false
             *
             * We commonly represent them conceptually as:
             *
             * true  → 1
             * false → 0
             */


            /*
             * Mistake 3:
             *
             * AND, OR, XOR and NOT modify
             * the BitArray that calls the operation.
             *
             * Example:
             *
             * bitArray4.And(bitArray5);
             *
             * bitArray4 is changed.
             *
             *
             * Therefore, if you want to keep the original:
             *
             * BitArray result = new BitArray(bitArray4);
             * result.And(bitArray5);
             */


            /*
             * Mistake 4:
             *
             * Index starts from 0.
             *
             * Example:
             *
             * BitArray(8)
             *
             * indexes:
             *
             * 0 1 2 3 4 5 6 7
             */


            /*
             * Mistake 5:
             *
             * NOT reverses every bit:
             *
             * true  → false
             * false → true
             */


            /*
             * Mistake 6:
             *
             * XOR returns true only when
             * the two bits are different.
             *
             * true  XOR false → true
             * false XOR true  → true
             * true  XOR true  → false
             * false XOR false → false
             */

            #endregion

            #endregion
            /*
             * is array of arrays with diffrent lenth
             * */

            //declaration and initialization
            int[][] JaggedArray=new int[3][];
            JaggedArray[0]=new int[] {2,3,4,42,43};
            JaggedArray[1]=new int[] {1,2};
            JaggedArray[2]=new int[] {4,5,5,34,322,64,45};

            for (int i = 0; i<JaggedArray.Length; i++)
            {
                Console.Write("[");
                for(int j = 0; j<JaggedArray[i].Length; j++)
                {
                    Console.Write(JaggedArray[i][j]+"\t" );
                }
                Console.WriteLine("]");
            }

        }
        static string BitArrayToString(BitArray bitArray)
        {
            char[] chars = new char[bitArray.Length];
            for (int i = 0; i< bitArray.Length; i++)
            {
                chars[i]=bitArray[i] ? '1' : '0';
            }
            return new string(chars);
        }
        static void print(object sender, NotifyCollectionChangedEventArgs e) {
           Console.WriteLine("====================Collection Change:======================");
            switch (e.Action)
            {
                
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("======new Items Add:======");
                    foreach (string item in e.NewItems)
                    {
                        Console.WriteLine($"{item}");
                    }
                    break;


                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("====== items remove ===========");
                    foreach(string item in e.OldItems)
                    {
                        Console.WriteLine($"{item}");
                    }
                    break;


                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("=========item Replace=========");

                    Console.Write("old:");
                    foreach (string item in e.OldItems)
                    {
                        Console.WriteLine($"{item}");
                    }

                    Console.Write("new:");
                    foreach( string item in e.NewItems)
                    {
                        Console.WriteLine($"{item}");
                    }

                    break;

                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine("========= Item Change Index =========");
                    Console.WriteLine(
                        $"Item: {e.NewItems[0]}"
                    );
                    Console.WriteLine($"item change indext from {e.OldStartingIndex} to {e.NewStartingIndex}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    
                    Console.WriteLine("========= Collection Reset =========");
                    Console.WriteLine("The collection has been reset.");
                    break;


            }
        }
    }

       public class Employee
       {
           public string name { get; set; }
           public string department { get; set; }
           public int salary { get; set; }
           public Employee(string name, string department, int salary)
           {
               this.name=name;
               this.department=department;
               this.salary=salary;
           }
       };
       public class Person
       {
           public string Name { get; set; }
           public int Age { get; set; }
           public Person(string name, int age)
           {
               Name = name;
               Age = age;
           }
       };
 }
