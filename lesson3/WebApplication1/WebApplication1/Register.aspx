<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:400px; margin: 0 auto;">
                <tr>
                    <td>Real name</td>
                    <td>
                        <asp:TextBox runat="server" ID="Name"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Login</td>
                    <td>
                        <asp:TextBox runat="server" ID="Login"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="Login_Button_Check" Text="Check" />
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox runat="server" ID="Password"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>Salt</td>
                    <td>
                        <asp:TextBox runat="server" ID="Salt"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="Salt_Button_Generate" Text="Generate" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="Button_Register" Text="Register" OnClick="Button_Register_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
