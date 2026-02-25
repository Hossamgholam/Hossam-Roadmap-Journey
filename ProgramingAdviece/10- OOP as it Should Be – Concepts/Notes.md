# 📘 OOP as it Should Be – Concepts  
## Technical Notes

---

# 1️⃣ Class & Object Basics

## Class
A class is a data type that contains:

- Data Members (properties)
- Member Functions (methods)

By default, members inside a class are **private**.

---

## Object (Instance)

An object is an instance of a class used to access:

- Properties (data members)
- Methods (functions / procedures)

---

## Object Memory

- Each object has its own separate space in memory.
- Data members are duplicated per object.
- Member functions are shared between all objects.

---

# 2️⃣ Access Specifiers (Modifiers)

Purpose:
- Security
- Controlled access
- Easier code management

## Private
- Accessible only inside the same class.

## Protected
- Accessible inside the class.
- Accessible inside all derived classes.

## Public
- Accessible inside the class.
- Accessible outside the class.
- Accessible by derived classes.

---

# 3️⃣ Properties (Getters & Setters)

## Get & Set
- Do not make properties public directly.
- Use getter and setter functions for controlled access.

---

## Read-Only Property
- Provide only a getter.
- Do not provide a setter.

---

## Declaration Specification (Property Mapping)

Used to map getter and setter functions to a property-like syntax.

Example:

Instead of:
```
person1.setFirstName("Hossam");
person1.getFirstName();
```

You can write:
```
person1._firstName = "Hossam";
person1._firstName;
```

Using:
```
__declspec(property(get=getFirstName, put=setFirstName)) string _firstName;
```

---

# 4️⃣ Constructors & Destructors

## Constructors
- Object cannot be created without constructor execution.
- Can be overloaded.

### Types:
- Default constructor
- Constructor without parameters
- Constructor with parameters
- Copy constructor

---

## Copy Constructor

Example:
```
clsAddress p2 = p1;
```

Used to copy one object into another.

---

## Destructor

- Has the same name as the class but starts with `~`
- Last function called when object is destroyed
- Cannot be overloaded
- Has no parameters
- Has no return value

---

# 5️⃣ Static Members

## Static Property
- Shared between all objects.
- Modification by one object affects all.
- Exists at class level.

---

## Static Method
- Can be called without creating an object.
- Can also be called using object.
- Can call static members.
- Cannot call non-static methods (because they require an object).

---

# 6️⃣ Encapsulation & Abstraction

## Encapsulation
- Collect properties and methods inside one unit (class).

## Abstraction
- Expose only necessary properties and methods.
- Hide unnecessary internal details from the user.

(Not abstract class — conceptual abstraction)

---

# 7️⃣ Inheritance

## Base Class (Parent)
## Derived Class (Child)

- Reuse code without copy & paste.

---

## Parameterized Constructor in Base Class

Derived class must explicitly call base constructor if it has parameters.

---

## Overriding

- Derived class overrides function in base class.
- If object is of derived type, latest overridden version is used.
- Base function can be accessed inside derived class using:

```
Base::FunctionName()
```

---

# 8️⃣ Inheritance Visibility Modes

## Public Inheritance
Normal behavior.

## Private Inheritance
- Public & protected members become private in derived class.
- Accessible inside derived class only.
- Not accessible from main or further derived classes.

## Protected Inheritance
- Public & protected become protected in derived class.
- Accessible inside derived class.
- Accessible in further derived classes.
- Not accessible from main.

---

### Conclusion

Private inheritance:
- Everything becomes private in derived.
- Only derived class can use it.

Protected inheritance:
- Everything becomes protected.
- Derived and further derived can use it.
- Objects cannot access it.

---

# 9️⃣ Types of Inheritance

- Single
- Multilevel
- Hierarchical
- Multiple (C++)
- Hybrid

---

# 🔟 Upcasting vs Downcasting

## Upcasting
Parent pointer refers to child object.

Example:
```
Person* p = new Employee();
```

- Allowed
- Parent pointer cannot access child-specific members.

## Downcasting
Child pointer refers to parent.
(Not allowed without explicit casting)

Purpose:
- Work with parent reference.
- Access shared features.
- Hide child-specific details.

---

# 1️⃣1️⃣ Virtual Function

Not all overriding is runtime.

Depends on:
- Using object directly (Static / Early Binding)
- Using pointer/reference (Dynamic / Late Binding)

If parent pointer points to child:

Without `virtual`:
- Parent version is called.

With `virtual`:
- Child overridden version is called.
- Enables runtime polymorphism.

---

# 1️⃣2️⃣ Polymorphism

Means: Many forms.

Types:

1. Function Overloading (Compile Time)
2. Function Overriding (Compile Time)
3. Virtual Function (Run Time)
4. Operator Overloading

---

# 1️⃣3️⃣ Pure Virtual Function & Abstract Class

Levels of overriding:

- Overriding
- Complete overriding (virtual)
- Pure virtual (abstract class)

Used when:

- Base class is used as interface contract.
- No logical default implementation exists.
- Force derived classes to implement function.

Abstract class:
- Cannot create objects from it.
- Used for design contract.

Encapsulation is not required in abstract class.

---

# 1️⃣4️⃣ Friend Class & Friend Function

Used when you want to access:

- Private members
- Protected members

Without inheritance.

## Friend Class
```
friend class clsEmployee;
```

## Friend Function
```
friend int FunctionName();
```

---

# 1️⃣5️⃣ Miscellaneous Concepts

## Structure Inside Class

## Class Inside Class
- Enclosing class
- Inner class

---

## Separate Class in Libraries

```
#pragma once
```
Prevents compiler from loading header file multiple times.

---

## This Pointer

- Points to current object.
- Used inside class to refer to invoking object.
- Not usable inside static methods.

---

## Objects with Functions, Vectors & Dynamic Arrays
Used with parameterized constructor and arrays.

---

## Struct vs Class

| Struct | Class |
|--------|-------|
| Default Public | Default Private |
| For grouping data | For abstraction & inheritance |
| Stack | Heap |
| Only parameterized constructor | All types |

---

## Template Function & Class

```
template<typename T>
template<class Y>
```

Used for generic programming.

---