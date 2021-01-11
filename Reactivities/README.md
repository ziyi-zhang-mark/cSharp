```
Create a project
dotnet sln add API

Add Domain as dependency
dotnet add reference ../Domain

Add entity framework tool
dotnet tool install --global dotnet-ef

Create a DB migration
dotnet ef migrations add InitialCreate -p Persistence/ -s API/
dotnet ef migrations add SeedValues -p Persistence/ -s API/
```
