<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SampleDotNetApp.About" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About - Sample .NET Framework Web Application</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 40px;
            background-color: #f5f5f5;
        }
        .container {
            background-color: white;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
            max-width: 800px;
            margin: 0 auto;
        }
        h1 {
            color: #333;
            text-align: center;
        }
        .nav {
            text-align: center;
            margin: 20px 0;
        }
        .nav a {
            color: #007bff;
            text-decoration: none;
            margin: 0 10px;
        }
        .nav a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="nav">
                <a href="Default.aspx">Home</a> | 
                <a href="About.aspx">About</a>
            </div>
            
            <h1>About This Application</h1>
            
            <p>This is a simple ASP.NET Web Forms application built with the .NET Framework (not .NET Core).</p>
            
            <h3>Features:</h3>
            <ul>
                <li>Traditional ASP.NET Web Forms architecture</li>
                <li>Server controls and postback model</li>
                <li>Simple form validation</li>
                <li>Session and application state management</li>
                <li>Responsive design with CSS</li>
            </ul>
            
            <h3>Technical Details:</h3>
            <ul>
                <li>Framework: .NET Framework 4.8</li>
                <li>Language: C#</li>
                <li>Web Technology: ASP.NET Web Forms</li>
                <li>Server: IIS/IIS Express</li>
            </ul>
            
            <p><strong>Created:</strong> <%= DateTime.Now.ToString("MMMM yyyy") %></p>
        </div>
    </form>
</body>
</html>
