"# desafio_react_api" 

dotnet ef migrations add InitialMigration --project backend.Domain --startup-project backend.Api

dotnet ef database update --project backend.Domain --startup-project backend.Api

dotnet ef migrations remove --project backend.InfraData

