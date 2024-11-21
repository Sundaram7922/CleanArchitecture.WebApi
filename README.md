**Clean Architecture with ASP.NET Web API**

**Overview**
This project demonstrates the implementation of Clean Architecture principles using ASP.NET Web API. Clean Architecture promotes a separation of concerns and ensures that the business logic is independent of frameworks, databases, and UI. This architecture enhances maintainability, testability, and scalability.

**Features**

Separation of Concerns: The application is structured into distinct layers, including presentation, application, domain, and infrastructure.
Dependency Inversion: High-level modules are not dependent on low-level modules. Both depend on abstractions.
Testable: Each layer can be tested independently, enabling unit and integration testing.
RESTful API: The project exposes a RESTful API for CRUD operations on resources.
Entity Framework Core: Utilizes EF Core for data access, promoting a clean separation between the data layer and the application.
DTOs and Mappers: Data Transfer Objects (DTOs) are used to transfer data between layers, with automatic mapping for simplicity.
Logging and Exception Handling: Implements structured logging and centralized exception handling to enhance reliability and debugging.

