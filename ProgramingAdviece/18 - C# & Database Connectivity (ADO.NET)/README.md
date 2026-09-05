# 18 - C# & Database Connectivity (ADO.NET)

## 📚 Course Overview

This course focuses on connecting C# applications to SQL Server databases using **ADO.NET** and applying database operations through a structured **Data Access Layer (DAL)** and **Business Layer (BLL)**.

It is an important step in the roadmap because it moves from learning SQL and database design to actually building C# code that can communicate with, retrieve, insert, update, and delete real database data.

---

## 🎯 What I Learned

### 1. ADO.NET Database Connectivity

- Understanding how C# applications communicate with SQL Server.
- Using `SqlConnection` to establish a database connection.
- Opening and closing connections correctly.
- Using `SqlCommand` to execute SQL statements.
- Working with connection strings.

### 2. Reading Data with `SqlDataReader`

- Using `ExecuteReader()` to retrieve multiple rows.
- Moving through returned records with `Read()`.
- Checking whether results exist with `HasRows`.
- Accessing column values by index and column name.
- Handling database `NULL` values with `IsDBNull()`.

### 3. Parameterized Queries

- Passing values to SQL queries through parameters.
- Using parameters such as `@ID`, `@FirstName`, and `@CountryID`.
- Understanding the importance of parameterized queries instead of directly concatenating user input into SQL statements.
- Building queries with multiple parameters.

### 4. Searching with SQL `LIKE`

Practiced parameterized searches for:

- Names that **start with** a specific value.
- Names that **end with** a specific value.
- Names that **contain** a specific value.

### 5. Executing Different Types of SQL Commands

Learned when to use:

| Method | Purpose |
|---|---|
| `ExecuteReader()` | Retrieve multiple rows of data |
| `ExecuteScalar()` | Retrieve a single value |
| `ExecuteNonQuery()` | Execute `INSERT`, `UPDATE`, and `DELETE` commands |

### 6. Retrieving a Single Value with `ExecuteScalar()`

- Using `ExecuteScalar()` when only one value is required.
- Retrieving a contact's first name by ID.
- Converting the returned `object` into the required C# type.

### 7. CRUD Operations

Implemented database operations for Contacts and Countries:

- **Create** — Insert new records.
- **Read** — Find one record or retrieve all records.
- **Update** — Modify existing records.
- **Delete** — Remove records.
- **Exists** — Check whether a record exists.

### 8. Returning the Newly Created ID

Learned how to retrieve the generated identity value after inserting a record using:

```sql
SELECT SCOPE_IDENTITY();
```

This allows the application to update the business object with the database-generated ID.

### 9. Working with `DataTable`

- Loading query results into a `DataTable`.
- Returning a `DataTable` from the Data Access Layer.
- Understanding when a tabular in-memory representation is useful for displaying database data.

### 10. Mapping Database Data to C# Objects

Practiced converting database records into C# models/structures instead of keeping database access code mixed with presentation logic.

For example:

- `StContactModel`
- `StCountryModel`
- `ClsContact`
- `ClsCountry`

### 11. Data Access Layer (DAL)

Created a dedicated layer responsible for communicating with SQL Server.

The Data Access Layer contains methods such as:

- `FindContactById()`
- `AddNewContact()`
- `UpdateContact()`
- `DeleteContact()`
- `GetAllContact()`
- `IsExsit()`
- `FindByID()`
- `FindByname()`

This helped me understand the importance of keeping database communication separate from business logic.

### 12. Business Layer (BLL)

Created business classes that represent application entities and communicate with the DAL.

The business layer handles operations such as:

- Finding contacts and countries.
- Creating new objects.
- Saving new records.
- Updating existing records.
- Deleting records.
- Checking whether records exist.

### 13. Add / Update Object State

Practiced using an internal mode such as:

```text
AddNew
Update
```

The object can therefore determine whether `Save()` should insert a new record or update an existing one.

### 14. Constructors for Object State

Applied different constructors for different object states:

- A public constructor for creating a new object.
- A private constructor for creating an object that already exists in the database.

This strengthened my understanding of constructors, object state, and encapsulation in real applications.

### 15. Exception Handling and Resource Management

- Using `try / catch / finally` around database operations.
- Closing database connections after operations.
- Returning meaningful success/failure results from DAL methods.

---

## 🏗️ Course Structure

The course currently contains practical C# projects demonstrating ADO.NET database connectivity and a layered approach:

```text
18 - C# & Database Connectivity (ADO.NET)
│
├── ADORetrieveData
│   └── Basic ADO.NET database operations
│
└── Contact-based DAL / BLL implementation
    ├── ContactDataAccessLayer
    └── ContactBussinesLayer
```

The practical work includes a Contacts/Countries database scenario and demonstrates how database operations can evolve from direct ADO.NET code into reusable Data Access and Business layers.

---

## 🔧 Technologies & Concepts

- **C#**
- **ADO.NET**
- **SQL Server**
- **.NET Framework 4.7.2**
- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`
- `ExecuteReader()`
- `ExecuteScalar()`
- `ExecuteNonQuery()`
- `DataTable`
- Parameterized SQL Queries
- SQL `LIKE`
- `SCOPE_IDENTITY()`
- CRUD Operations
- Data Access Layer (DAL)
- Business Layer (BLL)
- Object Mapping
- Exception Handling

---

## 🧠 Key Takeaway

The main lesson from this course is understanding the complete path of data inside a C# application:

```text
C# Application
      ↓
Business Layer
      ↓
Data Access Layer
      ↓
ADO.NET
      ↓
SQL Server
```

I learned that database programming is not only about writing SQL queries. It is also about designing a clean communication layer between the application and the database, handling results safely, separating responsibilities, and turning database records into usable C# objects.

This course provided the foundation I needed to build the **Data Access Layer and Business Layer used later in the DVLD project**.

---

## 📌 Course Status

**Status:** ✅ Completed

**Course:** 18 - C# & Database Connectivity (ADO.NET)

**Roadmap:** Programming Advices

**Next Step:** Apply these database connectivity and layered architecture concepts in a larger real-world project.
