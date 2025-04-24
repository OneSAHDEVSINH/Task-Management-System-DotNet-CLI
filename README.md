### Task Management System - DotNet CLI

#### Description
A task management system built using the .NET CLI. This application provides functionality to manage tasks effectively, including task creation, updates, and tracking progress. It is implemented in C# and designed for simplicity and scalability.

---

#### Table of Contents
1. [Features](#features)
2. [Installation](#installation)
3. [Usage](#usage)
4. [Project Structure](#project-structure)
5. [Contributing](#contributing)
6. [License](#license)

---

#### Features
- Create, read, update, and delete tasks.
- Command-line interface for managing tasks.
- Lightweight and efficient, leveraging the .NET CLI.

---

#### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/OneSAHDEVSINH/Task-Management-System-DotNet-CLI.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Task-Management-System-DotNet-CLI
   ```
3. Build the project using the .NET CLI:
   ```bash
   dotnet build
   ```

---

#### Usage
1. To run the project:
   ```bash
   dotnet run
   ```
2. Use the CLI to manage tasks:
   - Add a task:
     ```bash
     dotnet run add "Task Title" "Task Description"
     ```
   - Update a task:
     ```bash
     dotnet run update <task-id> "New Task Title" "New Task Description"
     ```
   - Mark a task as completed:
     ```bash
     dotnet run complete <task-id>
     ```
   - List all tasks:
     ```bash
     dotnet run list
     ```

---

#### Project Structure
```
Task-Management-System-DotNet-CLI/
├── Program.cs       // Entry point of the application
├── Models/          // Contains the task models
├── Services/        // Business logic for task management
├── Commands/        // CLI command parsers
└── README.md        // Project documentation
```

---

#### Contributing
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/<feature-name>
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add <feature>"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/<feature-name>
   ```
5. Open a Pull Request.

---

#### License
This project is licensed under the MIT License. See the `LICENSE` file for details.
