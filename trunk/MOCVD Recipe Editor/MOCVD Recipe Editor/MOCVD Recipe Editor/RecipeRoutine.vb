Public Class RecipeRoutine
	Public xmlRoutine As XElement
	Public steps As RecipeSteps

	Public Sub New()
		xmlRoutine =
		 <routine>
			 <name></name>
			 <steps></steps>
		 </routine>

		steps = New RecipeSteps(xmlRoutine.<steps>(0))
	End Sub

	Public Sub setIndex(index As Integer)
		xmlRoutine.@index = index
	End Sub

	Public Sub setName(name As String)
		xmlRoutine.<name>.Value = name
	End Sub

	Public Sub addStep(recipeStep As RecipeStep)
		steps.addStep(recipeStep)
	End Sub

End Class
