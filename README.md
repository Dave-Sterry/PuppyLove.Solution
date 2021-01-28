# _S.N.I.F.F._


<div align="center">

## 🐾 Paws Fair in Love and Fur

#### _C# Team Week Project_ 

<p>
  <small>Last Updated: January 28th, 2021</small>
</p>

#### ✒️ _**Jerrod Styrk, David Sterry, Jeff Chiu and Tawnee Harris**_
<br>
<img src="https://github.com/tawneeh.png" width="200px" height="auto" style="border-radius: 15px 50px;">
<img src="https://github.com/Dave-Sterry.png" width="200px" height="auto" style="border-radius: 15px 50px;"><br>
<img src="https://github.com/jeffchiudev.png" width="200px" height="auto" style="border-radius: 15px 50px;">
<img src="https://github.com/SJerrod.png" width="200px" height="auto" style="border-radius: 15px 50px;"><br>

<br>

# 🧑‍💻 Contributers
| Name | GitHub Profile |
|------|----------------|
|[Tawnee Harris](https://www.linkedin.com/in/tawneeh/)|[tawneeh](https://github.com/tawneeh)|
|[David Sterry](https://www.linkedin.com/in/david-sterry-developer/)|[Dave-Sterry](https://github.com/Dave-Sterry.png)|
|[Jeff Chiu](https://www.linkedin.com/in/jeff-chiu-developer/)|[jeffchiudev](https://github.com/jeffchiudev)|
|[Jerrod Styrk](https://www.linkedin.com/in/styrk-jerrodm/)|[SJerrod](https://github.com/SJerrod)|

</div>

## 📚 Description

This application is a service to assist in setting up Puppy Playdates! Users will be able to register, log in and create a profile for their Dog. They will browse randomly through other Dog profiles and either click `Squirrel` to see the next profile or `Sniff` to see more details about the current Dog.

## ⚙️ Setup/Installation Requirements

### Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench
* An API Client; I prefer Postman

### Open by Downloading or Cloning
* Navigate to <https://github.com/Dave-Sterry/PuppyLove.Solution.git>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

### AppSettings
* This project requires two AppSettings files, one for the database of Dogs and one for the database of Users. Create your first `appsettings.json` file in the API project directory `PuppyLove`
* Format your `appsettings.json` file as follows, including your unique password that was created at MySqlWorkbench installation:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=puppy_love;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

* Then, create your second `appsettings.json` file in the Client project directory `PuppyLoveClient`
* Format your `appsettings.json` file as follows, including your unique password that was created at MySqlWorkbench installation:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=puppy_love_user;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

### Import Database using Entity Framework Core
* Navigate to `PuppyLove.Solution/PuppyLove` and type `dotnet ef database update` into the terminal to create your Dog database.
* Then, navigate to `PuppyLove.Solution/PuppyLoveClient` and type `dotnet ef database update` into the terminal to create your User database.

### Launch this Application
* Navigate to `PuppyLove.Solution/PuppyLove` and type `dotnet restore` into the terminal
* Then, in the same API project directory, type `dotnet build` into the terminal followed by `dotnet run`
* Navigate to `PuppyLove.Solution/PuppyLoveClient` in a second terminal and type `dotnet restore` into that terminal
* Then, in the same Client project directory, type `dotnet build` into that terminal followed by `dotnet run`
* Peruse full functionality via the localhost

## 	📝 API Documentation

Feel free to navigate through the API endpoints via Postman or another API Client and peruse the CRUD functionality via the Client side views on the live server.

Certain information is available via query.

Dog Path Parameters

| Parameter | Type | Description |
| :---: | :---: | --- |
| name | string | Return matches by name
| owner name | string | Return matches by owner name
| mood | string | Return matches by mood
| age | int | Return matches by age
| size | string | Return matches by size
| location | string | Return matches by location
| user | string | Return matches by user


### Accessing SwaggerUI

Launch the project from the `PuppyLove` project directory by typing `dotnet run` into the terminal. Input `http://localhost:5000/swagger` to view and interact with the Swashbuckle SwaggerUI.
<br>

### Swagger UI Screenshot
<br>

<center>
<img style="width: 50% height: 50%" src="./DogsSwaggerUI.png">
</center>

### Documentation Referenced for Swashbuckle Integration

* [Microsoft Docs: Swagger Overview](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Microsoft Docs: Get Started with Swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)
* [GitHub Swashbuckle.AspNetCore README.md](https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/master/README.md)

## 🐛 Known Bugs

This application does not successfully limit Edit and Delete functionality to the Dog profile creator.

## 📫 Support and contact details

Please feel free to reach out anytime:

* Jerrod <jstyrk@citadel.edu>
* David <sterry.david@gmail.com>
* Jeff <jeffchiudev@gmail.com>
* Tawnee <tawneeh@icloud.com>

## 💾 Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Entity Framework Core 2.2.0](https://docs.microsoft.com/en-us/ef/core/)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Postman](postman.com)

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Jerrod Styrk, David Sterry, Jeff Chiu and Tawnee Harris_** ⚖️