# Blazor Hosting
An exploratory application for investigating Blazor hosting models.

## Goal 
Share a common set of Blazor components between applications that utilize different hosting models.

## Implementation
Blazor Server and Blazor WASM hosting models are considered. Blazor Server has a single Web project. Blazor WASM includes a Web project as well as a Blazor Web Assembly project.

## Applications
* `Blazor.Server.Host` - .NET 5 Web application configured to run as a Blazor Server application.
* `Blazor.Wasm.Host` - .NET 5 Web application serving as the static host and REST API for the Blazor WASM application.
* `Blazor.Wasm.Client` - .NET 5 Blazor Web Assembly application.

## Libraries
* `Domain` - .NET Standard 2.0 class library of domain level types to be shared with all projects.
* `RestApi.Core` - .NET Standard 2.0 class library which defines a REST API implementation.
* `Blazor.Core` - .NET 5 Razor class library which defines the Blazor client application.

## Get Started
* Clone the repository
* Compile `BlazorHosting.sln`
* Run `Blazor.Server.Host` or `Blazor.Wasm.Host` (Blazor Server or WASM hosting respectively)
