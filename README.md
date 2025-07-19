# Skinet

**A demo E-commerce application built with .NET Core using the Generic Repository and Specification Pattern / Angular 10 / Redis / Stripe**

![Demo animation](Shopping_Cart.gif)

This project is a proof-of-concept online store showcasing how to build a modern e-commerce platform using a .NET Core Web API backend and an Angular 10 frontend, developed with Angular CLI.

## 🔧 Tech Stack & Architecture

- **Backend**: ASP.NET Core Web API  
- **Frontend**: Angular 10  
- **Caching**: Redis  
- **Payments**: Stripe  
- **Design Patterns**: Generic Repository, Specification, Unit of Work  
- **Other Tools**: AutoMapper, Swagger

## ✅ Key Features

- Clean architecture using **Repository**, **Unit of Work**, and **Specification** patterns  
- Integration of **AutoMapper** for efficient object mapping  
- Full support for **pagination**, **sorting**, **searching**, and **filtering**  
- Custom middleware for handling **500 Internal Server Errors**  
- Centralized error handling mechanism that returns a consistent response structure for:
  - `401 Unauthorized`
  - `404 Not Found`
  - `400 Validation Errors`
  - `500 Internal Server Error`
- Follows **solid OOP principles** and clean coding practices  
- A **generic pagination** class that can be reused across different entities  
- Enhanced **Swagger API documentation** for better developer experience and clarity  
- Utilized **extension methods** for `IApplicationBuilder` and `IServiceCollection` to extract and organize startup logic, improving maintainability and readability
