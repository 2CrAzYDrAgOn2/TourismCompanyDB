CREATE DATABASE TourismCompanyDB;
USE TourismCompanyDB;

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(20)
);

CREATE TABLE Tours (
    TourID INT PRIMARY KEY IDENTITY(1,1),
    TourName NVARCHAR(100),
    Destination NVARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    Price DECIMAL(10, 2)
);

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT,
    TourID INT,
    BookingDate DATE,
    NumberOfPersons INT,
    TotalAmount DECIMAL(10, 2),
	FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
	FOREIGN KEY (TourID) REFERENCES Tours(TourID)
);

CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    BookingID INT,
    PaymentDate DATE,
    Amount DECIMAL(10, 2),
	FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
);

CREATE TABLE Registration (
	UserID INT PRIMARY KEY IDENTITY(1,1),
	UserLogin VARCHAR(50),
	UserPassword VARCHAR(50),
	IsAdmin bit
);

INSERT INTO Clients (FirstName, LastName, Email, Phone)
VALUES
    ('Иван', 'Иванов', 'ivan@example.com', '123-456-7890'),
    ('Мария', 'Петрова', 'maria@example.com', '987-654-3210');

INSERT INTO Tours (TourName, Destination, StartDate, EndDate, Price)
VALUES
    ('Отпуск на море', 'Гоа, Индия', '2023-05-15', '2023-05-25', 1200.00),
    ('Горнолыжный курорт', 'Альпы, Швейцария', '2023-12-01', '2023-12-10', 1800.00);

INSERT INTO Bookings (ClientID, TourID, BookingDate, NumberOfPersons, TotalAmount)
VALUES
    (1, 1, '2023-04-01', 2, 2400.00),
    (2, 2, '2023-11-15', 1, 1800.00);

INSERT INTO Payments (BookingID, PaymentDate, Amount)
VALUES
    (1, '2023-04-05', 1200.00),
    (2, '2023-11-20', 1800.00);

INSERT INTO Registration (UserLogin, UserPassword, IsAdmin)
VALUES
	('admin', 'admin', 1),
	('user', 'user', 0);

SELECT * FROM Clients;
SELECT * FROM Tours;
SELECT * FROM Bookings;
SELECT * FROM Payments;
SELECT * FROM Registration;

DROP DATABASE TourismCompanyDB;