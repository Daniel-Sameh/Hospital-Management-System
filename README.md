# Hospital-Management-System
## Overview
This Hospital Management System is a desktop application built using C# WinForms with Microsoft SQL Server as the database backend. It is designed to manage the operations of a hospital, including user management, patient management, appointment scheduling, and medical history tracking. The system ensures that administrative tasks are handled efficiently, providing a seamless experience for admins, doctors, nurses, and patients.
## Features
- **User Management**
  - Sign up new users (admin, doctor, nurse, patient)
  - Update user details
  - Patient Management
  - Add new patients (by admin)
- **Appointment Management**
  - Add new appointments for patients (by admin or patient)
  - Cancel patient appointments
  - Display a list of all appointments for a specific doctor
  - Display a list of appointments for a specific doctor based on criteria (e.g., date, specific patient)
- **Prescription Management**
  - Assign medicines to patients (by doctor)
- **Medical History**
  - Show all medical history for a specific patient
  - Add, delete, update a medical record (by patient)
## Getting Started
### Installation
1. Clone the repository:
  ```sh
  git clone https://github.com/Daniel-Sameh/Hospital-Management-System
  ```
2. Set up the Database:
   - Ensure you have `Microsoft SQL Server` installed and running.
   - Open `Hospital.sql` file in the server.
   - Execute the SQL script to create the necessary tables and relationships.
3. Configure the Connection Strings:
   - Open the project in Visual Studio.
   - Locate the C# files where the connection strings are defined (e.g., admin.cs).
   - Update the connection strings to point to your SQL Server instance and database.
4. Build and Run the Application:
  - Build the solution in Visual Studio.
  - Run the application.
## Usage
Upon launching the application, you will be greeted with the main interface, where you can navigate to different sections of the system:
  - Sign up a new user.
  - Login and enter your profile.
  - Manage your account and other users accounts according to your role (admin, doctor, nurse, patient).
  - Generate Report that has some statistics about the hospital.
## Media
![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/mainInterface.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/login.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/signup.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/signup1.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/admin.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/admin1.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/admin2.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/patient.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/patient1.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/patient2.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/patient3.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/patient4.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/doctor.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/doctor1.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/report.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/report1.png)

## Diagrams
![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/diagram.png)

![image](https://github.com/Daniel-Sameh/Hospital-Management-System/blob/main/Media/diagram1.png)

## Built With 
- **C# WinForms:** User Interface and main system logic.
- **Microsoft SQL Server:** Database for data storage and management.
## Contact 
For any questions or feedback, please contact [Daniel Sameh](mailto:danielsameh21@gmail.com).
