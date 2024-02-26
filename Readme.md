# Requirements

To get started with this project, make sure you have the following tools installed on mac:

- Visual Studio Code
- .NET SDK

## Project Selection

Run the following command to see available project templates and select the appropriate one for your application:

`dotnet new`

In our case, an ASP.NET Core Web API application is created. To create such an application, run:

`dotnet new webapi`

## Add Required Packages

Install the required packages using the following commands:

### For Entity Framework Core

`dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0`

### For SQL Server

`dotnet add package Microsoft.EntityFrameworkCore.SQLServer --version 7.0.0`

### For Authentication

`dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.1`

`dotnet add package Swashbuckle.AspNetCore.Filters`

### For AutoMapper

`dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`

## Setup (SQL Server Management Studio)SSMS for Mac

Follow these steps to set up SQL Server Management Studio (SSMS) for Mac:

1. Install Docker.
2. Set up Docker Image by following the documentation [here](https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&pivots=cs1-bash#pullandrun2022).
For further assistance, refer to this [link](https://setapp.com/how-to/install-sql-server).

## For Migrations

To manage migrations, install the `dotnet ef` tool globally:

`dotnet tool install --global dotnet-ef`

Use the following commands for migration-related tasks:

- For migration help: `dotnet ef -h`
- To add migrations: `dotnet ef migrations add InitialCreate`
- To run migrations: `dotnet ef database update`

## Run the Project on Mac

To run the project on Mac, use the following command:

`dotnet watch run`

Best of luck with your project! Happy coding! 🚀"
