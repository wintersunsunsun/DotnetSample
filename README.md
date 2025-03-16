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

---
#加密貨幣-幣別轉換系統
這是一個使用 Spring Boot 開發的 demo，提供幣別中文名稱管理和匯率查詢功能。

## 功能特點

- 幣別管理（CRUD 操作）
- 整合 CoinDesk API
- 自動更新匯率資料（每 30 秒）
- RESTful API 設計
- Swagger UI 文檔
- H2 資料庫支持

## 加分項目
1. AOP 應用
   - 使用 AOP 記錄 API 調用日誌
   - 記錄外部 API 調用的請求和響應
2. 設計模式應用
   - Factory Pattern
     - Spring 的 BeanFactory
     - 管理和創建各種 Bean
   
   - Dependency Injection
     - Constructor Injection
   
   - Repository Pattern
     - CurrencyRepository
     - 數據訪問層的抽象

### 參考
[Tutorial: Create a controller-based web API with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code)
[Make HTTP requests using IHttpClientFactory in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-9.0)