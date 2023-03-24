<!DOCTYPE html>
<html>

<head>

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Filmdex</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link rel="stylesheet" href="~/lib/font-awesome/css/all.min.css" />
    <link rel="icon" href="~/A23CAE2D-98C9-4B61-A555-7F7DB0FC300C_1_.ico" />
    <link rel="stylesheet" type="text/css" href="~/Content/Loader.css">
    
    <style>
        .navbar-nav {
            display: flex;
            flex-direction: row;
            justify-content: flex-start;
            align-items: center;
        }

            .navbar-nav li {
                margin-right: 10px;
            }
    </style>
</head>
<body>
     <font color="#DECFD7">
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
            <div class="logo">
                <a href="@Url.Action("Index", "Home")">
                    <img alt="Logo" src="~/A23CAE2D-98C9-4B61-A555-7F7DB0FC300C_1_.ico" style="
    text-align: left;
    margin-left: 15px;
    width:35%">
                </a>
            </div>
            <div class="logo2" style="position:absolute; left:39%;">
                <a href="@Url.Action("Index", "Home")">
                    <img alt="Logo-2" src="~/F3B35156-04DB-4485-BF96-53A2C39C2F06_1_.ico " style="width: 400px;">
                </a>
            </div>
            <div class="dropdown" style="float: right">
                <div class="container" onclick="myFunction(this)">
                    <div class="bar1"></div>
                    <div class="bar2"></div>
                    <div class="bar3"></div>
                    <script src="~/Scripts/ThreeLines.js"></script>
                    <div id="myDropdown" class="dropdown-content">
                        <a href="@Url.Action("About", "Home")">About us</a>
                        <a href="@Url.Action("Contact", "Home")">Contacts</a>
                        <a href="@Url.Action("Index", "Films")">Film Journal</a>
                        <style>
                            .container {
                                display: table;
                                cursor: pointer;
                            }

                            .dropdown {
                                display: inline-block;
                                left: 1480px;
                            }

                            button {
                                border: none;
                                border-radius: 5px;
                                padding: 15px 30px;
                                font-size: 18px;
                                cursor: pointer;
                            }

                            .navbar .dropdown-content {
                                right: 5px;
                                left: auto;
                                margin-top: 4px;
                            }

                            .dropdown-content {
                                display: none;
                                position: absolute;
                                overflow: auto;
                                background-color: #36454F;
                                border-radius: 5px;
                                box-shadow: 0px 10px 10px 0px rgba(0,0,0,0.4);
                            }



                                .dropdown-content a {
                                    display: block;
                                    color: ghostwhite;
                                    padding: 5px;
                                    text-decoration: none;
                                    padding: 20px 40px;
                                }

                            .bar1 {
                                background-color: #9F14E2;
                            }
                            .bar2 {
                                background-color: #8D15C7;
                            }
                            .bar3 {
                                background-color: #7B10D4;
                            }
                            .bar1, .bar2, .bar3 {
                                width: 60px;
                                height: 6px;
                                margin: 6px 0;
                                transition: 0.4s;
                            }

                            /* Rotate first bar */
                            .change .bar1 {
                                -webkit-transform: rotate(-45deg) translate(-9px, 8px);
                                transform: rotate(-45deg) translate(-9px, 8px);
                            }

                            /* Fade out the second bar */
                            .change .bar2 {
                                opacity: 0;
                            }

                            /* Rotate last bar */
                            .change .bar3 {
                                -webkit-transform: rotate(45deg) translate(-8px, -8px);
                                transform: rotate(45deg) translate(-8px, -8px);
                            }
                        </style>
                    </div>
                </div>
            </div>
        </nav>

        <div class="container body-content footer-container">
            @RenderBody()

            <footer>
            </footer>


        </div>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)

    </font>
</body>
</html>