# PDSC Developer Utilities
 The PDSC Developer Utilities is a set of tools to help you develop your .NET applications and keep your development environment clean and working as efficient as it can.

## Computer Cleaner
Visual Studio and .NET are great development environments for creating applications quickly. However, they tend to leave a lot of miscellaneous folders and files all over your hard drive. This utility recycles these folder and files to free up hard drive space.

## Project Cleaner
This tool goes through Visual Studio or VS Code project folders and recycles several folders that are not needed, and can be regenerated automatically next time you build your application. You can optionally have it look in .SLN, VBProj, CSProj files and eliminate any references to source control. It can also remove any read-only attributes from the files. This utility is configurable so you can choose what folders and files you wish to recycle.

## Property Generator
This utility generates C# or Visual Basic property statements. There are several templates (similar to the snippets in the Visual Studio editor) from which you can choose. You can also create your own templates to generate any type of property you want.

## JSON Generator
This utility allows you to choose a table or view and generates a JSON file of the data.

## XML Generator
This utility allows you to choose a table or view and generates an XML file of the data. Optionally, an XSD file of the schema of the table or view can also be generated.

## C# Data Repository Generator
This utility generates a repository class that returns hard-coded data that you select from a table in one of your database tables. When creating exercises for a training class, or to test some functionality, but you don't want to have to connect to a database, it is nice to have a collection of hard-coded data that can be returned. Instead of you having to create all this data by hand, if you have a table with data, you can use this generator to select some data and have it hard-coded into a repository class.

## Code Generator
This utility generates Entity, Repository, View Model and Search classes from a table. It can also generate a complete set of CRUD MVC pages.

## C# Application Creator
This utility copies all the files and folders from the where you installed the PDSC Framework template project to a new folder and name that you specify. It then renames the appropriate files to the new application name you specify.

## SQL Compare
This utility compares two SQL Server databases to determine any tables, constraints, stored procedures, views, etc. that are missing between the two databases.