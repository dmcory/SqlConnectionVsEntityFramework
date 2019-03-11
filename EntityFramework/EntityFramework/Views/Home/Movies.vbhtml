@ModelType List(Of Movie)
@Code
    ViewData("Title") = "Movies"
End Code

<table class="table">
    <thead>
        <tr>
            <th scope="col">id</th>
            <th scope="col">Name</th>
            <th scope="col">Genre</th>
        </tr>
    </thead>
    <tbody>
        @For Each movie In Model
            @<text>
                <tr>
                    <td>@Html.DisplayFor(Function(x) movie.id)</td>
                    <td>@Html.DisplayFor(Function(x) movie.Name)</td>
                    <td>@Html.DisplayFor(Function(x) movie.Genre)</td>
                </tr>
            </text>
        Next
    </tbody>
</table>
