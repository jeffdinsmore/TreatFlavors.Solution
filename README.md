# _Pierre's Sweet & Savory Treats_

#### _Pierre's website lists the flavors of his items and lists his treats, 10/23/2020_

#### By _Jeff Dinsmore_

## Description

_Pierre's website will allow a logged in user to see a list of treats and flavors while an admin login will be able to create, edit and delete treats and flavors._

## Setup/Installation Requirements

* _Clone this repository_
* _Open repository in your preferred code builder program. (This was built in VS Code)_
* _Check the .csproj file to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _Go to the appsettings.json file and check the password at the end of the code. It should look like this "pwd=epicodus". Change the password to your MySQL workbench password and save the file_
* _In the terminal, cd into the TreatFlavors folder_
* _Type in the terminal "dotnet restore" and press enter, then type "dotnet build" and press enter_
* _If there are no errors in the build, migrate the database by typing "dotnet ef database update" in the terminal and press enter_
* _To run the program, type "dotnet run" in the terminal_
* _The program should now be running_

### To Login as Administrator and Change Administrator Credentials
* _To login as the administrator, use the username and password credentials "admin@pierre.local" & "Notsecure1"_
* _The admin credentials can be changed to your preferred username and password by going to the SeedData.cs file in the project root directory_
* _Change lines 40 & 47 where the username "admin@pierre.local" is to your preferred username_
* _Change line 48 where the password "Notsecure1" is and change to your preferred password_
* _Save both files_
* _Your admin username and password are now updated_

## Known Bugs

_No known bugs at the this time._

## Support and contact details

_Please check the .csproj file to ensure the proper framework you are running and change if necessary as described in the Setup section_

_Please check the appsettings.json file to ensure the proper password to your MySQL Workbench and update as necessary as described above_

_Please verify the admin username and password and change if desired as described above_

_Any known issues, please reach out to Jeff Dinsmore by email at hello@jeffdinsmore.com._

## Technologies Used

* _C#_
* _CSHTML_
* _MySQL_
* _CSS_
* _Bootstrap_
* _VS Code_
* _LINQ_
* _Identity_
* _Entity Framework Core_

## License

Copyright (c) 2020, **_Jeff Dinsmore_**

This software is licensed under the MIT license.