Public Class RecipeRoutine
	Public xmlRoutine As XElement
	Public steps As RecipeSteps
	Public listViewRoutine As ListViewItem

	Public Sub New()
		xmlRoutine =
		 <routine>
			 <name>(name)</name>
			 <description>(description)</description>
			 <steps></steps>
		 </routine>

		steps = New RecipeSteps(xmlRoutine.<steps>(0))
		listViewRoutine = New ListViewItem({0, "(name)", "(description)", 0})
	End Sub

	Public Sub setIndex(index As Integer)
		xmlRoutine.@index = index
		listViewRoutine.SubItems(0).Text = index
	End Sub

	Public Sub setName(name As String)
		xmlRoutine.<name>.Value = name
		listViewRoutine.SubItems(1).Text = name
	End Sub

	Public Sub setDescription(description As String)
		xmlRoutine.<description>.Value = description
		listViewRoutine.SubItems(2).Text = description
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

	Public Function getStepCount() As Integer
		Return steps.count
	End Function

	Public Sub addStep(recipeStep As RecipeStep)
		steps.addStep(recipeStep)
		listViewRoutine.SubItems(3).Text = getStepCount()
	End Sub

End Class
