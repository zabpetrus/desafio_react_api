"# desafio_react_api" 

dotnet ef migrations add InitialMigration --project backend.InfraData --startup-project backend.Api

dotnet ef database update --project backend.InfraData --startup-project backend.Api
