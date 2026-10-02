using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public class SimpleDictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> _item = new List<KeyValuePair<TKey, TValue>>();

    public TValue this[TKey key]
    {
        get
        {
            foreach (var item in _item)
            {
                if (Equals(key, item.Key))
                {
                    return item.Value;
                }
            }
            throw new KeyNotFoundException($"the give key {key} not found ");
        }
        set
        {
            bool found = false;
            for (int i = 0; i<_item.Count; i++)
            {
                if (Equals(_item[i].Key, key))
                {
                    found = true;
                    _item[i]=new KeyValuePair<TKey, TValue>(key, value);
                    break;
                }
            }
            if (!found)
            {
                _item.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
        }

    }

    public ICollection<TKey> Keys => _item.ConvertAll(kvp => kvp.Key);

    public ICollection<TValue> Values => _item.ConvertAll(Kvp => Kvp.Value);

    public int Count => _item.Count;

    public bool IsReadOnly => false;

    public void Add(TKey key, TValue value)
    {
        foreach (var item in _item)
        {
            if (Equals(key, item.Key))
            {
                throw new ArgumentException("the element with same key exsit:");
            }
        }
        _item.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public void Add(KeyValuePair<TKey, TValue> item)
    {
        _item.Add(item);
    }

    public void Clear()
    {
        _item.Clear();
    }

    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        return _item.Contains(item);
    }

    public bool ContainsKey(TKey key)
    {
        foreach (var item in _item)
        {
            if (Equals(key, item.Key))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        _item.CopyTo(array, arrayIndex);
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return _item.GetEnumerator();
    }

    public bool Remove(TKey key)
    {
        for (int i = 0; i<_item.Count; i++)
        {
            if (Equals(_item[i].Key, key))
            {
                _item.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        return _item.Remove(item);
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        foreach (var item in _item)
        {
            if (Equals(item.Key, key))
            {
                value = item.Value;
                return true;
            }
        }
        value = default(TValue);
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class SimpleSet<T> : ISet<T>
{
    private HashSet<T> _Set = new HashSet<T>();
    public int Count => _Set.Count;

    public bool IsReadOnly => false;

    public bool Add(T item)
    {
        return _Set.Add(item);
    }

    public void Clear()
    {
        _Set.Clear();
    }

    public bool Contains(T item)
    {
        return _Set.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        _Set.CopyTo(array, arrayIndex);
    }

    public void ExceptWith(IEnumerable<T> other)
    {
        _Set.ExceptWith(other);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _Set.GetEnumerator() ;
    }

    public void IntersectWith(IEnumerable<T> other)
    {
        _Set.IntersectWith(other);
    }

    public bool IsProperSubsetOf(IEnumerable<T> other)
    {
        return _Set.IsProperSubsetOf(other);
    }

    public bool IsProperSupersetOf(IEnumerable<T> other)
    {
        return _Set.IsProperSupersetOf(other);
    }

    public bool IsSubsetOf(IEnumerable<T> other)
    {
        return _Set.IsSubsetOf(other);
    }

    public bool IsSupersetOf(IEnumerable<T> other)
    {
        return _Set.IsSupersetOf(other);
    }

    public bool Overlaps(IEnumerable<T> other)
    {
        return _Set.Overlaps(other);
    }

    public bool Remove(T item)
    {
        return _Set.Remove(item);
    }

    public bool SetEquals(IEnumerable<T> other)
    {
       return _Set.SetEquals(other);
    }

    public void SymmetricExceptWith(IEnumerable<T> other)
    {
        _Set.SymmetricExceptWith(other);
    }

    public void UnionWith(IEnumerable<T> other)
    {
        _Set.UnionWith(other);
    }

    void ICollection<T>.Add(T item)
    {
        Add( item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
namespace IDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson 24 - IDictionary<TKey, TValue>

            /*
             * ==================== What is it? ====================
             *
             * IDictionary<TKey, TValue>
             *
             * - Interface used to represent a collection of Key-Value pairs.
             * - Generic version exists in:
             *      System.Collections.Generic
             *
             * - The non-generic IDictionary exists in:
             *      System.Collections
             *
             * - Each item contains:
             *      Key
             *      Value
             *
             * - Keys must be unique.
             * - Values can be duplicated.
             *
             * Examples of implementations:
             *
             *      Dictionary<TKey, TValue>
             *      SortedDictionary<TKey, TValue>
             *      ConcurrentDictionary<TKey, TValue>
             *
             *
             * ==================== Why use it? ====================
             *
             * Use IDictionary<TKey, TValue> when data naturally has:
             *
             *      Key → Value
             *
             * Examples:
             *
             *      EmployeeID → EmployeeName
             *      StudentID  → StudentName
             *      ProductID  → ProductName
             *      LicenseID  → PersonName
             *
             *
             * ==================== Important Characteristics ====================
             *
             * - Access data using a key.
             * - Keys are unique.
             * - Supports Add / Remove.
             * - Supports ContainsKey.
             * - Supports TryGetValue.
             * - Supports Keys and Values.
             * - Supports foreach.
             *
             *
             * ==================== Important Operations ====================
             *
             * Add(key, value)
             *      Adds a new Key-Value pair.
             *
             * [key]
             *      Gets or changes the value associated with a key.
             *
             * ContainsKey(key)
             *      Checks whether a key exists.
             *
             * TryGetValue(key, out value)
             *      Tries to retrieve a value safely.
             *
             * Remove(key)
             *      Removes using the key.
             *
             * Contains(KeyValuePair<TKey,TValue>)
             *      Checks for a specific Key-Value pair.
             *
             * Keys
             *      Returns all keys.
             *
             * Values
             *      Returns all values.
             *
             * Count
             *      Number of Key-Value pairs.
             *
             * Clear()
             *      Removes all items.
             *
             *
             * ==================== Add vs Indexer ====================
             *
             * Add:
             *
             *      dictionary.Add(1, "Hossam");
             *
             * If key 1 already exists → exception.
             *
             *
             * Indexer:
             *
             *      dictionary[1] = "Hossam";
             *
             * If key 1 exists → update.
             * If key 1 does not exist → add.
             *
             *
             * ==================== ContainsKey vs Contains ====================
             *
             * ContainsKey:
             *
             *      ContainsKey(1)
             *
             * Checks the key only.
             *
             *
             * Contains:
             *
             *      Contains(new KeyValuePair<int,string>(1, "Hossam"))
             *
             * Checks the complete Key-Value pair.
             *
             *
             * ==================== Think ====================
             *
             *              IDictionary<TKey,TValue>
             *                         ↓
             *                  Key → Value
             *                         ↓
             *              ┌──────────┴──────────┐
             *              ↓                     ↓
             *        Unique Key              Any Value
             *              ↓
             *         Find by Key
             *
             *
             * Example:
             *
             *      101 → "Hossam"
             *      102 → "Ali"
             *      103 → "Ahmed"
             *
             *      dictionary[101]
             *              ↓
             *          "Hossam"
             */


            #region Coding

            ///*
            // * ============================================================
            // * Using SimpleDictionary
            // * ============================================================
            // *
            // * SimpleDictionary was implemented in the previous lesson.
            // * Here we focus on using the IDictionary behavior.
            // */

            //SimpleDictionary<int, string> keyValuePairs =
            //    new SimpleDictionary<int, string>();


            //KeyValuePair<int, string> keyValuePair =
            //    new KeyValuePair<int, string>(3, "Handa");


            //if (keyValuePairs.IsReadOnly == false)
            //{
            //    keyValuePairs[1] = "hossam";

            //    keyValuePairs.Add(2, "Ali");

            //    keyValuePairs.Add(keyValuePair);
            //}
            //else
            //{
            //    Console.WriteLine("The dictionary is read only");
            //}


            ///*
            // * ============================================================
            // * Add with Existing Key
            // * ============================================================
            // */

            //try
            //{
            //    keyValuePairs.Add(1, "ali");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}


            ///*
            // * ============================================================
            // * ContainsKey + Indexer
            // * ============================================================
            // */

            //if (keyValuePairs.ContainsKey(1))
            //{
            //    Console.WriteLine(
            //        $"the dictionay contain key 1 and value is {keyValuePairs[1]}");

            //    keyValuePairs[1] = "Handa";

            //    Console.WriteLine(
            //        $" key 1 and value after change: {keyValuePairs[1]}");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}


            ///*
            // * ============================================================
            // * Contains(KeyValuePair) + Remove(KeyValuePair)
            // * ============================================================
            // */

            //if (keyValuePairs.Contains(keyValuePair))
            //{
            //    Console.WriteLine(
            //        "the item is exsit and is delete");

            //    keyValuePairs.Remove(keyValuePair);
            //}
            //else
            //{
            //    Console.WriteLine("not exsit");
            //}


            ///*
            // * ============================================================
            // * foreach
            // * ============================================================
            // */

            //foreach (var pair in keyValuePairs)
            //{
            //    Console.WriteLine(pair.Value);
            //}


            ///*
            // * ============================================================
            // * TryGetValue
            // * ============================================================
            // */

            //if (keyValuePairs.TryGetValue(
            //    1,
            //    out string tryget))
            //{
            //    Console.WriteLine(
            //        "the employee with id 1:" + tryget);
            //}


            ///*
            // * ============================================================
            // * Keys and Values
            // * ============================================================
            // */

            //Console.WriteLine(
            //    $"the keys {string.Join(", ", keyValuePairs.Keys)}");

            //Console.WriteLine(
            //    $"the value {string.Join(", ", keyValuePairs.Values)}");


            ///*
            // * ============================================================
            // * CopyTo
            // * ============================================================
            // */

            //KeyValuePair<int, string>[] arr =
            //    new KeyValuePair<int, string>[2];

            //keyValuePairs.CopyTo(arr, 0);

            //foreach (var pair in arr)
            //{
            //    Console.WriteLine(pair.Value);
            //}


            #endregion



            #region Practice

            /*
             * ==================== IDictionary Practice ====================
             *
             * 5 real-life problems.
             *
             * No method signatures are given.
             * No implementation steps are given.
             *
             * Read the requirements and decide how you would solve them.
             */


            //// ============================================================
            //// Q1 - Employee Lookup
            //// ============================================================

            ///*
            // * You are developing an Employee Management System.
            // *
            // * Every employee has a unique ID and a name.
            // *
            // * The system currently has these employees:
            // *
            // *      101 → Hossam
            // *      102 → Ali
            // *      103 → Ahmed
            // *
            // * The manager enters an employee ID and wants the system
            // * to display the employee's name.
            // *
            // * If the ID does not exist, the system must display:
            // *
            // *      Employee not found
            // *
            // * The program must not throw an exception when the manager
            // * enters an unknown ID.
            // *
            // * Tasks:
            // *
            // * - Choose the appropriate collection/interface.
            // * - Write the code that performs the search.
            // * - Test it with an existing ID and a non-existing ID.
            // */
            //Console.WriteLine("================quition 1=============");
            //IDictionary<int, string> Employees = new Dictionary<int, string>()
            //{
            //        {101 , "Hossam"},
            //        {102 , "Ali   "},
            //        { 103 ," Ahmed" } ,
            //};

            //void SearchEmployees(IDictionary<int, string> keyValuePairs, int ID)
            //{
            //    if (keyValuePairs.ContainsKey(ID))
            //    {
            //        Console.WriteLine($"The Employee of ID {ID} Exsit :Name of Employee: {keyValuePairs[ID]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The Employee of ID {ID} not exsit:");
            //    }
            //}

            //SearchEmployees(Employees, 1);
            //SearchEmployees(Employees, 101);


            //// ============================================================
            //// Q2 - Update Application Status
            //// ============================================================

            ///*
            // * You are working on the Driving License System.
            // *
            // * The system stores the current status of each application:
            // *
            // *      1 → "New"
            // *      2 → "Completed"
            // *      3 → "Cancelled"
            // *
            // * An administrator enters an Application ID and a new status.
            // *
            // * Example:
            // *
            // *      Application ID: 1
            // *      New Status: "Completed"
            // *
            // * The system should update application 1.
            // *
            // * However, if the administrator enters an Application ID
            // * that does not exist, the system must NOT create a new
            // * application. It should simply report that the application
            // * was not found.
            // *
            // * Tasks:
            // *
            // * - Write the code for this operation.
            // * - Test updating an existing application.
            // * - Test using an ID that does not exist.
            // * - Decide which dictionary operation is appropriate and
            // *   explain why.
            // */
            //Console.WriteLine("================quition 1=============");
            //IDictionary<int, string> Appliction = new Dictionary<int, string>()
            //{
            //    { 1 , "New"},
            //    { 2 , "Completed"},
            //    { 3 ," Cancelled" },
            //    { 4 ," New" }
            //};

            //void UpdateApplictionStatus(IDictionary<int, string> keyValuePairs, int ID, string NewStatus)
            //{
            //    if (keyValuePairs.ContainsKey(ID))
            //    {
            //        keyValuePairs[ID] = NewStatus;
            //        Console.WriteLine($"the {ID} is  Exsit and Status Update");
            //    }
            //    else
            //    {

            //        Console.WriteLine($"The Appliction of iD {ID} not Exsit ");
            //    }
            //}
            //UpdateApplictionStatus(Appliction, 1, "Completed");
            //UpdateApplictionStatus(Appliction, 22, "new");


            //// ============================================================
            //// Q3 - Remove Employee
            //// ============================================================

            ///*
            // * An Employee Management System needs a function that removes
            // * an employee using the employee's ID.
            // *
            // * Current employees:
            // *
            // *      1001 → Hossam
            // *      1002 → Ali
            // *      1003 → Ahmed
            // *
            // * When the user enters an ID:
            // *
            // * - If the employee exists, remove the employee.
            // * - If the employee does not exist, nothing should be removed.
            // * - The program should be able to tell the caller whether
            // *   an employee was actually removed.
            // *
            // * After testing the operation, print all remaining employees.
            // *
            // * Tasks:
            // *
            // * - Choose the appropriate IDictionary operation.
            // * - Write the code.
            // * - Test with an existing ID.
            // * - Test with a non-existing ID.
            // * - Print the remaining employees.
            // */
            //Console.WriteLine("================quition 3=============");
            //void Remove(IDictionary<int, string> keyValuePairs, int ID)
            //{
            //    if (keyValuePairs.ContainsKey(ID))
            //    {
            //        string name = keyValuePairs[ID];
            //        if (keyValuePairs.Remove(ID))
            //        {
            //            Console.WriteLine($"the Employee {name} With ID {ID} Removin");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Some Thing wrong when Delete:");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"the Employee with ID {ID} Not Exsit");
            //    }
            //}
            //Remove(Employees, 1);
            //Remove(Employees, 102);

            //// ============================================================
            //// Q4 - Do We Need a Custom Dictionary?
            //// ============================================================

            ///*
            // * You are designing a Customer Management System.
            // *
            // * The system needs to store:
            // *
            // *      Customer ID → Customer
            // *
            // * The requirements are:
            // *
            // * - Customer IDs must be unique.
            // * - Add customers.
            // * - Find a customer by ID.
            // * - Update a customer's information.
            // * - Remove a customer by ID.
            // * - Check whether a customer exists.
            // *
            // * A developer suggests creating a completely new dictionary
            // * class instead of using the .NET collections.
            // *
            // * Before writing any code, make an engineering decision.
            // *
            // * Tasks:
            // *
            // * - Decide whether you need a custom data structure.
            // * - Choose the .NET collection/interface you would use.
            // * - Explain your decision.
            // * - Give one realistic requirement that could make a custom
            // *   dictionary implementation reasonable.
            // *
            // * Do not implement the custom dictionary.
            // */
            ////not need cutom datat structur becuse IDictionary requer al requirements 
            //// key is unique 
            ////have add fuction ,containkey for find ,update using set value  remove  
            //IDictionary<int, Customer> Customers = new Dictionary<int, Customer>()
            //{
            //    { 101, new Customer { ID=101, Name = "John Doe", Email = "john.doe@example.com", Phone = "123-456-7890" } },
            //    { 102, new Customer { ID=102, Name = "Jane Smith", Email = "jane.smith@example.com", Phone = "098-765-4321" } },
            //    { 103, new Customer { ID=103, Name=  "Hossam",Email="hossam@gmil.com" } }

            //};


            //    // ============================================================
            //    // Q5 - Reusable Dictionary Report
            //    // ============================================================

            //    /*
            //     * You are developing an application that uses dictionaries
            //     * in several different places.
            //     *
            //     * For example:
            //     *
            //     *      Employee ID → Employee Name
            //     *      Student ID  → Student Name
            //     *      Product ID  → Product Name
            //     *
            //     * You need one reusable piece of code that can receive any
            //     * dictionary containing keys and values and print its content.
            //     *
            //     * The output should look like:
            //     *
            //     *      Key: 101, Value: Hossam
            //     *      Key: 102, Value: Ali
            //     *      Key: 103, Value: Ahmed
            //     *
            //     * It should also display the total number of items.
            //     *
            //     * The code should not depend specifically on
            //     * Dictionary<TKey,TValue>, because another class that follows
            //     * the same dictionary contract should also be usable.
            //     *
            //     * Tasks:
            //     *
            //     * - Decide what type the reusable code should accept.
            //     * - Write the reusable code.
            //     * - Test it with a normal Dictionary.
            //     * - Explain why your chosen type allows the code to work with
            //     *   more than one dictionary implementation.
            //     */

            //void printDictionary(IDictionary<int, string> keyValuePairs)
            //{
            //    foreach(var item in keyValuePairs)
            //    {
            //        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //    }
            //    Console.WriteLine($"the Totel count {keyValuePairs.Count}");
            //}
            //printDictionary(Employees);
            //printDictionary(Appliction);

            #endregion




            #region Mistakes

            /*
             * ==================== Important Mistakes / Notes ====================
             */


            // ============================================================
            // 1. Add(KeyValuePair) and Add(key,value)
            // ============================================================

            /*
             * When implementing IDictionary, remember that there are
             * two Add forms:
             *
             *      Add(TKey key, TValue value)
             *
             * and:
             *
             *      Add(KeyValuePair<TKey,TValue> item)
             *
             * Both represent adding an item to the dictionary.
             *
             * Therefore, both should respect the rule:
             *
             *      Keys must be unique.
             */


            // ============================================================
            // 2. Add vs Indexer
            // ============================================================

            /*
             * Add:
             *
             *      dictionary.Add(1, "Hossam");
             *
             * Means:
             *
             *      "Add a NEW key."
             *
             * Existing key → exception.
             *
             *
             * Indexer:
             *
             *      dictionary[1] = "Ali";
             *
             * Means:
             *
             *      "Set the value for this key."
             *
             * Existing key → update.
             * Missing key → add.
             */


            // ============================================================
            // 3. ContainsKey vs Contains
            // ============================================================

            /*
             * ContainsKey:
             *
             *      dictionary.ContainsKey(1)
             *
             * Checks:
             *
             *      Key
             *
             *
             * Contains:
             *
             *      dictionary.Contains(
             *          new KeyValuePair<int,string>(1, "Hossam"))
             *
             * Checks:
             *
             *      Key + Value
             */


            // ============================================================
            // 4. TryGetValue
            // ============================================================

            /*
             * TryGetValue gives you two results:
             *
             *      bool
             *        ↓
             *      Was the key found?
             *
             *      out value
             *        ↓
             *      What is the value?
             *
             *
             * Example:
             *
             *      if(dictionary.TryGetValue(1, out string name))
             *      {
             *          Console.WriteLine(name);
             *      }
             */


            // ============================================================
            // 5. CopyTo
            // ============================================================

            /*
             * Remember:
             *
             *      CopyTo(array, arrayIndex)
             *
             * arrayIndex means:
             *
             *      The position where copying starts.
             *
             * It does NOT mean:
             *
             *      Number of elements to copy.
             *
             * Required array size must be enough for:
             *
             *      arrayIndex + Count
             */


            // ============================================================
            // 6. Your Custom Implementation Uses a List
            // ============================================================

            /*
             * Your SimpleDictionary uses:
             *
             *      List<KeyValuePair<TKey,TValue>>
             *
             * Therefore, finding a key requires searching the list.
             *
             * Conceptually:
             *
             *      Find Key
             *          ↓
             *      Start from first item
             *          ↓
             *      Compare keys
             *          ↓
             *      Continue until found
             *
             * This is O(n) lookup.
             *
             * Dictionary<TKey,TValue> is designed specifically for
             * efficient key-based lookup.
             *
             * This is one reason we normally use the existing
             * Dictionary<TKey,TValue> instead of creating a custom one
             * when there is no special requirement.
             */


            // ============================================================
            // 7. Keys and Values
            // ============================================================

            /*
             * Keys:
             *
             *      dictionary.Keys
             *
             * gives the collection of keys.
             *
             *
             * Values:
             *
             *      dictionary.Values
             *
             * gives the collection of values.
             *
             * They are different from the KeyValuePair collection:
             *
             *      KeyValuePair
             *          ↓
             *      Key + Value
             *
             *      Keys
             *          ↓
             *      Key only
             *
             *      Values
             *          ↓
             *      Value only
             */


            #endregion

            #endregion

            /*
             * ISet  
             * is inerface  located in system.collection.Generic
             * represent  collection of unique Element no dublication
             * key Featurea(uniqueness ,set operation ,add remove contains
             * */


        }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
    
    }
}
