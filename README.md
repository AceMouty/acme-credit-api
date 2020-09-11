# acme-credit-api
![MIT](https://img.shields.io/packagist/l/doctrine/orm.svg)

## Tech Stack

### [C# / .NET Core](https://github.com/dotnet/core)
![MIT](https://img.shields.io/packagist/l/doctrine/orm.svg)

.NET Core is a free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems. It is a cross-platform successor to .NET Framework

-----------------------------------------------------


### [Entity Framework Core](https://github.com/dotnet/efcore)
[![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

EF Core is a modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations. EF Core works with SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and other databases through a provider plugin API.

-------------------------------------------------------------

### [Microsoft SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

Microsoft SQL Server Express is a version of Microsoft's SQL Server relational database management system that is free to download, distribute and use. It comprises a database specifically targeted for embedded and smaller-scale applications.

----------------------------------------------------------------------------------------------------

## Installation
Clone this project to your local machine

## Environment Variables
In order for the API to work correctly the user must setup their own environment variables. The project uses the `Secret Manager Tool` that is provided in .NET Core. This tool is only to be used for local dvelopment so that secrets are not stored in the project itself.

In your file explorer be sure that you are able to see hidden files and folders
### Secrests Destination Folder and File
- For Mac
```
~/.microsoft/usersecrets/<user_secrets_id>/secrets.json
```
- For Windows
```
%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json
```

Create a folder with the a id of `3b24ef8a-4f0a-4e94-ba6e-376f8c4c5886`

In your newly created folder create a file with the name `secrets.json`

In `secrets.json` add the below, be sure to replace `your_connection_string_here` with
the connection string that will be used to connect to your databse

```
{
  "ConnectionStrings": {
    "AcmeConnection": "your_connection_string_here"
  }
}
```
---------------------------------------------------------------------------------------

## Migrations
This API comes with preset migrations for building out the database along with seed data that will be used to pre-populate tables built.

Run the following command
```
dotnet ef database update
```
Once complete you should be able to log into your newly created databse and query the 
`Loans` table with `Select * From Loans;` and see the seed data in the tables.

---------------------------------------------------------------------------------------

## Endpoints
Currently the following endpoints are exposed by the API

### GET /api/laons
Returns:
```
{
  "loans": [
    {
      "applicantName": "John Doe",
      "applicantPhoneNumber": "000-867-5309",
      "applicantEmail": "JohnDoe@gmail.com",
      "loanAmount": "34,000.00",
      "loanId": "924e075f-4058-49fb-98f4-11283a1c2ad2"
    },
    {
      "applicantName": "Jane Doe",
      "applicantPhoneNumber": "000-867-5310",
      "applicantEmail": "JaneDoe@gmail.com",
      "loanAmount": "80,000.00",
      "loanId": "0d7f34f6-f9ef-4077-b1f1-925a7a0bc884"
    }
  ]
}
```

### GET /api/loans/:loanId
Returns:
```
{
  "applicantName": "Jane Doe",
  "applicantPhoneNumber": "000-867-5310",
  "applicantEmail": "JaneDoe@gmail.com",
  "loanAmount": "80,000.00",
  "loanId": "0d7f34f6-f9ef-4077-b1f1-925a7a0bc884"
}
```

### POST /api/loans
Expects:
```
{ 
	
	"applicantName": "Joey Doe",
	"applicantEmail": "JoeyDoe@gmail.com",
	"applicantPhoneNumber":"000-867-5312",
	"loanAmount":"8000.00",
	"loanId":"456fad71-9c4e-4fd0-b844-3317f80124b1"
}
```

Returns:
```
{ 
	
	"applicantName": "Joey Doe",
	"applicantEmail": "JoeyDoe@gmail.com",
	"applicantPhoneNumber":"000-867-5312",
	"loanAmount":"8000.00",
	"loanId":"456fad71-9c4e-4fd0-b844-3317f80124b1"
}
```

### PUT /api/loans/:loanId
Expects:
```
{
  "applicantName": "Joey Doe",
  "applicantPhoneNumber": "000-867-5312",
  "applicantEmail": "JoeyDoe@gmail.com",
  "loanAmount": "300.00",
  "loanId": "456fad71-9c4e-4fd0-b844-3317f80124b1"
}
```
Returns:
```
{
  "applicantName": "Joey Doe",
  "applicantPhoneNumber": "000-867-5312",
  "applicantEmail": "JoeyDoe@gmail.com",
  "loanAmount": "300.00",
  "loanId": "456fad71-9c4e-4fd0-b844-3317f80124b1"
}
```

## Frontend Documentation
See [Frontend Documentation](https://github.com/AceMouty/acme-credit) for details on the frontend of my project