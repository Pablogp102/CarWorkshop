# Automotive Workshop Management System

## Overview
Welcome to the Automotive Workshop Management System! This web application is meticulously crafted to assist automotive workshop owners in efficiently managing their operations. Upholding the principles of Clean Architecture, this project provides a robust foundation for creating, editing, and maintaining workshop details while ensuring scalability, flexibility, and maintainability.

## Technologies Used
- **ASP.NET Core MVC**: A powerful web application framework for building dynamic websites.
- **Entity Framework**: A robust ORM tool for interacting with the database.
- **CQRS with MediatR**: Clear separation of concerns and efficient handling of commands and queries.
- **ASP.NET Identity**: Seamless integration for user authentication and authorization.
- **MS SQL Server**: A reliable database management system for storing workshop data.
- **Razor Engine**: Enables server-side rendering of views for a seamless user experience.
- **HTML/JavaScript**: Facilitates frontend development and enhances user interaction.
- **FluentValidation MVC**: Ensures accurate client-side data validation for improved data integrity.

## Features
- **User Authentication and Authorization**: Secure registration and login functionality allow workshop owners to access their personalized dashboard.
- **Workshop Management**: Intuitively create, edit, and manage workshop details such as services offered, contact information, and location.

## Clean Architecture Principles
- **Separation of Concerns**: Modular structure with distinct layers (presentation, application, domain, and infrastructure) for clear separation of concerns.
- **Dependency Inversion**: Inversion of dependencies promotes flexibility and testability by decoupling high-level modules from low-level modules.
- **CQRS (Command Query Responsibility Segregation)**: Commands and queries are segregated to ensure clear boundaries and facilitate scalability.
- **MediatR Pattern**: Efficient handling of requests and orchestration of commands and queries within the application, promoting decoupling and maintainability.
