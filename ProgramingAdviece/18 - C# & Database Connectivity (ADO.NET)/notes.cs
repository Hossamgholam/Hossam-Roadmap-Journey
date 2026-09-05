/* theory
 what is xml:
   1-extensible markup language.
   2-store and transport data and configurations.
   2-cross platform and language independent.

EF Core vs ADO.NET:
    maximum control and performance with ADO.NET, but more code and complexity.
    easier development and maintainability with EF Core, but potentially less control and performance.


   

/*ADo.Net
===========================
📌 Topic: what is ADO.NET?  ,ADo.Net Framework Data Providers, ADO.NET Architecutre
📅 Date: 29/04/2026

💡 Idea:
1- ADO.NET is a data access technology in the .NET Framework that provides a set of classes for working with data sources such as databases, XML files, and other data formats.

 2- ADO.NET Framework Data Providers are specific implementations of the ADO.NET architecture that allow you to connect to different types of data sources. Examples include:
   - SqlClient: for SQL Server databases.
   - OleDb: for OLE DB data sources.
   - Odbc: for ODBC data sources.
   - OracleClient: for Oracle databases (deprecated).

   is used to connect execute retrieve data from a database.
   (sqlconnection, sqlcommand, sqlDataReader, sqlDataAdapter, sqlTransaction)

 3- ADO.NET Architecture consists of several key components:
   1- Data Providers: These are the specific implementations that allow you to connect to different types of data sources.
    1.1 online data providers:
      - Connection: Represents a connection to a specific data source.
      - Command: Represents a SQL statement or stored procedure to execute against a data source.
      - DataReader: A forward-only, read-only stream of data from a data source.

    1.2 offline data providers:
      - DataAdapter: A bridge between a DataSet and a data source for retrieving and saving data.[insert,update,delete,select]

      -DataSet: An in-memory representation of data that can hold multiple tables and relationships.
      -[DataTable] ------>[dataview]

  
4-3 tier architecture:
   1- Presentation Layer: This is the user interface layer that interacts with the user. It can be a web application, desktop application, or mobile application.
   user interface,client tier

   2- Business Logic Layer: This layer contains the business rules and logic of the application. It processes data received from the presentation layer and interacts with the data access layer to retrieve or manipulate data.
   middle tier,

   3- Data Access Layer: This layer is responsible for interacting with the database or other data sources. It contains methods for performing CRUD (Create, Read, Update, Delete) operations and abstracts the underlying data access technology (e.g., ADO.NET, Entity Framework).
   persistence tier, data tier
 



---------------------------
*/

/*connect to sql server database retrieve data(online sql connection sql command sql data reader)
===========================
📌 Topic: get all ,parameterized queries,parametrized query with like, retrieve single value, find
📅 Date: 29/04/2026

💡 Idea:
      1-sql connection: represents a connection to a specific data source. It is used to establish a connection to the database and manage the connection state.
      

      4-query statment:(DDl, DML, DCL,Tcl)
        .parameterized queries are used to prevent sql injection attacks 
        .handial in  where ContactID in ("+contactIn+");";
      

      2-sql command: represents a SQL statement or stored procedure to execute against a data
        
        .executeNonQuery: used for executing SQL statements that do not return any data (e.g., INSERT, UPDATE, DELETE).
          in insert if you want to get the id of the inserted record you can use "SELECT SCOPE_IDENTITY();" after the insert statement and execute it with executeScalar to retrieve the id.
        
        .executeScalar: used for executing SQL statements that return a single value[object] (e.g., SELECT COUNT(*) FROM table).
        
        .executeReader: used for executing SQL statements that return a result set[SqlDataReader] (e.g., SELECT * FROM table).


      3-sql data reader: a forward-only, read-only stream of data from a data source. It is used to read data retrieved from the database.

    

    
    
    /*Contacts Project on 3 Tier Architecture - Console App
        ===========================
       

        💡 Idea:
            find ,update,delete,insert,list,isExist contacts in a sql server database using ado.net in a 3 tier architecture console application.

    

        */

        /*Contacts Windows Form Project
        ===========================
        

        💡 Idea:
   

    

        */


/*dataproviders ofline(dataset, datatable, dataview,dataaddapter)
===========================




          /*Datatables
          ===========================
          📌 Topic: 
          📅 Date: 14/5/2026
          
          💡 Idea:
              DataTable is an in-memory representation of a single table of data. 
              It can be used to store and manipulate data retrieved from a database or other data sources. 
              DataTables are often used in conjunction with DataAdapters to fill the DataTable with data and to update the database with changes made to the DataTable.
          
                1- create datatable and add columns and rows
                   datatable.columns.add("columnName", typeof(dataType));
                   datatable.rows.add(value1, value2, ...);
                   datatable.rows;
                   datarow["columnName"] = newValue;
          
                2-count rows, compute aggregate functions
                   datatable.rows.count;
                   datatable.compute("sum(columnName)","filterExpression");
          
                3-filter, sort, delete, clear rows
                   dataRow[] filteredRows = datatable.select("filterExpression");
          
                   datatable1.defaultview.sort = "columnName ASC|DESC";
                   datatable=datatable1.defaultview.totable();
              
                   datatable.rows[index].delete(); 
                   with foreach row.delete() you can mark multiple rows for deletion.
                   // mark the row for deletion, it will be removed when you call datatable.acceptchanges() or when you update the database with a dataadapter.
          
                   datatable.clear(); // removes all rows from the datatable but keeps the schema (columns) intact.
                4-
                   primary key:
                   datatable.primarykey = new datacolumn[] { datatable.columns["columnName"] };


         /*dataview
          ===========================
          📌 Topic: 
          📅 Date: 14/5/2026
          
          💡 Idea:
               represent databinding friendly view of a datatable.
               not storage data.
               change in dataview will reflect in datatable and vice versa.
               faster and lightweight than datatable.
              


              view=datatable.defaultview; // get the default dataview of the datatable.
              view.rowfilter="filterExpression"; // filter the dataview based on a filter expression.
              view.sort="columnName ASC|DESC"; // sort the dataview based on a
              
    

*/

   
  