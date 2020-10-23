# _Application Name_

#### _{Brief descrition on what application does}, {Date}_

#### By _Jeff Dinsmore_

## Description

_{Detailed description on what the application does.}_

## Setup/Installation Requirements

* _Clone this repository._
* _Open repository in your preferred code builder program. (This was built in VS Code)_

### MySQL WorkBench Schema Setup:
1. Open [MySql Workbench](https://www.mysql.com/products/workbench/) and connect to Local instance
2. Create a new sql tab by clicking the upper left icon: 'Create A New SQL Tab for Executing Queries'
3. Copy the following code from the sql file in the root directory of this project
4. Paste the code in a Query and click on the lightning bolt icon "Execute the selected portion of this script or everything"
5. Refresh your schemas and the database is ready to use.
---

* _Check both of the .csproj files to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _In the terminal, cd into the NumberToWords.Tetst folder_
* _Type in the terminal "dotnet restore"_
* _To run the program, type cd into the "NumbersToWords" directory and type dotnet run in the terminal_
* _The program should now be running_

### Website Setup:
* _Check both of the .csproj files to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _In the terminal, cd into the HairSalon folder_
* _Type in the terminal "dotnet restore"_
* _To run the program, type "dotnet build" in the terminal and then type "dotnet run" in the terminal_
* _The program should now be running_

## Known Bugs

_No known bugs at the this time._

## Support and contact details

_Please check the .csproj files to ensure the proper framework you are running and change if necessary as described in the Setup section_

_Any known issues, please reach out to Jeff Dinsmore by email at hello@jeffdinsmore.com._

## Technologies Used

* _C#_
* _CSHTML_
* _MySQL_
* _CSS_
* _Bootstrap_
* _VS Code_
* _LINQ_
* _Entity Framework Core_


## License

Copyright (c) 2020, **_Jeff Dinsmore_**

This software is licensed under the MIT license.