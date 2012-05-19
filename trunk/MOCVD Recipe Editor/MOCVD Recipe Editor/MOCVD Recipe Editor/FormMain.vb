Public Class FormMain
	Dim sortColumn_ValveList As Integer = -1
	Dim sortColumn_MFCsList As Integer = -1

	Dim recipe As Recipe

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



	Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		ComboBox_TimeUnits.SelectedItem = "sec"
		ComboBox_RampUnits.SelectedItem = "sec"
		ComboBox_DelayUnits.SelectedItem = "sec"

		Dim routine As New RecipeRoutine()
		routine.setName(My.Settings.Recipe_Name)

		recipe = New Recipe
		recipe.addRoutine(routine)
		recipe.setRecipeName(My.Settings.Recipe_Name)
	End Sub

	Private Sub Button_AddValve_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddValve.Click
		If Not ListView_ValveList.Items.ContainsKey(NumericUpDownValveIndex.Value.ToString) Then
			ListView_ValveList.Items.Add(NumericUpDownValveIndex.Value.ToString, NumericUpDownValveIndex.Value.ToString, 0)

			Dim valve = ListView_ValveList.Items(ListView_ValveList.Items.Count - 1)

			If RadioButton_ValveClose.Checked = True Then
				valve.SubItems.Add("Close")
				valve.SubItems(0).ForeColor = Color.Red
			Else
				valve.SubItems.Add("Open")
				valve.SubItems(0).ForeColor = Color.Green
			End If

		Else


		End If


	End Sub

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

	Private Sub Button_AddStep_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddStep.Click
		Dim time As Integer
		Dim ramp As Integer
		Dim delay As Integer

		getTiming(time, ramp, delay)

		Dim recipeStep = New RecipeStep(TextBox_StepName.Text, TextBox_StepDescription.Text, time, ramp, delay)

		For Each item As ListViewItem In ListView_ValveList.Items
			recipeStep.addValve(item.SubItems(0).Text, item.SubItems(1).Text)
		Next

		recipe.getCurrentRoutine().addStep(recipeStep)

		TextBox1.Text = recipe.xmlRecipe.ToString
		addStep(recipeStep)
		clearSettings()
	End Sub

	Private Sub ListView_ValveList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_ValveList.ColumnClick
		sortListViewColumn(e, ListView_ValveList, sortColumn_ValveList)
	End Sub

	Private Sub ListView_MFCsList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_MFCsList.ColumnClick
		sortListViewColumn(e, ListView_MFCsList, sortColumn_MFCsList)
	End Sub

	Private Sub Button_MFCs_Click(sender As System.Object, e As System.EventArgs) Handles Button_MFCs.Click

	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
		
	End Sub

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

	Private Sub clearSettings()

		ListView_ValveList.Items.Clear()
		RadioButton_ValveClose.Checked = True
		NumericUpDownValveIndex.Value = 1

	End Sub

	Private Sub addStep(ByRef recipeStep As RecipeStep)
		ListView_Steps.Items.Add(New ListViewItem({recipeStep.getIndex, recipeStep.getName, recipeStep.getDescription, recipeStep.getTime / 1000, recipeStep.getRamp / 1000, recipeStep.getDelay / 1000, recipeStep.getValveCount, recipeStep.getMFCCount}))
	End Sub

	Private Sub Button_AddRoutine_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddRoutine.Click

	End Sub
End Class
