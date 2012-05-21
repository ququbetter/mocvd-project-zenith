Public Class RecipeRoutine
	Public xmlRoutine As XElement
	Public steps As RecipeSteps
	Public listViewRoutine As ListViewItem

	Public Sub New(Optional name As String = "", Optional description As String = "")
		xmlRoutine =
		 <routine>
			 <name><%= name %></name>
			 <description><%= description %></description>
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

	Public Sub setDescription(description As String)
		xmlRoutine.<description>.Value = description
	End Sub

	Public Function getIndex() As Integer
		Return xmlRoutine.@index
	End Function

	Public Function getName() As String
		Return xmlRoutine.<name>.Value
	End Function

	Public Function getDescription() As String
		Return xmlRoutine.<description>.Value
	End Function

	Public Sub addStep(recipeStep As RecipeStep)
		steps.addStep(recipeStep)
	End Sub

End Class
