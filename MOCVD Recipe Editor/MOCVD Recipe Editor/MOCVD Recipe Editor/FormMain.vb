Public Class FormMain

	Dim recipe As Recipe
	Public currentRoutine As RecipeRoutine
	Public currentStep As RecipeStep

#Region "Sort Columns"
	Dim sortColumn_ValveList As Integer = -1
	Dim sortColumn_MFCsList As Integer = -1

	'Visual Basic 
	' Implements the manual sorting of items by columns.
	Class ListViewItemComparer
		Implements IComparer
		Private col As Integer
		Private order As SortOrder

		Public Sub New()
			col = 0
			order = SortOrder.Ascending
		End Sub

		Public Sub New(column As Integer, order As SortOrder)
			col = column
			Me.order = order
		End Sub

		Public Function Compare(x As Object, y As Object) As Integer _
		  Implements System.Collections.IComparer.Compare
			Dim returnVal As Integer = -1
			returnVal = [String].Compare(CType(x,  _
			  ListViewItem).SubItems(col).Text, _
			  CType(y, ListViewItem).SubItems(col).Text)
			' Determine whether the sort order is descending.
			If order = SortOrder.Descending Then
				' Invert the value returned by String.Compare.
				returnVal *= -1
			End If

			Return returnVal
		End Function
	End Class

	Private Sub sortListViewColumn(ByRef e As System.Windows.Forms.ColumnClickEventArgs, ByRef list As ListView, ByRef sortColumn As Integer)
		If e.Column <> sortColumn Then
			' Set the sort column to the new column.
			sortColumn = e.Column
			' Set the sort order to ascending by default.
			list.Sorting = SortOrder.Ascending
		Else
			' Determine what the last sort order was and change it.
			If list.Sorting = SortOrder.Ascending Then
				list.Sorting = SortOrder.Descending
			Else
				list.Sorting = SortOrder.Ascending
			End If
		End If
		' Call the sort method to manually sort.
		list.Sort()
		' Set the ListViewItemSorter property to a new ListViewItemComparer
		' object.
		list.ListViewItemSorter = New ListViewItemComparer(e.Column, list.Sorting)
	End Sub
#End Region


#Region "Forms"
	Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		ComboBox_TimeUnits.SelectedItem = "sec"
		ComboBox_RampUnits.SelectedItem = "sec"
		ComboBox_DelayUnits.SelectedItem = "sec"

		recipe = New Recipe
		recipe.setRecipeName(My.Settings.Recipe_Name)

		Me.Size = New Size(ShowStepsHiddenSize, Me.Size.Height)
		FormDebug.Show()
	End Sub
#End Region


#Region "Menu"
	Private Sub SetToOpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetToOpenToolStripMenuItem.Click
		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			item.SubItems(1).Text = "Open"
			item.SubItems(0).ForeColor = Color.Green
		Next
	End Sub

	Private Sub SetToCloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetToCloseToolStripMenuItem.Click
		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			item.SubItems(1).Text = "Close"
			item.SubItems(0).ForeColor = Color.Red
		Next
	End Sub

	Private Sub RemoveItemsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveItemsToolStripMenuItem.Click
		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			ListView_ValveList.Items.Remove(item)
		Next
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

	End Sub
#End Region


#Region "ListView"
	Private Sub ListView_ValveList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_ValveList.ColumnClick
		sortListViewColumn(e, ListView_ValveList, sortColumn_ValveList)
	End Sub

	Private Sub ListView_MFCsList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_MFCsList.ColumnClick
		sortListViewColumn(e, ListView_MFCsList, sortColumn_MFCsList)
	End Sub
#End Region


#Region "Routines"

	Private Sub Button_AddRoutine_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddRoutine.Click
		Dim routine As New RecipeRoutine(TextBox_RoutineName.Text, TextBox_RoutineDescription.Text)
		recipe.addRoutine(routine)

		addListViewRoutine(routine)

		FormDebug.RichTextBox1.Text = recipe.xmlRecipe.ToString
	End Sub

	Private Sub addListViewRoutine(ByRef recipeRoutine As RecipeRoutine)
		ListView_Routines.Items.Add(New ListViewItem({recipeRoutine.getIndex, recipeRoutine.getName, recipeRoutine.getDescription, recipeRoutine.steps.count}))
	End Sub


	Private Sub ListView_Routines_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView_Routines.SelectedIndexChanged
		If ListView_Routines.SelectedIndices.Count > 0 Then
			currentRoutine = recipe.routines.routines((ListView_Routines.SelectedIndices(0)))

			ListView_Steps.Items.Clear()
			If currentRoutine.steps.steps.Count > 0 Then
				currentStep = currentRoutine.steps.steps(0)
				displayStep(currentStep)
				For Each item As RecipeStep In currentRoutine.steps.steps
					If IsNothing(item) Then
						Exit For
					End If
					addListViewStep(item)
				Next
			Else
				clearStep()
				currentStep = Nothing
			End If

		End If
	End Sub

#End Region


#Region "Steps"

