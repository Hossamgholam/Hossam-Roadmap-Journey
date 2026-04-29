# 🧠 OOP in C# – Notes & Practice

This file documents my understanding and practice while learning OOP in C#.

---

## 🔹 Core Concepts

### 📌 Encapsulation
- Hiding internal data and exposing controlled access
- Implemented using:
  - Access Modifiers
  - Properties

---

### 📌 Abstraction
- Focus on what the object does, not how
- Implemented using:
  - Abstract classes
  - Interfaces

---

### 📌 Inheritance
- "is-a" relationship
- Derived class can access:
  - public & protected members
- Used for code reuse and structure

---

### 📌 Polymorphism
- Same method, different behavior

Types:
- Runtime (override / virtual)
- Compile-time (overloading)

---

## 🔹 C# OOP Features

### 📌 Access Modifiers
- public
- private
- protected
- internal
- protected internal
- private protected

---

### 📌 Properties
- Getter / Setter
- Read-only properties
- Auto-implemented properties
- Validation inside setters

---

### 📌 Constructors
- Default
- Parameterized
- Static constructor
- Private constructor

---

### 📌 Static Members
- Shared between all objects
- Used for:
  - Counters
  - Global state

---

### 📌 Advanced Topics
- Sealed class / method
- Partial class / method
- Inner class
- Composition

---

## 🔹 Practical Implementations

### 🎫 Ticket System
- Used static members
- Counted number of objects
- Practiced shared state

---

### 👤 Person / Student (Access Modifiers)
- Tested visibility levels
- Practiced inheritance access rules

---

### 🧾 Person with Properties
- Applied validation in setters
- Implemented change tracking using Stack

---

### 🔍 Search System
- Static Find methods
- Overloading:
  - Search by Id
  - Search by username & password

---

### 🧮 Calculator
- Encapsulation
- Internal state tracking
- Controlled operations

---

### 🏢 Person / Employee System
- Inheritance with constructors
- Method extension (AddBonus)
- Real-world modeling

---

### 🔁 Polymorphism Example
- virtual & override
- Upcasting behavior
- Method hiding (new keyword)

---

## ⚠️ Mistakes & Observations

- Mixing logic with Console output
- Using static incorrectly (shared vs instance confusion)
- Unsafe downcasting may cause runtime errors
- Some naming not following conventions (PascalCase)

---

## 🧠 Key Insights

- Object stores data, not behavior (behavior shared via class)
- Upcasting simplifies handling collections
- Downcasting should be used carefully
- Properties are better than public fields
- OOP is about design, not syntax

---

## 🚀 Conclusion

This was not just learning syntax...

It was the first step in thinking like a backend developer using OOP in C#.