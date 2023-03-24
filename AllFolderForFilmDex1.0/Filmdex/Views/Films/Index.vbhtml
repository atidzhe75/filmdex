@ModelType IEnumerable(Of Data.Model.Film)
@Code
    ViewData("Title") = "Index"
End Code
<link rel="stylesheet" type="text/css" href="~/Content/styles.css">

<p class="button-2" style="position: relative; right: 1%;text-align: center">

    @Html.ActionLink("Create New", "Create")
    
</p>


<font size="5">
    <table class="table" style="color:ghostwhite">

        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Title)
            </th>

            <th>
                @Html.DisplayNameFor(Function(model) model.Genre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.WatchedOn)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Title)
                </td>

                <td>
                    @Html.DisplayFor(Function(modelItem) item.Genre)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.WatchedOn)
                </td>
                <td class="button-1" style="text-align: center;">
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id})
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id})
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                    
                </td>

            </tr>
            Next

    </table>
</font>
