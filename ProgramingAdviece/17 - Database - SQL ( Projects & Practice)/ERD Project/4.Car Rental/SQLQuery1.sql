-- =========================
-- Customer
-- =========================
use RentCar EXEC sp_changedbowner 'sa'
CREATE TABLE Customer (
    CustomerId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    DriverLicenseNumber NVARCHAR(50)
);

-- =========================
-- FuelType
-- =========================
CREATE TABLE FuelType (
    FuelTypeId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50)
);

-- =========================
-- VehicleCategory
-- =========================
CREATE TABLE VehicleCategory (
    CategoryId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50)
);

-- =========================
-- Vehicle
-- =========================
CREATE TABLE Vehicle (
    VehicleId INT PRIMARY KEY IDENTITY,
    Make NVARCHAR(50),
    Model NVARCHAR(50),
    Year INT,
    Mileage INT,
    RentalRate DECIMAL(10,2),
    PlateNumber NVARCHAR(20),

    FuelTypeId INT,
    CategoryId INT,

    FOREIGN KEY (FuelTypeId) REFERENCES FuelType(FuelTypeId),
    FOREIGN KEY (CategoryId) REFERENCES VehicleCategory(CategoryId)
);

-- =========================
-- Booking
-- =========================
CREATE TABLE Booking (
    BookingId INT PRIMARY KEY IDENTITY,
    StartDate DATE,
    EndDate DATE,
    PickupLocation NVARCHAR(100),
    DropoffLocation NVARCHAR(100),

    InitialRentalDays INT,
    InitialTotalDueAmount DECIMAL(10,2),
    InitialVehicleCheckNotes NVARCHAR(255),
    RentalPricePerDay DECIMAL(10,2),

    CustomerId INT,
    VehicleId INT,

    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (VehicleId) REFERENCES Vehicle(VehicleId)
);

-- =========================
-- Transaction
-- =========================
CREATE TABLE [Transaction] (
    TransactionId INT PRIMARY KEY IDENTITY,

    PaidInitialDueAmount DECIMAL(10,2),
    PaymentDetails NVARCHAR(255),
    TransactionDate DATE,

    ActualFinalAmountDue DECIMAL(10,2),
    RemainingAmount DECIMAL(10,2),
    RefundAmount DECIMAL(10,2),

    UpdateTransactionDate DATE,

    BookingId INT UNIQUE, 


    FOREIGN KEY (BookingId) REFERENCES Booking(BookingId)
);

-- =========================
-- Return
-- =========================
CREATE TABLE [Return] (
    ReturnId INT PRIMARY KEY IDENTITY,

    ActualReturnDate DATETIME,
    ActualRentalDays INT,
    FinalCheckNotes NVARCHAR(255),
    AdditionalCharges DECIMAL(10,2),

    CurrentMileage INT,
    ConsumedMileage INT,
    ActualFinalAmountDue DECIMAL(10,2),

    BookingId INT UNIQUE,

    FOREIGN KEY (BookingId) REFERENCES Booking(BookingId)
);