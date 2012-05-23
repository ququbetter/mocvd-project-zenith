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

	Public Function addMFC(index As Integer, setPoint As Double) As StepMFC
		Dim MFC = New StepMFC(index, setPoint)
		addMFC(MFC)
		Return MFC
	End Function

	Public Sub removeMFC(index As Integer)
		Dim found = False

		For i As Integer = 0 To count - 1
			If found Then
				MFCs(i) = MFCs(i + 1)
			Else
				If MFCs(i).getIndex = index Then
					found = True
					MFCs(i).xmlMFC.Remove()
					MFCs(i) = MFCs(i + 1)
				End If
			End If
		Next

		If found Then
			count -= 1
			listViewStep.SubItems(7).Text = count
		End If
	End Sub

	Public Function getMFC(index As Integer) As StepMFC
		Return MFCs(index)
	End Function

	Public Function getCount() As Integer
		Return count
	End Function
End Class
