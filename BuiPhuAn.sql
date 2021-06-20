CREATE DATABASE BuiPhuAnDB
USE BuiPhuAnDB

CREATE TABLE UserAccount(
	ID INT IDENTITY(1,1) ,
	UserName VARCHAR(50) UNIQUE,
	Password VARCHAR(50),
	Status VARCHAR(10),
	PRIMARY KEY(ID)
)

CREATE TABLE Category(
	ID INT IDENTITY(1,1),
	Name NVARCHAR(50),
	Description NVARCHAR(200),
	PRIMARY KEY(ID)
)

CREATE TABLE Product(
	ID INT IDENTITY(1,1) ,
	Name NVARCHAR(50),
	UnitCost INT, 
	Quantity INT,
	UrlImage VARCHAR(max),
	Description NVARCHAR(200),
	Status VARCHAR(10),
	CategoryID INT,
	PRIMARY KEY(ID),
	FOREIGN KEY(CategoryID) REFERENCES dbo.Category(ID)
)

DROP TABLE	dbo.Product

INSERT dbo.UserAccount
        ( UserName, Password, Status )
VALUES  ( 'tuan', -- UserName - varchar(50)
          'abc123', -- Password - varchar(50)
          'ACTIVE'  -- Status - varchar(10)
          ),
		  ( 'dinh', -- UserName - varchar(50)
          'abc123', -- Password - varchar(50)
          'BLOCK'  -- Status - varchar(10)
          )

INSERT dbo.Category
        ( Name, Description )
VALUES  ( N'CLASSIC', -- Name - nvarchar(50)
          N'aaaaaaa'  -- Description - nvarchar(200)
          )