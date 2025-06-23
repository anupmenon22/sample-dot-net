<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleDotNetApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample .NET Framework Web Application</title>
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
        .form-group {
            margin: 20px 0;
        }
        label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        input[type="text"], textarea {
            width: 100%;
            padding: 8px;
            border: 1px solid #ddd;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .btn {
            background-color: #007bff;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            margin: 5px;
        }
        .btn:hover {
            background-color: #0056b3;
        }
        .result {
            margin-top: 20px;
            padding: 15px;
            background-color: #d4edda;
            border: 1px solid #c3e6cb;
            border-radius: 4px;
            color: #155724;
        }
        .info {
            background-color: #e7f3ff;
            padding: 15px;
            border-radius: 4px;
            margin: 20px 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Welcome to Sample .NET Framework Web Application</h1>
            
            <div class="info">
                <strong>Application Info:</strong><br />
                Framework Version: <%= Environment.Version %><br />
                Server Time: <%= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %><br />
                Machine Name: <%= Environment.MachineName %>
            </div>

            <div class="form-group">
                <label for="txtName">Enter Your Name:</label>
                <asp:TextBox ID="txtName" runat="server" placeholder="Your name here..."></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtMessage">Enter a Message:</label>
                <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="4" placeholder="Your message here..."></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn" OnClick="btnClear_Click" />
            </div>

            <asp:Panel ID="pnlResult" runat="server" Visible="false" CssClass="result">
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
