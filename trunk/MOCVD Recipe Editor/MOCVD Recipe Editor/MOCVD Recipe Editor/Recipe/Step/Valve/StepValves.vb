Public Class StepValves
	Public xmlValves As XElement
	Public valves() As StepValve
	Private dimSize As Integer = 8
	Public count As Integer = 0
	Public listViewStep As ListViewItem

	Public Sub New(ByRef xmlValves As XElement, ByRef listViewStep As ListViewItem)
		Me.xmlValves = xmlValves
		Me.listViewStep = listViewStep
		ReDim valves(dimSize)
	End Sub

	Public Sub addValve(stepValve As StepValve)
		If count >= dimSize - 1 Then
			dimSize *= 2
			ReDim Preserve valves(dimSize)
		End If

		xmlValves.Add(stepValve.xmlValve)
		valves(count) = stepValve
		count += 1

		listViewStep.SubItems(6).Text = count
	End Sub

	Public Function addValve(index As Integer, value As Boolean) As StepValve
		Dim valve = New StepValve(index, value)
		addValve(valve)
		Return valve
	End Function

	Public Sub removeValve(index As Integer)
		Dim found = False

		For i As Integer = 0 To count
			If found Then
				valves(i) = valves(i + 1)
			Else
				If valves(i).getIndex = index Then
					found = True
					valves(i).xmlValve.Remove()
					valves(i) = valves(i + 1)
				End If
			End If
		Next

		If found Then
			count -= 1
			listViewStep.SubItems(6).Text = count
		End If

	End Sub

	Public Function getValve(index As Integer) As StepValve
		For i As Integer = 0 To count - 1
			If valves(i).getIndex = index Then
				Return valves(i)
			End If
		Next
		Return Nothing
	End Function

	Public Function getCount() As Integer
		Return count
	End Function

End Class
