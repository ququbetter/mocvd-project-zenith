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

	Public Function addValve(index As String, value As Boolean) As StepValve
		Dim valve = New StepValve(index, value)
		addValve(valve)
		Return valve
	End Function

	Public Function getValve(index As Integer) As StepValve
		Return valves(index)
	End Function

	Public Function getCount() As Integer
		Return count
	End Function

End Class
