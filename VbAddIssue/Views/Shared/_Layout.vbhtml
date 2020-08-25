﻿<!DOCTYPE html>
<html>   
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>@ViewBag.Title - My Telerik MVC Application</title>
    	<link href="https://kendo.cdn.telerik.com/2020.2.617/styles/kendo.bootstrap-v4.min.css" rel="stylesheet" type="text/css" />
	<link href="@Url.Content("~/Content/bootstrap.min.css")" rel="stylesheet" type="text/css" />
	<link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
	<script src="https://kendo.cdn.telerik.com/2020.2.617/js/jquery.min.js"></script>
	<script src="https://kendo.cdn.telerik.com/2020.2.617/js/jszip.min.js"></script>
	<script src="https://kendo.cdn.telerik.com/2020.2.617/js/kendo.all.min.js"></script>
	<script src="https://kendo.cdn.telerik.com/2020.2.617/js/kendo.aspnetmvc.min.js"></script>
	<script src="@Url.Content("~/Scripts/bootstrap.min.js")"></script>
	<script src="@Url.Content("~/Scripts/kendo.modernizr.custom.js")"></script>
</head>
    <body class="k-content">
        <nav class="navbar navbar-inverse navbar-fixed-top p-3">
            <div class="container p-0 p-sm-3">
                <div class="navbar-header">
                    <button id="configure" class="k-rpanel-toggle k-button btn-toggle"><span class="k-icon k-i-menu"></span></button>
                    @Html.ActionLink("Application name", "Index", "Home", New With {Key .area = ""}, New With {Key .class = "navbar-brand"})
                </div>
                <div id="responsive-panel" class="navbar-left">
                    @Code
                        Html.Kendo().Menu() _
                            .Name("Menu") _
                            .Items(Sub(items)
                                       items.Add().Text("Home").Action("Index", "Home", New With {Key .area = ""})
                                       items.Add().Text("About").Action("About", "Home", New With {Key .area = ""})
                                       items.Add().Text("Contact").Action("Contact", "Home", New With {Key .area = ""})
                                   End Sub).Render()
                    End Code
                </div>
            </div>
        </nav>
       
        <main>
            <div class="container">
                @RenderBody()
            </div>
        </main>
       
        <footer class="footer text-center d-flex align-items-center">
            <div class="container pb-0">
                <hr />
                <p>Copyright &copy; @DateTime.Now.Year Progress Software Corporation and/or its subsidiaries or affiliates. All Rights Reserved.</p>
            </div>
        </footer>
       
        <script>
            $(document).ready(function () {
                $("#responsive-panel").kendoResponsivePanel({
                    breakpoint: 768,
                    autoClose: false,
                    orientation: "top"
                });
            });
            function onclick(e) {
                $("#responsive-panel").getKendoResponsivePanel().toggle();
            }
        </script>
       
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </body>
</html>
