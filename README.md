# SkillsInternational - Student Registration System  

## 📌 Project Overview  
The **SkillsInternational Student Registration System** is a comprehensive application designed to manage student registrations efficiently.  
This system allows administrators to:  
- **Add**, **update**, **delete**, and **view** student details.  
- Handle **form validation** and **data integrity** to prevent errors.  
- Use a **WinForms-based UI** with **C# (.NET Framework)** and **SQL Server** for backend storage.  

---

## 📖 Table of Contents  

- [Features](#features)  
- [Technologies Used](#technologies-used)  
- [Database Schema](#database-schema)  
- [Installation Guide](#installation-guide)  
- [Usage](#usage)  
- [Code Structure](#code-structure)  
- [Contributing](#contributing)  
- [License](#license)  

---

## ✅ Features  

✔ **User Registration:** Register new students with essential details.  
✔ **Data Validation:** Ensures email format, numeric-only phone numbers, and required fields.  
✔ **Student Management:** Update and delete student records dynamically.  
✔ **Dropdown with Null Option:** Allows users to select a student or choose a "null" option.  
✔ **Form Clearing & Error Handling:** Clears input fields and handles errors effectively.  
✔ **Authentication System:** Supports login/logout functionality.  
✔ **Responsive UI:** Developed using **WinForms** for a user-friendly interface.  

---

## 🛠️ Technologies Used  

- **Programming Language:** C# (.NET Framework, WinForms)  
- **Database:** Microsoft SQL Server  
- **Development Tools:**  
  - Microsoft Visual Studio  
  - SQL Server Management Studio (SSMS)  
  - Git for version control  

---

## 🗃️ Database Schema  

The **Registration** table structure:  

| Column Name  | Data Type         | Description                        |
|-------------|------------------|------------------------------------|
| regNo       | INT (PK, Identity) | Unique student registration number |
| firstName   | NVARCHAR(50)       | Student's first name               |
| lastName    | NVARCHAR(50)       | Student's last name                |
| dateOfBirth | DATE               | Student's date of birth            |
| gender      | NVARCHAR(10)       | Gender (Male/Female)               |
| address     | NVARCHAR(255)      | Student’s residential address      |
| email       | NVARCHAR(100)      | Student’s email address            |
| mobilePhone | NVARCHAR(15)       | Mobile phone number                |
| homePhone   | NVARCHAR(15)       | Home phone number (optional)       |
| parentName  | NVARCHAR(50)       | Parent or guardian name            |
| nic         | NVARCHAR(12)       | National Identity Card number      |
| contactNo   | NVARCHAR(15)       | Emergency contact number           |

---

## ⚙️ Installation Guide  

### **Step 1: Clone the Repository**  

```bash
git clone https://github.com/yourusername/SkillsInternational.git
cd SkillsInternational
