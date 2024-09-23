# **Student Management System**
This is a C# Windows Form Application built with .NET and MySQL for managing students, teachers, and admins. The system includes features like user login, student registration, and management of both students and teachers, as well as admin account management.

## Features
* User Login
* Manage Student: Register new students, update their details, or remove them from the system.
* Manage Admins: Add, update, delete, and display all admins in the system.
* Teacher Management: Register new teachers, update, delete, or show all teachers.
## Tech Stack
* Programming Language: C#
* Framework: .NET Framework
* Database: MySQL
* IDE: Visual Studio
##Installation
* Clone the repository:
* git clone https://github.com/your-repository/student-management-system.git
* Open the solution in Visual Studio.
* Restore NuGet packages and build the solution.
* Set up MySQL database with the provided SQL scripts.
## Setup Database
### Connection String
* static string connectionString = "Data Source=Kavindu\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;";
  1. Admins 
     * ![Admin_Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Admin.png)
   
  2. Registrations(Students)
     * ![Registrations_Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Student(Registrations).png)
      
  3. Teachers
     * ![Teachers_Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Teacher.png)
  
* Run the application.


## Application Purpose and Crud Operations
### Login
* Admin can log into the Application and access the dashboard.
  1. Login Form
     *  ![Login_Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Form.png)
  
  2. Check whether Both inputs are Enter or Not
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Inputs_Validate.png)
 
  3. Login Error
     *  ![Login_Error](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Error.png)
 
  4. Login Success
     *  ![Login_Success](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Success.png)
  
### Manage Students(Registration,Update,Delete,Show all)
* Admin can Register a new student, update, delete, and view all students list.
  1. Home Page(Student_Management) Form
     *  ![Homepage_Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Mobile_Number_Validate.png)
  
  2. Important inputs should be not null
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Inputs_Validate_Error_Message.png)

  3. Mobile Number should have 10 digits
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Mobile_Number_Validate.png)

  4. Successfully Register a Student
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Student_Registered_Successfully.png)
    
  5. Successfully Update a Student
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Update_Student_Successfully.png)
    
  6. Ask to delete a Student
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Ask_Before_Delete_Student.png)
    
  7. Successfully Delete a Student
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Successfull_Deleted_Student.png)

### Manage Admis(Registration,Update,Delete,Show all)
* Admin can add a new admin, update, delete, and view all admin lists.
    
  1. Admin_management Form
     *  ![Homepage_Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Manage_Admins_Form.png)
  
  2. Important inputs should be not null
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Inputs_Validate.png)

  3. Username validate(Username Unique)
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Username_Validate.png)

  4. Successfully add an Admin
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Succesfully_Added_Admin.png)
    
  5. Successfully Update an Admin
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Succesfully_Update_Admin.png)
    
  6. Ask to delete an Admin
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Ask_Before_Delete_admin.png)
    
  7. Successfully Delete an Admin
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Admins/Succesfully_Deleted_Admin.png)
    
  
    
  
    
  
    
  
    
  
  
 
  
  


2. Update Student Information
You can update the details of an existing student.


3. Delete a Student
Remove a student’s record from the system.


4. Show All Students
View a list of all registered students.


5. Add a New Admin
Register a new admin who can manage the system.


6. Update Admin Information
Edit the details of an existing admin.


7. Delete an Admin
Remove an admin from the system.


8. Show All Admins
View a list of all the admins.


9. Register a Teacher
Register a new teacher to the system.


10. Update Teacher Information
Modify the details of an existing teacher.


11. Delete a Teacher
Remove a teacher from the system.


12. Show All Teachers
View a list of all registered teachers.


How to Contribute
Fork the repository.
Create a new branch.
Make your changes.
Submit a pull request.
