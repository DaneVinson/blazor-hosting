# Blazor Hosting
An application for exploring Blazor hosting models.

## Goal 
Expose a common Blazor application through multiple hosting models.

## Implementation
Blazor Web Apps with Interactive Render Modes of `Server` and `Web Assembly` are considered.

## Applications
* `Blazor.Server.Host` - .NET 8 Blazor Web App with Interactive Render Mode of `Server`.
* `Blazor.Wasm.Host` - The server-side project of a .NET 8 Blazor Web App with Interactive Render Mode of `Web Assembly`. Serves as the static host of the Web Assembly client application and as the REST API for to the client.
* `Blazor.Wasm.Client` - The client project of a .NET 8 Blazor Web App with Interactive Render Mode of `Web Assembly`.

## Libraries
* `Domain` - .NET Standard 2.0 class library of domain level types to be shared with all projects.
* `Services.Core` - .NET 8 class library which defines server-side types.
* `Blazor.Core` - .NET 8 Razor class library which defines the types that make up the Blazor application.

## Get Started
* Clone the repository
* Build `BlazorHosting.sln`
* Run `Blazor.Server.Host` or `Blazor.Wasm.Host` (Blazor Web Apps with Interactive Render Mode of Server and Web Assembly respectively)
