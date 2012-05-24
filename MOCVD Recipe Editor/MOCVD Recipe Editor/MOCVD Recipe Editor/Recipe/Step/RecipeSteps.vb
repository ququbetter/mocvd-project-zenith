Public Class RecipeSteps
	Public xmlSteps As XElement
	Public steps() As RecipeStep
	Private dimSize As Integer = 8
	Public count As Integer = 0
	Public currentStep As RecipeStep

	Public Sub New(ByRef xmlSteps As XElement)
		Me.xmlSteps = xmlSteps

		ReDim steps(dimSize)

	End Sub

	Public Sub addStep(recipeStep As RecipeStep)

		If count >= dimSize - 1 Then
			dimSize *= 2
			ReDim Preserve steps(dimSize)
		End If

		recipeStep.setIndex(count)
		steps(count) = recipeStep
		xmlSteps.Add(recipeStep.xmlStep)
		count += 1

		FormRecipeEditor.currentStep = recipeStep
	End Sub

	Public Function getStep(index As Integer) As RecipeStep
		Return steps(index)
	End Function


End Class
