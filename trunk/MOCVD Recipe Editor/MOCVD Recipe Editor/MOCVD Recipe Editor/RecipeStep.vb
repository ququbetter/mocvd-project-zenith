Public Class RecipeStep
	Public xmlStep As XElement
	Public listViewStep As ListViewItem

	Public Sub New()
		xmlStep =
		 <step index="0">
			 <name>(name)</name>
			 <description>(description)</description>
			 <time unit="sec">0</time>
			 <ramp>none</ramp>
			 <valves></valves>
			 <MFCs></MFCs>
		 </step>

		listViewStep = New ListViewItem({0, "(name)", "(description)", 0, "sec", "none", 0, 0})
	End Sub

	Public Sub setIndex(index As Integer)
		xmlStep.@index = index
		listViewStep.SubItems(0).Text = index
	End Sub

	Public Sub setName(name As String)
		xmlStep.<name>.Value = name
		listViewStep.SubItems(1).Text = name
	End Sub

	Public Sub setDescription(description As String)
		xmlStep.<description>.Value = description
		listViewStep.SubItems(2).Text = description
	End Sub

	Public Sub setTime(time As String, unit As String)
		xmlStep.<time>.Value = time
		xmlStep.<time>.@unit = unit
		listViewStep.SubItems(3).Text = time
		listViewStep.SubItems(4).Text = unit
	End Sub

	Public Sub setRamp(ramp As String)
		xmlStep.<ramp>.Value = ramp
		listViewStep.SubItems(5).Text = ramp
	End Sub

	Public Function getIndex() As Integer
		Return xmlStep.@index
	End Function

	Public Function getName() As String
		Return xmlStep.<name>.Value
	End Function

	Public Function getDescription() As String
		Return xmlStep.<description>.Value
	End Function

	Public Function getTime() As Integer
		Return xmlStep.<time>.Value
	End Function

	Public Function getTimeUnit() As String
		Return xmlStep.<time>.@unit
	End Function

	Public Function getRamp() As String
		Return xmlStep.<ramp>.Value
	End Function

	Public Function getValveCount() As Integer
		Return xmlStep.<valves>.<valve>.Count
	End Function

	Public Function getMFCCount() As Integer
		Return xmlStep.<MFCs>.<MFC>.Count
	End Function

	Public Sub addValve(index As String, action As String)
		Dim valve As XElement =
		  <valve index=<%= index %>>
			  <action><%= action %></action>
		  </valve>
		xmlStep.<valves>(0).Add(valve)
		listViewStep.SubItems(6).Text = getValveCount()
	End Sub

End Class
