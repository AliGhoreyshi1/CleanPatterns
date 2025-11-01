# 🧩 CleanPatterns  
*A Minimal Console App Demonstrating Repository, Unit of Work, and Template Method Patterns in C#*

---

## 📘 Overview  

**CleanPatterns** is a lightweight educational console application built to demonstrate three essential design patterns commonly used in software architecture:

- **Repository Pattern** – Abstracts data access logic and promotes separation of concerns.  
- **Unit of Work Pattern** – Coordinates multiple repositories as a single logical transaction.  
- **Template Method Pattern** – Defines a common structure for operations while allowing subclasses to customize specific steps.

This project is intentionally designed **without any database** — all data is stored **in-memory**, making it perfect for educational purposes, code reviews, and design pattern demonstrations.

---

## ⚙️ Design Patterns in Action  

### 🧩 Repository Pattern  
Defines a **clean abstraction** between business logic and data access.  
Each repository provides CRUD operations (`Add`, `GetAll`, `GetById`, `Update`, `Delete`) for its entity type.

### 🧱 Template Method Pattern  
Implemented through the `BaseRepository<T>` abstract class, which defines the **skeleton** of CRUD operations while allowing derived repositories to override specific behaviors.

### 🔄 Unit of Work Pattern  
Coordinates multiple repositories and ensures that operations performed across them are treated as **a single logical unit** — even though this demo doesn’t use a real database, it clearly illustrates the concept.

---

## 💡 Key Highlights  

✅ Fully in-memory — no database setup required  
✅ Clean and minimal C# implementation  
✅ Well-documented and easy to understand  
✅ Ideal for students, junior developers, and blog/article demos  
✅ Ready to extend into EF Core or real data storage if needed  

---

## 🚀 How to Run  

1. Clone the repository:
   ```bash
   git clone https://github.com/AliGhoreyshi1/CleanPatterns.git
2. Open the solution in Visual Studio or VS Code.

3. Set the startup project to the Console App.

4. Run the project:
   ```bash
   dotnet run

## 🧠 Educational Purpose

This repository was designed to explain key design patterns in a simple, visual, and practical way.
It can serve as a teaching resource or a foundation for introducing clean architecture principles.

✍️ Author

Ali Ghoreyshi
💼 www.linkedin.com/in/ali-ghoreyshi-3a899a186
