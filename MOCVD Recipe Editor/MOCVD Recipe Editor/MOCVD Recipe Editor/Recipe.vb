Public Class Recipe
	Public xmlRecipe As XDocument

	Public routines As RecipeRoutines

	Public Sub New()
		xmlRecipe =
		 <?xml version="1.0"?>
		 <Recipe>
			 <name></name>
			 <routines>
			 </routines>
		 </Recipe>

		routines = New RecipeRoutines(xmlRecipe.<Recipe>.<routines>(0))

	End Sub

	Public Sub setRecipeName(name As String)
		xmlRecipe.<Recipe>.@name = name

	End Sub

	Public Sub addRoutine(recipeRoutine As RecipeRoutine)
		routines.addRoutine(recipeRoutine)
	End Sub

	Public Function getCurrentRoutine() As RecipeRoutine
		Return routines.currentRoutine
	End Function

End Class
