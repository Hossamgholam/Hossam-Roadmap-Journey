-- =========================
-- 1. Authors
-- =========================

 use Library EXEC sp_changedbowner 'sa'
CREATE TABLE Authors (
    AuthorId INT IDENTITY PRIMARY KEY,
    AuthorName NVARCHAR(100) NOT NULL
);

-- =========================
-- 2. Books
-- =========================
CREATE TABLE Book (
    BookId INT IDENTITY PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    ISBNNumber NVARCHAR(50) UNIQUE,
    Genre NVARCHAR(100),
    PublicationDate DATE,
    AdditionalDetails NVARCHAR(MAX)
);

-- =========================
-- 3. AuthorsBook (M:N)
-- =========================
CREATE TABLE AuthorsBook (
    AuthorBookId INT IDENTITY PRIMARY KEY,
    AuthorId INT NOT NULL,
    BookId INT NOT NULL,

    CONSTRAINT FK_AuthorsBook_Authors
        FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId),

    CONSTRAINT FK_AuthorsBook_Book
        FOREIGN KEY (BookId) REFERENCES Book(BookId),

    CONSTRAINT UQ_AuthorsBook UNIQUE (AuthorId, BookId)
);

-- =========================
-- 4. Users
-- =========================
CREATE TABLE [User] (
    UserId INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20),
    Title NVARCHAR(50),
    LibraryCardNumber NVARCHAR(50) UNIQUE
);

-- =========================
-- 5. BookCopy
-- =========================
CREATE TABLE BookCopy (
    CopyId INT IDENTITY PRIMARY KEY,
    BookId INT NOT NULL,
    Availability BIT DEFAULT 1,

    CONSTRAINT FK_BookCopy_Book
        FOREIGN KEY (BookId) REFERENCES Book(BookId)
);

-- =========================
-- 6. Borrowing
-- =========================
CREATE TABLE Borrowing (
    BorrowId INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL,
    BookCopyId INT NOT NULL,
    BorrowDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,

    CONSTRAINT FK_Borrowing_User
        FOREIGN KEY (UserId) REFERENCES [User](UserId),

    CONSTRAINT FK_Borrowing_BookCopy
        FOREIGN KEY (BookCopyId) REFERENCES BookCopy(CopyId)
);

-- =========================
-- 7. Reservation
-- =========================
CREATE TABLE Reservation (
    ReservationId INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL,
    CopyId INT NOT NULL,
    ReservationDate DATE NOT NULL,

    CONSTRAINT FK_Reservation_User
        FOREIGN KEY (UserId) REFERENCES [User](UserId),

    CONSTRAINT FK_Reservation_BookCopy
        FOREIGN KEY (CopyId) REFERENCES BookCopy(CopyId)
);

-- =========================
-- 8. Fine
-- =========================
CREATE TABLE Fine (
    FineId INT IDENTITY PRIMARY KEY,
    UserId INT NOT NULL,
    BorrowId INT NOT NULL,
    FineAmount DECIMAL(10,2) NOT NULL,
    NumberOfDayLate INT,
    PaymentStatus NVARCHAR(20),

    CONSTRAINT FK_Fine_User
        FOREIGN KEY (UserId) REFERENCES [User](UserId),

    CONSTRAINT FK_Fine_Borrowing
        FOREIGN KEY (BorrowId) REFERENCES Borrowing(BorrowId)
);