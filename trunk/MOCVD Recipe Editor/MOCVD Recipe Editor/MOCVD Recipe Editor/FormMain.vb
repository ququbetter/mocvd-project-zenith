Public Class FormMain
	Dim sortColumn As Integer = -1

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



	Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		ComboBox_TimeUnits.SelectedItem = "sec"
		ComboBox_RampUnits.SelectedItem = "sec"
		ComboBox_DelayUnits.SelectedItem = "sec"
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

	End Sub

	Private Sub ListView_ValveList_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView_ValveList.ColumnClick
		If e.Column <> sortColumn Then
			' Set the sort column to the new column.
			sortColumn = e.Column
			' Set the sort order to ascending by default.
			ListView_ValveList.Sorting = SortOrder.Ascending
		Else
			' Determine what the last sort order was and change it.
			If ListView_ValveList.Sorting = SortOrder.Ascending Then
				ListView_ValveList.Sorting = SortOrder.Descending
			Else
				ListView_ValveList.Sorting = SortOrder.Ascending
			End If
		End If
		' Call the sort method to manually sort.
		ListView_ValveList.Sort()
		' Set the ListViewItemSorter property to a new ListViewItemComparer
		' object.
		ListView_ValveList.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView_ValveList.Sorting)
	End Sub
End Class
