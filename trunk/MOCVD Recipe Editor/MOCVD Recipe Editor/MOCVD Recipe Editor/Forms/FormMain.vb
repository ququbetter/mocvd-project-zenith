
Public Class FormMain

	Dim recipe As Recipe
	Public currentRoutine As RecipeRoutine
	Public currentStep As RecipeStep
	Dim disableEvent As Boolean = False

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


#Region "Misc"
	Public Sub updateXMLViewer()
		Dim value As New Xml.XmlDocument
		value.LoadXml(recipe.xmlRecipe.ToString)

		Dim s As New System.IO.StringReader(My.Resources.defaultss)

		Dim xr As Xml.XmlReader = Xml.XmlReader.Create(s)
		Dim xct As Xml.Xsl.XslCompiledTransform = New Xml.Xsl.XslCompiledTransform
		xct.Load(xr)

		Dim sb As New System.Text.StringBuilder()
		Dim xw As Xml.XmlWriter = Xml.XmlWriter.Create(sb)
		xct.Transform(value, xw)
		FormXMLViewer.WebBrowser1.DocumentText = sb.ToString()
	End Sub

	Public Sub updateDebug()
		Dim value As New Xml.XmlDocument
		value.LoadXml(recipe.xmlRecipe.ToString)

		Dim s As New System.IO.StringReader(My.Resources.defaultss)

		Dim xr As Xml.XmlReader = Xml.XmlReader.Create(s)
		Dim xct As Xml.Xsl.XslCompiledTransform = New Xml.Xsl.XslCompiledTransform
		xct.Load(xr)

		Dim sb As New System.Text.StringBuilder()
		Dim xw As Xml.XmlWriter = Xml.XmlWriter.Create(sb)
		xct.Transform(value, xw)
		FormDebug.WebBrowser1.DocumentText = sb.ToString()
	End Sub
#End Region

#Region "Forms"
	Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		ComboBox_TimeUnits.SelectedItem = "sec"
		ComboBox_Ramp.SelectedItem = "none"

		recipe = New Recipe
		recipe.setRecipeName(My.Settings.Recipe_Name)

		Me.Size = New Size(ShowStepsHiddenSize, Me.Size.Height)

#If DEBUG Then
		FormDebug.Show()
#End If

	End Sub
#End Region



#Region "Menu"
	Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

	End Sub

	Private Sub ViewXMLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewXMLToolStripMenuItem.Click
		FormXMLViewer.Show()
		updateXMLViewer()

	End Sub
#End Region


#Region "ListView"
	Private Sub ListView_ValveList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_ValveList.ColumnClick
		sortListViewColumn(e, ListView_ValveList, sortColumn_ValveList)
	End Sub

	Private Sub ListView_MFCsList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_MFCList.ColumnClick
		sortListViewColumn(e, ListView_MFCList, sortColumn_MFCsList)
	End Sub
#End Region


#Region "Routines"

	Private Sub Button_AddRoutine_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddRoutine.Click
		Dim routine As New RecipeRoutine()
		recipe.addRoutine(routine)

		addListViewRoutine(routine)

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub addListViewRoutine(ByRef recipeRoutine As RecipeRoutine)
		If IsNothing(recipeRoutine) Then
			Return
		End If
		ListView_Routines.Items.Add(recipeRoutine.listViewRoutine)
		displayRoutine(recipeRoutine)
	End Sub

	Private Sub ListView_Routines_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView_Routines.SelectedIndexChanged
		If disableEvent Then
			Return
		End If
		If ListView_Routines.SelectedIndices.Count > 0 Then
			currentRoutine = recipe.routines.routines((ListView_Routines.SelectedIndices(0)))
			displayRoutine(currentRoutine)
		End If
	End Sub

	Private Sub displayRoutine(recipeRoutine As RecipeRoutine)
		Dim tempDisableEvent = disableEvent
		disableEvent = True
		ListView_Steps.Items.Clear()


		currentStep = recipeRoutine.steps.steps(0)
		displayStep(currentStep)
		For Each item As RecipeStep In recipeRoutine.steps.steps
			If IsNothing(item) Then
				Exit For
			End If
			addListViewStep(item)
		Next
		TextBox_RoutineName.Text = recipeRoutine.getName()
		TextBox_RoutineDescription.Text = recipeRoutine.getDescription()
		TextBox_RoutineSelectedIndex.Text = recipeRoutine.getIndex()

		disableEvent = tempDisableEvent
	End Sub

	Private Sub clearRoutine()
		Dim tempDisableEvent = disableEvent
		disableEvent = True
		TextBox_RoutineName.Text = ""
		TextBox_RoutineDescription.Text = ""
		TextBox_RoutineSelectedIndex.Text = ""
		disableEvent = tempDisableEvent
	End Sub

