#  Introduction to Programming with C++ – Level 1  
## Personal Structured Notes

This document represents my structured understanding of C++ fundamentals.
This is not random syntax collection — it is organized knowledge built on thinking first.

---

#  1️⃣ C++ Overview

- Cross-platform language
- Supports Procedural Programming
- Supports Object-Oriented Programming (OOP)
- Close to hardware (gives strong memory understanding)

Comparison mindset:

- C → Procedural
- Java → Pure OOP focus
- C++ → Both (Procedural + OOP)

C++ is a tool to implement logic — not programming itself.

---

#  2️⃣ Output & Buffering

Two main line-ending techniques:

- `endl` → inserts new line + flushes buffer
- `\n` → inserts new line only (faster)

Use `\n` when performance matters.

---

#  3️⃣ Literals & Escape Sequences

### Literal
A literal is a fixed value stored directly in the program.

Examples:
- Integer → 10
- Floating → 10.5
- Character → 'A'
- String → "Hello"

### Escape Sequences
Used inside strings:

- `\n` → new line
- `\t` → tab
- `\\` → backslash
- `\"` → double quote
- `\'` → single quote
- `\a` → alert sound

---

#  4️⃣ Data Types

## A) Fundamental Types

### Integral Types
- int (4 bytes)
- short (2 bytes)
- long (4 bytes)
- long long (8 bytes)
- char (1 byte – ASCII)
- bool (1 byte)

### Floating Types
- float (4 bytes)
- double (8 bytes)
- long double (12 bytes)

### Other
- string
- void
- wchar_t (2 bytes – Unicode)

Use `sizeof()` to check memory size.

---

## B) Type Modifiers

- signed (default)
- unsigned
- short
- long

Examples:

```cpp
unsigned int
unsigned short
unsigned long long
```

---

## C) Derived Types

- Array
- Function
- Pointer
- Reference

---

## D) User-Defined Types

- struct
- class
- enum
- union
- typedef

---

# 5️⃣ Variable Naming Rules

Valid:
- Letters
- Numbers
- Underscore (_)
- Must NOT start with number
- No spaces
- No special characters
- Case sensitive

Invalid examples:
- 2x
- my-name
- my name
- #name

---

#  6️⃣ Operators

### Arithmetic
+  -  *  /  %

### Relational
==  !=  >  <  >=  <=

### Logical
&&  ||  !

### Assignment
=  +=  -=  *=  /=

---

#  7️⃣ Math Functions (`<cmath>`)

```cpp
sqrt(x)
pow(x,y)
abs(x)
ceil(x)
floor(x)
round(x)
```

---

#  8️⃣ Structures

Used to group related variables.

```cpp
struct Car {
    string brand;
    string model;
    int year;
};
```

Nested struct example:

```cpp
struct PersonContact {
    string email;
    string phone;
};

struct Person {
    string name;
    short age;
    PersonContact contact;
};
```

Struct = foundation before OOP classes.

---

#  9️⃣ Enum (Enumeration)

Special type representing a set of constants.

```cpp
enum Color { red, blue, green, black };
```

Usage:

```cpp
Color myColor = Color::red;
```

Enum improves readability over raw integers.

---

#  1️⃣0️⃣ Casting

## Implicit
Automatic conversion.

## Explicit
Manual conversion.

### String to Number
```cpp
stoi()
stof()
stod()
```

### Number to String
```cpp
to_string()
```

---

#  1️⃣1️⃣ String Handling

Important operations:

```cpp
s.length()
s[index]
s1 + s2
```

### getline()
Used to read full line including spaces.

When mixing `cin` and `getline`:

```cpp
cin.ignore();
getline(cin, name);
```

---

#  1️⃣2️⃣ Functions

Two main types:

### Void Function
Does not return value.

### Returning Function
Returns value (int, double, etc.)

---

##  Scope

### Local Variable
Defined inside function.

### Global Variable
Defined outside all functions.
Accessed using `::`

---

##  Passing Parameters

### Pass By Value
- Creates copy
- Changes do NOT affect original

### Pass By Reference
- Uses &
- Changes affect original variable

```cpp
void changeValue(int &x) {
    x = 100;
}
```

---

#  1️⃣3️⃣ Loops

### for Loop
Used when number of repetitions is known.

### while Loop
Used when repetition count is unknown.

Nested loops used for:
- Patterns
- Tables
- Combinations

---

#  1️⃣4️⃣ Arrays

```cpp
int arr[10];
```

Searching example:

```cpp
for(int i = 0; i < size; i++) {
    if(arr[i] == value) {
        // found
    }
}
```

---

#  Final Understanding

This course built:

- Comfort with C++ syntax
- Control over variables and types
- Logical structuring using functions
- Data grouping using structs and enums
- Real understanding of loops and conditions
- Foundation for memory thinking

C++ here was not the goal.

Correct implementation of thinking was the goal.

Thinking → Logic → Structured Code

This is where real programming started.