# 🎓 **Student Management System**
This is a **C# Windows Form Application** built with **.NET** and **MySQL** for managing students, teachers, and admins. The system includes features like user login, student registration, and management of both students and teachers, as well as admin account management.

---

## 🚀 **Features**
- 🔑 **User Login**: Secure login functionality for administrators.
- 👨‍🎓 **Student Management**: Register new students, update their details, remove students, or view the student list.
- 👩‍💼 **Admin Management**: Add, update, delete, and view all admins in the system.
- 👨‍🏫 **Teacher Management**: Register new teachers, update their details, remove them, or display the teachers list.

---

## 🛠️ **Tech Stack**
- **Programming Language**: ![C#](https://img.shields.io/badge/-C%23-239120?logo=c-sharp&logoColor=white&style=flat-square)
- **Framework**: ![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white&style=flat-square)
- **Database**: ![MySQL](https://img.shields.io/badge/-MySQL-4479A1?logo=mysql&logoColor=white&style=flat-square)
- **IDE**: ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visual-studio&logoColor=white&style=flat-square)

---

## 📥 **Installation**
1. **Clone the repository**:
    ```bash
    git clone https://github.com/kavindukaveesha/Student_Management_project.git
    ```
2. **Open the Solution**:
   - Open the project solution in **Visual Studio**.
   - Restore **NuGet** packages and build the solution.
3. **Set up MySQL Database**:
   - Use the provided SQL scripts to create the required tables.
4. **Update Connection String**:
    ```csharp
    static string connectionString = "Data Source=YourServer\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;";
    ```

---

## 🗂️ **Database Setup**
### **Tables Overview**
1. **Admins Table**
   ![Admin Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Admin.png)
   
2. **Students Table**
   ![Students Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Student(Registrations).png)
   
3. **Teachers Table**
   ![Teachers Table](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Database/Teacher.png)

---

## 📋 **CRUD Operations**

### 🔐 **Login**
- **Admin Login** to access the dashboard.
  
  1. **Login Form**  
     ![Login Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Form.png)
  
  2. **Input Validation**  
     ![Input Validation](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Inputs_Validate.png)

  3. **Login Error**  
     ![Login Error](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Error.png)

  4. **Login Success**  
     ![Login Success](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Login/Login_Success.png)

### 👨‍🎓 **Student Management** (Register, Update, Delete, Show All)
  1. **Student Registration Form**  
     ![Student Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Mobile_Number_Validate.png)
  
  2. **Important Inputs Validation**  
     ![Validate Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Inputs_Validate_Error_Message.png)
  
  3. **Mobile Number Validation**  
     ![Mobile Validation](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Mobile_Number_Validate.png)
  
  4. **Successfully Register Student**  
     ![Success](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Student_Registered_Successfully.png)
  
  5. **Update Student Details**  
     ![Update Success](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Update_Student_Successfully.png)
  
  6. **Delete Confirmation**  
     ![Delete Confirm](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Ask_Before_Delete_Student.png)
  
  7. **Delete Success**  
     ![Delete Success](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Home_Page/Successfull_Deleted_Student.png)

### 👩‍💼 **Admin Management** (Add, Update, Delete, Show All)
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
       
### 👨‍🏫 **Teacher Management** (Add, Update, Delete, Show All)
  1. Teacher_management Form
     *  ![Homepage_Form](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Manage_Teachers.png)
  
  2. Important inputs should be not null
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Validate_Inputs.png)

  3. Mobile Number validate(Username Unique)
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers.png/Validate_Mobile_Number.png)

  4. Successfully add a Teacher
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Teacher_Registered_Succesfully.png)
    
  5. Successfully Update a Teacher
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Successfully_Updated_Teacher.png)
    
  6. Ask to delete a Teacher
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Ask_Before_Delete_Teacher.png)
    
  7. Successfully Delete a Teacher
     *  ![Check_Inputs](https://github.com/kavindukaveesha/Student_Management_project/blob/main/Image_Video_Resource/Manage_Teachers/Succesfully_Deleted_Teacher.png)
       
---

## 📝 **How to Contribute**
1. Fork the repository.
2. Create a new branch.
3. Make your changes.
4. Submit a pull request.

---

## 👨‍💻 **Developers**
- [**Kavindu Kaveesha**](https://github.com/kavindukaveesha)
- [**Prasad Prasanna**](https://github.com/PrasaKV)

