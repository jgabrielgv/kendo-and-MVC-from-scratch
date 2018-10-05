# Kendo and MVC from scratch
This solution contains all the exercises done in the [Kendo and MVC from scratch](https://app.pluralsight.com/player?course=kendo-mvc-from-scratch&author=jesse-liberty&name=kendo-mvc-fs-m5&clip=5&mode=live) course from Pluralsight.
The Kendo controls used in this project are the trial version of the product, specifically 2018.3.911.

## Running the Northwind database script
Make sure you run the [NorthwindDB.sql script](https://github.com/jgabrielgv/kendo-and-MVC-from-scratch/blob/master/Scripts/SQL%20Server%20NorthwindDB.sql) to create the Northwind database if do not have it yet installed.

## Migration commands
### Here is the list of commands used to create the Book table using the migration technique.
```console
foo@bar:~$ dotnet ef migrations add -c KendoUIDemo.Data.BooksDbContext InitialCreate -v
```
```console
foo@bar:~$ dotnet ef migrations add -c KendoUIDemo.Data.BooksDbContext AddingAuthorColumn -v
```
```console
foo@bar:~$ dotnet ef migrations add -c KendoUIDemo.Data.BooksDbContext AddingSeedData -v
```

Notice that the context (-c) needs to be passed to specify the database (or DbContext) that we want to affect.

### Running the database update
```console
foo@bar:~$ dotnet ef database update -c KendoUIDemo.Data.BooksDbContext -v
```

## Additional considerations
Do not forget to update the NorthwindConnection connection string (appsettings.json) according to your local database.

kendo-and-MVC-from-scratch  is [MIT licensed](./LICENSE).