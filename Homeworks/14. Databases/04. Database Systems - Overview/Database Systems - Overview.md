#  Database Systems - Homework #

### 1. What database models do you know? ###

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated.

**Database models:**

* Hierarchical (tree) - A hierarchical database model is a data model in which the data is organized into a tree-like structure. The hierarchical database model mandates that each child record has only one parent, whereas each parent record can have one or more child records. In order to retrieve data from a hierarchical database the whole tree needs to be traversed starting from the root node. 
* Network / graph - The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs.While the hierarchical database model structures data as a tree of records, with each record having one parent record and many children, the network model allows each record to have multiple parent and child records, forming a generalized graph structure.
* Relational (table) - The relational model for database management is an approach to managing data using a structure and language consistent. The purpose of the relational model is to provide a declarative method for specifying data and queries: users directly state what information the database contains and what information they want from it, and let the database management system software take care of describing data structures for storing the data and retrieval procedures for answering queries.Most relational databases use the SQL data definition and query language.
* Object-oriented - An object database is a database management system in which information is represented in the form of objects as used in object-oriented programming. Object databases are different from relational databases which are table-oriented.

### 2. Which are the main functions performed by a Relational Database Management System (RDBMS)? ###

A relational database management system (RDBMS) is a database management system (DBMS) that is based on the relational model.Relational databases have often replaced legacy hierarchical databases and network databases because they are easier to understand and use. RDBMS systems are also known as Database management servers. Existing DBMSs provide various functions that allow management of a database and its data which can be classified into four main functional groups:

* Data definition – Creation, modification and removal of definitions that define the organization of the data.
* Update – Insertion, modification, and deletion of the actual data.
* Retrieval – Providing information in a form directly usable or for further processing by other applications. The retrieved data may be made available in a form basically the same as it is stored in the database or in a new form obtained by altering or combining existing data from the database.
* Administration – Registering and monitoring users, enforcing data security, monitoring performance, maintaining data integrity, dealing with concurrency control, and recovering information that has been corrupted by some event such as an unexpected system failure.

### 3. Define what is "table" in database terms. ###

Database tables consist of data, arranged in rows and columns. All rows of the table have the same structure. And columns have name and type (number, string, date, image, or other).

### 4. Explain the difference between a primary and a foreign key. ###
Primary key is a column of the table that uniquely identifies its rows (usually its is a number).Two records (rows) are different if and only if their primary keys are different. The primary key can be composed by several columns (composite primary key).The foreign key is an identifier of a record located in another table (usually its primary key).

**Differences:**

* There is only one primary key allowed per table but you may have more than one foreign key per table.
* Primary key will not allowed "null values" and "Duplicate values" while in foreign key allowed.
* By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index. Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.

### 5. Explain the different kinds of relationships between tables in relational databases. ###
There are three types of relationships:

* One-to-one: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. They're like spouses - you may or may not be married, but if you are, both you and your spouse have only one spouse. Most one-to-one relationships are forced by business rules and don't flow naturally from the data. In the absence of such a rule, you can usually combine both tables into one table without breaking any normalization rules.
* One-to-many: The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between you and a parent. You have only one mother, but your mother may have several children.
* Many-to-many: Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.


### 6. When is a certain database schema normalized? ###

Normalization is basically to design a database schema such that duplicate and redundant data is avoided. If some piece of data is duplicated several places in the database, there is the risk that it is updated in one place but not the other, leading to data corruption.
A typical example of normalization is that an entity's unique ID is stored everywhere in the system but its name is held in only one table. The name can be updated more easily in one row of one table. A typical update in such an example would be the RIM company changing its name to BlackBerry. That update would be done in one place and immediately the correct "BlackBerry" name would be displayed throughout the system.

### 7. What are the advantages of normalized databases? ###

The objectives of normalization:

* To free the collection of relations from undesirable insertion, update and deletion dependencies.
* To reduce the need for restructuring the collection of relations, as new types of data are introduced, and thus increase the life span of application programs
* To make the relational model more informative to users
* To make the collection of relations neutral to the query statistics, where these statistics are liable to change as time goes by

### 8. What are database integrity constraints and when are they used? ###

Integrity constraints ensure data integrity in the database tables. Enforce data rules which cannot be violated. Type of constrains:

* Primary key constraint - ensures that the primary key of a table has unique value for each table row.
* Unique key constraint - ensures that all values in a certain column (or a group of columns) are unique.
* Foreign key constraint - ensures that the value in given column is a key from another table.
* Check constraint - ensures that values in a certain column meet some predefined condition

### 9. Point out the pros and cons of using indexes in a database. ###

A database index is a data structure that improves the speed of data retrieval operations on a database table at the cost of additional writes and storage space to maintain the index data structure. Indexes are used to quickly locate data without having to search every row in a database table every time a database table is accessed. Indexes can be created using one or more columns of a database table, providing the basis for both rapid random lookups and efficient access of ordered records.

