# JWT Authentication API

## Overview

This project is an ASP.NET Core Web API that implements JWT (JSON Web Token) authentication. It provides secure authentication and authorization using bearer tokens.

## Features

- User login authentication
- JWT token generation
- Protected API endpoints
- ASP.NET Core Web API
- Swagger API documentation

## Technologies Used

- C#
- ASP.NET Core Web API
- JWT Authentication
- Swagger
- Visual Studio Code

## Project Structure

```
JwtAuthenticationApi
│
├── Controllers
│   └── AuthController.cs
│
├── Models
│   └── LoginModel.cs
│
├── Properties
│
├── appsettings.json
├── Program.cs
└── JwtAuthenticationApi.csproj
```

## API Endpoints

### Login API

**POST**

```
/api/Auth/login
```

Request Body:

```json
{
    "username": "admin",
    "password": "admin123"
}
```

Response:

```json
{
    "token": "your-jwt-token"
}
```

---

### Secure API

**GET**

```
/api/Auth/secure
```

Authorization:

```
Bearer <your-jwt-token>
```

Response:

```text
JWT Authentication Successful!
```

## JWT Configuration

The JWT settings are stored in `appsettings.json`.

```json
"Jwt": {
    "Key": "ThisIsASecretKeyForJwtToken12345",
    "Issuer": "MyAuthServer",
    "Audience": "MyApiUsers",
    "DurationInMinutes": 60
}
```

## Installation

Clone the repository:

```bash
git clone <repository-url>
```

Navigate to the project folder:

```bash
cd JwtAuthenticationApi
```

Restore packages:

```bash
dotnet restore
```

Build the project:

```bash
dotnet build
```

Run the project:

```bash
dotnet run
```

Open Swagger:

```
http://localhost:5297/swagger
```

## Test Credentials

Username:

```
admin
```

Password:

```
admin123
```

## Author

Akash Kumar Gupta

B.Tech CSE Student

C. V. Raman Global University