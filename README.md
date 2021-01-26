# _Sniff, OnlyDoggos, OKDoggo, Plenty of Doggos, PawDate, Fetch, Pawsitive Playdates_

#### _C# Team Week Project_ 
#### _DATE 01.25.2021_

#### ✒️ By _**Jerrod Styrk, David Sterry, Jeff Chiu and Tawnee Harris**_

## 	📚 Description

This application...

## ⚙️ Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench
* An API Client; I prefer Postman

Open by Downloading or Cloning
* Navigate to <https://github.com/Dave-Sterry/PuppyLove.Solution.git>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the API project directory `PuppyLove`
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

Import Database using Entity Framework Core
* Navigate to `PuppyLove.Solution/PuppyLove` and type `dotnet ef database update` into the terminal to create your database tables.

Launch this Application
* Navigate to `PuppyLove.Solution/PuppyLove` and type `dotnet restore` into the terminal
* Then, in the same API project directory, type `dotnet build` into the terminal followed by `dotnet run`
* Peruse full CRUD functionality via Postman or the local host

## 	📝 API Documentation

Feel free to navigate through the API endpoints via Postman or another API Client.

* API List of Dogs: `http://localhost:5004/api/dogs`

## 🐛 Known Bugs

This application currently does not include a Client side or API Versioning. 

## 📫 Support and contact details

Please feel free to reach out anytime:

* Jerrod <jstyrk@citadel.edu>
* David <sterry.david@gmail.com>
* Jeff <jeffchiudev@gmail.com>
* Tawnee <tawneeh@icloud.com>

## 💾 Technologies Used

* C#
* Entity Framework Core
* MySql
* MySql Workbench
* Postman

<br>

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Jerrod Styrk, David Sterry, Jeff Chiu and Tawnee Harris_** ⚖️