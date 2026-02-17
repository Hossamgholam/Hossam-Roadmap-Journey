# C++ Level 2 – Organized Notes

---

## 1️⃣ Debugging

### Breakpoints & Memory Inspection
- Breakpoint
- Auto Window (Visual Studio)
- Quick Watch (Shift + F9)

### Execution Control
- Step Into → F11
- Step Over → F10
- Step Out → Shift + F11

Debugging allows inspecting memory and execution flow step by step.

---

## 2️⃣ Miscellaneous Concepts

### Create Your Own Library
- Organizing reusable code into custom libraries.

### Short-Hand If (Ternary Operator)
```cpp
string result = (grade > 50) ? "pass" : "failed";
```

### Range-Based Loop
```cpp
for (int n : your_array) { }
```

### Input Validation
```cpp
cin.fail();
cin.clear();
cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
```

### Bitwise Operators
- Bitwise AND (&)
- Bitwise OR (|)

---

## 3️⃣ More About Functions

- Function Declaration vs Definition
- Default Parameters
- Function Overloading
- Recursion
- Call Stack & Active Frames

### Navigation Shortcuts (Visual Studio)
- Ctrl + F12 → Go to declaration
- F12 → Go to definition
- Shift + F12 → Show all calls

---

## 4️⃣ More About Variables

### Static Variable
- Declared inside a function
- Lifetime persists across function calls

Example:
```cpp
int add(int myNumber) {
    static int total = 0;
    total += myNumber;
    return total;
}
```

### Global Variable
- Accessible across the program

### Automatic Variable
```cpp
auto number = 12;
```

### Register Variable
- Deprecated after C++11

---

## 5️⃣ Printing & Formatting

### Integer Formatting
```cpp
printf("%d", number);
printf("%0*d", width, number);
```

### Float Formatting
```cpp
printf("%.4f", number);
```

### String & Char Formatting
```cpp
printf("%s", name);
printf("%*c", width, ch);
```

### iomanip
```cpp
#include <iomanip>
setw(10);
```

---

## 6️⃣ Arrays

- Two-dimensional arrays

---

## 7️⃣ Vectors (Dynamic Arrays)

### Declaration
```cpp
vector<int> numbers;
```

### Add / Remove
```cpp
numbers.push_back(10);
numbers.pop_back();
```

### Utility Functions
- empty()
- size()
- clear()
- front()
- back()
- capacity()

### Access Elements
```cpp
numbers.at(0);
numbers[0];
```

### Iteration Methods

#### Iterator
```cpp
vector<int>::iterator iter;
for (iter = numbers.begin(); iter < numbers.end(); iter++) {
    cout << *iter;
}
```

#### Range-Based Loop
```cpp
for (const int& n : numbers) {
    cout << n;
}
```

#### Index-Based Loop
```cpp
for (int i = 0; i < numbers.size(); i++) {
    cout << numbers[i];
}
```

---

## 8️⃣ References & Pointers

### Reference
```cpp
int a = 10;
int& x = a;
```

### Pointer
```cpp
int* p = &a;
```

### Dereferencing
```cpp
cout << *p;
```

### Pointer with Swap
```cpp
void swap(int* n1, int* n2) {
    int temp = *n1;
    *n1 = *n2;
    *n2 = temp;
}
```

### Pointer with Array
```cpp
int arr[5];
int* ptr = arr;

for (int i = 0; i < 5; i++) {
    cout << *(ptr + i) << endl;
}
```

### Pointer with Structure
```cpp
ptr->name;
ptr->salary;
```

### Void Pointer
```cpp
void* ptr;
float y = 23.4;
ptr = &y;
cout << *(static_cast<float*>(ptr));
```

---

## 9️⃣ Dynamic Memory Allocation

### new / delete
```cpp
int* p = new int;
delete p;
```

### Dynamic Array
```cpp
int* arr = new int[5];
delete[] arr;
```

### Memory Areas
- Stack → local variables
- Heap → dynamic variables
- Static → global/static variables
- Code Segment → program instructions

---

## 🔟 Exception Handling

Types of errors:
- Runtime error
- Logical error
- Crash error

Example:
```cpp
try {
    // risky code
}
catch(...) {
    // handle error
}
```

---

## 1️⃣1️⃣ Dealing with String

### String Functions
- length()
- at()
- append()
- insert()
- substr()
- push_back()
- pop_back()
- find()
- clear()

### cctype Functions
- toupper()
- tolower()
- isupper()
- islower()
- isdigit()
- ispunct()

---

## 1️⃣2️⃣ File Handling

### Write Mode
- ios::out

### Append Mode
- ios::app

### Read Mode
- ios::in

### Load File into Vector
```cpp
while (getline(myfile, line)) {
    myvector.push_back(line);
}
```

### Update / Delete Record
- Convert file → vector
- Modify vector
- Rewrite file

---

## 1️⃣3️⃣ Date & Time

### Local & UTC
```cpp
time_t t = time(0);
char* dt = ctime(&t);
```

- gmtime()
- asctime()

### tm Structure Fields
- tm_year
- tm_mon
- tm_mday
- tm_hour
- tm_min
- tm_sec
- tm_wday
- tm_yday
- tm_isdst
