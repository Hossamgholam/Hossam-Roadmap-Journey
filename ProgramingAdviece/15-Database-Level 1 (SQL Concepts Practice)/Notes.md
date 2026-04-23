# 📚 Database – Level 1 Notes

### From Raw Data → To Structured Systems

---

## 🧠 1. Foundations

### 🔹 Data → Information → Knowledge → Wisdom

- **Data** → raw facts  
- **Information** → processed data  
- **Knowledge** → applying information  
- **Wisdom** → making correct decisions  

---

### 🔹 Data Structures vs Databases

**Data Structures (DS)**
- Work inside program (RAM)
- Temporary (exist while program runs)
- Used for fast access and reducing complexity

**Databases (DB)**
- Stored permanently (Disk)
- Exist after system restart
- Used to manage large data using SQL

---

## 🏗️ 2. Database Basics

### 🔹 What is a Database?
- Organized collection of data managed by DBMS

### 🔹 Types:
- **DBMS** → non-relational (File System, XML)
- **RDBMS** → relational (SQL Server, Oracle)

👉 Data is stored as:
- Table → Entity Set  
- Row → Record  
- Column → Attribute  

---

### 🔹 Important Concepts

#### NULL
- Missing / Unknown value  
- Not equal to 0 or empty  

#### Primary Key (PK)
- Unique + NOT NULL  
- Identifies each record  

#### Foreign Key (FK)
- References PK in another table  
- Maintains relationships  

---

### 🔹 Redundancy
- Duplicate data  
❌ Problems:
- Wasted space  
- Data inconsistency  
- Hard maintenance  

✅ Solution:
- Normalization  

---

### 🔹 Data Integrity

Ensures data is:
- Accurate  
- Consistent  
- Reliable  

Types:
- Entity Integrity  
- Referential Integrity  
- Domain Integrity  
- Business Rules  

---

### 🔹 Constraints

Rules applied to data:
- Primary Key  
- Foreign Key  
- NOT NULL  
- UNIQUE  
- CHECK  

---

## 🧩 3. Database Design

### 🔹 ERD (Entity Relationship Diagram)

Used to design database before implementation

#### Components:
- Entity  
- Attribute  
- Relationship  

#### Relationships:
- 1:1  
- 1:N  
- M:N  

---

### 🔹 Advanced Concepts

#### Generalization
- Combine common properties into parent entity  
👉 (Bottom-Up)

#### Specialization
- Split entity into sub-entities  
👉 (Top-Down)

---

## 🔄 4. Relational Schema

Convert ERD → Tables

### Key Rules:

- 1:N → FK in "Many" side  
- M:N → New table  
- 1:1 → FK in one side  
- Multivalued → Separate table  

---

## 💻 5. SQL

### 🔹 Types of SQL

- **DDL** → Create / Alter / Drop  
- **DML** → Insert / Update / Delete  
- **DQL** → Select  
- **DCL** → Grant / Revoke  
- **TCL** → Commit / Rollback  

---

## ⚙️ 6. DDL (Structure)

- CREATE TABLE  
- ALTER TABLE  
- DROP TABLE  

Also:
- Data Types  
- Backup & Restore  

---

## ✏️ 7. DML (Data)

- INSERT  
- UPDATE  
- DELETE  

### 🔹 Important:

**DELETE vs TRUNCATE**

| Feature | DELETE | TRUNCATE |
|--------|--------|----------|
| Condition | Yes | No |
| Transaction | Yes | No |
| Reset Identity | No | Yes |

---

## 🔍 8. Queries (DQL)

### Basics:
- SELECT  
- WHERE  
- ORDER BY  
- DISTINCT  

### Advanced:
- GROUP BY  
- HAVING  
- Aggregations (SUM, AVG, COUNT)

---

### 🔹 LIKE & Wildcards

- `%` → multiple characters  
- `_` → single character  

---

## 🔗 9. Joins

- INNER JOIN  
- LEFT JOIN  
- RIGHT JOIN  
- FULL JOIN  

👉 Used to combine tables  

---

## 🧱 10. Views

- Virtual tables  
- Save repeated queries  
- Improve readability  

---

## ⚡ 11. Advanced SQL

- EXISTS  
- UNION  
- CASE  

---

## 🔒 12. Constraints & Index

### Constraints:
- PK, FK, UNIQUE, CHECK, DEFAULT  

### Index:
- Improves search performance  
- Should be used wisely  

---

## 🧼 13. Normalization

### Goal:
- Reduce redundancy  
- Improve consistency  

### Levels:

**1NF**
- Atomic values  
- No repeating groups  

**2NF**
- No partial dependency  

**3NF**
- No transitive dependency  

---

## 🧠 Final Insight

Databases are not about storing data.

👉 They are about **designing systems correctly**

Bad design = bugs + slow systems  
Good design = clean, scalable software