# Course 18 — C# & Database Connectivity (ADO.NET)

> **Programming Advices Roadmap**

## Overview

This course introduces **ADO.NET** as the foundation for connecting C# applications to **SQL Server** databases.

The practical work progresses from direct database access using ADO.NET to a more structured application design using a **Data Access Layer (DAL)** and **Business Layer (BLL)**. The course focuses on retrieving and manipulating data, executing parameterized SQL commands, mapping database records to C# models, and separating database responsibilities from business logic.

---

## Learning Objectives

By completing this course, the following concepts and skills were practiced:

- Establishing database connectivity from C# applications.
- Executing SQL commands from C#.
- Retrieving and processing database records.
- Using parameterized SQL queries.
- Implementing CRUD operations.
- Working with `SqlDataReader` and `DataTable`.
- Retrieving single values with `ExecuteScalar()`.
- Retrieving generated identity values using `SCOPE_IDENTITY()`.
- Mapping database records to C# models.
- Separating database access from business logic.
- Designing reusable Data Access Layer methods.
- Managing object state for Add/Update operations.
- Applying constructors and encapsulation in business objects.
- Handling database exceptions and connection resources.

---

## Core ADO.NET Concepts

### Database Connection

Implemented SQL Server connectivity using:

- `SqlConnection`
- Connection strings
- `Open()` / `Close()`
- `try / catch / finally`

### SQL Command Execution

Practiced the three primary command execution methods:

| Method | Usage |
|---|---|
| `ExecuteReader()` | Retrieve multiple rows from the database |
| `ExecuteScalar()` | Retrieve a single value |
| `ExecuteNonQuery()` | Execute `INSERT`, `UPDATE`, and `DELETE` statements |

### Data Retrieval

Used `SqlDataReader` to:

- Iterate through result sets with `Read()`.
- Check for returned records with `HasRows`.
- Access values by column name or index.
- Handle database `NULL` values with `IsDBNull()`.

---

## Parameterized Queries

Implemented parameterized SQL commands using parameters such as:

- `@ID`
- `@FirstName`
- `@CountryID`

Parameterized queries were also used with SQL `LIKE` to implement:

- Starts-with searches.
- Ends-with searches.
- Contains searches.
- Multiple search conditions.

This establishes a safer and more maintainable approach to passing application values to SQL commands.

---

## CRUD Operations

Database operations were implemented for the Contacts and Countries entities.

| Operation | Implementation |
|---|---|
| **Create** | Insert new records and retrieve generated IDs |
| **Read** | Find individual records and retrieve collections |
| **Update** | Modify existing records |
| **Delete** | Remove existing records |
| **Exists** | Check whether a record exists |

For inserts, `SCOPE_IDENTITY()` was used to retrieve the newly generated database identity value.

---

## Data Mapping

Database records were mapped into C# models before being passed to the business layer.

Examples include:

- `StContactModel`
- `StCountryModel`
- `ClsContact`
- `ClsCountry`

This approach provides a clear boundary between raw database data and application-level objects.

---

## Layered Architecture

A major part of the course was moving from direct ADO.NET operations toward a layered structure.

```text
┌─────────────────────────┐
│      Application        │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│     Business Layer      │
│          (BLL)          │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│    Data Access Layer    │
│          (DAL)          │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│        ADO.NET          │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│       SQL Server        │
└─────────────────────────┘
```

### Data Access Layer (DAL)

The DAL is responsible for communication with SQL Server.

Examples of implemented operations include:

```text
FindContactById()
AddNewContact()
UpdateContact()
DeleteContact()
GetAllContact()
IsExsit()
FindByID()
FindByname()
```

### Business Layer (BLL)

The BLL provides application-level objects and operations while keeping database communication inside the DAL.

The practical implementation includes:

- `ClsContact`
- `ClsCountry`
- Find operations.
- Save operations.
- Update operations.
- Delete operations.
- Existence checks.

---

## Object State & Encapsulation

The course also applied C# object-oriented concepts to database entities.

An internal mode is used to distinguish between object states:

```text
AddNew → Create a new database record
Update → Modify an existing database record
```

Different constructors are used to represent these states, including a public constructor for new objects and a controlled constructor for objects loaded from the database.

The `Save()` operation can then determine whether the object should perform an **INSERT** or **UPDATE** operation.

This provides a practical example of combining **OOP principles with database programming**.

---

## Practical Work

The course includes practical implementations based on a **Contacts / Countries** database.

### ADO.NET Retrieval Project

**`ADORetrieveData`** demonstrates direct ADO.NET operations, including:

- Retrieving all contacts.
- Searching by first name.
- Searching by first name and country.
- Starts-with, ends-with, and contains searches.
- Retrieving a single value with `ExecuteScalar()`.
- Finding a single contact by ID.
- Converting `SqlDataReader` results into a C# structure.

### Contact Data Access & Business Layers

The practical implementation was extended into separate layers:

```text
ContactDataAccessLayer
        │
        └── SQL Server communication

ContactBussinesLayer
        │
        └── Business objects and operations
```

This demonstrates the transition from basic database connectivity to a reusable layered application structure.

---

## Technologies & Tools

- **C#**
- **ADO.NET**
- **SQL Server**
- **.NET**
- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`
- `DataTable`
- Parameterized SQL
- SQL `LIKE`
- `SCOPE_IDENTITY()`
- CRUD
- Data Access Layer (DAL)
- Business Layer (BLL)
- Object Mapping
- Exception Handling

---

## Key Takeaways

The most important outcome of this course is understanding how a C# application communicates with a relational database and how that communication can be organized into maintainable layers.

The progression can be summarized as:

```text
SQL Queries
     ↓
ADO.NET
     ↓
Data Access Layer
     ↓
Business Layer
     ↓
Application
```

This course established the database-access foundation used in larger C# applications and prepared the architecture and concepts needed for subsequent real-world projects, including the **DVLD project**.

---

## Course Status

| Item | Details |
|---|---|
| **Course** | 18 — C# & Database Connectivity (ADO.NET) |
| **Roadmap** | Programming Advices |
| **Status** | Completed |
| **Primary Technology** | C# / ADO.NET |
| **Database** | SQL Server |
| **Focus** | Database Connectivity, CRUD, DAL & BLL |

---

## Repository Structure

```text
18 - C# & Database Connectivity (ADO.NET)
│
├── ADORetrieveData
│   └── Direct ADO.NET practice
│
├── ContactDataAccessLayer
│   └── Database access operations
│
└── ContactBussinesLayer
    └── Business objects and operations
```
