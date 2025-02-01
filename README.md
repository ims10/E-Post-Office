
# E-Post Office Management System

## 📌 Project Overview

The **E-Post Office Management System** is a **C# .NET**-based application designed to digitalize post office services. It streamlines operations like parcel tracking, postage calculation, customer management, and employee records. The project follows a structured **Windows Forms** architecture with **User Controls** and utilizes **SQL Server** as the backend database.

## 🚀 Features

- **User Authentication & Roles:** Admin and employee login system

- Parcel Management: Send, receive, and track parcels

- Customer Management: Store and manage customer details

- Billing System: Calculate postage and generate invoices

- Employee Management: Manage post office staff details

- Reports & Analytics: Generate reports for better decision-making

- User-Friendly Interface: Interactive Windows Forms with custom User Controls

- Database Management: Secure storage using SQL Server

## 🛠️ Technologies Used

- **Frontend:** C# .NET (Windows Forms, User Controls)

- **Backend:** SQL Server

- **Database Connectivity:** ADO.NET

- **IDE:** Visual Studio

## 🔧 Installation & Setup

**1️⃣ Prerequisites**

- Install Visual Studio (Latest Version)

- Install SQL Server and SQL Server Management Studio (SSMS)

- .NET Framework (if required)

 **2️⃣ Database Setup**

- Open SQL Server Management Studio (SSMS)

- Create a new database: EPostOfficeDB

- Execute the provided SQL script (DatabaseScript.sql) to create tables

- Update the connection string in app.config:

<connectionStrings>
    <add name="EPostDB" connectionString="Data Source=YOUR_SERVER;Initial Catalog=EPostOfficeDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>

 **3️⃣ Running the Application**

- Open the project in Visual Studio

- Build the solution (Ctrl + Shift + B)

- Run the project (F5)

## 📸 Screenshots

(Add screenshots of your application here)

## 📜 License

This project is for educational purposes. Feel free to modify and enhance it.

## 👨‍💻 Author

Developed by [Indrajeet Shinde] as a final year project.
