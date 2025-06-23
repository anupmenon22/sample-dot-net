# Sample .NET Framework MVC Application

This is a simple ASP.NET MVC application built with the .NET Framework 4.8 using Razor Views.

## Features

- ASP.NET MVC 5 architecture
- Razor View Engine for clean, maintainable views
- Model-View-Controller pattern for separation of concerns
- Form validation and user interaction
- Multiple views (Home/Index and Home/About)
- Responsive CSS styling
- RESTful routing
- Clean HTML output without ViewState

## Project Structure

```
├── Controllers/
│   └── HomeController.cs         # MVC Controller handling requests
├── Models/
│   └── MessageModel.cs           # Data model for form handling
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml          # Main page view
│   │   └── About.cshtml          # About page view
│   ├── Shared/
│   │   └── _Layout.cshtml        # Master layout template
│   ├── _ViewStart.cshtml         # View initialization
│   └── web.config                # Views configuration
├── Global.asax                   # Application events
├── Global.asax.cs                # Global application code with routing
├── Web.config                    # Application configuration
├── SampleDotNetApp.csproj        # Project file
├── SampleDotNetApp.sln           # Solution file
├── packages.config               # NuGet packages
└── Properties/
    └── AssemblyInfo.cs           # Assembly metadata
```

## Requirements

- .NET Framework 4.8
- ASP.NET MVC 5.2.9
- IIS or IIS Express
- Visual Studio (recommended) or any compatible IDE

## Running the Application

1. Open the solution file `SampleDotNetApp.sln` in Visual Studio
2. Restore NuGet packages (if needed)
3. Build the solution (Ctrl+Shift+B)
4. Run with IIS Express (F5) or deploy to IIS
5. Navigate to the application in your browser (default route: `/Home/Index`)

## Technology Stack

- **Framework**: .NET Framework 4.8
- **Language**: C#
- **Web Technology**: ASP.NET MVC 5
- **View Engine**: Razor
- **Server**: IIS/IIS Express
- **UI**: HTML, CSS, Razor Views

## Key Benefits of MVC over Web Forms

This application demonstrates the advantages of MVC architecture:

- **Separation of Concerns**: Clear separation between Models, Views, and Controllers
- **Testability**: Controllers and models can be easily unit tested
- **Full HTML Control**: Complete control over rendered HTML markup
- **RESTful URLs**: Clean, SEO-friendly URLs with routing
- **No ViewState**: Lighter page weight without ViewState overhead
- **Stateless**: True stateless web application model
- **Modern Web Development**: Better support for AJAX, JSON, and modern web practices

## Routes

- `/` or `/Home/Index` - Main page with form
- `/Home/About` - About page with application information

## Architecture

The application follows the MVC pattern:

- **Models**: `MessageModel` handles form data and validation
- **Views**: Razor views (.cshtml) for presentation layer
- **Controllers**: `HomeController` handles HTTP requests and responses
- **Routing**: Configured in `Global.asax.cs` for clean URLs
