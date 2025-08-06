"# RoleBasedPermissionChecker"

# RoleBasedPermissionChecker

A simple C# console application that demonstrates **role-based access control** using `[Flags]` enums.

## 🔑 Features

- User authentication with predefined roles:
  - **Manager**: Read, Insert, Update, Delete
  - **Admin**: Read, Insert, Update
  - **Supervisor**: Read, Insert
  - **Guest**: Read only
- Console menu for checking permissions interactively
- Visual feedback using console colors (green = allowed, red = denied)
- Uses `enum` flags for efficient permission management

## 🛠 Technologies

- C#
- .NET Console App
- [Flags] Enum

## 🚀 How to Run

1. Clone this repository
2. Open in Visual Studio or any C# IDE
3. Build and run the project
4. Enter a username and password when prompted
5. Explore the permission menu

## 💡 Example Credentials

| Username    | Password        | Role       |
| ----------- | --------------- | ---------- |
| `manager`   | `manager2025`   | Manager    |
| `admin`     | `admin2025`     | Admin      |
| `supervise` | `supervise2025` | Supervisor |
| Any other   | Any             | Guest      |

---
