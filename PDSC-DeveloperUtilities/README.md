# PDSC Developer Utilities
 The PDSC Developer Utilities is a set of tools to help you develop your .NET applications and keep your development environment clean and working as efficient as it can.

## Computer Cleaner
Visual Studio is a great development environment for creating applications quickly. However, it will leave a lot of miscellaneous files all over your hard drive. There are a few locations on your hard drive that you should be checking to see if there are left-over folders or files that you can delete. This utility will help you get rid of all of these left-over files.

## Property Builder
This utility allows you to generate Property statements for your C# or Visual Basic classes. There are several templates (similar to the snippets in the Visual Studio editor) that you can choose from. You can also create your own templates to generate any type of property you want.

## Project Cleaner
This tool will go through a folder and all sub-folders and delete any \bin and \obj folders. It will also delete any .suo, .webinfo and .user files. You can optionally have it look in .SLN, VBProj, CSProj files and eliminate any references to source control. It will also remove any read-only attributes from the files. This utility is configurable so you can choose what folders and files you wish to delete.

## JSON Builder
This utility will allow you to choose a table, view or a SELECT stored procedure and will generate a JSON file of the data.

## XML Builder
This utility will allow you to choose a table, view or a SELECT stored procedure and will generate an XML file of the data, or an XSD file of the schema of the table or view.

## SQL Compare
This utility compares two SQL Server databases to determine what objects are missing, or have been changed between them.

## C# Application Creator
This utility copies all the files and folders from the where you installed the PDSC Framework template project to a new folder and name that you specify. It then renames the appropriate files to the new application name you specify.

## C# Entity Generator
A typical entity class in C# is one that has a one-to-one correlation between the properties of the class and a table in a database. If you have a Product table in a database, this tool generates a Product class with one property for each column in your Product table.

## C# Hard-Coded Repository Generator
A repository class is one that has methods to return data from a data source. When creating exercises for a training class, or to test some functionality, but you don't want to have to connect to a database, it is nice to have a collection of hard-coded data that can be returned. Instead of you having to create all this data by hand, if you have a table with data, you can use this generator to select some data and have it hard-coded into a repository class.