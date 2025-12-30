# 🎓 Student Result API

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)

> A robust, clean, and scalable RESTful API for managing student results, built with modern .NET best practices.

## 🌟 Overview

Refactored from a simple CRUD application, this project now serves as a demonstration of **Advanced .NET Software Design**. It implements a clean architecture ensuring separation of concerns, scalability, and maintainability.

## 🚀 Key Features

*   **Clean Architecture**: Separation of concerns into Controllers, Services, and Repositories.
*   **DTOs (Data Transfer Objects)**: Strictly typed request and response models for secure data handling.
*   **Repository Pattern**: Abstracted data access layer using generic patterns.
*   **Dependency Injection**: Loose coupling using .NET's built-in DI container.
*   **Async/Await**: Fully asynchronous operations for high performance and scalability.
*   **Global Error Handling**: Centralized middleware for consistent API error responses.

## 🛠️ Tech Stack

*   **Framework**: ASP.NET Core 8.0
*   **Language**: C#
*   **Architecture**: Layered (Controller -> Service -> Repository)
*   **Data Storage**: In-Memory Collection (Refactorable to EF Core/SQL)

## 📂 Project Structure

```bash
StudentResultAPI/
├── Controllers/       # API Endpoints
├── Services/          # Business Logic
├── Repositories/      # Data Access Layer
├── DTOs/              # Data Transfer Objects
├── Models/            # Domain Entities
└── Middleware/        # Global Exception Handling
```

## ⚡ Getting Started

### Prerequisites

*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
*   VS Code or Visual Studio

### Installation

1.  **Clone the repository**
    ```bash
    git clone https://github.com/Ayomide-R/StudentResultAPI.git
    cd StudentResultAPI
    ```

2.  **Restore dependencies**
    ```bash
    dotnet restore
    ```

3.  **Run the application**
    ```bash
    dotnet run
    ```

The API will be available at `http://localhost:5296`.

## 📖 API Endpoints

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/students` | Retrieve all students |
| `POST` | `/api/students` | Create a new student |
| `GET` | `/api/students/{id}` | Get specific student details |
| `PUT` | `/api/students/{id}` | Update an existing student |
| `DELETE` | `/api/students/{id}` | Remove a student |
| `GET` | `/api/students/search` | Search students by name |

## 🧪 Testing

You can test the API using **Postman**, **Swagger**, or the included `api_tests.http` file (requires REST Client extension in VS Code).

---

Made with ❤️ by [Ayomide-R](https://github.com/Ayomide-R)
