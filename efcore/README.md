##### Create empty .NET Core console application
```sh
$ dotnet new console -o efcore
$ cd efcore
$ dotnet run
```

##### Install EF Core Nuget packages
```sh
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet restore
```

##### Add models with DBContext -> Create migration -> Run migration
```sh
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
$ dotnet run
```