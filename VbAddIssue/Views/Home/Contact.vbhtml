@Code
    ViewData("Title") = "Contact"
End Code


<section class="jumbotron text-center">
    <div class="container">
        <h1 class="jumbotron-heading">@ViewBag.Title.</h1>
        <p class="lead-text text-muted">@ViewBag.Message</p>
    </div>
</section>


<div>
    <h3>UI for ASP.NET MVC TabStrip</h3>
    @Code
        Html.Kendo().TabStrip() _
        .Name("ContactsTabStrip") _
        .Items(Sub(items)
            items.Add() _
                .Text("Phone") _
                .Selected(True) _
                .Content(Sub()
                    @<text>
                        <p>
                            <span class="label">Main:</span>
                            <span>425.555.0100</span>
                        </p>
                        <p>
                            <span class="label">After Hours:</span>
                            <span>425.555.0199</span>
                        </p>
                    </text>
                         End Sub) _
                .ContentHtmlAttributes(New With {.style = "min-height: 200px"})
            items.Add() _
                .Text("Email") _
                .Content(Sub()
                     @<text>
                         <p>
                             <span class="label">Support:</span>
                             <span><a href="mailto:Support@example.com">Support@example.com</a></span>
                         </p>
                         <p>
                             <span class="label">Marketing:</span>
                             <span><a href="mailto:Marketing@example.com">Marketing@example.com</a></span>
                         </p>
                         <p>
                             <span class="label">General:</span>
                             <span><a href="mailto:General@example.com">General@example.com</a></span>
                         </p>
                     </text>
                         End Sub) _
                .ContentHtmlAttributes(New With {.style = "min-height: 200px"})
            items.Add() _
                .Text("Address") _
                .Content(Sub()
                    @<text>
                        <p>
                            One Microsoft Way<br />
                            Redmond, WA 98052-6399
                        </p>
                    </text>
                         End Sub) _
                .ContentHtmlAttributes(New With {.style = "min-height: 200px"})
               End Sub).Render()
End Code
</div>
