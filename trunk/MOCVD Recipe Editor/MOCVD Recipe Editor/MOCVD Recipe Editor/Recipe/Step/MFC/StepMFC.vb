Public Class StepMFC
	Public xmlMFC As XElement
	Public listViewMFC As ListViewItem

	Public Sub New(index As Integer, setPoint As Double)
		xmlMFC =
		 <MFC index=<%= index %>>
			 <setPoint></setPoint>
		 </MFC>

		listViewMFC = New ListViewItem({index, ""})
		listViewMFC.Name = index
		setSetPoint(setPoint)
	End Sub

	Public Sub setIndex(index As Integer)
		xmlMFC.@index = index
		listViewMFC.SubItems(0).Text = index
		listViewMFC.Name = index
	End Sub

	Public Sub setSetPoint(setPoint As Double)
		xmlMFC.<setPoint>.Value = setPoint
		listViewMFC.SubItems(1).Text = setPoint
	End Sub

	Public Function getIndex() As Integer
		Return xmlMFC.@index
	End Function
End Class
