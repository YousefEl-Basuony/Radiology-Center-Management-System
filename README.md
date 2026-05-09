<div align="center">

<h1>🏥 Taiba Center - Radiology Center Management System</h1>

<p>
  <img src="https://img.shields.io/badge/Platform-Windows-blue?logo=windows&style=for-the-badge" />
  <img src="https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet&style=for-the-badge" />
  <img src="https://img.shields.io/badge/UI-WinForms-orange?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-red?logo=microsoftsqlserver&style=for-the-badge" />
  <img src="https://img.shields.io/badge/Status-Ready%20for%20Delivery-brightgreen?style=for-the-badge" />
</p>

> **A complete desktop clinic management system** built for the Taybah Orthopedic Center.  
> Designed with full **Role-Based Access Control (RBAC)**, patient management, medical reports, appointment scheduling, and employee management — all in one unified dashboard.

</div>

---

## 📌 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [System Roles](#-system-roles)
- [System Architecture](#-system-architecture)
- [Database Schema](#-database-schema)
- [Getting Started](#-getting-started)
- [Default Login Credentials](#-default-login-credentials)
- [Project Structure](#-project-structure)
- [Screenshots Overview](#-screenshots-overview)
- [Team](#-team)
- [Technologies Used](#-technologies-used)

---

## 🔍 Overview

The **Taybah Center Clinic Management System** is a Windows Forms desktop application developed as a graduation project for a medical informatics course. It digitizes the day-to-day operations of an orthopedic clinic — from patient registration and appointment booking to medical report generation and employee administration.

The system enforces **three distinct user roles**: Admin (Manager/Doctor), Doctor, and Assistant — each with carefully scoped permissions to ensure both security and usability.

---

## ✨ Key Features

### 👨‍⚕️ Patient Management
- Register new patients with name and phone number
- Edit patient information
- Delete patients (with cascading deletion of all related bookings)
- Search patients by name, phone, or file number
- Full patient medical history displayed on selection

### 📅 Appointment Booking
- Book examinations for registered patients
- Select from available examination types (with live pricing)
- Date picker for scheduling future appointments
- Invoice generation upon booking confirmation

### 📄 Medical Reports (Doctor-Only)
- Create detailed medical reports linked to a patient
- Select scan type: X-Ray, MRI, CT Scan, or Ultrasound
- Fields: Patient name, attending doctor, diagnosis, notes, and report date
- Search and view historical reports by patient name
- Click on any report row to auto-populate the form for quick editing

### 👥 Employee Management (Admin/Doctor)
- View all registered employees (Assistants & Doctors)
- Add, update, or delete employees (Admin & Doctor only)
- Assign roles: Doctor or Assistant

### 📊 Live Dashboard
- Real-time count of **today's appointments**
- Real-time count of **total registered patients**
- Auto-refreshes on every navigation

### ⚙️ User Profile & Settings
- Update display name
- Upload and persist a profile avatar image
- Role badge displayed in the sidebar

### 🔐 Authentication
- Secure login with username + password
- Role-based form loading on successful login
- Sign-up form with role selection (Doctor / Assistant)
- Logout with confirmation dialog

---

## 🎭 System Roles

| Role | Dashboard | Register Patient | Book Exam | Invoice | Medical Reports | Employee Mgmt |
|------|:---------:|:----------------:|:---------:|:-------:|:---------------:|:-------------:|
| **Admin** | ✅ | ✅ | ✅ | ✅ | ❌ | ✅ |
| **Doctor** | ✅ | ❌ | ❌ | ❌ | ✅ | ✅ |
| **Assistant** | ✅ | ✅ | ✅ | ❌ | ❌ | ❌ |

> **Note:** When an Assistant registers a new patient, the patient immediately appears in the Doctor's patient list and dashboard count — no manual refresh required.

---

## 🏗 System Architecture

```
┌─────────────────────────────────────────────────────┐
│                   WinForms Desktop App               │
│                                                     │
│  ┌─────────┐   ┌──────────┐   ┌──────────────────┐  │
│  │  Login  │──▶│  SignUp  │   │ Home (Splash)    │  │
│  └────┬────┘   └──────────┘   └──────────────────┘  │
│       │                                             │
│       ▼  (Role-Based)                               │
│  ┌──────────────────────────────────────────────┐   │
│  │            ReceptionForm (Main Dashboard)     │   │
│  │  ┌──────────┬────────────┬────────────────┐  │   │
│  │  │ Sidebar  │ Main Panel │ Dynamic Pages  │  │   │
│  │  │          │            │                │  │   │
│  │  │ Dashboard│  Content   │ - Dashboard    │  │   │
│  │  │ Register │   Area     │ - Patient Reg  │  │   │
│  │  │ Patients │            │ - Patients     │  │   │
│  │  │ Reports* │            │ - Med Reports* │  │   │
│  │  │ Employees│            │ - Settings     │  │   │
│  │  │ Settings │            │                │  │   │
│  │  └──────────┴────────────┴────────────────┘  │   │
│  └──────────────────────────────────────────────┘   │
│       │                                             │
│       ▼                                             │
│  ┌──────────────────────┐                           │
│  │  EmployeeManagement  │ (Modal — Admin/Doctor)    │
│  └──────────────────────┘                           │
└─────────────────────────────────────────────────────┘
                    │
                    ▼
         ┌──────────────────────┐
         │  SQL Server Database │
         │   "Taybah Center"    │
         │                      │
         │  • AppUsers          │
         │  • Patients          │
         │  • Bookings          │
         │  • Examinations      │
         │  • MedicalReports    │
         │  • Employees         │
         └──────────────────────┘
```

> `*` — Pages marked with asterisk are only accessible to the Doctor role.

---

## 🗄 Database Schema

The application connects to a **SQL Server** database named `Taybah Center` on the `YOUSEFEL-BASUON` server instance.

### `AppUsers` — System Login Accounts
| Column | Type | Description |
|--------|------|-------------|
| UserID | INT (PK, Identity) | Unique user ID |
| FirstName | NVARCHAR(50) | First name |
| LastName | NVARCHAR(50) | Last name |
| UserName | NVARCHAR(50) UNIQUE | Login username |
| Phone | NVARCHAR(20) | Phone number |
| Email | NVARCHAR(100) | Email address |
| Password | NVARCHAR(255) | Plain-text password |
| Role | NVARCHAR(50) | `Doctor`, `Assistant`, or `Admin` |

### `Patients` — Registered Patients
| Column | Type | Description |
|--------|------|-------------|
| PatientID | INT (PK, Identity) | Unique patient file number |
| FullName | NVARCHAR(200) | Patient full name |
| Phone | NVARCHAR(20) | Contact number |

### `Examinations` — Available Scan Types
| Column | Type | Description |
|--------|------|-------------|
| ExamID | INT (PK, Identity) | Unique exam ID |
| ExamName | NVARCHAR(200) | Name of the examination |
| Price | DECIMAL | Examination price (EGP) |

### `Bookings` — Patient Appointments
| Column | Type | Description |
|--------|------|-------------|
| BookingID | INT (PK, Identity) | Unique booking ID |
| PatientID | INT (FK → Patients) | Linked patient |
| ExamID | INT (FK → Examinations) | Linked examination |
| BookingDate | DATETIME | Scheduled date |

### `MedicalReports` — Doctor Reports
| Column | Type | Description |
|--------|------|-------------|
| ReportID | INT (PK, Identity) | Unique report ID |
| PatientName | NVARCHAR(200) | Patient name |
| DoctorName | NVARCHAR(200) | Attending doctor |
| ScanType | NVARCHAR(100) | Type of imaging |
| ReportDate | DATE | Report creation date |
| Diagnosis | NVARCHAR(MAX) | Full diagnosis text |
| Notes | NVARCHAR(MAX) | Additional notes |

### `Employees` — Clinical Staff
| Column | Type | Description |
|--------|------|-------------|
| EmployeeID | INT (PK, Identity) | Unique employee ID |
| FullName | NVARCHAR(200) | Employee full name |
| Username | NVARCHAR(100) | Login username |
| Password | NVARCHAR(255) | Password |
| UserType | NVARCHAR(50) | `Doctor` or `Assistant` |
| Phone | NVARCHAR(20) | Contact number |

---

## 🚀 Getting Started

### Prerequisites

| Requirement | Version |
|-------------|---------|
| Windows | 10 / 11 |
| .NET SDK | 8.0+ |
| SQL Server | 2019 / 2022 (any edition) |
| Visual Studio | 2022 (recommended) |

### Setup Steps

**1. Clone or copy the project**
```
system-for-Orthopedic-Clinic/
└── WinForms_TEST/         ← Open this in Visual Studio
```

**2. Configure the database**

Make sure SQL Server is running. The connection string is pre-configured for:
```
Server=YOUSEFEL-BASUON
Database=Taybah Center
Integrated Security=True
```

To change the server name, update the `connectionString` field in:
- `ReceptionForm.cs` (line 12)
- `Login.cs` (line 42)
- `SignUp.cs` (line 59)
- `EmployeeManagement.cs` (line 10)
- `Frm_MedicalReport.cs` (line 10)

**3. Create the initial database tables**

Run the following SQL on your server to set up the schema:

```sql
CREATE DATABASE [Taybah Center];
GO

USE [Taybah Center];

CREATE TABLE Patients (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(200) NOT NULL,
    Phone NVARCHAR(20)
);

CREATE TABLE Examinations (
    ExamID INT IDENTITY(1,1) PRIMARY KEY,
    ExamName NVARCHAR(200) NOT NULL,
    Price DECIMAL(10,2) DEFAULT 0
);

CREATE TABLE Bookings (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    ExamID INT FOREIGN KEY REFERENCES Examinations(ExamID),
    BookingDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE MedicalReports (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    PatientName NVARCHAR(200),
    DoctorName NVARCHAR(200),
    ScanType NVARCHAR(100),
    ReportDate DATE,
    Diagnosis NVARCHAR(MAX),
    Notes NVARCHAR(MAX)
);

CREATE TABLE AppUsers (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    UserName NVARCHAR(50) UNIQUE,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Password NVARCHAR(255),
    Role NVARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(200),
    Username NVARCHAR(100),
    Password NVARCHAR(255),
    UserType NVARCHAR(50),
    Phone NVARCHAR(20)
);

-- Seed some examination types
INSERT INTO Examinations (ExamName, Price) VALUES
    (N'أشعة سينية (X-Ray)', 150),
    (N'رنين مغناطيسي (MRI)', 800),
    (N'أشعة مقطعية (CT Scan)', 600),
    (N'موجات فوق صوتية (Ultrasound)', 250);
```

**4. Build and run**
```bash
cd WinForms_TEST
dotnet build
dotnet run
```
Or simply press **F5** in Visual Studio.

---

## 🔑 Default Login Credentials

> First-time users should sign up via the **Sign Up** screen.  
> The system includes a built-in fallback admin account:

| Username | Password | Role |
|----------|----------|------|
| `admin` | `password` | Admin (Manager) |

After first launch, register your actual users via the **Sign Up** form and assign them the appropriate role.

---

## 📁 Project Structure

```
WinForms_TEST/
├── Program.cs                  # App entry point
├── WinForms_TEST.csproj        # Project config (.NET 8, WinForms)
├── sqlconnection.cs            # (Legacy stub — unused)
│
├── Home.cs / Home.Designer.cs  # Splash/welcome screen
├── Login.cs / Login.Designer.cs    # Authentication screen
├── SignUp.cs / SignUp.Designer.cs  # User registration screen
│
├── ReceptionForm.cs            # ★ Main dashboard (all roles)
├── ReceptionForm.Designer.cs   # Auto-generated form layout
│
├── EmployeeManagement.cs       # Staff management (Admin/Doctor)
├── EmployeeManagement.Designer.cs
│
├── Frm_MedicalReport.cs        # Standalone medical report editor
├── Frm_MedicalReport.Designer.cs
│
└── Properties/
    └── Resources.resx          # App resources
```

---

## 🖼 Screenshots Overview

| Screen | Description |
|--------|-------------|
| **Login** | Dark-themed auth screen with role detection |
| **Sign Up** | Registration with Doctor / Assistant role toggle |
| **Dashboard (Admin)** | Live stats + full navigation sidebar |
| **Dashboard (Doctor)** | Medical reports panel + employee management |
| **Dashboard (Assistant)** | Patient registration + booking — no invoice |
| **Patient List** | Searchable grid with edit/delete and history panel |
| **Medical Reports** | Full report editor + historical search grid |
| **Employee Management** | CRUD form for managing clinical staff |
| **Settings** | Name update + profile picture upload |

---

## 👨‍💻 Team

<table align="center">
  <thead>
    <tr>
      <th>Name</th>
      <th>Role</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>🌟 <strong>Youssef Mohamed El-Basuoni</strong></td>
      <td>Team Leader</td>
    </tr>
    <tr>
      <td>💻 <strong>Khaled Mohamed El-Said</strong></td>
      <td>Developer</td>
    </tr>
    <tr>
      <td>🎨 <strong>Abdel Rahman El-Shenawy</strong></td>
      <td>Developer</td>
    </tr>
    <tr>
      <td>🗄️ <strong>Moaz Zaghloul</strong></td>
      <td>Developer</td>
    </tr>
  </tbody>
</table>

---

## 🛠 Technologies Used

| Technology | Purpose |
|------------|---------|
| **C# / .NET 8** | Core application language |
| **Windows Forms (WinForms)** | Desktop UI framework |
| **SQL Server** | Relational database engine |
| **Microsoft.Data.SqlClient v7** | SQL Server ADO.NET driver |
| **Visual Studio 2022** | IDE and designer |

---

<div align="center">

**Taybah Center Clinic Management System** — Built with ❤️ by the team

*Faculty Project — 2025/2026*

</div>
