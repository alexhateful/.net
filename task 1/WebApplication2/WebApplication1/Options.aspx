﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="WebApplication1.Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Options</title>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.0/css/all.css" integrity="sha384-Mmxa0mLqhmOeaE8vgOSbKacftZcsNYDjQzuCOm6D02luYSzBG8vpaOykv9lFQ51Y" crossorigin="anonymous">
    <link href="./assets/normalize.css" rel="stylesheet" />
    <link href="./assets/grid.css" rel="stylesheet" />
    <link href="./assets/utilities.css" rel="stylesheet" />
    <link href="./assets/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-4 mt-5 uk-margin-large-top">
                    <asp:HyperLink runat="server" SkinID="Link" NavigateUrl="~/Default.aspx">Back to Login form</asp:HyperLink>
                </div>
                <div class="col-4">
                    <h1 class="text-center mt-5 uk-margin-large-top">Choose theme</h1>
                    <div class="form-group uk-margin">
                        <asp:RadioButton ID="bootstrap" Value="bootstrap" runat="server" Text="bootstrap" GroupName="theme" CssClass="custom-control custom-radio uk-radio" />
                    </div>
                    <div class="form-group uk-margin">
                        <asp:RadioButton ID="uikit" Value="uikit" runat="server" Text="uikit" GroupName="theme" CssClass="custom-control custom-radio uk-radio" />
                    </div>
                    <asp:Button ID="Theme_Submit" Text="Submit" runat="server" SkinID="primary" OnClick="Theme_Submit_Click" />
                </div>
            </div>
        </div>
        <%--bootstrap--%>
        <div>
            <div class="custom-control custom-radio">
                <input type="radio" id="customRadio1" name="customRadio" class="custom-control-input" checked>
                <label class="custom-control-label" for="customRadio1">Toggle this custom radio</label>
            </div>
            <div class="custom-control custom-radio">
                <input type="radio" id="customRadio2" name="customRadio" class="custom-control-input">
                <label class="custom-control-label" for="customRadio2">Or toggle this other custom radio</label>
            </div>
        </div>
        <%--uikit--%>
        <div class="uk-margin uk-grid-small uk-child-width-auto uk-grid">
            <label>
                <input class="uk-radio" type="radio" name="radio2" checked>
                A</label>
            <label>
                <input class="uk-radio" type="radio" name="radio2">
                B</label>
        </div>
    </form>
</body>
</html>
