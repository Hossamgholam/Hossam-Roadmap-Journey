using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_ICollection
{
    public class MyCustomCollection<T> : IEnumerable<T>, ICollection<T>
    {
        private List<T> item = new List<T>();


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i<item.Count; i++)
            {
                yield return item[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T value)
        {
            item.Add(value);
        }


        public int Count => item.Count;

        public bool IsReadOnly => false;

        public void Clear()
        {
            item.Clear();
        }

        public bool Contains(T ite)
        {
            return item.Contains(ite);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            item.CopyTo(array, arrayIndex);
        }

        public bool Remove(T ite)
        {
            return item.Remove(ite);
        }
        public bool RemoveAt(int Index)
        {
            return Remove(item[Index]);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson 21 - IEnumerable

            /*
             * ==================== What is IEnumerable? ====================
             *
             * IEnumerable is the base interface for collections
             * that provides support for simple iteration.
             *
             * It defines one main method:
             *
             * GetEnumerator()
             *
             * GetEnumerator() returns an IEnumerator.
             *
             * IEnumerator is responsible for controlling the iteration
             * using:
             *
             * - MoveNext()
             * - Current
             * - Reset()
             *
             *
             * ==================== Why use IEnumerable? ====================
             *
             * The best practice is to use IEnumerable when:
             *
             * - You need to read/iterate over a collection.
             * - You do not need to modify the collection.
             *
             *
             * This makes your method less dependent on a specific
             * collection type.
             *
             *
             * ==================== How does it work? ====================
             *
             * Collection
             *      ↓
             * IEnumerable
             *      ↓
             * GetEnumerator()
             *      ↓
             * IEnumerator
             *      ↓
             * ┌──────────────┐
             * │ MoveNext()   │ → Move to next item
             * │ Current      │ → Get current item
             * │ Reset()      │ → Return to beginning
             * └──────────────┘
             *
             *
             * ==================== foreach ====================
             *
             * When we write:
             *
             * foreach (var item in collection)
             *
             * C# uses the collection's enumeration mechanism
             * to move through its elements.
             *
             *
             * ==================== Important Idea ====================
             *
             * IEnumerable
             *      ↓
             * "I can give you an enumerator."
             *
             * IEnumerator
             *      ↓
             * "I know how to move through the collection
             *  and give you the current item."
             *
             */

            #region Coding

            //// ======================================================
            //// Custom Collection
            //// ======================================================

            ///*
            //MyCustomCollection<int> m = new MyCustomCollection<int>();

            //m.Add(1);
            //m.Add(2);
            //m.Add(3);


            //// MyCustomCollection implements IEnumerable,
            //// so we can use foreach to iterate over it.
            ////
            //// If we want to use a for loop,
            //// we should implement IList interface
            //// to get Count property and indexer.

            //for (int i = 0; i < m.Count(); i++)
            //{
            //    Console.WriteLine(m[i]);
            //}


            //foreach (var item in m)
            //{
            //    Console.WriteLine(item);
            //}
            //*/


            //// ======================================================
            //// Simple IEnumerable Example
            //// ======================================================

            //List<int> numbers = new List<int>
            //{
            //    10,
            //    20,
            //    30,
            //    40
            //};

            //IEnumerable<int> enumerableNumbers = numbers;

            //foreach (var number in enumerableNumbers)
            //{
            //    Console.WriteLine(number);
            //}


            //// ======================================================
            //// Get Enumerator Manually
            //// ======================================================

            //IEnumerator<int> enumerator =
            //    enumerableNumbers.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


            //// ======================================================
            //// IEnumerable with a Method
            //// ======================================================

            //// The method only needs to read the collection,
            //// so IEnumerable is suitable here.

            // void PrintNumbers(IEnumerable<int> number)
            //{
            //    foreach (var n in number)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}


            //// The method can receive different collections.

            //List<int> listNumbers = new List<int>
            //{
            //    1, 2, 3
            //};

            //HashSet<int> setNumbers = new HashSet<int>
            //{
            //    4, 5, 6
            //};

            //PrintNumbers(listNumbers);
            //PrintNumbers(setNumbers);

            #endregion
            #region Think

            /*
             *
             * Why not simply use List<int>?
             *
             * Because the method does not need List-specific features.
             *
             *
             * If the method only needs:
             *
             *     foreach
             *
             * then:
             *
             *     IEnumerable<int>
             *
             * is enough.
             *
             *
             * Example:
             *
             * static void PrintProducts(IEnumerable<Product> products)
             *
             *
             * The method can receive:
             *
             * List<Product>
             * HashSet<Product>
             * other IEnumerable<Product> collections
             *
             *
             * The method only cares about:
             *
             * "Can I iterate through these products?"
             *
             */

            #endregion
            #region IEnumerable vs IList

            /*
             *
             * IEnumerable<T>
             *      ↓
             * Mainly for reading / iteration.
             *
             *      foreach
             *
             *
             * IList<T>
             *      ↓
             * Gives additional capabilities.
             *
             *      Index
             *      Add
             *      Remove
             *      Insert
             *      Count
             *
             *
             * Example:
             *
             * IEnumerable<int> numbers
             *
             * You can:
             *
             * foreach (var number in numbers)
             *
             *
             * But you cannot directly do:
             *
             * numbers.Add(100);
             *
             *
             * Because IEnumerable does not provide Add().
             *
             */

            #endregion


            #region Practice

            ///*
            // * ==================== IEnumerable Practice ====================
            // *
            // * 10 Real-Life Practice Questions
            // *
            // * Focus:
            // * - IEnumerable
            // * - GetEnumerator
            // * - foreach
            // * - Reading collections
            // * - Passing different collections to one method
            // *
            // */


            //// Q1:
            //// Imagine you have a list of customer names.
            ////
            //// Create:
            //// List<string> customers
            ////
            //// Add 5 customer names.
            ////
            //// Create a method:
            //// PrintCustomers(IEnumerable<string> customers)
            ////
            //// Print all customers using foreach.
            //Console.WriteLine("==========questiion 1=========="); 
            //void PrintCustomers(IEnumerable<string> customers)
            //{
            //    foreach(string customer in customers)
            //    {
            //        Console.Write(customer+",");
            //    }
            //}
            //List<string> strings = new List<string>() { "Hossam", "Ali", "Tareq", "osame", "Abdoullah" };
            //PrintCustomers(strings);
            //Console.WriteLine();

            //// Q2:
            //// Imagine you have a list of product prices.
            ////
            //// Create:
            //// List<double> prices
            ////
            //// Pass it to:
            //// PrintPrices(IEnumerable<double> prices)
            ////
            //// Print every price.
            //Console.WriteLine("==========questiion 1==========");
            //void PrintPrices(IEnumerable<double> prices)
            //{
            //    foreach(double price in prices)
            //    {
            //        Console.Write(price+",");
            //    }
            //}
            //List<double> doubles = new List<double>() { 200, 30000, 493, 2323 };
            //PrintPrices(doubles);
            //Console.WriteLine();


            ///*
            // * Q3:
            // * A store has a HashSet<string> containing
            // * product categories.
            // *
            // * Create at least 5 categories.
            // *
            // * Write a method:
            // *
            // * PrintCategories(IEnumerable<string> categories)
            // *
            // * Print all categories.
            // *
            // * Notice that the method works with HashSet<string>
            // * even though it was not specifically designed
            // * for HashSet.
            // */
            //Console.WriteLine("==========questiion 3==========");
            //void PrintCategories(IEnumerable<string> categories)
            //{
            //    foreach (string category in categories)
            //    {
            //        Console.Write(category+",");
            //    }
            //}
            //HashSet<string> strings1 = new HashSet<string>() { "Electronics", "Clothing", "Books", "Toys", "Furniture" };
            //PrintCategories(strings1);
            //Console.WriteLine();



            //// Q4:
            //// A school has a List<int> containing
            //// student grades.
            ////
            //// Write a method:
            ////
            //// PrintGrades(IEnumerable<int> grades)
            ////
            //// Print all grades.
            ////
            //// The method should NOT modify the collection.
            //Console.WriteLine("==========questiion 4==========");
            //void PrintGrades(IEnumerable<int> grades)
            //{
            //    foreach (int grade in grades)
            //    {
            //        Console.Write(grade+",");
            //    }
            //}
            //List<int> ints = new List<int>() { 88,77,79,90,80 };
            //PrintGrades(ints);
            //Console.WriteLine();


            //// Q5:
            //// A company has a list of employee salaries.
            ////
            //// Write a method:
            ////
            //// PrintHighSalaries(IEnumerable<double> salaries)
            ////
            //// Inside the method, use foreach to print
            //// only salaries greater than 10000.
            //Console.WriteLine("==========questiion 5==========");
            //void PrintHighSalaries(IEnumerable<double> salaries)
            //{
            //    foreach(int salar in salaries)
            //    {
            //        if (salar>10000)
            //        {

            //        Console.Write(salar+",");
            //        }
            //    }
            //}
            //List<double> ints1 = new List<double>() { 10000, 9000, 15000, 3000, 20000 };
            //PrintHighSalaries(ints1);
            //Console.WriteLine();

            ///*
            // * Q6:
            // * A hospital has a list of patient names.
            // *
            // * Write a method:
            // *
            // * PrintPatients(IEnumerable<string> patients)
            // *
            // * Print each patient with a number:
            // *
            // * Patient 1: Ali
            // * Patient 2: Ahmed
            // * ...
            // *
            // * Use foreach.
            // */
            //Console.WriteLine("==========questiion 6==========");
            //void PrintPatients(IEnumerable<string> patients)
            //{
            //    int NumberOfPatient = 0;
            //    foreach (string patient in patients)
            //    {
            //        NumberOfPatient++;
            //        Console.WriteLine($"patient {NumberOfPatient}:{patient}");
            //    }
            //}
            //List<string> strings2= new List<string>() { "Ali", "Ahmed", "Sara", "Mona" };
            //PrintPatients(strings2);
            //Console.WriteLine();


            //// Q7:
            //// A restaurant has a HashSet<string>
            //// containing unique meal names.
            ////
            //// Write a method:
            ////
            //// PrintMeals(IEnumerable<string> meals)
            ////
            //// Print all meals.
            ////
            //// Call the method using the HashSet.
            //Console.WriteLine("==========questiion 7==========");
            //void PrintMeals(IEnumerable<string> meals)
            //{
            //    foreach (string meal in meals)
            //    {
            //        Console.Write(meal+",");
            //    }
            //}
            //HashSet<string> names = new HashSet<string>() { "Pizza", "Burger", "Pasta","Salad" };
            //PrintMeals(names);
            //Console.WriteLine();


            ///*
            // * Q8:
            // * An online store has:
            // *
            // * List<int> orderIds
            // *
            // * Write:
            // *
            // * PrintOrders(IEnumerable<int> orderIds)
            // *
            // * The method should print:
            // *
            // * Order ID: 101
            // * Order ID: 102
            // * ...
            // *
            // * Then call the same method using
            // * a List<int> and a HashSet<int>.
            // */
            //Console.WriteLine("==========questiion 8==========");
            //void PrintOrders(IEnumerable<int> orderIds)
            //{

            //    foreach(int id in orderIds)
            //    {
            //        Console.Write($"Order ID:{id} ,");
            //    }
            //}
            //List<int> ints2 = new List<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int>ints3 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //PrintOrders(ints2);
            //Console.WriteLine();
            //PrintOrders(ints3);
            //Console.WriteLine();

            //// Q9:
            //// A company wants a reusable method:
            ////
            //// CountItems(IEnumerable<string> items)
            ////
            //// The method should count how many items
            //// exist using foreach.
            ////
            //// Test it with:
            //// 1. List<string>
            //// 2. HashSet<string>
            ////
            //// Think:
            //// Why can the same method work with both?
            //Console.WriteLine("==========questiion 9==========");
            //int CountItems(IEnumerable<string> items)
            //{
            //    int count = 0;
            //    foreach(string item in items)
            //    {
            //        count++;
            //    }
            //    return count;
            //}
            //HashSet<string> strings3 = new HashSet<string>() { "Electronics", "Clothing", "Books", "Toys", "Furniture" };
            //List<string> strings4 = new List<string>() { "Electronics", "Clothing", "Books"};
            //Console.WriteLine($"the count of string 3{CountItems(strings3)}");
            //Console.WriteLine($"the count of string 4{CountItems(strings4)}");

            ///*
            // * Q10:
            // * Real-world scenario:
            // *
            // * You have two collections of employee names:
            // *
            // * List<string> employees
            // * HashSet<string> uniqueEmployees
            // *
            // * Create ONE method:
            // *
            // * PrintEmployeeNames(IEnumerable<string> employees)
            // *
            // * The method should:
            // *
            // * 1. Print all employee names.
            // * 2. Count the employees using foreach.
            // *
            // * Call the same method with both collections.
            // *
            // * Question:
            // *
            // * Why is IEnumerable a good choice
            // * for this method?
            // */
            //Console.WriteLine("==========questiion 10==========");
            //int  PrintEmployeeNames(IEnumerable<string> employees)
            //{
            //    int count = 0;
            //    foreach (string employee in employees)
            //    {
            //        count++;
            //        Console.Write(employee+',');
            //    }
            //    return count;
            //}
            //List<string> employe1=new List<string>() { "Hossam", "Ali", "Tareq", "osame", "Abdoullah" };

            //HashSet<string> uniqueEmployees= new HashSet<string>() { "ahmed" , "sara" , "omar" , "layla" , "karim" };
            //int count1 = PrintEmployeeNames(employe1);
            //Console.WriteLine();
            //Console.WriteLine("the number of employe1 is "+count1); 
            //int count2 = PrintEmployeeNames(uniqueEmployees);
            //Console.WriteLine();
            //Console.WriteLine("the number of uniqueEmployees is "+count2);
            #endregion


            #region Mistakes

            /*
             * ==================== Common Mistakes ====================
             *
             *
             * Mistake 1:
             *
             * Thinking IEnumerable is a collection itself.
             *
             * IEnumerable is an interface/contract.
             *
             *
             *
             * Mistake 2:
             *
             * Expecting Add(), Remove(), or an indexer
             * from IEnumerable.
             *
             * IEnumerable is mainly concerned with iteration.
             *
             *
             *
             * Mistake 3:
             *
             * Using a concrete type unnecessarily.
             *
             * Instead of:
             *
             * static void Print(List<int> numbers)
             *
             * Prefer:
             *
             * static void Print(IEnumerable<int> numbers)
             *
             * when the method only needs to read/iterate.
             *
             *
             *
             * Mistake 4:
             *
             * Confusing IEnumerable with IEnumerator.
             *
             *
             * IEnumerable
             *      ↓
             * Provides GetEnumerator()
             *
             *
             * IEnumerator
             *      ↓
             * Controls the iteration
             *
             *      MoveNext()
             *      Current
             *      Reset()
             *
             *
             *
             * Mistake 5:
             *
             * Thinking foreach directly accesses the collection
             * without an enumerator.
             *
             * foreach uses the enumeration mechanism
             * to move through the elements.
             *
             */

            #endregion

            #endregion

            #region Lesson 22 - ICollection<T>

            /*
             * ==================== What is ICollection<T>? ====================
             *
             * ICollection<T> is an interface that provides a general-purpose
             * way to work with collections.
             *
             * It defines basic operations such as:
             *
             * - Add
             * - Remove
             * - Clear
             * - Contains
             * - Count
             * - CopyTo
             * - IsReadOnly
             *
             *
             * ==================== Namespace ====================
             *
             * ICollection
             *      ↓
             * System.Collections
             *
             *
             * ICollection<T>
             *      ↓
             * System.Collections.Generic
             *
             *
             * ==================== Why use ICollection<T>? ====================
             *
             * Use ICollection<T> when you need a collection that supports
             * basic collection operations such as adding and removing items.
             *
             *
             * It is more powerful than IEnumerable<T> because:
             *
             * IEnumerable<T>
             *      ↓
             * Mainly iteration
             *
             *
             * ICollection<T>
             *      ↓
             * Iteration + basic collection operations
             *
             *
             * ==================== Main Idea ====================
             *
             * ICollection<T> is a contract.
             *
             * It says:
             *
             * "Any class that implements me must provide
             * these operations."
             *
             *
             * Your class:
             *
             * MyCustomCollection<T>
             *          ↓
             * implements
             *          ↓
             * ICollection<T>
             *          ↓
             * therefore it MUST implement
             *          ↓
             * Add()
             * Remove()
             * Clear()
             * Contains()
             * Count
             * IsReadOnly
             * CopyTo()
             *
             *
             * ==================== Think ====================
             *
             * ICollection<T>
             *       ↓
             *      Contract
             *       ↓
             * Defines WHAT a collection must provide
             *
             * MyCustomCollection<T>
             *       ↓
             * Implementation
             *       ↓
             * Defines HOW those operations actually work
             *
             */

            #region Coding

            //// ======================================================
            //// Using MyCustomCollection
            //// ======================================================

            //MyCustomCollection<string> strings =
            //    new MyCustomCollection<string>();

            //strings.Add("Hossam");
            //strings.Add("Ali");
            //strings.Add("Ahmed");


            //// ======================================================
            //// Count
            //// ======================================================

            //Console.WriteLine(
            //    $"The count of elements: {strings.Count}");


            //// ======================================================
            //// Contains + Remove
            //// ======================================================

            //if (strings.Contains("Hossam"))
            //{
            //    strings.Remove("Hossam");

            //    Console.WriteLine("Item removed");
            //}
            //else
            //{
            //    Console.WriteLine("Not exist");
            //}


            //// ======================================================
            //// RemoveAt
            //// ======================================================

            //// RemoveAt is NOT part of ICollection<T>.
            //// We added it ourselves to MyCustomCollection<T>.

            //strings.RemoveAt(0);


            //// ======================================================
            //// Iterate through the collection
            //// ======================================================

            //Console.WriteLine("=========== Elements ===========");

            //foreach (string item in strings)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion











            #region Practice

            ///*
            // * ==================== ICollection<T> Practice ====================
            // *
            // * 10 Real-Life Practice Questions
            // *
            // * Difficulty: Medium
            // *
            // * Focus on:
            // * - ICollection<T> as a contract
            // * - IEnumerable<T> relationship
            // * - MyCustomCollection<T>
            // * - Writing reusable methods
            // * - Different collection implementations
            // * - Count / Contains / Remove / CopyTo
            // * - Understanding what belongs to the interface
            // *
            // */


            //// ======================================================
            //// Q1 - Employee Management
            //// ======================================================

            ///*
            // * Create:
            // *
            // * MyCustomCollection<string> employees
            // *
            // * Add 6 employee names.
            // *
            // * Create a method:
            // *
            // * PrintCollection(ICollection<string> employees)
            // *
            // * Inside the method:
            // * - Print Count.
            // * - Print all employees using foreach.
            // *
            // * Call the method using your custom collection.
            // *
            // * Think:
            // * Why can ICollection<string> be used as
            // * the parameter instead of MyCustomCollection<string>?
            // */
            //Console.WriteLine("==========questiion 1==========");
            //   MyCustomCollection<string> employees= new MyCustomCollection<string>();
            //   employees.Add("Hossam");
            //   employees.Add("Ali");
            //   employees.Add("Ahmed");
            //   employees.Add("Sana");
            //   employees.Add("Handa");


            //   void PrintCollection(ICollection<string> Employees)
            //   {
            //       int count = 0;
            //       foreach (string item in Employees)
            //       {
            //           Console.Write(item+",");
            //           count++;
            //       }
            //       Console.WriteLine($"\nThe count of collection item {count}");
            //   }

            //   PrintCollection(employees); Console.WriteLine();


            //   // ======================================================
            //   // Q2 - Remove Employee
            //   // ======================================================

            //   /*
            //    * Using the employees collection from Q1:
            //    *
            //    * Create:
            //    *
            //    * RemoveEmployee(
            //    *     ICollection<string> employees,
            //    *     string employeeName)
            //    *
            //    * The method should:
            //    *
            //    * 1. Check whether the employee exists.
            //    * 2. Remove the employee if found.
            //    * 3. Print whether the operation succeeded.
            //    *
            //    * Test it with:
            //    * - An existing employee.
            //    * - A non-existing employee.
            //    */
            //   Console.WriteLine("==========questiion 2==========");

            //   void RemoveEmployee(ICollection<string> Employees,string employeeName)
            //   {
            //       if (Employees.Contains(employeeName))
            //       {
            //           Console.WriteLine($"Exsit {employeeName}");
            //           if (Employees.Remove(employeeName))
            //           {
            //               Console.WriteLine("the employee removing:and operation success");
            //           }
            //           else
            //           {
            //               Console.WriteLine("Not removing:operation Not successed");
            //           }
            //       }
            //       else
            //       {
            //           Console.WriteLine($"Not Exsit {employeeName}");
            //       }
            //   }
            //   RemoveEmployee(employees, "Hossam");

            //   Console.WriteLine("------");
            //   RemoveEmployee(employees, "A");


            //   // ======================================================
            //   // Q3 - Shopping Cart
            //   // ======================================================

            //   /*
            //    * Create:
            //    *
            //    * MyCustomCollection<string> cart
            //    *
            //    * Add:
            //    *
            //    * "Laptop"
            //    * "Mouse"
            //    * "Keyboard"
            //    * "Monitor"
            //    * "Headset"
            //    *
            //    * Create:
            //    *
            //    * RemoveProduct(
            //    *     ICollection<string> cart,
            //    *     string product)
            //    *
            //    * Remove:
            //    *
            //    * "Mouse"
            //    * "Printer"
            //    *
            //    * Observe the difference between
            //    * an existing and non-existing product.
            //    */
            //   Console.WriteLine("==========questiion 3==========");

            //   MyCustomCollection<string> Cart= new MyCustomCollection<string>();
            //   Cart.Add("Laptop");
            //   Cart.Add("Mouse");
            //   Cart.Add("Keyboard");
            //   Cart.Add("Monitor");
            //   Cart.Add("Headset");

            //   void RemoveProduct(ICollection<string> cart,string productName)
            //   {
            //       if (cart.Contains(productName))
            //       {
            //           Console.WriteLine($"Exsit {productName}");
            //           if (cart.Remove(productName))
            //           {
            //               Console.WriteLine("the Product removing:and operation success");
            //           }
            //           else
            //           {
            //               Console.WriteLine("Not removing:operation Not successed");
            //           }
            //       }
            //       else
            //       {
            //           Console.WriteLine($"Not Exsit {productName}");
            //       }
            //   }
            //   RemoveProduct(Cart, "Mouse");
            //   RemoveProduct(Cart, "Printer");

            //   // ======================================================
            //   // Q4 - Different Implementations
            //   // ======================================================

            //   /*
            //    * Create:
            //    *
            //    * List<string> listCustomers
            //    *
            //    * HashSet<string> uniqueCustomers
            //    *
            //    * Add some customer names to both.
            //    *
            //    * Create ONE method:
            //    *
            //    * PrintCustomers(ICollection<string> customers)
            //    *
            //    * The method should:
            //    *
            //    * - Print Count.
            //    * - Print all customers.
            //    *
            //    * Call the SAME method with:
            //    *
            //    * listCustomers
            //    * uniqueCustomers
            //    *
            //    * Think:
            //    *
            //    * Why does one method work with two different
            //    * concrete collection types?
            //    */
            //   Console.WriteLine("==========questiion 1==========");

            //   void PrintCustomers(ICollection<string> customers)
            //   {
            //       int count = 0;
            //       foreach (string customer in customers)
            //       {
            //           count++;
            //           Console.Write(customer+","); 
            //       }
            //       Console.WriteLine($"\nthe number of customer:{count}");

            //   }
            //   List<string> Customers = new List<string>()
            //   {
            //       "Hossam", "Ali", "Ahmed", "Sana", "Handa"
            //   };
            //   HashSet<string> UniqueCustomers = new HashSet<string>()
            //   {
            //       "Hossam", "Ali", "Ahmed", "Sana", "Handa"
            //   };

            //   PrintCustomers(Customers);
            //   PrintCustomers(UniqueCustomers);
            //   // ======================================================
            //   // Q5 - CopyTo
            //   // ======================================================

            //   /*
            //    * A company has:
            //    *
            //    * MyCustomCollection<string> employees
            //    *
            //    * Add 5 employees.
            //    *
            //    * Create:
            //    *
            //    * string[] employeeArray = new string[5];
            //    *
            //    * Use CopyTo() to copy the collection
            //    * into the array.
            //    *
            //    * Print the array.
            //    *
            //    * Then try:
            //    *
            //    * string[] employeeArray = new string[10];
            //    *
            //    * and start copying from index 2.
            //    *
            //    * Observe where the employees are stored.
            //    */
            //   Console.WriteLine("==========questiion 5==========");
            //   MyCustomCollection<string> Employeess = new MyCustomCollection<string>() { "Hossam", "Ali", "Ahmed", "Sana", "Handa" };
            //   string[] employeeArray = new string[5];

            //   Employeess.CopyTo(employeeArray, 0);

            //   foreach (string employee in employeeArray)
            //   {
            //       Console.Write(employee+",");
            //   }
            //   Console.WriteLine();

            //   string[] employeeArray1= new string[10];
            //   Employeess.CopyTo(employeeArray1, 2);
            //   foreach (string employee in employeeArray1)
            //   {
            //       Console.Write(employee+",");
            //   }



            //   // ======================================================
            //   // Q6 - Collection Report
            //   // ======================================================

            //   /*
            //    * Create:
            //    *
            //    * MyCustomCollection<int> orderIds
            //    *
            //    * Add 8 order IDs.
            //    *
            //    * Create:
            //    *
            //    * void PrintCollectionReport(ICollection<int> orders)
            //    *
            //    * The method should print:
            //    *
            //    * - Number of orders.
            //    * - All order IDs.
            //    * - Whether order 1005 exists.
            //    *
            //    * Do NOT modify the collection inside the method.
            //    *
            //    * Think:
            //    *
            //    * Is ICollection<T> the best possible interface
            //    * if the method only reads the collection?
            //    *
            //    * Why?
            //    */
            //   Console.WriteLine("==========questiion 6==========");
            //   MyCustomCollection<int> orderIds=new MyCustomCollection<int>() { 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008 };
            //   void PrintCollectionReport(ICollection<int> orders)
            //   {
            //       int count = 0;
            //       foreach(int item in orders)
            //       {
            //           count++;
            //           Console.Write(item+",");
            //       }
            //       Console.WriteLine("the number of order "+count);

            //       if (orders.Contains(1005))
            //       {
            //           Console.WriteLine("the order is Exsit");
            //       }
            //   }


            //   // ======================================================
            //   // Q7 - Build Your Own RemoveAt
            //   // ======================================================

            //   /*
            //    * Your MyCustomCollection<T> has:
            //    *
            //    * Remove(T item)
            //    *
            //    * but ICollection<T> does NOT provide:
            //    *
            //    * RemoveAt(index)
            //    *
            //    * Implement:
            //    *
            //    * RemoveAt(int index)
            //    *
            //    * Requirements:
            //    *
            //    * 1. Check if the index is valid.
            //    * 2. Remove the element at that index.
            //    * 3. Return true if removed.
            //    * 4. Return false if the index is invalid.
            //    *
            //    * Test:
            //    *
            //    * RemoveAt(0)
            //    * RemoveAt(3)
            //    * RemoveAt(100)
            //    */
            //   Console.WriteLine("==========questiion 1==========");


            //   // ======================================================
            //   // Q8 - IsReadOnly
            //   // ======================================================

            //   /*
            //    * Create:
            //    *
            //    * MyCustomCollection<string> tasks
            //    *
            //    * Add several tasks.
            //    *
            //    * Print:
            //    *
            //    * tasks.IsReadOnly
            //    *
            //    * Then create:
            //    *
            //    * void AddTask(
            //    *     ICollection<string> tasks,
            //    *     string task)
            //    *
            //    * Inside the method:
            //    *
            //    * Check IsReadOnly.
            //    *
            //    * If it is false:
            //    *     Add the task.
            //    *
            //    * Otherwise:
            //    *     Print "Collection is read-only".
            //    *
            //    * Test the method with your custom collection.
            //    */
            //   Console.WriteLine("==========questiion 1==========");


            //   // ======================================================
            //   // Q9 - Generic Reusable Method
            //   // ======================================================

            //   /*
            //    * Create a generic method:
            //    *
            //    * void PrintCollection<T>(
            //    *     ICollection<T> collection)
            //    *
            //    * The method should:
            //    *
            //    * - Print Count.
            //    * - Print every item.
            //    *
            //    * Test it with:
            //    *
            //    * MyCustomCollection<string>
            //    * MyCustomCollection<int>
            //    *
            //    * Think:
            //    *
            //    * Why don't we need to create:
            //    *
            //    * PrintStringCollection()
            //    * PrintIntCollection()
            //    *
            //    * separately?
            //    */
            //   Console.WriteLine("==========questiion 1==========");


            //   // ======================================================
            //   // Q10 - Real Project Scenario
            //   // ======================================================

            //   /*
            //    * Imagine you are building a simple
            //    * License Management System.
            //    *
            //    * You need a collection of license IDs.
            //    *
            //    * Create:
            //    *
            //    * MyCustomCollection<int> licenses
            //    *
            //    * Add:
            //    *
            //    * 101
            //    * 102
            //    * 103
            //    * 104
            //    * 105
            //    *
            //    * Create this method:
            //    *
            //    * ProcessLicenses(ICollection<int> licenses)
            //    *
            //    * The method should:
            //    *
            //    * 1. Print the number of licenses.
            //    *
            //    * 2. Check whether license 103 exists.
            //    *
            //    * 3. Remove license 103.
            //    *
            //    * 4. Check again whether license 103 exists.
            //    *
            //    * 5. Print all remaining licenses.
            //    *
            //    *
            //    * Then answer in a comment:    
            //    *
            //    * Why did we use ICollection<int>
            //    * as the parameter instead of
            //    * MyCustomCollection<int>?
            //    *
            //    * And:
            //    *
            //    * Which operations in this method are
            //    * provided by ICollection<T>?
            //    *
            //    * Which operation is provided by
            //    * your own MyCustomCollection<T>?
            //    */
            //   Console.WriteLine("==========questiion 1==========");

            #endregion


            #region Mistakes

            /*
             * ==================== Mistakes We Made ====================
             *
             *
             * Mistake 1:
             *
             * Confusing ICollection with ICollection<T>.
             *
             *
             * ICollection
             *      ↓
             * System.Collections
             *      ↓
             * Non-generic
             *
             *
             * ICollection<T>
             *      ↓
             * System.Collections.Generic
             *      ↓
             * Generic
             *
             *
             *
             * Mistake 2:
             *
             * Thinking RemoveAt() is part of ICollection<T>.
             *
             * It is NOT.
             *
             * ICollection<T> provides:
             *
             * Remove(item)
             *
             * but not:
             *
             * RemoveAt(index)
             *
             *
             * Your RemoveAt() is a custom method
             * that you added to MyCustomCollection<T>.
             *
             *
             *
             * Mistake 3:
             *
             * Your RemoveAt implementation:
             *
             * return Remove(item[Index]);
             *
             * works, but it has a possible problem.
             *
             * If Index is invalid:
             *
             * item[Index]
             *
             * can throw an exception.
             *
             * Safer version:
             *
             * public bool RemoveAt(int index)
             * {
             *     if (index < 0 || index >= item.Count)
             *         return false;
             *
             *     item.RemoveAt(index);
             *     return true;
             * }
             *
             *
             *
             * Mistake 4:
             *
             * Thinking ICollection<T> tells us HOW
             * the collection stores its data.
             *
             * It does not.
             *
             * It only defines the contract.
             *
             * Your implementation decides the storage.
             *
             * In your case:
             *
             * ICollection<T>
             *       ↓
             * MyCustomCollection<T>
             *       ↓
             * private List<T> item
             *
             *
             *
             * Mistake 5:
             *
             * Forgetting why IEnumerable<T> is also implemented.
             *
             * ICollection<T> inherits from IEnumerable<T>.
             *
             * Therefore your collection can be used with:
             *
             * foreach
             *
             * because it provides GetEnumerator().
             *
             */

            #endregion

            #endregion
        }
    }
}
