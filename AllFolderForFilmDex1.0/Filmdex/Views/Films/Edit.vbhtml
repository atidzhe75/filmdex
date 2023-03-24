@ModelType Data.Model.Film
@Code
    ViewData("Title") = "Edit"
End Code
<link rel="stylesheet" type="text/css" href="~/Content/styles.css">

    <h2 style="position: absolute; left: 830px; top: 130px; font-size: 40px">Edit Film</h2>
    
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
           
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            @Html.HiddenFor(Function(model) model.Id)

            <div class="form-group" style="position: absolute; top: 250px; font-size: 30px">
                @Html.LabelFor(Function(model) model.Title, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Title, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Title, "", New With {.class = "text-danger"})
                </div>
            </div>


            <div class="form-group" style="position: absolute; top: 330px; font-size: 30px">
                @Html.LabelFor(Function(model) model.Genre, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Genre, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Genre, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group" style="position: absolute; top: 410px; font-size: 30px">
                @Html.LabelFor(Function(model) model.WatchedOn, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.WatchedOn, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.WatchedOn, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group" style="position: absolute; top: 560px;">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Save" class="btn btn-default" style="font-size: 25px" />
                </div>
            </div>

        </div>

    End Using

    <div class="button-1" style="position: absolute; top: 560px; left: 125px">
        @Html.ActionLink("Back to List", "Index")
    </div>

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
