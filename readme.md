# Blazor Hosting
A .NET 8 exploratory application investigating Blazor hosting models.

## Goal 
Expose a common Blazor application through multiple hosting models.

## Implementation
Blazor Server and Blazor WASM hosting models are considered. Blazor Server has a single Web project. Blazor WASM includes a Web project and a Blazor Web Assembly project.

## Get Started
* Clone the repository
* Build `BlazorHosting.sln`
* Run `Blazor.Server.Host` or `Blazor.Wasm.Host` (Blazor Server or WASM hosting respectively)

## Applications
* `Blazor.Server.Host` - .NET 8 Web application configured to run as a Blazor Server application.
* `Blazor.Wasm.Host` - .NET 8 Web application serving as the static host and REST API for the Blazor WASM application.
* `Blazor.Wasm.Client` - .NET 8 Blazor Web Assembly application.

## Libraries
* `Domain` - .NET Standard 2.0 class library of domain level types to be shared with all projects.
* `Services.Core` - .NET 8 class library which defines server-side implementation.
* `Blazor.Core` - .NET 8 Razor class library which defines the Blazor client application.
