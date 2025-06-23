# Sample .NET Framework Web Application

This is a simple ASP.NET Web Forms application built with the .NET Framework 4.8 (not .NET Core).

## Features

- Traditional ASP.NET Web Forms architecture
- Server controls with postback model
- Form validation and user interaction
- Multiple pages (Default.aspx and About.aspx)
- Responsive CSS styling
- Session and application state management

## Project Structure

```
├── Default.aspx              # Main page with form
├── Default.aspx.cs           # Code-behind for main page
├── Default.aspx.designer.cs  # Designer file for main page
├── About.aspx                # About page
├── About.aspx.cs             # Code-behind for about page
├── About.aspx.designer.cs    # Designer file for about page
├── Global.asax               # Application events
├── Global.asax.cs            # Global application code
├── Web.config                # Application configuration
├── SampleDotNetApp.csproj    # Project file
└── Properties/
    └── AssemblyInfo.cs       # Assembly metadata
```

## Requirements

- .NET Framework 4.8
- IIS or IIS Express
- Visual Studio (recommended) or any compatible IDE

## Running the Application

1. Open the project in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run with IIS Express (F5) or deploy to IIS
4. Navigate to Default.aspx in your browser

## Technology Stack

- **Framework**: .NET Framework 4.8
- **Language**: C#
- **Web Technology**: ASP.NET Web Forms
- **Server**: IIS/IIS Express
- **UI**: HTML, CSS, Server Controls

## Key Differences from .NET Core

This application uses the traditional .NET Framework approach:
- Web Forms instead of MVC or Razor Pages
- Server controls with ViewState
- Postback event model
- Global.asax for application events
- Web.config for configuration
- Full .NET Framework runtime required
