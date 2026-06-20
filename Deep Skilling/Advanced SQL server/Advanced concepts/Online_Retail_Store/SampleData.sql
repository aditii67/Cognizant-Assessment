-- Create Database
CREATE DATABASE OnlineRetailStore;
GO

USE OnlineRetailStore;
GO

-- Create Products Table

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert Data

INSERT INTO Products VALUES
(1,'Laptop','Electronics',85000),
(2,'Mobile','Electronics',60000),
(3,'Headphones','Electronics',5000),
(4,'Smart Watch','Electronics',15000),

(5,'Shirt','Fashion',2500),
(6,'Jacket','Fashion',4500),
(7,'Shoes','Fashion',4000),
(8,'Jeans','Fashion',3000),

(9,'Dining Table','Furniture',25000),
(10,'Sofa','Furniture',50000),
(11,'Chair','Furniture',7000),
(12,'Bed','Furniture',40000);