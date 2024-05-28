# Opção

Segundo instruções da Microsoft, encontrados no endereço

https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice

As pastas repository, Iterfaces e Context foram anexadas ao Dominio, para manter os limites de contexto do microsserviço relativamente pequenos, uma
vez que é necessária uma comunicação bidirecional entre as classes de domínio e repositorio.


"É semelhante ao cheiro de código de Intimidade Inadequada ao implementar classes. Se dois microsserviços precisarem colaborar muito entre si, eles deverão provavelmente ser o mesmo microsserviço."

[![Modelo DDD](https://learn.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/media/ddd-oriented-microservice/domain-driven-design-microservice.png)]