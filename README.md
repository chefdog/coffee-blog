# coffee-blog
.net core angular 9 blog engine

# .NET Core WebApi

## ImageService

Uses https://github.com/Azure-Samples/storage-blobs-dotnet-webapp

Azure Blob Storage Photo Gallery - Demonstrates how to use the Blob Storage service.  
Blob storage stores unstructured data such as text, binary data, documents or media files.  
Blobs can be accessed from anywhere in the world via HTTP or HTTPS. 

Note: This sample uses the .NET 4.5 asynchronous programming model to demonstrate how to call the Storage Service using the  
storage client libraries asynchronous API's. When used in real applications this approach enables you to improve the  
responsiveness of your application. Calls to the storage service are prefixed by the await keyword.  
  
Documentation References:  
- What is a Storage Account - http://azure.microsoft.com/en-us/documentation/articles/storage-whatis-account/ 
- Getting Started with Blobs - http://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-how-to-use-blobs/ 
- Blob Service Concepts - http://msdn.microsoft.com/en-us/library/dd179376.aspx  
- Blob Service REST API - http://msdn.microsoft.com/en-us/library/dd135733.aspx 
- Blob Service C# API - http://go.microsoft.com/fwlink/?LinkID=398944 
- Delegating Access with Shared Access Signatures - http://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-shared-access-signature-part-1/ 

## Database

### Install migration tools
Install-Package Microsoft.EntityFrameworkCore.Tools
Update-Package Microsoft.EntityFrameworkCore.Tools

### SQL Server (Azure) 
run the command : "Add-Migration InitialCreate -project CryptoTracker.Common -Context CTDbContext -OutputDir Migrations\SqlServerMigrations" and next: "Update-Database InitialCreate"

### SQLite (filebased, runs under linux, windows) 
run the command : "Add-Migration InitialCreate -project CryptoTracker.Common -Context CTDbsqliteContext -OutputDir Migrations\SqliteMigrations" and next: "Update-Database InitialCreate"

