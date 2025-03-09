### Build Minimal API Project
```bash
dotnet new webapi --use-controllers -o TodoApi
```

### Add Library
```bash
cd TodoApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package NSwag.AspNetCore
```

### Generate Assets for Build and Debug
When Visual Studio Code requests that you add assets to build and debug the project, select Yes. If Visual Studio Code doesn't offer to add build and debug assets, select View > Command Palette and type ".NET" into the search box. From the list of commands, select the .NET: Generate Assets for Build and Debug command.

### Trust the HTTPS development certificate
```bash
dotnet dev-certs https --trust
```

### Run the app
```bash
dotnet run --launch-profile https
```

### 

### 參考
[Tutorial: Create a controller-based web API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code)