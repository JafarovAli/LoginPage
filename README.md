# User Management App (Windows Forms - C#)

## Overview
This is a Windows Forms application developed in C# that provides user authentication and CRUD (Create, Read, Update, Delete) operations for user data. The application includes login and registration functionalities, allowing users to manage their accounts efficiently.

## Features
- **User Authentication:**
  - Login functionality with email and password.
  - Secure password storage.
  - Registration system for new users.
  
- **User Management:**
  - Create new users.
  - Read and display user details.
  - Update user information.
  - Delete users from the system.
  
## Technologies Used
- **C#** (Windows Forms)
- **.NET Framework**
- **SQL Server** (for user data storage)

## Installation & Setup
1. **Clone the repository:**
   ```sh
   git clone <repository_url>
   ```
2. **Open the project in Visual Studio.**
3. **Configure the database:**
   - Create a new SQL Server database.
   - Execute the provided SQL script (`database.sql`) to set up the required tables.
   - Update the connection string in `App.config`:
     ```xml
     <connectionStrings>
       <add name="DbConnection" connectionString="Server=your_server;Database=your_db;User Id=your_user;Password=your_password;" providerName="System.Data.SqlClient"/>
     </connectionStrings>
     ```
4. **Build and run the application in Visual Studio.**

## Database Schema
The database consists of a single table: `Users`
```sql
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL
);
```

## Usage
1. **Register a new user** through the registration form.
2. **Login** using registered credentials.
3. **Perform CRUD operations** on user data through the admin panel.

## License
This project is open-source and can be modified as per requirements.


