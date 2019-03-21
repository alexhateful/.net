<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>Login form</title>
    <meta name="viewport" content="width=device-width" />
    <link href="./assets/normalize.css" rel="stylesheet" />
    <link href="./assets/grid.css" rel="stylesheet" />
    <link href="./assets/utilities.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-4">&nbsp;</div>
                <div class="col-4">
                    <h1 class="text-center mt-5 uk-margin-large-top">Login form</h1>
                    <div class="form-group uk-margin">
                        <asp:Label ID="UsernameLabel"
                            Text="Username:"
                            AssociatedControlID="UsernameTextBox"
                            runat="server">
                        </asp:Label>
                        <asp:TextBox ID="UsernameTextBox" runat="server" />
                    </div>
                    <div class="form-group uk-margin">
                        <asp:Label ID="Label2"
                            Text="Password:"
                            AssociatedControlID="UsernamePassword"
                            runat="server">
                        </asp:Label>
                        <asp:TextBox ID="UsernamePassword" runat="server" />
                    </div>
                    <asp:Button Text="Submit" runat="server" SkinID="primary" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
