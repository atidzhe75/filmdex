@ModelType Data.Model.Film
@Code
    ViewData("Title") = "Delete"
End Code
<link rel="stylesheet" type="text/css" href="~/Content/styles.css">

<h2 style="position: absolute; left: 810px; top: 130px; font-size: 40px">
    Delete Film
</h2>

<font size="6">
    <h3 style="position: absolute; top: 200px;">
    <strong>Are you sure you want to delete this?</strong>
    </h3>
    <div>

        <dl class="dl-horizontal" style="position: absolute; top: 250px;">
            <dt>
                @Html.DisplayNameFor(Function(model) model.Title)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Title)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.Genre)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.Genre)
            </dd>

            <dt>
                @Html.DisplayNameFor(Function(model) model.WatchedOn)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.WatchedOn)
            </dd>

        </dl>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-actions no-color" style="position: absolute; top: 570px;">
        <input type="submit" value="Delete" class="btn btn-default" style="font-size: 25px"/>
        <div class="button-1" style="position: absolute; top: 0px; left: 125px ">
            @Html.ActionLink("Back to List", "Index")
        </div>
    </div>
End Using
    </div>
 </font>
