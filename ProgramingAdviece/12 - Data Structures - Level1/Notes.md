# 🧠 Notes – Data Structures Level 1

These notes summarize the key concepts learned during the **Data Structures – Level 1** course.

They focus on the core ideas behind data organization, complexity analysis, and the implementation of fundamental data structures.

# 📦 What is a Data Structure?

A **Data Structure (DS)** is a way of organizing, storing, and managing data in memory so that it can be accessed and processed efficiently by a program.

Data structures define how data elements are related and how operations such as:

* storing
* retrieving
* inserting
* deleting

can be performed efficiently.

Good data structures help reduce program complexity and improve performance.

# 🧩 Data Structures vs Databases

### Data Structures

Used inside programs to manage data in **memory (RAM)**.

Main characteristics:

* Organize data during program execution
* Improve algorithm efficiency
* Reduce program complexity
* Exist only while the program is running

Examples:

* Arrays
* Stacks
* Queues
* Linked Lists

### Databases

Used to store and manage data **permanently on disk**.

Main characteristics:

* Store large amounts of persistent data
* Allow querying and managing data using SQL
* Data remains even after the system shuts down or restarts

Examples:

* MySQL
* SQL Server
* PostgreSQL

# 🧱 Classification of Data Structures

Data structures can be classified into two main types.

## Linear Data Structures

Elements are organized sequentially.

Examples:

* Array
* Stack
* Queue
* Linked List

## Non-Linear Data Structures

Elements are organized hierarchically or in network relationships.

Examples:

* Trees
* Graphs

# ⏱ Time and Space Complexity

Algorithm performance depends mainly on two factors:

1️⃣ Algorithm design
2️⃣ Hardware performance

To measure algorithm efficiency independently of hardware, we use **Big O notation**.

# 📊 Big O Notation

Big O describes the relationship between the **input size (N)** and the **execution time or memory usage** of an algorithm.

It focuses on **growth rate**, not exact time.

Common complexities:

**O(1) – Constant Time**
Execution time does not depend on input size.

**O(N) – Linear Time**
Execution time grows linearly with input size.

**O(N²) – Quadratic Time**
Execution time grows proportionally to the square of input size.

**O(log N) – Logarithmic Time**
Execution time grows slowly as input increases (common in search operations).

Two algorithms having the same Big O does not always mean they perform exactly the same, but it helps compare their scalability.

# 🧱 Binary Data Representation

Binary data structures work at the **bit level**, often using bitwise operations to manipulate data efficiently.

# 📚 Core Data Structures Studied

During this course the following data structures were studied and implemented.

## Array

A collection of elements stored in **contiguous memory locations**.

Characteristics:

* Fixed size
* Fast access using index
* Efficient for sequential data

## Matrix

A two-dimensional data structure representing rows and columns.

Often used for:

* mathematical computations
* grid-based data
* image processing

## Stack

A **Last-In First-Out (LIFO)** data structure.

Main operations:

* Push
* Pop
* Top
* Size
* Empty
* Swap

Characteristics:

* No direct access to internal elements
* Access only through the top element

## Queue

A **First-In First-Out (FIFO)** data structure.

Main operations:

* Enqueue
* Dequeue
* Front
* Back

# ⚙️ STL vs ADT

### STL – Standard Template Library

A C++ library that provides ready-to-use implementations of many data structures and algorithms.

Examples:

* vector
* map
* stack
* queue

### ADT – Abstract Data Type

Defines the **behavior and operations** of a data structure without specifying the implementation.

Example:

A stack ADT defines:

* push
* pop
* top

but does not define how the stack is implemented.

# 🔗 Linked Lists

A **Linked List** is a linear data structure composed of nodes.

Each node contains:

* Data
* Pointer to the next node

## Singly Linked List

Each node points to the **next node only**.

Typical operations implemented:

* Insert at beginning
* Insert after node
* Insert at end
* Delete node
* Delete first node
* Delete last node
* Find node

## Doubly Linked List

Each node contains:

* Pointer to the next node
* Pointer to the previous node

This allows traversal in both directions.

## Circular Linked List

The last node points back to the **first node**, creating a circular structure.

# 🗺 Map (Associative Container)

`map` is a container in the **STL** that represents an associative array.

Characteristics:

* Stores elements as **key–value pairs**
* Elements are automatically ordered by key
* Search operations typically have **O(log N)** complexity

# 🧪 Practice

During this course, implementations were created for the main operations of each data structure.

A separate **Practice folder** contains implementations and exercises related to:

* Arrays and matrices
* Stack operations
* Queue operations
* Linked list implementations
* Map usage
