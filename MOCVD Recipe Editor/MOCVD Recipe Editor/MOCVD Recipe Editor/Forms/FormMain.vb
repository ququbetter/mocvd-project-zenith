Public Class FormMain

	Private Sub Button_NewRecipe_Click(sender As System.Object, e As System.EventArgs) Handles Button_NewRecipe.Click
		FormRecipeEditor.Show()
		Me.Close()
	End Sub

	Private Sub Button_LoadRecipe_Click(sender As System.Object, e As System.EventArgs) Handles Button_LoadRecipe.Click
		Dim result = OpenFileDialog1.ShowDialog()
		FormRecipeEditor.Show()
		Me.Close()
	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

	End Sub

	Private Sub FormMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
	End Sub
End Class