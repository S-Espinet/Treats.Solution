# Pierre's\_Sweet\_and\_Savory\_Treats

#### By _**S-Espinet**_

#### _C#/.NET application using databases to keep track of a fictional bakeries treats and flavor options_ 

## Technologies Used

* _C#_
* _.NET5.0_
* _Microsoft Entity Framework Core_
* _SQL_
* _C# HTML_
* _Razor view engine_
* _Bootstrap_
* _Microsoft.AspNetCore.Identity_

## Description

_This is a C# application that uses .NET and Entity to work with a SQL database to help a fictional bakery keep track of its treats and flavor options for those treats. It also uses Identity to authenticate users._

## GitHub Pages Link

* _N/A_

## Setup/Installation Requirements

* _navigate to github.com/S-Espinet in browser_
* _select repository (Treats.Solution)_
* _click `Code` button and select desired security protocol_
* _run git clone in the terminal into desired directory_
* _make sure that dotnet is installed_
* _run "dotnet restore" in the terminal from SweetAndSavory directory_
* _you may need to run the following commands in the terminal:_  
	* _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_ 
	* _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_ 
	* _dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0_
  * _dotnet tool install --global dotnet-ef --version 5.0.1_
  * _dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0_
  * _dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0_
* _create appsettings.json file; it should appear as follows:_   

~~~    
 {
  "ConnectionStrings": {  
  "DefaultConnection": "Server=localhost;Port=3306;database={YOURFIRSTNAME_YOURLASTNAME};uid=root;pwd={YOUR_PASSWORD};"
  }
}  
~~~  

* _run "dotnet ef database update" to create your database_
* _your appsettings.json file and any auto-generated files other than the Migrations directory (obj, bin, .vscode) should be stored in your .gitignore file_
* _run "dotnet run" in terminal from SweetAndSavory directory_
* _respond to prompts in browser to add contents to your database_  

## Known Bugs

* _No known bugs at this time_

## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _S-Espinet_