#Region "Routine Details"
	Private Sub TextBox_Routine_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_RoutineName.TextChanged, TextBox_RoutineDescription.TextChanged
		If IsNothing(currentRoutine) Or disableEvent Then
			Return
		End If

		currentRoutine.setName(TextBox_RoutineName.Text)
		currentRoutine.setDescription(TextBox_RoutineDescription.Text)

#If DEBUG Then
		updateDebug()
#End If
	End Sub
#End Region

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
		If IsNothing(currentRoutine) Or disableEvent Then
			Return
		End If

		Dim recipeStep = New RecipeStep()

		currentRoutine.addStep(recipeStep)
		addListViewStep(recipeStep)

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub addListViewStep(ByRef recipeStep As RecipeStep)
		If IsNothing(recipeStep) Then
			Return
		End If
		ListView_Steps.Items.Add(recipeStep.listViewStep)
		displayStep(recipeStep)
	End Sub

	Private Sub ListView_Steps_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView_Steps.SelectedIndexChanged
		If ListView_Steps.SelectedIndices.Count > 0 Then
			currentStep = currentRoutine.steps.steps(ListView_Steps.SelectedIndices(0))
			displayStep(currentStep)
		End If
	End Sub

	Private Sub displayStep(ByRef recipeStep As RecipeStep)
		clearStep()
		If IsNothing(recipeStep) Then
			Return
		End If

		Dim tempDisableEvent = disableEvent
		disableEvent = True

		displayValves(recipeStep)
		displayStepDetails(recipeStep)
		displayTiming(recipeStep)
		displayMFCs(recipeStep)

		disableEvent = tempDisableEvent
	End Sub

	Private Sub clearStep()
		Dim tempDisableEvent = disableEvent
		disableEvent = True

		clearValves()
		clearStepDetails()
		clearTiming()
		clearMFCs()

		disableEvent = tempDisableEvent
	End Sub

#Region "Step Details"
	Private Sub TextBox_Step_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_StepName.TextChanged, TextBox_StepDescription.TextChanged
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		currentStep.setName(TextBox_StepName.Text)
		currentStep.setDescription(TextBox_StepDescription.Text)

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub displayStepDetails(ByRef recipeStep As RecipeStep)
		TextBox_StepName.Text = recipeStep.getName()
		TextBox_StepDescription.Text = recipeStep.getDescription()
		TextBox_StepSelectedIndex.Text = recipeStep.getIndex()
	End Sub


	Private Sub clearStepDetails()
		TextBox_StepName.Text = ""
		TextBox_StepDescription.Text = ""
		TextBox_StepSelectedIndex.Text = ""
	End Sub
#End Region

#Region "Timing"
	Private Sub NumericUpDown_Timing_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown_Time.ValueChanged, ComboBox_TimeUnits.SelectedIndexChanged
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		currentStep.setTime(NumericUpDown_Time.Value, ComboBox_TimeUnits.SelectedItem)

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub displayTiming(ByRef recipeStep As RecipeStep)
		NumericUpDown_Time.Value = Integer.Parse(recipeStep.getTime())
		ComboBox_TimeUnits.SelectedItem = recipeStep.getTimeUnit()
		ComboBox_Ramp.SelectedItem = recipeStep.getRamp()
	End Sub

	Private Sub clearTiming()
		NumericUpDown_Time.Value = 0
		ComboBox_TimeUnits.SelectedItem = "sec"
		ComboBox_Ramp.SelectedItem = "none"
	End Sub

	Private Sub ComboBox_Ramp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_Ramp.SelectedIndexChanged
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		currentStep.setRamp(ComboBox_Ramp.SelectedItem)

#If DEBUG Then
		updateDebug()
#End If
	End Sub
#End Region