#Region "Show Steps"
	Dim ShowStepsEnabled As Boolean = False
	Dim ShowStepsHiddenSize As Integer = 359
	Dim ShowStepsRevealedSize As Integer = 1150

	Private Sub Button_ShowSteps_Click(sender As System.Object, e As System.EventArgs) Handles Button_ShowSteps.Click
		ShowStepsEnabled = Not ShowStepsEnabled
		If (ShowStepsEnabled) Then
			Button_ShowSteps.Text = "<--"
			Me.Size = New Size(ShowStepsRevealedSize, Me.Size.Height)
		Else
			Button_ShowSteps.Text = "-->"
			Me.Size = New Size(ShowStepsHiddenSize, Me.Size.Height)
		End If
	End Sub
#End Region

	Private Sub Button_AddStep_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddStep.Click
		If IsNothing(currentRoutine) Then
			Return
		End If

		Dim recipeStep = generateStep()

		currentRoutine.addStep(recipeStep)

		FormDebug.RichTextBox1.Text = recipe.xmlRecipe.ToString
		addListViewStep(recipeStep)
		clearStep()
	End Sub

	Private Function generateStep() As RecipeStep
		Dim time As Integer
		Dim ramp As Integer
		Dim delay As Integer

		getTiming(time, ramp, delay)

		Dim recipeStep = New RecipeStep(TextBox_StepName.Text, TextBox_StepDescription.Text, time, ramp, delay)

		For Each item As ListViewItem In ListView_ValveList.Items
			recipeStep.addValve(item.SubItems(0).Text, item.SubItems(1).Text)
		Next

		Return recipeStep
	End Function

	Private Sub Button_StepsUpdateChanges_Click(sender As System.Object, e As System.EventArgs) Handles Button_StepsUpdateChanges.Click
		currentStep = generateStep()

	End Sub

	Private Sub addListViewStep(ByRef recipeStep As RecipeStep)
		If IsNothing(currentStep) Then
			Return
		End If
		ListView_Steps.Items.Add(New ListViewItem({recipeStep.getIndex, recipeStep.getName, recipeStep.getDescription, recipeStep.getTime / 1000, recipeStep.getRamp / 1000, recipeStep.getDelay / 1000, recipeStep.getValveCount, recipeStep.getMFCCount}))
	End Sub

	Private Sub ListView_Steps_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView_Steps.SelectedIndexChanged
		If ListView_Steps.SelectedIndices.Count > 0 Then
			currentStep = currentRoutine.steps.steps(ListView_Steps.SelectedIndices(0))
			displayStep(currentStep)
		End If
	End Sub

	Private Sub displayStep(ByRef recipeStep As RecipeStep)
		clearStep()
		If IsNothing(currentStep) Then
			Return
		End If

		For Each valve As XElement In recipeStep.xmlStep.<valves>.<valve>
			addValve(valve.<index>.Value, valve.<action>.Value)
		Next
	End Sub

	Private Sub clearStep()

		ListView_ValveList.Items.Clear()
		RadioButton_ValveClose.Checked = True
		NumericUpDownValveIndex.Value = 1

	End Sub

#Region "Timing"
	Private Sub getTiming(ByRef time As Integer, ByRef ramp As Integer, ByRef delay As Integer)
		Select Case (ComboBox_TimeUnits.SelectedItem)
			Case "min"
				time = NumericUpDown_Time.Value * 60000
			Case "sec"
				time = NumericUpDown_Time.Value * 1000
			Case "ms"
				time = NumericUpDown_Time.Value
		End Select

		Select Case (ComboBox_RampUnits.SelectedItem)
			Case "min"
				ramp = NumericUpDown_Ramp.Value * 60000
			Case "sec"
				ramp = NumericUpDown_Ramp.Value * 1000
			Case "ms"
				ramp = NumericUpDown_Ramp.Value
		End Select

		Select Case (ComboBox_DelayUnits.SelectedItem)
			Case "min"
				delay = NumericUpDown_Delay.Value * 60000
			Case "sec"
				delay = NumericUpDown_Delay.Value * 1000
			Case "ms"
				delay = NumericUpDown_Delay.Value
		End Select
	End Sub
#End Region

#Region "Valves"
	Private Sub Button_AddValve_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddValve.Click
		If Not ListView_ValveList.Items.ContainsKey(NumericUpDownValveIndex.Value.ToString) Then
			addValve(NumericUpDownValveIndex.Value, RadioButton_ValveClose.Checked)
		Else

		End If
	End Sub

	Private Sub addValve(index As Decimal, value As Boolean)
		ListView_ValveList.Items.Add(index.ToString, index.ToString, 0)

		Dim valve = ListView_ValveList.Items(ListView_ValveList.Items.Count - 1)

		If value = True Then
			valve.SubItems.Add("Close")
			valve.SubItems(0).ForeColor = Color.Red
		Else
			valve.SubItems.Add("Open")
			valve.SubItems(0).ForeColor = Color.Green
		End If
	End Sub

	Private Sub addValve(index As String, action As String)
		ListView_ValveList.Items.Add(index, index, 0)

		Dim valve = ListView_ValveList.Items(ListView_ValveList.Items.Count - 1)

		If action = "Close" Then
			valve.SubItems.Add("Close")
			valve.SubItems(0).ForeColor = Color.Red
		Else
			valve.SubItems.Add("Open")
			valve.SubItems(0).ForeColor = Color.Green
		End If
	End Sub

#End Region

#Region "MFCs"
	Private Sub Button_MFCs_Click(sender As System.Object, e As System.EventArgs) Handles Button_MFCs.Click

	End Sub
#End Region

#End Region
End Class
