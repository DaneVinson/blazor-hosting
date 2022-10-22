# Blazor Hosting
A .net exploratory application investigating Blazor hosting models.

## Goal 
Expose a common Blazor application through multiple hosting models.

## Implementation
Blazor Server and Blazor WASM hosting models are considered. Blazor Server has a single Web project. Blazor WASM includes a Web project and a Blazor Web Assembly project.

## Get Started
* Clone the repository
* Compile `BlazorHosting.sln`
* Run `Blazor.Server.Host` or `Blazor.Wasm.Host` (Blazor Server or WASM hosting respectively)

## Applications
* `Blazor.Server.Host` - .NET 6 Web application configured to run as a Blazor Server application.
* `Blazor.Wasm.Host` - .NET 6 Web application serving as the static host and REST API for the Blazor WASM application.
* `Blazor.Wasm.Client` - .NET 6 Blazor Web Assembly application.

## Libraries
* `Domain` - .NET Standard 2.0 class library of domain level types to be shared with all projects.
* `RestApi.Core` - .NET 6 class library which defines a REST API implementation.
* `Blazor.Core` - .NET 6 Razor class library which defines the Blazor client application.
