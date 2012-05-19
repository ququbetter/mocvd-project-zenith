Public Class RecipeRoutines
	Public xmlRoutines As XElement
	Public routines() As RecipeRoutine
	Public currentRoutine As RecipeRoutine
	Private dimSize As Integer = 8
	Public count As Integer = 0

	Public Sub New(ByRef xmlRoutines As XElement)
		Me.xmlRoutines = xmlRoutines

		ReDim routines(dimSize)

	End Sub

	Public Sub addRoutine(recipeRoutine As RecipeRoutine)

		If count >= dimSize - 1 Then
			dimSize *= 2
			ReDim Preserve routines(dimSize)
		End If

		recipeRoutine.setIndex(count)
		routines(count) = recipeRoutine
		xmlRoutines.Add(recipeRoutine.xmlRoutine)
		currentRoutine = recipeRoutine
		count += 1

	End Sub
End Class