**Pros:**

* Usually implemented as B-trees - allow fast searching.
* Indexes can be built-in the table (clustered) or stored externally (non-clustered)

**Cons:**

* Adding and deleting records in indexed tables is slower
* Indexes should be used for big tables only (e.g. 50 000 rows)


### 10. What's the main purpose of the SQL language? Give an example.###

SQL (Structured Query Language) is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS). 

The example below demonstrates a query of multiple tables, grouping, and aggregation, by returning a list of books and the number of authors associated with each book.

      SELECT Book.title AS Title,
             count(*) AS Authors
        FROM Book
        JOIN Book_author
          ON Book.isbn = Book_author.isbn
    GROUP BY Book.title;


### 11. What is a NoSQL database? ###

A NoSQL (originally referring to "non SQL" or "non relational" ) database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. Motivations for this approach include: simplicity of design, simpler "horizontal" scaling to clusters of machines, which is a problem for relational databases,and finer control over availability. NoSQL databases are increasingly used in big data and real-time web applications. NoSQL systems are also sometimes called "Not only SQL" to emphasize that they may support SQL-like query languages.

**Relational vs. NoSQL Databases**

Relational databases

* Data stored as table rows
* Relationships between related rows
* Single entity spans multiple tables
* RDBMS systems are very mature, rock solid

NoSQL databases

* Data stored as documents
* Single entity (document) is a single record
* Documents do not have a fixed structure

**NoSQL pros/cons**

Advantages :

* High scalability
* Distributed Computing
* Lower cost
* Schema flexibility, semi-structure data
* No complicated Relationships

Disadvantages

* No	standardization
* Limited query capabilities (so far)
* Eventual consistent is not intuitive to program for 

### 12. Explain the classical non-relational data models. ###

The term NoSQL was coined by Carlo Strozzi in the year 1998. He used this term to name his Open Source, Light Weight, DataBase which did not have an SQL interface.

In the early 2009, when last.fm wanted to organize an event on open-source distributed databases, Eric Evans, a Rackspace employee, reused the term to refer databases which are non-relational, distributed, and does not conform to atomicity, consistency, isolation, durability - four obvious features of traditional relational database systems.

In the same year, the "no:sql(east)" conference held in Atlanta, USA, NoSQL was discussed and debated a lot.

And then, discussion and practice of NoSQL got a momentum, and NoSQL saw an unprecedented growth.

In today’s time data is becoming easier to access and capture through third parties such as Facebook, Google+ and others. Personal user information, social graphs, geo location data, user-generated content and machine logging data are just a few examples where the data has been increasing exponentially. To avail the above service properly, it is required to process huge amount of data. Which SQL databases were never designed. The evolution of NoSql databases is to handle these huge data properly.

### 13. Give few examples of NoSQL databases and their pros and cons. ###

* **Document model** (e.g. MongoDB, CouchDB) - Set of documents, e.g. JSON strings. The central concept of a document store is the notion of a "document". While each document-oriented database implementation differs on the details of this definition, in general, they all assume that documents encapsulate and encode data (or information) in some standard formats or encodings. Encodings in use include XML, YAML, and JSON as well as binary forms like BSON. 

* **Key-value model** (e.g. Redis)- Set of key-value pairs. Key-value (KV) stores use the associative array (also known as a map or dictionary) as their fundamental data model. In this model, data is represented as a collection of key-value pairs, such that each possible key appears at most once in the collection.The key-value model is one of the simplest non-trivial data models, and richer data models are often implemented on top of it. The key-value model can be extended to an ordered model that maintains keys in lexicographic order. This extension is powerful, in that it can efficiently process key ranges.
*Examples include Oracle NoSQL Database, redis, and dbm.*

* **Hierarchical key-value** - Hierarchy of key-value pairs. Graph DBMS, also called graph-oriented DBMS or graph database, represent data in graph structures as nodes and edges, which are relationships between nodes. They allow easy processing of data in that form, and simple calculation of specific properties of the graph, such as the number of steps needed to get from one node to another node. Graph DBMSs usually don't provide indexes on all nodes, direct access to nodes based on attribute values is not possible in these cases.*Examples include Neo4j, Titan, OrientDB, ArangoDB, Giraph*

* **Wide-column model** (e.g. Cassandra)- Key-value model with schema. A wide column store is a type of key-value database. It uses tables, rows, and columns, but unlike a relational database, the names and format of the columns can vary from row to row in the same table. *Examples: Apache Cassandra, Apache HBase, Apache Accumulo, Hypertable, Sqrrl.*

* **Object model** (e.g. Cache)- Set of OOP-style objects. *Examples:  DB4O, Objectivity/DB, Perst, Shoal, ZopeDB.*