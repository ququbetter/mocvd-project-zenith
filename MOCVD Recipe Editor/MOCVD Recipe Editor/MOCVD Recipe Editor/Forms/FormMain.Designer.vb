<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.Button_NewRecipe = New System.Windows.Forms.Button()
		Me.Button_LoadRecipe = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SuspendLayout()
		'
		'Button_NewRecipe
		'
		Me.Button_NewRecipe.Location = New System.Drawing.Point(12, 12)
		Me.Button_NewRecipe.Name = "Button_NewRecipe"
		Me.Button_NewRecipe.Size = New System.Drawing.Size(219, 50)
		Me.Button_NewRecipe.TabIndex = 0
		Me.Button_NewRecipe.Text = "New Recipe"
		Me.Button_NewRecipe.UseVisualStyleBackColor = True
		'
		'Button_LoadRecipe
		'
		Me.Button_LoadRecipe.Location = New System.Drawing.Point(12, 68)
		Me.Button_LoadRecipe.Name = "Button_LoadRecipe"
		Me.Button_LoadRecipe.Size = New System.Drawing.Size(219, 50)
		Me.Button_LoadRecipe.TabIndex = 1
		Me.Button_LoadRecipe.Text = "Load Recipe"
		Me.Button_LoadRecipe.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		Me.OpenFileDialog1.Filter = "Recipes|*.recipe"
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(243, 131)
		Me.Controls.Add(Me.Button_LoadRecipe)
		Me.Controls.Add(Me.Button_NewRecipe)
		Me.Name = "FormMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MOCVD Recipe Editor"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Button_NewRecipe As System.Windows.Forms.Button
	Friend WithEvents Button_LoadRecipe As System.Windows.Forms.Button
	Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
