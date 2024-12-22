# ASP.NET Web API and Blazor WebAssembly Full Stack Project

This repository contains a full stack application built using **ASP.NET Web API** and **Blazor WebAssembly** with **.NET 6**. The solution is divided into three projects:

1. **API**: The back-end project that provides RESTful endpoints.
2. **APP**: The front-end Blazor WebAssembly application.
3. **Shared**: A class library for shared models and entities used by both the API and the Blazor application.

## Overview
This solution demonstrates a simple full stack application with ASP.NET Web API handling the back-end logic and data processing, while Blazor WebAssembly serves as the front-end framework for building an interactive user interface. The **Shared** library is used to ensure consistency between the front-end and back-end by sharing models and entities.

---

## Features
- RESTful API with CRUD operations.
- Interactive front-end built with Blazor WebAssembly.
- Shared library for reusability and consistent data models.

---

## Technologies Used
- **.NET 6**
- **ASP.NET Web API** for back-end development
- **Blazor WebAssembly** for front-end development
- **Entity Framework Core** for database operations
- **Dependency Injection** for decoupled architecture

---

## Getting Started
### Prerequisites
1. Install **.NET 6 SDK**: [Download](https://dotnet.microsoft.com/download/dotnet/6.0)
2. Install a suitable code editor (e.g., **Visual Studio 2022** or **Visual Studio Code**).

### Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository.git
   ```
2. Navigate to the solution directory:
   ```bash  
    cd BlazorWorkshop
   ```
3. Open the solution in Visual Studio or Visual Studio Code.
4. Restore the NuGet packages:
    ```bash
    dotnet restore
    ```
5. Build the solution:
    ``` bash
    dotnet build
    ```
6. Run the projects:
    - Start the API project:
    ```bash
    cd API
    dotnet run
    ```
    - Start the APP project:
    ```bash
    cd APP
    dotnet run
    ```
7. Access the application:
  - API Endpoints: https://localhost:7260/swagger/index.html
  - Front-End: https://localhost:7022
