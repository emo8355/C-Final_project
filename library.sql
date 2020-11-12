DROP DATABASE IF EXISTS Library
GO

CREATE DATABASE Library
GO

USE Library
GO

CREATE TABLE [customer] (
    customer_id INTEGER PRIMARY KEY IDENTITY(1,1),
	firstname NVARCHAR(50) NOT NULL,
	lastname NVARCHAR(50) NOT NULL,
    email NVARCHAR(255) NOT NULL,
    password CHAR(64) NOT NULL,
    phonenumber CHAR(25),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT customer_indentify UNIQUE(email)
)
GO

CREATE TABLE [category] (
    category_id INTEGER PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE [author] (
    author_id INTEGER PRIMARY KEY IDENTITY(1,1),
	firstname NVARCHAR(50) NOT NULL,
	lastname NVARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT author_indentify UNIQUE(firstname,lastname)
)
GO

CREATE TABLE [books] (
    book_id INTEGER PRIMARY KEY IDENTITY(1,1),
	title NVARCHAR(180) NOT NULL,
	language NVARCHAR(50) NOT NULL,
	category_id INTEGER NOT NULL DEFAULT 0,
	author_id INTEGER NOT NULL DEFAULT 0,
	published_date DATETIME NOT NULL,
	FOREIGN KEY (category_id) REFERENCES category(category_id),
    FOREIGN KEY (author_id) REFERENCES author(author_id),
	CONSTRAINT book_indentify UNIQUE(author_id,title)
)
GO

CREATE TABLE [borrowed_books](
	customer_id INTEGER,
	book_id INTEGER,
	is_returned BIT DEFAULT 0,
	created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    FOREIGN KEY (book_id) REFERENCES books(book_id),
	CONSTRAINT borrowed UNIQUE(customer_id,book_id)
)
GO
