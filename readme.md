# Blazor Hosting
An application to explore hosting models for Blazor with the goal of sharing Blazor components between two different shell applications, i.e. one employing the Blazor Server hosting model and the other Blazor WASM.

## Projects
* Domain - .NET Standard 2.0 class library which contains domain level types which are shared with all other projects.
* RestApi.Core - .NET 5 class library which contains all types needs for a REST API implementation, e.g. Controllers.
* Blazor.Core - .NET 5 Razor Components class library which contains all Blazor components with make up the client application.
* Blazor.Server.Host - .NET 5 Blazor application using the Blazor Server hosting model.
* Blazor.Wasm.Host - .NET 5 ASP.NET web application which serves as the hosting application and the REST API for the Blazor WASM client.
* Blazor.Wasm.Client - .NET 5 Blazor application using the Blazor WASM hosting model.