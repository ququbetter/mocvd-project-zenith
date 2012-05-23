Public Class StepMFC
	Public xmlMFC As XElement
	Public listViewMFC As ListViewItem

	Public Sub New(index As String, setPoint As Double)
		xmlMFC =
		 <MFC index=<%= index %>>
			 <setPoint></setPoint>
		 </MFC>

		listViewMFC = New ListViewItem({index, ""})
		setSetPoint(setPoint)
	End Sub

	Public Sub setIndex(index As Integer)
		xmlMFC.@index = index
		listViewMFC.SubItems(0).Text = index
	End Sub

	Public Sub setSetPoint(setPoint As Double)
		xmlMFC.<setPoint>.Value = setPoint
		listViewMFC.SubItems(1).Text = setPoint
	End Sub
End Class
