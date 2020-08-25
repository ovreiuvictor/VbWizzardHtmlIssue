@Modeltype Equipment

@Code
	ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
	<h1>ASP.NET</h1>
	<p class="lead text-muted">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
	<p><a href="http://asp.net" class="k-button k-primary">Learn more &raquo;</a></p>
</div>

@Code
	Html.Kendo.Wizard() _
		.Name("wzdEquipment") _
		.Tag("form") _
		.HtmlAttributes(New With {.novalidate = ""}) _
		.ReloadOnSelect(False) _
		.Steps(Sub(s)
				   s.Add() _
				   .Title("Definire utilaj") _
				   .Form(Sub(f)
							 f.Validatable(Sub(v)
											   v.ValidateOnBlur(True)
											   v.ValidationSummary(Function(vs) vs.Enable(True))
											   v.ErrorTemplate("<span style='color: red'>#:message#</span>")
										   End Sub)
							 f.FormData(Model)
							 f.Items(Sub(i)
										 i.Add().Field("Symbol").Label("Simbol")
										 i.Add().Field("Description").Label("Descriere")
									 End Sub)
						 End Sub) _
				   .Buttons(Sub(b)
								b.Next()
							End Sub)
				   s.Add() _
				   .Title("Operatii utilaj") _
				   .Buttons(Sub(b)
								b.Previous()
								b.Done()
							End Sub)
			   End Sub) _
		.Render()
End Code
