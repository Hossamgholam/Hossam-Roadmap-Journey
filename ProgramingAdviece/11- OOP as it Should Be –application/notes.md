# Bank Management System

## Project Overview

This project is a **Console Bank Management System written in C++ using Object-Oriented Programming (OOP)**.

The system simulates a simple banking environment where users can:

- Manage bank clients
- Perform financial transactions
- Manage system users
- Track login activity
- Track transfer operations
- Exchange currencies

The system uses **text files as a simple database** to store data.

---

# Project Architecture

The system follows a **layered architecture** to separate responsibilities and make the project easier to understand.

```
Bank Management System
│
├── UI Layer (Screens)
│
├── Business Logic Layer
│
├── Utility Classes
│
└── Data Storage (Text Files)
```

---

# 1. UI Layer (Screens)

This layer is responsible for **interacting with the user**.

All screens inherit from a base class called `clsScreen`.

```
clsScreen
│
├── clsShowLoginScreen
├── clsMainScreen
│
├── Client Screens
│   ├── clsClientListScreen
│   ├── clsAddNewClientScreen
│   ├── clsDeleteClientScreen
│   ├── clsUpdateClientScreen
│   └── clsFindClientScreen
│
├── Transaction Screens
│
├── User Management Screens
│
├── Login Register Screen
│
└── Currency Exchange Screen
```

### Responsibilities

- Display menus
- Receive user input
- Call business logic classes
- Check user permissions

---

# 2. Business Logic Layer

This layer contains the **core system logic**.

```
clsPerson
   │
   ├── clsBankClient
   │
   └── clsUser
```

---

## clsPerson

Base class that stores **basic personal information**.

```
firstName
lastName
email
phone
```

Both **clients and system users inherit from it**.

---

## clsBankClient

Represents a **bank account client**.

### Properties

```
Account Number
Pin Code
Account Balance
```

### Main Operations

```
Find Client
Add Client
Update Client
Delete Client
Deposit
Withdraw
Transfer
Get Total Bank Balance
```

### Transfer Logging

Each transfer operation is stored in:

```
TransferLog.txt
```

Stored data:

```
Date
Source Account
Destination Account
Amount
Source Balance
Destination Balance
User Name
```

---

## clsUser

Represents a **system user who can log into the system**.

### Properties

```
UserName
Password
Permissions
```

### Responsibilities

```
Authentication (Login)
Authorization (Permissions)
User Management
Login Logging
```

---

# Permission System

The system uses a **bitmask permission system**.

Example permissions:

```
Show Client List
Add Client
Delete Client
Update Client
Find Client
Transactions
Manage Users
Login Register
```

Each user may have **different access rights**.

---

# 3. Utility Classes

These classes provide **helper functions used across the system**.

```
clsString
clsDate
clsUtil
clsInputValidate
```

### Examples

**clsString**

```
Split strings
String manipulation
```

**clsDate**

```
Get system date
Format date
```

**clsInputValidate**

```
Validate user input
Ensure numbers are within range
```

---

# 4. Data Storage

The system uses **text files instead of a database**.

```
clients.txt
users.txt
TransferLog.txt
LoginRegister.txt
```

---

## Clients File Format

```
FirstName#//#LastName#//#Email#//#Phone#//#AccountNumber#//#PinCode#//#Balance
```

Example:

```
Ali#//#Hassan#//#ali@mail.com#//#012345#//#A100#//#1234#//#5000
```

---

## Users File Format

```
FirstName#//#LastName#//#Email#//#Phone#//#UserName#//#Password#//#Permission
```

---

## Transfer Log Format

```
DateTime#//#SourceAccount#//#DestinationAccount#//#Amount#//#SourceBalance#//#DestinationBalance#//#UserName
```

---

## Login Register Format

```
DateTime#//#UserName#//#EncryptedPassword#//#Permissions
```

---

# System Flow

```
Program Start
      │
      ▼
Login Screen
      │
      ▼
User Authentication
      │
      ▼
Main Menu
      │
      ├── Client Management
      │
      ├── Transactions
      │
      ├── User Management
      │
      ├── Login Register
      │
      └── Currency Exchange
```

---

# Security Features

```
User Authentication
Permission-Based Access Control
Maximum Login Attempts (3)
Login History Logging
Transfer Operation Logging
```

---

# Main Features

```
Client Management
Add / Update / Delete Clients
Search Clients

Transactions
Deposit
Withdraw
Transfer
Total Balance Calculation

User Management
Add / Update / Delete Users
Permission System

Logs
Login Register
Transfer History

Currency Exchange
```

---

# Technologies Used

```
C++
Object-Oriented Programming (OOP)
File Handling
STL (vector, string)
Console Application
```
