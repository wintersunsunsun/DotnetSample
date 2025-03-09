### Build Minimal API Project
```bash
dotnet new webapi --use-controllers -o TodoApi
```

### Trust the HTTPS development certificate
```bash
dotnet dev-certs https --trust
```

### Add Library
Add NuGet packages required for develop
```bash
cd TodoApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package NSwag.AspNetCore
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

Install the scaffolding engine (dotnet-aspnet-codegenerator) after uninstalling any possible previous version.
### 
```bash
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```

### Scaffolds Controller
```bash
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers
```

### Run the app
```bash
dotnet run --launch-profile https
```

### 

### 參考
[Tutorial: Create a controller-based web API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code)
[Make HTTP requests using IHttpClientFactory in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-9.0)