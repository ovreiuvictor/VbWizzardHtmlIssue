@Code
    ViewData("Title") = "About"
End Code

<section class="jumbotron text-center">
    <div class="container">
        <h1 class="jumbotron-heading">@ViewBag.Title.</h1>
        <p class="lead-text text-muted">@ViewBag.Message</p>
    </div>
</section>

<div class="row mb-3">
    <div class="col-md mt-3 mb-3">
        <div class="k-card">
            <div class="k-card-header">
                Card Header
            </div>
            <div class="k-card-body">
                <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            </div>
            <div class="k-card-actions">
                <span class="k-button k-flat k-primary">Action 1</span>
                <span class="k-button k-flat k-primary">Action 2</span>
            </div>
        </div>
    </div>
    <div class="col-md mt-3 mb-3">
        <div class="k-card">
            <div class="k-card-header">
                Card Header
            </div>
            <div class="k-card-body">
                <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            </div>
            <div class="k-card-actions">
                <span class="k-button k-flat k-primary">Action 1</span>
                <span class="k-button k-flat k-primary">Action 2</span>
            </div>
        </div>
    </div>
    <div class="col-md mt-3 mb-3">
        <div class="k-card">
            <div class="k-card-header">
                Card Header
            </div>
            <div class="k-card-body">
                <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            </div>
            <div class="k-card-actions">
                <span class="k-button k-flat k-primary">Action 1</span>
                <span class="k-button k-flat k-primary">Action 2</span>
            </div>
        </div>
    </div>
</div>

<div>
    <h4 class="font-weight-normal">UI for ASP.NET MVC TreeView</h4>

    @(Html.Kendo().TreeView() _
       .Name("LinksTreeView") _
       .Items(Sub(items)
                  items.Add() _
                      .Text("Home") _
                      .Action("Index", "Home") _
                      .Items(Sub(a)
                                 a.Add().Text("Nested TreeView item")
                             End Sub)
                  items.Add() _
                      .Text("About") _
                      .Action("About", "Home") _
                      .Items(Sub(a)
                                 a.Add().Text("Nested TreeView item")
                             End Sub)
                  items.Add() _
                      .Text("Contact") _
                      .Action("Contact", "Home") _
                      .Items(Sub(a)
                                 a.Add().Text("Nested TreeView item")
                             End Sub)
              End Sub)
        )
</div>
