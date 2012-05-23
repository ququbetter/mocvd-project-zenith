Public Class StepMFCs
	Public xmlMFCs As XElement
	Public MFCs() As StepMFC
	Private dimSize As Integer = 8
	Public count As Integer = 0
	Public listViewStep As ListViewItem

	Public Sub New(ByRef xmlMFCs As XElement, ByRef listViewStep As ListViewItem)
		Me.xmlMFCs = xmlMFCs
		Me.listViewStep = listViewStep
		ReDim MFCs(dimSize)
	End Sub

	Public Sub addMFC(stepMFC As StepMFC)
		If count >= dimSize - 1 Then
			dimSize *= 2
			ReDim Preserve MFCs(dimSize)
		End If

		xmlMFCs.Add(stepMFC.xmlMFC)
		MFCs(count) = stepMFC
		count += 1

		listViewStep.SubItems(7).Text = count
	End Sub

	Public Function addMFC(index As String, setPoint As Double) As StepMFC
		Dim MFC = New StepMFC(index, setPoint)
		addMFC(MFC)
		Return MFC
	End Function

	Public Function getMFC(index As Integer) As StepMFC
		Return MFCs(index)
	End Function

	Public Function getCount() As Integer
		Return count
	End Function
End Class
