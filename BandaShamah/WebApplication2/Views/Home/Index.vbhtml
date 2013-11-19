﻿@Code
    Layout = Nothing
    Response.Headers("X-UA-Compatible") = "IE=10"
End Code
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>My ASP.NET Application</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width" />
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div data-bind="visible: loading">Loading...</div>
    <div style="display: none" data-bind="visible: true" class="container body-content">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <p class="navbar-brand" data-bind="if: !loggedIn()">Application Name</p>
                    <a href="#" class="navbar-brand" data-bind="if: loggedIn, click: navigateToHome">Application Name</a>
                </div>
                <div data-bind="if: loggedIn" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a href="#" data-bind="click: navigateToHome">Home</a></li>
                        <li>@Html.ActionLink("API", "Index", "Help", New With {.area = "HelpPage"}, Nothing)</li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right" data-bind="with: user">
                        <li>
                            <span class="navbar-text nofloat">Hello, <a href="#" class="navbar-link" data-bind="text: name, click: manage"></a>!</span>
                        </li>
                        <li><a href="#" data-bind="click: logOff">Log off</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <div data-bind="foreach: errors" class="padding-error">
            <p class="text-danger" data-bind="text: $data"></p>
        </div>
        @Html.Partial("_Home")
        @Html.Partial("_Login")
        @Html.Partial("_Register")
        @Html.Partial("_RegisterExternal")
        @Html.Partial("_Manage")
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/knockout")
    @Scripts.Render("~/bundles/app")
    @Scripts.Render("~/bundles/bootstrap")
</body>
</html>
