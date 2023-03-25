@ModelType Data.Model.Film
@Code
    ViewData("Title") = "Details"
End Code
<link rel="stylesheet" type="text/css" href="~/Content/styles.css">

<h2 style="position: absolute; left: 810px; top: 130px; font-size: 40px">Film Details</h2>
<font size="6">
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
</div>
    </font>
<p class="button-1" style="position: absolute; top: 570px; left: 0px;">
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id})
    @Html.ActionLink("Back to List", "Index")
</p>
