using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList
{
    public class SimpleList<t> : IList<t>
    {
        private List<t> _item = new List<t>();
        public t this[int index] { get => _item[index]; set => _item[index]=value; }

        public int Count => _item.Count;

        public bool IsReadOnly => false;

        public void Add(t item)
        {
            _item.Add(item);
        }

        public void Clear()
        {
            _item.Clear();
        }

        public bool Contains(t item)
        {
            return _item.Contains(item);
        }

        public void CopyTo(t[] array, int arrayIndex)
        {
            _item.CopyTo(array, arrayIndex);
        }

        public IEnumerator<t> GetEnumerator()
        {
            foreach (t t in _item)
            {
                yield return t;
            }
        }

        public int IndexOf(t item)
        {
            return _item.IndexOf(item);
        }

        public void Insert(int index, t item)
        {
            _item.Insert(index, item);
        }

        public bool Remove(t item)
        {
            return _item.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _item.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson 23 - IList<T>

            /*
             * ==================== What is it? ====================
             *
             * IList<T> is a generic interface in System.Collections.Generic.
             *
             * It represents a collection that supports:
             * - Index-based access
             * - Insert
             * - RemoveAt
             * - IndexOf
             *
             * IList<T> inherits from ICollection<T>,
             * and ICollection<T> inherits from IEnumerable<T>.
             *
             *
             * ==================== Relationship ====================
             *
             * IEnumerable<T>
             *      ↓
             * ICollection<T>
             *      ↓
             * IList<T>
             *
             *
             * IEnumerable<T>
             * - Mainly used for iteration.
             *
             * ICollection<T>
             * - Adds basic collection operations.
             *
             * IList<T>
             * - Adds index-based operations.
             *
             *
             * ==================== Why use it? ====================
             *
             * - When we need to access elements by index.
             * - When we need to insert an element at a specific position.
             * - When we need to remove an element by index.
             * - When we need to find the index of an element.
             *
             *
             * ==================== Important Operations ====================
             *
             * - Add(T item)
             *      Adds an item to the collection.
             *
             * - [index]
             *      Gets or sets an item using its index.
             *
             * - Insert(int index, T item)
             *      Inserts an item at a specific index.
             *
             * - RemoveAt(int index)
             *      Removes the item at a specific index.
             *
             * - IndexOf(T item)
             *      Returns the index of the first matching item.
             *      Returns -1 if the item does not exist.
             *
             * - Remove(T item)
             *      Removes the first matching item.
             *
             * - Contains(T item)
             *      Checks whether an item exists.
             *
             * - Count
             *      Returns the number of elements.
             *
             * - Clear()
             *      Removes all elements.
             *
             * - IsReadOnly
             *      Indicates whether the collection is read-only.
             *
             *
             * ==================== Important Difference ====================
             *
             * ICollection<T>
             *      ↓
             * Basic collection operations
             *
             * IList<T>
             *      ↓
             * Basic collection operations
             * +
             * Index-based operations
             *
             *
             * Example:
             *
             * ICollection<T>
             *      employees.Add("Hossam");
             *
             * IList<T>
             *      employees[0]
             *      employees.Insert(1, "Ali");
             *      employees.RemoveAt(0);
             *      employees.IndexOf("Hossam");
             *
             *
             * ==================== Mental Model ====================
             *
             * IList<T>
             *      ↓
             * "I have a collection AND I can work with it by index."
             *
             */

            #region Coding

            // ======================================================
            // Basic IList<T> Implementation
            // ======================================================



            // ======================================================
            // Using SimpleList<T>
            // ======================================================

            SimpleList<string> strings = new SimpleList<string>();

            strings.Add("Hossam");
            strings.Add("Ali");

            strings.Insert(2, "Ahmed");

            strings[2] = "Handa";


            // ======================================================
            // Using foreach
            // ======================================================

            Console.Write("The custom list with foreach: ");

            foreach (string s in strings)
            {
                Console.Write(s + ",");
            }

            Console.WriteLine();


            // ======================================================
            // Using for + Indexer
            // ======================================================

            Console.Write("The custom list with for: ");

            for (int i = 0; i<strings.Count; i++)
            {
                Console.Write(strings[i] + ",");
            }

            Console.WriteLine();


            // ======================================================
            // Contains + IndexOf + Remove
            // ======================================================

            if (strings.Contains("Hossam"))
            {
                Console.WriteLine(
                    $"The index of student: {strings.IndexOf("Hossam")}"
                );

                if (strings.Remove("Hossam"))
                {
                    Console.WriteLine("We removed the student.");
                }
                else
                {
                    Console.WriteLine("The student was not removed.");
                }
            }
            else
            {
                Console.WriteLine("Not exist");
            }


            // ======================================================
            // Clear
            // ======================================================

            strings.Clear();

            #endregion


            #region Practice

            ///*
            // * ==================== IList<T> Practice ====================
            // *
            // * 10 Real-Life Practice Questions
            // *
            // * Difficulty: Medium
            // *
            // * Focus on:
            // * - IList<T> as a contract
            // * - Relationship with ICollection<T>
            // * - Indexer
            // * - Insert
            // * - RemoveAt
            // * - IndexOf
            // * - Different IList<T> implementations
            // * - Reusable methods
            // * - Real-life scenarios
            // */


            //// ======================================================
            //// Q1 - Student List
            //// ======================================================

            ///*
            // * Create:
            // *
            // * IList<string> students
            // *
            // * Use List<string> as the implementation.
            // *
            // * Add 5 students.
            // *
            // * Then:
            // * - Print all students.
            // * - Print the student at index 2.
            // *
            // * Think:
            // * Why can IList<string> reference a List<string>?
            // */
            //Console.WriteLine("===============Quetion 1===========");

            //IList<string> Students = new List<string>();

            //Students.Add("hossam");
            //Students.Add("Ali");
            //Students.Add("Salah");
            //Students.Add("Handa");
            //Students.Add("Sama");

            //foreach (string s in Students)
            //{
            //    Console.Write(s+",");
            //}

            //Console.WriteLine($"\nthe sutedent at index 2 {Students[2]}");

            ////he refrence becuse list Implement Ilist 


            //    // ======================================================
            //    // Q2 - Update Employee
            //    // ======================================================

            //    /*
            //     * Create an IList<string> employees.
            //     *
            //     * Add:
            //     * - Hossam
            //     * - Ali
            //     * - Ahmed
            //     * - Sana
            //     *
            //     * Change the employee at index 1 to "Omar"
            //     * using the indexer.
            //     *
            //     * Print the collection.
            //     */
            //Console.WriteLine("=============== Quetion 2 ===========");
            //IList<string> Employees= new List<string>();
            //Employees.Add("Hossam");
            //Employees.Add("Ali");
            //Employees.Add("Ahmed");
            //Employees.Add("Sana");
            //foreach (string s in Employees)
            //{
            //    Console.Write(s+",");
            //}

            //Console.WriteLine("\nAfter change item in index 1 to Omar");

            //Employees[1]="Omar";
            //foreach (string s in Employees)
            //{
            //    Console.Write(s+",");
            //}




            //// ======================================================
            //// Q3 - Insert Product
            //// ======================================================

            ///*
            // * Create:
            // *
            // * IList<string> products
            // *
            // * Add:
            // * Laptop
            // * Mouse
            // * Keyboard
            // * Monitor
            // *
            // * Insert "Printer" at index 2.
            // *
            // * Print the final collection.
            // *
            // * Observe how the indexes changed.
            // */
            //Console.WriteLine("\n===============Quetion 1===========");

            //IList<string> Products= new List<string>();
            //Products.Add("Laptop");
            //Products.Add("Mouse");
            //Products.Add("Keyboard");
            //Products.Add("Monitor");
            //foreach (string s in Products)
            //{
            //    Console.Write(s+",");
            //}

            //Console.WriteLine("\nAfter insert Printer at index 2");

            //Products.Insert(2, "Printer");

            //foreach (string s in Products)
            //{
            //    Console.Write(s+",");
            //}




            //// ======================================================
            //// Q4 - Remove Product By Index
            //// ======================================================

            ///*
            // * Create an IList<string> cart.
            // *
            // * Add 5 products.
            // *
            // * Remove the product at index 2.
            // *
            // * Print the remaining products.
            // *
            // * Think:
            // * What is the difference between:
            // *
            // * Remove("Mouse")
            // *
            // * and:
            // *
            // * RemoveAt(2)
            // */
            //Console.WriteLine("\n===============Quetion 4===========");
            //IList<String>cart = new List<String>();
            //cart.Add("Laptop");
            //cart.Add("Mouse");
            //cart.Add("Keyboard");
            //cart.Add("Monitor");
            //cart.Add("Printer");

            //foreach (string s in cart)
            //{
            //    Console.Write(s+",");
            //}

            //Console.WriteLine("\nAfter removing product at index 2");

            //cart.RemoveAt(2);

            //foreach (string s in cart)
            //{
            //    Console.Write(s+",");
            //}




            //// ======================================================
            //// Q5 - Find Employee
            //// ======================================================

            ///*
            // * Create an IList<string> employees.
            // *
            // * Add 6 employees.
            // *
            // * Create:
            // *
            // * int FindEmployee(
            // *     IList<string> employees,
            // *     string employeeName)
            // *
            // * Return the index of the employee.
            // *
            // * Test:
            // * - Existing employee.
            // * - Non-existing employee.
            // *
            // * What value does IndexOf return when
            // * the employee doesn't exist?
            // */
            //Console.WriteLine("\n===============Quetion 5===========");
            //IList<string> employees=new List<string>();
            //employees.Add("Hossam");
            //employees.Add("Ali");
            //employees.Add("Ahmed");
            //employees.Add("Sana");
            //employees.Add("Handa");

            //int FindEmplyee(IList<string> list,string employeeName)
            //{
            //    for (int i = 0; i<list.Count; i++)
            //    {
            //        if (list[i] == employeeName)
            //        {
            //            return i;
            //        }
            //    }
            //    return -1;
            //}

            //int employeeIndex = FindEmplyee(employees, "Hossam");
            //if (employeeIndex == -1)
            //{
            //    Console.WriteLine("Employee note exsit");
            //}
            //else
            //{
            //    Console.WriteLine($"emloyee exsit at index:{employeeIndex}");
            //}

            //employeeIndex=FindEmplyee(employees, "sama");
            //if (employeeIndex == -1)
            //{
            //    Console.WriteLine("Employee note exsit");
            //}
            //else
            //{
            //    Console.WriteLine($"emloyee exsit at index{employeeIndex}");
            //}


            //// ======================================================
            //// Q6 - Reusable IList Method
            //// ======================================================

            ///*
            // * Create:
            // *
            // * void PrintList(IList<string> items)
            // *
            // * The method should:
            // * - Print Count.
            // * - Print every item using a for loop.
            // *
            // * Why can you use:
            // *
            // * items[i]
            // *
            // * inside the method?
            // */
            //Console.WriteLine("===============Quetion 6===========");
            //void PrintList(IList<string> items,out int count)
            //{
            //    int countin = 0;

            //    for (int i = 0; i<items.Count; i++) {
            //        countin++;
            //        Console.Write(items[i]+",");

            //    }
            //    count= countin;
            //}

            //// ======================================================
            //// Q7 - Order Management
            //// ======================================================

            ///*
            // * Create:
            // *
            // * IList<int> orderIds
            // *
            // * Add 6 order IDs.
            // *
            // * Create:
            // *
            // * void RemoveOrder(
            // *     IList<int> orders,
            // *     int index)
            // *
            // * The method should:
            // * - Check whether the index is valid.
            // * - Remove the order using RemoveAt().
            // * - Print whether the operation succeeded.
            // *
            // * Test:
            // * - Valid index.
            // * - Invalid index.
            // */
            //Console.WriteLine("===============Quetion 1===========");
            //IList<int> orderIds= new List<int>();
            //orderIds.Add(0);
            //orderIds.Add(11);
            //orderIds.Add(22);
            //orderIds.Add(33);
            //orderIds.Add(44);
            //orderIds.Add(55);
            //void RemoveOder(IList<int>orders,int index)
            //{
            //    if (orders.Contains(index))
            //    {
            //        orders.RemoveAt(index);
            //        Console.WriteLine("Operation succeeded");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Operation not succeeded");
            //    }

            //}




            #endregion


            #region Mistakes

            /*
             * Common mistakes to watch for:
             *
             * 1. Confusing Insert with replacing:
             *
             * Insert(index, value)
             *      → adds a new element
             *
             * list[index] = value
             *      → replaces an existing element
             *
             *
             * 2. Confusing Remove with RemoveAt:
             *
             * Remove(value)
             *      → removes by value
             *
             * RemoveAt(index)
             *      → removes by index
             *
             *
             * 3. Forgetting that IndexOf returns -1
             *    when the item does not exist.
             *
             *
             * 4. Using an invalid index:
             *
             * Valid access:
             *
             * 0 <= index < Count
             *
             *
             * 5. Forgetting that IList<T> inherits
             *    the operations of ICollection<T>.
             *
             *
             * 6. Confusing interface and implementation:
             *
             * IList<T>
             *      = contract
             *
             * List<T>
             *      = implementation
             *
             * ObservableCollection<T>
             *      = another implementation
             *
             */

            #endregion

            #endregion
        }
    }
}
