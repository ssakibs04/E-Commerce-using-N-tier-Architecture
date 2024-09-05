# Shopping Application

This is a simple **Shopping Application** built using **ASP.NET Core** with a layered architecture, including **Repository Pattern** and **Unit of Work**. The project demonstrates how to manage categories and products using Entity Framework Core with proper separation of concerns.

## Features
- Category Management (CRUD operations)
- Repository Pattern for Data Access
- Unit of Work Pattern to manage multiple repositories
- ASP.NET Core MVC Framework

## Table of Contents
- [Technologies Used](#technologies-used)
- [Requirements](#requirements)
- [Getting Started](#getting-started)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [Project Structure](#project-structure)

## Technologies Used
- ASP.NET Core 6.0
- Entity Framework Core 6.0
- SQL Server
- Visual Studio 2022

## Requirements
To run this project locally, you need the following installed:
- **.NET 6.0 SDK**: [Download .NET 6.0](https://dotnet.microsoft.com/download)
- **SQL Server** (or any database supported by Entity Framework Core)
- **Visual Studio 2022** (or any preferred IDE that supports ASP.NET Core)

## Getting Started



1. **Clone the Repository**:
   Open a terminal and run the following command:
   ```bash
   git clone https://github.com/ssakibs04/E-Commerce-using-N-tier-Architecture.git

   # Database Setup

This document provides instructions on how to configure and set up the database for the **Shopping Application**.

## Prerequisites

Make sure you have the following installed and set up before proceeding:

- **SQL Server** (You can use SQL Server Express or any SQL Server instance)
- **SQL Server Management Studio (SSMS)** (optional, but helpful for managing the database)
- **Entity Framework Core** (this is already included in the project)

## 1. Configure Connection String

1. Open the project in your preferred IDE (like Visual Studio).
2. Navigate to the `appsettings.json` file in the root of your project.
3. Modify the **connection string** to point to your local or remote SQL Server instance. The format is as follows:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your-server-name;Database=ShoppingDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
# Migration Setup

This document explains how to create and apply database migrations for the **Shopping Application** using **Entity Framework Core**.

## Prerequisites

Make sure you have the following tools installed and set up:

- **.NET 6.0 SDK**
- **Entity Framework Core Tools**
- A SQL Server instance (or any supported database)

## 1. Install Entity Framework Core Tools

If you don't already have **EF Core Tools** installed, you can install them using the following command:

### Using **NuGet Package Manager Console**:

1. Open **NuGet Package Manager Console** in Visual Studio.
2. Run the following command to install Entity Framework Core tools:

   ```powershell
   Install-Package Microsoft.EntityFrameworkCore.Tools

