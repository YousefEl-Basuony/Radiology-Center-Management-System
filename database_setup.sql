-- ============================================================
-- اسم السيرفير: YOUSEFEL-BASUON
-- اسم الداتابيز: Taybah Center
-- شغّل الكود ده في SQL Server Management Studio (SSMS)
-- ============================================================

USE [Taybah Center];
GO

-- 1. جدول المستخدمين (لتسجيل الدخول)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AppUsers' AND xtype='U')
CREATE TABLE AppUsers (
    UserID    INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName  NVARCHAR(50),
    UserName  NVARCHAR(50) UNIQUE NOT NULL,
    Phone     NVARCHAR(20),
    Email     NVARCHAR(100),
    Password  NVARCHAR(255) NOT NULL,
    Role      NVARCHAR(50) DEFAULT 'Assistant'  -- Doctor / Assistant / Admin
);
GO

-- 2. جدول المرضى
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Patients' AND xtype='U')
CREATE TABLE Patients (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName  NVARCHAR(200) NOT NULL,
    Phone     NVARCHAR(20),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- 3. جدول أنواع الأشعة / الفحوصات
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Examinations' AND xtype='U')
CREATE TABLE Examinations (
    ExamID   INT IDENTITY(1,1) PRIMARY KEY,
    ExamName NVARCHAR(200) NOT NULL,
    Price    DECIMAL(10,2) DEFAULT 0
);
GO

-- 4. جدول الحجوزات
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Bookings' AND xtype='U')
CREATE TABLE Bookings (
    BookingID   INT IDENTITY(1,1) PRIMARY KEY,
    PatientID   INT NOT NULL REFERENCES Patients(PatientID),
    ExamID      INT NOT NULL REFERENCES Examinations(ExamID),
    BookingDate DATETIME DEFAULT GETDATE()
);
GO

-- 5. جدول التقارير الطبية (للدكتور)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='MedicalReports' AND xtype='U')
CREATE TABLE MedicalReports (
    ReportID    INT IDENTITY(1,1) PRIMARY KEY,
    PatientName NVARCHAR(200),
    DoctorName  NVARCHAR(200),
    ScanType    NVARCHAR(100),
    ReportDate  DATE,
    Diagnosis   NVARCHAR(MAX),
    Notes       NVARCHAR(MAX),
    CreatedAt   DATETIME DEFAULT GETDATE()
);
GO

-- ============================================================
-- بيانات تجريبية (اختياري - احذفها لو مش محتاجها)
-- ============================================================

-- مستخدم Doctor
IF NOT EXISTS (SELECT * FROM AppUsers WHERE UserName = 'doctor1')
INSERT INTO AppUsers (FirstName, LastName, UserName, Password, Role)
VALUES (N'محمد', N'أحمد', 'doctor1', '123456', 'Doctor');

-- مستخدم Assistant
IF NOT EXISTS (SELECT * FROM AppUsers WHERE UserName = 'assistant1')
INSERT INTO AppUsers (FirstName, LastName, UserName, Password, Role)
VALUES (N'سارة', N'علي', 'assistant1', '123456', 'Assistant');

-- مستخدم Admin
IF NOT EXISTS (SELECT * FROM AppUsers WHERE UserName = 'admin')
INSERT INTO AppUsers (FirstName, LastName, UserName, Password, Role)
VALUES (N'مدير', N'النظام', 'admin', 'password', 'Admin');

-- فحوصات تجريبية
IF NOT EXISTS (SELECT * FROM Examinations WHERE ExamName = N'أشعة سينية (X-Ray)')
INSERT INTO Examinations (ExamName, Price) VALUES
(N'أشعة سينية (X-Ray)', 150),
(N'رنين مغناطيسي (MRI)', 800),
(N'أشعة مقطعية (CT Scan)', 600),
(N'موجات فوق صوتية (Ultrasound)', 250);
GO

PRINT 'تم إنشاء جميع الجداول بنجاح في قاعدة بيانات Taybah Center ✅';