#Region "Valves"
	Private Sub Button_AddValve_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddValve.Click
		If IsNothing(currentStep) Then
			Return
		End If

		If ListView_ValveList.Items.Find(NumericUpDown_ValveIndex.Value.ToString, False).Count() = 0 Then
			Dim valve As StepValve = currentStep.valves.addValve(NumericUpDown_ValveIndex.Value, RadioButton_ValveOpen.Checked)
			ListView_ValveList.Items.Add(valve.listViewValve)
		Else

		End If

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub displayValves(ByRef recipeStep As RecipeStep)
		For Each valve As StepValve In currentStep.valves.valves
			If IsNothing(valve) Then
				Exit For
			End If
			ListView_ValveList.Items.Add(valve.listViewValve)
		Next
	End Sub

	Private Sub clearValves()
		ListView_ValveList.Items.Clear()
		RadioButton_ValveClose.Checked = True
		NumericUpDown_ValveIndex.Value = 1
	End Sub

	Private Sub SetToOpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetToOpenToolStripMenuItem.Click
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			item.SubItems(1).Text = "Open"
			item.SubItems(0).ForeColor = Color.Green
			Dim tempItem = item
			Dim valve As IEnumerable(Of XElement) = From elem In currentStep.xmlStep.<valves>.Elements() Where elem.@index = tempItem.Text Select elem
			valve.<action>.Value = "Open"
		Next

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub SetToCloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetToCloseToolStripMenuItem.Click
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			item.SubItems(1).Text = "Close"
			item.SubItems(0).ForeColor = Color.Red

			Dim valve As IEnumerable(Of XElement) = From elem In currentStep.xmlStep.<valves>.Elements() Where elem.@index = item.Text Select elem
			valve.<action>.Value = "Close"
		Next

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub RemoveItemsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveItemsToolStripMenuItem.Click
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		For Each item As ListViewItem In ListView_ValveList.SelectedItems
			ListView_ValveList.Items.Remove(item)
			Dim tempItem = item
			currentStep.valves.removeValve(item.Text)
		Next

#If DEBUG Then
		updateDebug()
#End If
	End Sub

#End Region

#Region "MFCs"
	Private Sub Button_MFCs_Click(sender As System.Object, e As System.EventArgs) Handles Button_MFCs.Click
		If IsNothing(currentStep) Then
			Return
		End If

		If ListView_MFCList.Items.Find(NumericUpDown_MFCIndex.Value.ToString, False).Count() = 0 Then
			Dim MFC As StepMFC = currentStep.MFCs.addMFC(NumericUpDown_MFCIndex.Value, NumericUpDown_MFCSetPoint.Value)
			ListView_MFCList.Items.Add(MFC.listViewMFC)
		Else

		End If

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub displayMFCs(ByRef recipeStep As RecipeStep)
		For Each MFC As StepMFC In currentStep.MFCs.MFCs
			If IsNothing(MFC) Then
				Exit For
			End If
			ListView_MFCList.Items.Add(MFC.listViewMFC)
		Next
	End Sub

	Private Sub clearMFCs()
		ListView_MFCList.Items.Clear()
		NumericUpDown_MFCIndex.Value = 1
		NumericUpDown_MFCSetPoint.Value = 0
	End Sub

	Private Sub ContextMenuStrip_MFCList_Closing(sender As Object, e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip_MFCList.Closing
		If ToolStripTextBox_MFCSetPoint.Enabled Then
			Dim value As Double
			If Double.TryParse(ToolStripTextBox_MFCSetPoint.Text, value) Then
				currentStep.MFCs.getMFC(ListView_MFCList.SelectedItems(0).Text).setSetPoint(value)
			End If
		End If

#If DEBUG Then
		updateDebug()
#End If
	End Sub

	Private Sub ContextMenuStrip_MFCList_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip_MFCList.Opening
		Dim tempDisableEvent = disableEvent
		disableEvent = True

		If ListView_MFCList.SelectedItems.Count = 0 Or ListView_MFCList.SelectedItems.Count > 1 Then
			ToolStripTextBox_MFCSetPoint.Text = ""
			ToolStripTextBox_MFCSetPoint.Enabled = False
			ToolStripTextBox_MFCSetPoint.BackColor = Color.LightGray
		Else
			ToolStripTextBox_MFCSetPoint.Text = ListView_MFCList.SelectedItems(0).SubItems(1).Text
			ToolStripTextBox_MFCSetPoint.Enabled = True
			ToolStripTextBox_MFCSetPoint.BackColor = Color.White
		End If

		disableEvent = tempDisableEvent
	End Sub

	Private Sub RemoveItemsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RemoveItemsToolStripMenuItem1.Click
		If IsNothing(currentStep) Or disableEvent Then
			Return
		End If

		For Each item As ListViewItem In ListView_MFCList.SelectedItems
			ListView_MFCList.Items.Remove(item)
			currentStep.MFCs.removeMFC(item.Text)
		Next

#If DEBUG Then
		updateDebug()
#End If
	End Sub
#End Region

#End Region
End Class
