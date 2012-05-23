Public Class StepValve
	Public xmlValve As XElement
	Public listViewValve As ListViewItem

	Public Sub New(index As Integer, value As Boolean)
		xmlValve =
		  <valve index=<%= index %>>
			  <action></action>
		  </valve>

		listViewValve = New ListViewItem({index, ""})
		listViewValve.Name = index
		setAction(value)
	End Sub

	Public Sub setIndex(index As Integer)
		xmlValve.@index = index
		listViewValve.SubItems(0).Text = index
		listViewValve.Name = index
	End Sub

	Public Function getIndex() As Integer
		Return xmlValve.@index
	End Function
	
	Public Sub setAction(value As Boolean)
		If value Then
			xmlValve.<action>.Value = "Open"
			listViewValve.SubItems(1).Text = "Open"
			listViewValve.SubItems(0).ForeColor = Color.Green
		Else
			xmlValve.<action>.Value = "Close"
			listViewValve.SubItems(1).Text = "Close"
			listViewValve.SubItems(0).ForeColor = Color.Red
		End If

	End Sub

End Class
