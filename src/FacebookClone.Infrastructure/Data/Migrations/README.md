# Generating Migrations
To generate a new migration you need to run the following command from the FacebookClone.API folder (that is because the FacebookCloneDbContext is available through DI from the FacebookClone.API)

```
dotnet ef migrations add Migration_Name --context FacebookCloneDbContext -p "../FacebookClone.Infrastructure"  -o "Data/Migrations"
```
