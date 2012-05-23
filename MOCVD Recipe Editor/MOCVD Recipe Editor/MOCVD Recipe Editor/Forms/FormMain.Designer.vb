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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NumericUpDown_Time = New System.Windows.Forms.NumericUpDown()
		Me.Label_Time = New System.Windows.Forms.Label()
		Me.Label_Ramp = New System.Windows.Forms.Label()
		Me.ComboBox_TimeUnits = New System.Windows.Forms.ComboBox()
		Me.Button_AddStep = New System.Windows.Forms.Button()
		Me.GroupBoxValves = New System.Windows.Forms.GroupBox()
		Me.ListView_ValveList = New System.Windows.Forms.ListView()
		Me.ColumnHeaderValve = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeaderAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ContextMenuStrip_ValveList = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.SetToOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SetToCloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RemoveItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button_AddValve = New System.Windows.Forms.Button()
		Me.RadioButton_ValveClose = New System.Windows.Forms.RadioButton()
		Me.RadioButton_ValveOpen = New System.Windows.Forms.RadioButton()
		Me.LabelValveIndex = New System.Windows.Forms.Label()
		Me.NumericUpDownValveIndex = New System.Windows.Forms.NumericUpDown()
		Me.GroupBoxTiming = New System.Windows.Forms.GroupBox()
		Me.ComboBox_Ramp = New System.Windows.Forms.ComboBox()
		Me.ListView_Steps = New System.Windows.Forms.ListView()
		Me.ColumnHeader_StepIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepTimeUnits = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepRamp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepValves = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_StepMFCs = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox_MFCs = New System.Windows.Forms.GroupBox()
		Me.ListView_MFCsList = New System.Windows.Forms.ListView()
		Me.ColumnHeader_MFC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_SetPoint = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Button_MFCs = New System.Windows.Forms.Button()
		Me.Label_MFCsSetPoint = New System.Windows.Forms.Label()
		Me.NumericUpDown_MFCsSetPoint = New System.Windows.Forms.NumericUpDown()
		Me.Label_MFCsIndex = New System.Windows.Forms.Label()
		Me.NumericUpDown_MFCsIndex = New System.Windows.Forms.NumericUpDown()
		Me.TextBox_StepName = New System.Windows.Forms.TextBox()
		Me.Label_StepName = New System.Windows.Forms.Label()
		Me.Label_StepDescription = New System.Windows.Forms.Label()
		Me.TextBox_StepDescription = New System.Windows.Forms.TextBox()
		Me.ListView_Routines = New System.Windows.Forms.ListView()
		Me.ColumnHeader_RoutineIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader_RoutineSteps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Button_AddRoutine = New System.Windows.Forms.Button()
		Me.GroupBox_StepDetails = New System.Windows.Forms.GroupBox()
		Me.Button_StepIndexDown = New System.Windows.Forms.Button()
		Me.Button_StepIndexUp = New System.Windows.Forms.Button()
		Me.GroupBox_RoutineDetails = New System.Windows.Forms.GroupBox()
		Me.TextBox_RoutineDescription = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox_RoutineName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button_ShowSteps = New System.Windows.Forms.Button()
		Me.ButtonLoadRoutine = New System.Windows.Forms.Button()
		Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintPreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.IndexToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
		Me.SaveToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
		Me.PrintToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.PrintPreviewToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.UndoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.RedoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
		Me.CutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
		Me.SelectAllToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.CustomizeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.OptionsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContentsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.IndexToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SearchToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
		Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.TextBox_RoutineSelectedIndex = New System.Windows.Forms.TextBox()
		Me.TextBox_StepSelectedIndex = New System.Windows.Forms.TextBox()
		Me.Button_RoutineIndexUp = New System.Windows.Forms.Button()
		Me.Button_RoutineIndexDown = New System.Windows.Forms.Button()
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxValves.SuspendLayout()
		Me.ContextMenuStrip_ValveList.SuspendLayout()
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxTiming.SuspendLayout()
		Me.GroupBox_MFCs.SuspendLayout()
		CType(Me.NumericUpDown_MFCsSetPoint, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_MFCsIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox_StepDetails.SuspendLayout()
		Me.GroupBox_RoutineDetails.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.NewToolStripMenuItem.Text = "&New"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
		Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.OpenToolStripMenuItem.Text = "&Open"
		'
		'toolStripSeparator
		'
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
		Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveToolStripMenuItem.Text = "&Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.SaveAsToolStripMenuItem.Text = "Save &As"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
		'
		'PrintToolStripMenuItem
		'
		Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
		Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintToolStripMenuItem.Text = "&Print"
		'
		'PrintPreviewToolStripMenuItem
		'
		Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
		Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
		Me.EditToolStripMenuItem.Text = "&Edit"
		'
		'UndoToolStripMenuItem
		'
		Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
		Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.UndoToolStripMenuItem.Text = "&Undo"
		'
		'RedoToolStripMenuItem
		'
		Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
		Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.RedoToolStripMenuItem.Text = "&Redo"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
		'
		'CutToolStripMenuItem
		'
		Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
		Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CutToolStripMenuItem.Text = "Cu&t"
		'
		'CopyToolStripMenuItem
		'
		Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
		Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.CopyToolStripMenuItem.Text = "&Copy"
		'
		'PasteToolStripMenuItem
		'
		Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
		Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
		Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.PasteToolStripMenuItem.Text = "&Paste"
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
		'
		'SelectAllToolStripMenuItem
		'
		Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
		Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
		Me.SelectAllToolStripMenuItem.Text = "Select &All"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem
		'
		Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
		Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.CustomizeToolStripMenuItem.Text = "&Customize"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
		Me.OptionsToolStripMenuItem.Text = "&Options"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'ContentsToolStripMenuItem
		'
		Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
		Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.ContentsToolStripMenuItem.Text = "&Contents"
		'
		'IndexToolStripMenuItem
		'
		Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
		Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.IndexToolStripMenuItem.Text = "&Index"
		'
		'SearchToolStripMenuItem
		'
		Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
		Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.SearchToolStripMenuItem.Text = "&Search"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.AboutToolStripMenuItem.Text = "&About..."
		'
		'NumericUpDown_Time
		'
		Me.NumericUpDown_Time.DecimalPlaces = 2
		Me.NumericUpDown_Time.Location = New System.Drawing.Point(54, 19)
		Me.NumericUpDown_Time.Name = "NumericUpDown_Time"
		Me.NumericUpDown_Time.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Time.TabIndex = 3
		'
		'Label_Time
		'
		Me.Label_Time.AutoSize = True
		Me.Label_Time.Location = New System.Drawing.Point(19, 21)
		Me.Label_Time.Name = "Label_Time"
		Me.Label_Time.Size = New System.Drawing.Size(33, 13)
		Me.Label_Time.TabIndex = 4
		Me.Label_Time.Text = "Time:"
		'
		'Label_Ramp
		'
		Me.Label_Ramp.AutoSize = True
		Me.Label_Ramp.Location = New System.Drawing.Point(14, 47)
		Me.Label_Ramp.Name = "Label_Ramp"
		Me.Label_Ramp.Size = New System.Drawing.Size(38, 13)
		Me.Label_Ramp.TabIndex = 5
		Me.Label_Ramp.Text = "Ramp:"
		'
		'ComboBox_TimeUnits
		'
		Me.ComboBox_TimeUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_TimeUnits.FormattingEnabled = True
		Me.ComboBox_TimeUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_TimeUnits.Location = New System.Drawing.Point(141, 19)
		Me.ComboBox_TimeUnits.MaxLength = 3
		Me.ComboBox_TimeUnits.Name = "ComboBox_TimeUnits"
		Me.ComboBox_TimeUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_TimeUnits.TabIndex = 9
		'
		'Button_AddStep
		'
		Me.Button_AddStep.Location = New System.Drawing.Point(343, 387)
		Me.Button_AddStep.Name = "Button_AddStep"
		Me.Button_AddStep.Size = New System.Drawing.Size(192, 30)
		Me.Button_AddStep.TabIndex = 12
		Me.Button_AddStep.Text = "Add Step"
		Me.Button_AddStep.UseVisualStyleBackColor = True
		'
		'GroupBoxValves
		'
		Me.GroupBoxValves.Controls.Add(Me.ListView_ValveList)
		Me.GroupBoxValves.Controls.Add(Me.Button_AddValve)
		Me.GroupBoxValves.Controls.Add(Me.RadioButton_ValveClose)
		Me.GroupBoxValves.Controls.Add(Me.RadioButton_ValveOpen)
		Me.GroupBoxValves.Controls.Add(Me.LabelValveIndex)
		Me.GroupBoxValves.Controls.Add(Me.NumericUpDownValveIndex)
		Me.GroupBoxValves.Location = New System.Drawing.Point(835, 27)
		Me.GroupBoxValves.Name = "GroupBoxValves"
		Me.GroupBoxValves.Size = New System.Drawing.Size(141, 202)
		Me.GroupBoxValves.TabIndex = 13
		Me.GroupBoxValves.TabStop = False
		Me.GroupBoxValves.Text = "Valves"
		'
		'ListView_ValveList
		'
		Me.ListView_ValveList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderValve, Me.ColumnHeaderAction})
		Me.ListView_ValveList.ContextMenuStrip = Me.ContextMenuStrip_ValveList
		Me.ListView_ValveList.FullRowSelect = True
		Me.ListView_ValveList.Location = New System.Drawing.Point(6, 96)
		Me.ListView_ValveList.Name = "ListView_ValveList"
		Me.ListView_ValveList.Size = New System.Drawing.Size(127, 100)
		Me.ListView_ValveList.TabIndex = 15
		Me.ListView_ValveList.UseCompatibleStateImageBehavior = False
		Me.ListView_ValveList.View = System.Windows.Forms.View.Details
		'
		'ColumnHeaderValve
		'
		Me.ColumnHeaderValve.Text = "Valve"
		Me.ColumnHeaderValve.Width = 42
		'
		'ColumnHeaderAction
		'
		Me.ColumnHeaderAction.Text = "Action"
		Me.ColumnHeaderAction.Width = 43
		'
		'ContextMenuStrip_ValveList
		'
		Me.ContextMenuStrip_ValveList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetToOpenToolStripMenuItem, Me.SetToCloseToolStripMenuItem, Me.RemoveItemsToolStripMenuItem})
		Me.ContextMenuStrip_ValveList.Name = "ContextMenuStrip_ValveList"
		Me.ContextMenuStrip_ValveList.Size = New System.Drawing.Size(158, 70)
		'
		'SetToOpenToolStripMenuItem
		'
		Me.SetToOpenToolStripMenuItem.Name = "SetToOpenToolStripMenuItem"
		Me.SetToOpenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.SetToOpenToolStripMenuItem.Text = "Set to 'Open'"
		'
		'SetToCloseToolStripMenuItem
		'
		Me.SetToCloseToolStripMenuItem.Name = "SetToCloseToolStripMenuItem"
		Me.SetToCloseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.SetToCloseToolStripMenuItem.Text = "Set to 'Close'"
		'
		'RemoveItemsToolStripMenuItem
		'
		Me.RemoveItemsToolStripMenuItem.Name = "RemoveItemsToolStripMenuItem"
		Me.RemoveItemsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
		Me.RemoveItemsToolStripMenuItem.Text = "Remove Item(s)"
		'
		'Button_AddValve
		'
		Me.Button_AddValve.Location = New System.Drawing.Point(6, 67)
		Me.Button_AddValve.Name = "Button_AddValve"
		Me.Button_AddValve.Size = New System.Drawing.Size(127, 23)
		Me.Button_AddValve.TabIndex = 16
		Me.Button_AddValve.Text = "Add Valve"
		Me.Button_AddValve.UseVisualStyleBackColor = True
		'
		'RadioButton_ValveClose
		'
		Me.RadioButton_ValveClose.AutoSize = True
		Me.RadioButton_ValveClose.Checked = True
		Me.RadioButton_ValveClose.Location = New System.Drawing.Point(82, 42)
		Me.RadioButton_ValveClose.Name = "RadioButton_ValveClose"
		Me.RadioButton_ValveClose.Size = New System.Drawing.Size(51, 17)
		Me.RadioButton_ValveClose.TabIndex = 18
		Me.RadioButton_ValveClose.TabStop = True
		Me.RadioButton_ValveClose.Text = "Close"
		Me.RadioButton_ValveClose.UseVisualStyleBackColor = True
		'
		'RadioButton_ValveOpen
		'
		Me.RadioButton_ValveOpen.AutoSize = True
		Me.RadioButton_ValveOpen.Location = New System.Drawing.Point(82, 19)
		Me.RadioButton_ValveOpen.Name = "RadioButton_ValveOpen"
		Me.RadioButton_ValveOpen.Size = New System.Drawing.Size(51, 17)
		Me.RadioButton_ValveOpen.TabIndex = 17
		Me.RadioButton_ValveOpen.Text = "Open"
		Me.RadioButton_ValveOpen.UseVisualStyleBackColor = True
		'
		'LabelValveIndex
		'
		Me.LabelValveIndex.AutoSize = True
		Me.LabelValveIndex.Location = New System.Drawing.Point(16, 23)
		Me.LabelValveIndex.Name = "LabelValveIndex"
		Me.LabelValveIndex.Size = New System.Drawing.Size(36, 13)
		Me.LabelValveIndex.TabIndex = 17
		Me.LabelValveIndex.Text = "Index:"
		'
		'NumericUpDownValveIndex
		'
		Me.NumericUpDownValveIndex.Location = New System.Drawing.Point(19, 39)
		Me.NumericUpDownValveIndex.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.NumericUpDownValveIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumericUpDownValveIndex.Name = "NumericUpDownValveIndex"
		Me.NumericUpDownValveIndex.Size = New System.Drawing.Size(48, 20)
		Me.NumericUpDownValveIndex.TabIndex = 16
		Me.NumericUpDownValveIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'GroupBoxTiming
		'
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_Ramp)
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_TimeUnits)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Ramp)
		Me.GroupBoxTiming.Location = New System.Drawing.Point(343, 280)
		Me.GroupBoxTiming.Name = "GroupBoxTiming"
		Me.GroupBoxTiming.Size = New System.Drawing.Size(192, 101)
		Me.GroupBoxTiming.TabIndex = 14
		Me.GroupBoxTiming.TabStop = False
		Me.GroupBoxTiming.Text = "Timing"
		'
		'ComboBox_Ramp
		'
		Me.ComboBox_Ramp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_Ramp.FormattingEnabled = True
		Me.ComboBox_Ramp.Items.AddRange(New Object() {"none", "linear", "exponential"})
		Me.ComboBox_Ramp.Location = New System.Drawing.Point(54, 44)
		Me.ComboBox_Ramp.Name = "ComboBox_Ramp"
		Me.ComboBox_Ramp.Size = New System.Drawing.Size(129, 21)
		Me.ComboBox_Ramp.TabIndex = 10
		'
		'ListView_Steps
		'
		Me.ListView_Steps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_StepIndex, Me.ColumnHeader_StepName, Me.ColumnHeader_StepDescription, Me.ColumnHeader_StepTime, Me.ColumnHeader_StepTimeUnits, Me.ColumnHeader_StepRamp, Me.ColumnHeader_StepValves, Me.ColumnHeader_StepMFCs})
		Me.ListView_Steps.FullRowSelect = True
		Me.ListView_Steps.HideSelection = False
		Me.ListView_Steps.Location = New System.Drawing.Point(343, 27)
		Me.ListView_Steps.MultiSelect = False
		Me.ListView_Steps.Name = "ListView_Steps"
		Me.ListView_Steps.Size = New System.Drawing.Size(486, 247)
		Me.ListView_Steps.TabIndex = 15
		Me.ListView_Steps.UseCompatibleStateImageBehavior = False
		Me.ListView_Steps.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_StepIndex
		'
		Me.ColumnHeader_StepIndex.Text = "Step"
		Me.ColumnHeader_StepIndex.Width = 36
		'
		'ColumnHeader_StepName
		'
		Me.ColumnHeader_StepName.Text = "Name"
		Me.ColumnHeader_StepName.Width = 52
		'
		'ColumnHeader_StepDescription
		'
		Me.ColumnHeader_StepDescription.Text = "Description"
		Me.ColumnHeader_StepDescription.Width = 66
		'
		'ColumnHeader_StepTime
		'
		Me.ColumnHeader_StepTime.Text = "Time"
		Me.ColumnHeader_StepTime.Width = 50
		'
		'ColumnHeader_StepTimeUnits
		'
		Me.ColumnHeader_StepTimeUnits.Text = "Units"
		Me.ColumnHeader_StepTimeUnits.Width = 45
		'
		'ColumnHeader_StepRamp
		'
		Me.ColumnHeader_StepRamp.Text = "Ramp"
		Me.ColumnHeader_StepRamp.Width = 71
		'
		'ColumnHeader_StepValves
		'
		Me.ColumnHeader_StepValves.Text = "Valves"
		Me.ColumnHeader_StepValves.Width = 45
		'
		'ColumnHeader_StepMFCs
		'
		Me.ColumnHeader_StepMFCs.Text = "MFCs"
		Me.ColumnHeader_StepMFCs.Width = 43
		'
		'GroupBox_MFCs
		'
		Me.GroupBox_MFCs.Controls.Add(Me.ListView_MFCsList)
		Me.GroupBox_MFCs.Controls.Add(Me.Button_MFCs)
		Me.GroupBox_MFCs.Controls.Add(Me.Label_MFCsSetPoint)
		Me.GroupBox_MFCs.Controls.Add(Me.NumericUpDown_MFCsSetPoint)
		Me.GroupBox_MFCs.Controls.Add(Me.Label_MFCsIndex)
		Me.GroupBox_MFCs.Controls.Add(Me.NumericUpDown_MFCsIndex)
		Me.GroupBox_MFCs.Location = New System.Drawing.Point(982, 27)
		Me.GroupBox_MFCs.Name = "GroupBox_MFCs"
		Me.GroupBox_MFCs.Size = New System.Drawing.Size(141, 202)
		Me.GroupBox_MFCs.TabIndex = 16
		Me.GroupBox_MFCs.TabStop = False
		Me.GroupBox_MFCs.Text = "MFCs"
		'
		'ListView_MFCsList
		'
		Me.ListView_MFCsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_MFC, Me.ColumnHeader_SetPoint})
		Me.ListView_MFCsList.ContextMenuStrip = Me.ContextMenuStrip_ValveList
		Me.ListView_MFCsList.FullRowSelect = True
		Me.ListView_MFCsList.Location = New System.Drawing.Point(6, 96)
		Me.ListView_MFCsList.Name = "ListView_MFCsList"
		Me.ListView_MFCsList.Size = New System.Drawing.Size(127, 100)
		Me.ListView_MFCsList.TabIndex = 17
		Me.ListView_MFCsList.UseCompatibleStateImageBehavior = False
		Me.ListView_MFCsList.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_MFC
		'
		Me.ColumnHeader_MFC.Text = "MFC"
		Me.ColumnHeader_MFC.Width = 42
		'
		'ColumnHeader_SetPoint
		'
		Me.ColumnHeader_SetPoint.Text = "SetPoint"
		Me.ColumnHeader_SetPoint.Width = 52
		'
		'Button_MFCs
		'
		Me.Button_MFCs.Location = New System.Drawing.Point(6, 67)
		Me.Button_MFCs.Name = "Button_MFCs"
		Me.Button_MFCs.Size = New System.Drawing.Size(127, 23)
		Me.Button_MFCs.TabIndex = 17
		Me.Button_MFCs.Text = "Add MFC"
		Me.Button_MFCs.UseVisualStyleBackColor = True
		'
		'Label_MFCsSetPoint
		'
		Me.Label_MFCsSetPoint.AutoSize = True
		Me.Label_MFCsSetPoint.Location = New System.Drawing.Point(61, 23)
		Me.Label_MFCsSetPoint.Name = "Label_MFCsSetPoint"
		Me.Label_MFCsSetPoint.Size = New System.Drawing.Size(50, 13)
		Me.Label_MFCsSetPoint.TabIndex = 20
		Me.Label_MFCsSetPoint.Text = "SetPoint:"
		'
		'NumericUpDown_MFCsSetPoint
		'
		Me.NumericUpDown_MFCsSetPoint.Location = New System.Drawing.Point(64, 39)
		Me.NumericUpDown_MFCsSetPoint.Name = "NumericUpDown_MFCsSetPoint"
		Me.NumericUpDown_MFCsSetPoint.Size = New System.Drawing.Size(65, 20)
		Me.NumericUpDown_MFCsSetPoint.TabIndex = 17
		'
		'Label_MFCsIndex
		'
		Me.Label_MFCsIndex.AutoSize = True
		Me.Label_MFCsIndex.Location = New System.Drawing.Point(7, 23)
		Me.Label_MFCsIndex.Name = "Label_MFCsIndex"
		Me.Label_MFCsIndex.Size = New System.Drawing.Size(36, 13)
		Me.Label_MFCsIndex.TabIndex = 19
		Me.Label_MFCsIndex.Text = "Index:"
		'
		'NumericUpDown_MFCsIndex
		'
		Me.NumericUpDown_MFCsIndex.Location = New System.Drawing.Point(10, 39)
		Me.NumericUpDown_MFCsIndex.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.NumericUpDown_MFCsIndex.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NumericUpDown_MFCsIndex.Name = "NumericUpDown_MFCsIndex"
		Me.NumericUpDown_MFCsIndex.Size = New System.Drawing.Size(48, 20)
		Me.NumericUpDown_MFCsIndex.TabIndex = 18
		Me.NumericUpDown_MFCsIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'TextBox_StepName
		'
		Me.TextBox_StepName.Location = New System.Drawing.Point(78, 19)
		Me.TextBox_StepName.Name = "TextBox_StepName"
		Me.TextBox_StepName.Size = New System.Drawing.Size(204, 20)
		Me.TextBox_StepName.TabIndex = 17
		'
		'Label_StepName
		'
		Me.Label_StepName.AutoSize = True
		Me.Label_StepName.Location = New System.Drawing.Point(9, 22)
		Me.Label_StepName.Name = "Label_StepName"
		Me.Label_StepName.Size = New System.Drawing.Size(63, 13)
		Me.Label_StepName.TabIndex = 19
		Me.Label_StepName.Text = "Step Name:"
		'
		'Label_StepDescription
		'
		Me.Label_StepDescription.AutoSize = True
		Me.Label_StepDescription.Location = New System.Drawing.Point(9, 49)
		Me.Label_StepDescription.Name = "Label_StepDescription"
		Me.Label_StepDescription.Size = New System.Drawing.Size(63, 13)
		Me.Label_StepDescription.TabIndex = 20
		Me.Label_StepDescription.Text = "Description:"
		'
		'TextBox_StepDescription
		'
		Me.TextBox_StepDescription.AcceptsReturn = True
		Me.TextBox_StepDescription.AcceptsTab = True
		Me.TextBox_StepDescription.Location = New System.Drawing.Point(78, 46)
		Me.TextBox_StepDescription.Multiline = True
		Me.TextBox_StepDescription.Name = "TextBox_StepDescription"
		Me.TextBox_StepDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox_StepDescription.Size = New System.Drawing.Size(204, 85)
		Me.TextBox_StepDescription.TabIndex = 21
		'
		'ListView_Routines
		'
		Me.ListView_Routines.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_RoutineIndex, Me.ColumnHeader_RoutineName, Me.ColumnHeader_RoutineDescription, Me.ColumnHeader_RoutineSteps})
		Me.ListView_Routines.FullRowSelect = True
		Me.ListView_Routines.HideSelection = False
		Me.ListView_Routines.Location = New System.Drawing.Point(12, 27)
		Me.ListView_Routines.MultiSelect = False
		Me.ListView_Routines.Name = "ListView_Routines"
		Me.ListView_Routines.Size = New System.Drawing.Size(288, 174)
		Me.ListView_Routines.TabIndex = 22
		Me.ListView_Routines.UseCompatibleStateImageBehavior = False
		Me.ListView_Routines.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader_RoutineIndex
		'
		Me.ColumnHeader_RoutineIndex.Text = "Routine"
		'
		'ColumnHeader_RoutineName
		'
		Me.ColumnHeader_RoutineName.Text = "Name"
		'
		'ColumnHeader_RoutineDescription
		'
		Me.ColumnHeader_RoutineDescription.Text = "Description"
		Me.ColumnHeader_RoutineDescription.Width = 69
		'
		'ColumnHeader_RoutineSteps
		'
		Me.ColumnHeader_RoutineSteps.Text = "Steps"
		'
		'Button_AddRoutine
		'
		Me.Button_AddRoutine.Location = New System.Drawing.Point(158, 387)
		Me.Button_AddRoutine.Name = "Button_AddRoutine"
		Me.Button_AddRoutine.Size = New System.Drawing.Size(142, 30)
		Me.Button_AddRoutine.TabIndex = 23
		Me.Button_AddRoutine.Text = "Add Routine"
		Me.Button_AddRoutine.UseVisualStyleBackColor = True
		'
		'GroupBox_StepDetails
		'
		Me.GroupBox_StepDetails.Controls.Add(Me.TextBox_StepSelectedIndex)
		Me.GroupBox_StepDetails.Controls.Add(Me.Button_StepIndexDown)
		Me.GroupBox_StepDetails.Controls.Add(Me.Label_StepName)
		Me.GroupBox_StepDetails.Controls.Add(Me.TextBox_StepName)
		Me.GroupBox_StepDetails.Controls.Add(Me.Label_StepDescription)
		Me.GroupBox_StepDetails.Controls.Add(Me.TextBox_StepDescription)
		Me.GroupBox_StepDetails.Controls.Add(Me.Button_StepIndexUp)
		Me.GroupBox_StepDetails.Location = New System.Drawing.Point(541, 280)
		Me.GroupBox_StepDetails.Name = "GroupBox_StepDetails"
		Me.GroupBox_StepDetails.Size = New System.Drawing.Size(288, 137)
		Me.GroupBox_StepDetails.TabIndex = 24
		Me.GroupBox_StepDetails.TabStop = False
		Me.GroupBox_StepDetails.Text = "Step Details"
		'
		'Button_StepIndexDown
		'
		Me.Button_StepIndexDown.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.DownArrow
		Me.Button_StepIndexDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_StepIndexDown.Location = New System.Drawing.Point(6, 107)
		Me.Button_StepIndexDown.Name = "Button_StepIndexDown"
		Me.Button_StepIndexDown.Size = New System.Drawing.Size(25, 25)
		Me.Button_StepIndexDown.TabIndex = 30
		Me.Button_StepIndexDown.UseVisualStyleBackColor = True
		'
		'Button_StepIndexUp
		'
		Me.Button_StepIndexUp.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.UpArrow
		Me.Button_StepIndexUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_StepIndexUp.Location = New System.Drawing.Point(6, 76)
		Me.Button_StepIndexUp.Name = "Button_StepIndexUp"
		Me.Button_StepIndexUp.Size = New System.Drawing.Size(25, 25)
		Me.Button_StepIndexUp.TabIndex = 30
		Me.Button_StepIndexUp.UseVisualStyleBackColor = True
		'
		'GroupBox_RoutineDetails
		'
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Button_RoutineIndexDown)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Button_RoutineIndexUp)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.TextBox_RoutineSelectedIndex)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.TextBox_RoutineDescription)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Label2)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.TextBox_RoutineName)
		Me.GroupBox_RoutineDetails.Controls.Add(Me.Label1)
		Me.GroupBox_RoutineDetails.Location = New System.Drawing.Point(12, 207)
		Me.GroupBox_RoutineDetails.Name = "GroupBox_RoutineDetails"
		Me.GroupBox_RoutineDetails.Size = New System.Drawing.Size(288, 174)
		Me.GroupBox_RoutineDetails.TabIndex = 25
		Me.GroupBox_RoutineDetails.TabStop = False
		Me.GroupBox_RoutineDetails.Text = "Routine Details"
		'
		'TextBox_RoutineDescription
		'
		Me.TextBox_RoutineDescription.AcceptsReturn = True
		Me.TextBox_RoutineDescription.AcceptsTab = True
		Me.TextBox_RoutineDescription.Location = New System.Drawing.Point(90, 48)
		Me.TextBox_RoutineDescription.Multiline = True
		Me.TextBox_RoutineDescription.Name = "TextBox_RoutineDescription"
		Me.TextBox_RoutineDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox_RoutineDescription.Size = New System.Drawing.Size(192, 120)
		Me.TextBox_RoutineDescription.TabIndex = 27
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 51)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 13)
		Me.Label2.TabIndex = 26
		Me.Label2.Text = "Description:"
		'
		'TextBox_RoutineName
		'
		Me.TextBox_RoutineName.Location = New System.Drawing.Point(90, 22)
		Me.TextBox_RoutineName.Name = "TextBox_RoutineName"
		Me.TextBox_RoutineName.Size = New System.Drawing.Size(192, 20)
		Me.TextBox_RoutineName.TabIndex = 26
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 13)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Routine Name:"
		'
		'Button_ShowSteps
		'
		Me.Button_ShowSteps.Location = New System.Drawing.Point(306, 27)
		Me.Button_ShowSteps.Name = "Button_ShowSteps"
		Me.Button_ShowSteps.Size = New System.Drawing.Size(31, 390)
		Me.Button_ShowSteps.TabIndex = 27
		Me.Button_ShowSteps.Text = "-->"
		Me.Button_ShowSteps.UseVisualStyleBackColor = True
		'
		'ButtonLoadRoutine
		'
		Me.ButtonLoadRoutine.Location = New System.Drawing.Point(12, 387)
		Me.ButtonLoadRoutine.Name = "ButtonLoadRoutine"
		Me.ButtonLoadRoutine.Size = New System.Drawing.Size(142, 30)
		Me.ButtonLoadRoutine.TabIndex = 28
		Me.ButtonLoadRoutine.Text = "Insert Routine From File..."
		Me.ButtonLoadRoutine.UseVisualStyleBackColor = True
		'
		'FileToolStripMenuItem1
		'
		Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.OpenToolStripMenuItem1, Me.toolStripSeparator6, Me.SaveToolStripMenuItem1, Me.SaveAsToolStripMenuItem1, Me.toolStripSeparator7, Me.PrintToolStripMenuItem1, Me.PrintPreviewToolStripMenuItem1, Me.toolStripSeparator8, Me.ExitToolStripMenuItem1})
		Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
		Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem1.Text = "&File"
		'
		'NewToolStripMenuItem1
		'
		Me.NewToolStripMenuItem1.Image = CType(resources.GetObject("NewToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
		Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.NewToolStripMenuItem1.Text = "&New"
		'
		'OpenToolStripMenuItem1
		'
		Me.OpenToolStripMenuItem1.Image = CType(resources.GetObject("OpenToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.OpenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
		Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.OpenToolStripMenuItem1.Text = "&Open"
		'
		'toolStripSeparator6
		'
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		Me.toolStripSeparator6.Size = New System.Drawing.Size(140, 6)
		'
		'SaveToolStripMenuItem1
		'
		Me.SaveToolStripMenuItem1.Image = CType(resources.GetObject("SaveToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.SaveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
		Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.SaveToolStripMenuItem1.Text = "&Save"
		'
		'SaveAsToolStripMenuItem1
		'
		Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
		Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.SaveAsToolStripMenuItem1.Text = "Save &As"
		'
		'toolStripSeparator7
		'
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		Me.toolStripSeparator7.Size = New System.Drawing.Size(140, 6)
		'
		'PrintToolStripMenuItem1
		'
		Me.PrintToolStripMenuItem1.Image = CType(resources.GetObject("PrintToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.PrintToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
		Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.PrintToolStripMenuItem1.Text = "&Print"
		'
		'PrintPreviewToolStripMenuItem1
		'
		Me.PrintPreviewToolStripMenuItem1.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.PrintPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
		Me.PrintPreviewToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.PrintPreviewToolStripMenuItem1.Text = "Print Pre&view"
		'
		'toolStripSeparator8
		'
		Me.toolStripSeparator8.Name = "toolStripSeparator8"
		Me.toolStripSeparator8.Size = New System.Drawing.Size(140, 6)
		'
		'ExitToolStripMenuItem1
		'
		Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
		Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
		Me.ExitToolStripMenuItem1.Text = "E&xit"
		'
		'EditToolStripMenuItem1
		'
		Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem1, Me.RedoToolStripMenuItem1, Me.toolStripSeparator9, Me.CutToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.toolStripSeparator10, Me.SelectAllToolStripMenuItem1})
		Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
		Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
		Me.EditToolStripMenuItem1.Text = "&Edit"
		'
		'UndoToolStripMenuItem1
		'
		Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
		Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.UndoToolStripMenuItem1.Text = "&Undo"
		'
		'RedoToolStripMenuItem1
		'
		Me.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1"
		Me.RedoToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.RedoToolStripMenuItem1.Text = "&Redo"
		'
		'toolStripSeparator9
		'
		Me.toolStripSeparator9.Name = "toolStripSeparator9"
		Me.toolStripSeparator9.Size = New System.Drawing.Size(119, 6)
		'
		'CutToolStripMenuItem1
		'
		Me.CutToolStripMenuItem1.Image = CType(resources.GetObject("CutToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.CutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
		Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.CutToolStripMenuItem1.Text = "Cu&t"
		'
		'CopyToolStripMenuItem1
		'
		Me.CopyToolStripMenuItem1.Image = CType(resources.GetObject("CopyToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.CopyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
		Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.CopyToolStripMenuItem1.Text = "&Copy"
		'
		'PasteToolStripMenuItem1
		'
		Me.PasteToolStripMenuItem1.Image = CType(resources.GetObject("PasteToolStripMenuItem1.Image"), System.Drawing.Image)
		Me.PasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
		Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.PasteToolStripMenuItem1.Text = "&Paste"
		'
		'toolStripSeparator10
		'
		Me.toolStripSeparator10.Name = "toolStripSeparator10"
		Me.toolStripSeparator10.Size = New System.Drawing.Size(119, 6)
		'
		'SelectAllToolStripMenuItem1
		'
		Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
		Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.SelectAllToolStripMenuItem1.Text = "Select &All"
		'
		'ToolsToolStripMenuItem1
		'
		Me.ToolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem1, Me.OptionsToolStripMenuItem1})
		Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
		Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem1.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem1
		'
		Me.CustomizeToolStripMenuItem1.Name = "CustomizeToolStripMenuItem1"
		Me.CustomizeToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
		Me.CustomizeToolStripMenuItem1.Text = "&Customize"
		'
		'OptionsToolStripMenuItem1
		'
		Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
		Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
		Me.OptionsToolStripMenuItem1.Text = "&Options"
		'
		'HelpToolStripMenuItem1
		'
		Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem1, Me.IndexToolStripMenuItem1, Me.SearchToolStripMenuItem1, Me.toolStripSeparator11, Me.AboutToolStripMenuItem1})
		Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
		Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem1.Text = "&Help"
		'
		'ContentsToolStripMenuItem1
		'
		Me.ContentsToolStripMenuItem1.Name = "ContentsToolStripMenuItem1"
		Me.ContentsToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.ContentsToolStripMenuItem1.Text = "&Contents"
		'
		'IndexToolStripMenuItem1
		'
		Me.IndexToolStripMenuItem1.Name = "IndexToolStripMenuItem1"
		Me.IndexToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.IndexToolStripMenuItem1.Text = "&Index"
		'
		'SearchToolStripMenuItem1
		'
		Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
		Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.SearchToolStripMenuItem1.Text = "&Search"
		'
		'toolStripSeparator11
		'
		Me.toolStripSeparator11.Name = "toolStripSeparator11"
		Me.toolStripSeparator11.Size = New System.Drawing.Size(119, 6)
		'
		'AboutToolStripMenuItem1
		'
		Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
		Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
		Me.AboutToolStripMenuItem1.Text = "&About..."
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem2, Me.EditToolStripMenuItem2, Me.ToolsToolStripMenuItem2, Me.HelpToolStripMenuItem2})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
		Me.MenuStrip1.TabIndex = 30
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem2
		'
		Me.FileToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem2, Me.OpenToolStripMenuItem2, Me.toolStripSeparator12, Me.SaveToolStripMenuItem2, Me.SaveAsToolStripMenuItem2, Me.toolStripSeparator13, Me.PrintToolStripMenuItem2, Me.PrintPreviewToolStripMenuItem2, Me.toolStripSeparator14, Me.ExitToolStripMenuItem2})
		Me.FileToolStripMenuItem2.Name = "FileToolStripMenuItem2"
		Me.FileToolStripMenuItem2.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem2.Text = "&File"
		'
		'NewToolStripMenuItem2
		'
		Me.NewToolStripMenuItem2.Image = CType(resources.GetObject("NewToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.NewToolStripMenuItem2.Name = "NewToolStripMenuItem2"
		Me.NewToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.NewToolStripMenuItem2.Text = "&New"
		'
		'OpenToolStripMenuItem2
		'
		Me.OpenToolStripMenuItem2.Image = CType(resources.GetObject("OpenToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.OpenToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.OpenToolStripMenuItem2.Name = "OpenToolStripMenuItem2"
		Me.OpenToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.OpenToolStripMenuItem2.Text = "&Open"
		'
		'toolStripSeparator12
		'
		Me.toolStripSeparator12.Name = "toolStripSeparator12"
		Me.toolStripSeparator12.Size = New System.Drawing.Size(140, 6)
		'
		'SaveToolStripMenuItem2
		'
		Me.SaveToolStripMenuItem2.Image = CType(resources.GetObject("SaveToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.SaveToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SaveToolStripMenuItem2.Name = "SaveToolStripMenuItem2"
		Me.SaveToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.SaveToolStripMenuItem2.Text = "&Save"
		'
		'SaveAsToolStripMenuItem2
		'
		Me.SaveAsToolStripMenuItem2.Name = "SaveAsToolStripMenuItem2"
		Me.SaveAsToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.SaveAsToolStripMenuItem2.Text = "Save &As"
		'
		'toolStripSeparator13
		'
		Me.toolStripSeparator13.Name = "toolStripSeparator13"
		Me.toolStripSeparator13.Size = New System.Drawing.Size(140, 6)
		'
		'PrintToolStripMenuItem2
		'
		Me.PrintToolStripMenuItem2.Image = CType(resources.GetObject("PrintToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.PrintToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintToolStripMenuItem2.Name = "PrintToolStripMenuItem2"
		Me.PrintToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.PrintToolStripMenuItem2.Text = "&Print"
		'
		'PrintPreviewToolStripMenuItem2
		'
		Me.PrintPreviewToolStripMenuItem2.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.PrintPreviewToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PrintPreviewToolStripMenuItem2.Name = "PrintPreviewToolStripMenuItem2"
		Me.PrintPreviewToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.PrintPreviewToolStripMenuItem2.Text = "Print Pre&view"
		'
		'toolStripSeparator14
		'
		Me.toolStripSeparator14.Name = "toolStripSeparator14"
		Me.toolStripSeparator14.Size = New System.Drawing.Size(140, 6)
		'
		'ExitToolStripMenuItem2
		'
		Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
		Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
		Me.ExitToolStripMenuItem2.Text = "E&xit"
		'
		'EditToolStripMenuItem2
		'
		Me.EditToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem2, Me.RedoToolStripMenuItem2, Me.toolStripSeparator15, Me.CutToolStripMenuItem2, Me.CopyToolStripMenuItem2, Me.PasteToolStripMenuItem2, Me.toolStripSeparator16, Me.SelectAllToolStripMenuItem2})
		Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
		Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(39, 20)
		Me.EditToolStripMenuItem2.Text = "&Edit"
		'
		'UndoToolStripMenuItem2
		'
		Me.UndoToolStripMenuItem2.Name = "UndoToolStripMenuItem2"
		Me.UndoToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.UndoToolStripMenuItem2.Text = "&Undo"
		'
		'RedoToolStripMenuItem2
		'
		Me.RedoToolStripMenuItem2.Name = "RedoToolStripMenuItem2"
		Me.RedoToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.RedoToolStripMenuItem2.Text = "&Redo"
		'
		'toolStripSeparator15
		'
		Me.toolStripSeparator15.Name = "toolStripSeparator15"
		Me.toolStripSeparator15.Size = New System.Drawing.Size(119, 6)
		'
		'CutToolStripMenuItem2
		'
		Me.CutToolStripMenuItem2.Image = CType(resources.GetObject("CutToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.CutToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CutToolStripMenuItem2.Name = "CutToolStripMenuItem2"
		Me.CutToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.CutToolStripMenuItem2.Text = "Cu&t"
		'
		'CopyToolStripMenuItem2
		'
		Me.CopyToolStripMenuItem2.Image = CType(resources.GetObject("CopyToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.CopyToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.CopyToolStripMenuItem2.Name = "CopyToolStripMenuItem2"
		Me.CopyToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.CopyToolStripMenuItem2.Text = "&Copy"
		'
		'PasteToolStripMenuItem2
		'
		Me.PasteToolStripMenuItem2.Image = CType(resources.GetObject("PasteToolStripMenuItem2.Image"), System.Drawing.Image)
		Me.PasteToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.PasteToolStripMenuItem2.Name = "PasteToolStripMenuItem2"
		Me.PasteToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.PasteToolStripMenuItem2.Text = "&Paste"
		'
		'toolStripSeparator16
		'
		Me.toolStripSeparator16.Name = "toolStripSeparator16"
		Me.toolStripSeparator16.Size = New System.Drawing.Size(119, 6)
		'
		'SelectAllToolStripMenuItem2
		'
		Me.SelectAllToolStripMenuItem2.Name = "SelectAllToolStripMenuItem2"
		Me.SelectAllToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.SelectAllToolStripMenuItem2.Text = "Select &All"
		'
		'ToolsToolStripMenuItem2
		'
		Me.ToolsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem2, Me.OptionsToolStripMenuItem2})
		Me.ToolsToolStripMenuItem2.Name = "ToolsToolStripMenuItem2"
		Me.ToolsToolStripMenuItem2.Size = New System.Drawing.Size(48, 20)
		Me.ToolsToolStripMenuItem2.Text = "&Tools"
		'
		'CustomizeToolStripMenuItem2
		'
		Me.CustomizeToolStripMenuItem2.Name = "CustomizeToolStripMenuItem2"
		Me.CustomizeToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
		Me.CustomizeToolStripMenuItem2.Text = "&Customize"
		'
		'OptionsToolStripMenuItem2
		'
		Me.OptionsToolStripMenuItem2.Name = "OptionsToolStripMenuItem2"
		Me.OptionsToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
		Me.OptionsToolStripMenuItem2.Text = "&Options"
		'
		'HelpToolStripMenuItem2
		'
		Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem2, Me.IndexToolStripMenuItem2, Me.SearchToolStripMenuItem2, Me.toolStripSeparator17, Me.AboutToolStripMenuItem2})
		Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
		Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem2.Text = "&Help"
		'
		'ContentsToolStripMenuItem2
		'
		Me.ContentsToolStripMenuItem2.Name = "ContentsToolStripMenuItem2"
		Me.ContentsToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.ContentsToolStripMenuItem2.Text = "&Contents"
		'
		'IndexToolStripMenuItem2
		'
		Me.IndexToolStripMenuItem2.Name = "IndexToolStripMenuItem2"
		Me.IndexToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.IndexToolStripMenuItem2.Text = "&Index"
		'
		'SearchToolStripMenuItem2
		'
		Me.SearchToolStripMenuItem2.Name = "SearchToolStripMenuItem2"
		Me.SearchToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.SearchToolStripMenuItem2.Text = "&Search"
		'
		'toolStripSeparator17
		'
		Me.toolStripSeparator17.Name = "toolStripSeparator17"
		Me.toolStripSeparator17.Size = New System.Drawing.Size(119, 6)
		'
		'AboutToolStripMenuItem2
		'
		Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
		Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(122, 22)
		Me.AboutToolStripMenuItem2.Text = "&About..."
		'
		'TextBox_RoutineSelectedIndex
		'
		Me.TextBox_RoutineSelectedIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox_RoutineSelectedIndex.Location = New System.Drawing.Point(37, 77)
		Me.TextBox_RoutineSelectedIndex.Name = "TextBox_RoutineSelectedIndex"
		Me.TextBox_RoutineSelectedIndex.Size = New System.Drawing.Size(45, 38)
		Me.TextBox_RoutineSelectedIndex.TabIndex = 28
		Me.TextBox_RoutineSelectedIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBox_StepSelectedIndex
		'
		Me.TextBox_StepSelectedIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox_StepSelectedIndex.Location = New System.Drawing.Point(37, 76)
		Me.TextBox_StepSelectedIndex.Name = "TextBox_StepSelectedIndex"
		Me.TextBox_StepSelectedIndex.Size = New System.Drawing.Size(35, 38)
		Me.TextBox_StepSelectedIndex.TabIndex = 31
		Me.TextBox_StepSelectedIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Button_RoutineIndexUp
		'
		Me.Button_RoutineIndexUp.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.UpArrow
		Me.Button_RoutineIndexUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_RoutineIndexUp.Location = New System.Drawing.Point(6, 73)
		Me.Button_RoutineIndexUp.Name = "Button_RoutineIndexUp"
		Me.Button_RoutineIndexUp.Size = New System.Drawing.Size(25, 25)
		Me.Button_RoutineIndexUp.TabIndex = 31
		Me.Button_RoutineIndexUp.UseVisualStyleBackColor = True
		'
		'Button_RoutineIndexDown
		'
		Me.Button_RoutineIndexDown.BackgroundImage = Global.MOCVD_Recipe_Editor.My.Resources.Resources.DownArrow
		Me.Button_RoutineIndexDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Button_RoutineIndexDown.Location = New System.Drawing.Point(6, 104)
		Me.Button_RoutineIndexDown.Name = "Button_RoutineIndexDown"
		Me.Button_RoutineIndexDown.Size = New System.Drawing.Size(25, 25)
		Me.Button_RoutineIndexDown.TabIndex = 32
		Me.Button_RoutineIndexDown.UseVisualStyleBackColor = True
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1134, 424)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.ButtonLoadRoutine)
		Me.Controls.Add(Me.Button_ShowSteps)
		Me.Controls.Add(Me.GroupBox_RoutineDetails)
		Me.Controls.Add(Me.GroupBox_StepDetails)
		Me.Controls.Add(Me.Button_AddRoutine)
		Me.Controls.Add(Me.ListView_Routines)
		Me.Controls.Add(Me.GroupBox_MFCs)
		Me.Controls.Add(Me.ListView_Steps)
		Me.Controls.Add(Me.GroupBoxTiming)
		Me.Controls.Add(Me.GroupBoxValves)
		Me.Controls.Add(Me.Button_AddStep)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.Name = "FormMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "MOCVD Recipe Editor"
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxValves.ResumeLayout(False)
		Me.GroupBoxValves.PerformLayout()
		Me.ContextMenuStrip_ValveList.ResumeLayout(False)
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxTiming.ResumeLayout(False)
		Me.GroupBoxTiming.PerformLayout()
		Me.GroupBox_MFCs.ResumeLayout(False)
		Me.GroupBox_MFCs.PerformLayout()
		CType(Me.NumericUpDown_MFCsSetPoint, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_MFCsIndex, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox_StepDetails.ResumeLayout(False)
		Me.GroupBox_StepDetails.PerformLayout()
		Me.GroupBox_RoutineDetails.ResumeLayout(False)
		Me.GroupBox_RoutineDetails.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NumericUpDown_Time As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label_Time As System.Windows.Forms.Label
	Friend WithEvents Label_Ramp As System.Windows.Forms.Label
	Friend WithEvents ComboBox_TimeUnits As System.Windows.Forms.ComboBox
	Friend WithEvents Button_AddStep As System.Windows.Forms.Button
	Friend WithEvents GroupBoxValves As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBoxTiming As System.Windows.Forms.GroupBox
	Friend WithEvents NumericUpDownValveIndex As System.Windows.Forms.NumericUpDown
	Friend WithEvents RadioButton_ValveClose As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton_ValveOpen As System.Windows.Forms.RadioButton
	Friend WithEvents LabelValveIndex As System.Windows.Forms.Label
	Friend WithEvents Button_AddValve As System.Windows.Forms.Button
	Friend WithEvents ListView_ValveList As System.Windows.Forms.ListView
	Friend WithEvents ListView_Steps As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeaderValve As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeaderAction As System.Windows.Forms.ColumnHeader
	Friend WithEvents ContextMenuStrip_ValveList As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents SetToCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RemoveItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SetToOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents GroupBox_MFCs As System.Windows.Forms.GroupBox
	Friend WithEvents ListView_MFCsList As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader_MFC As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_SetPoint As System.Windows.Forms.ColumnHeader
	Friend WithEvents Button_MFCs As System.Windows.Forms.Button
	Friend WithEvents Label_MFCsSetPoint As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_MFCsSetPoint As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label_MFCsIndex As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_MFCsIndex As System.Windows.Forms.NumericUpDown
	Friend WithEvents TextBox_StepName As System.Windows.Forms.TextBox
	Friend WithEvents Label_StepName As System.Windows.Forms.Label
	Friend WithEvents Label_StepDescription As System.Windows.Forms.Label
	Friend WithEvents TextBox_StepDescription As System.Windows.Forms.TextBox
	Friend WithEvents ColumnHeader_StepIndex As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepName As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepDescription As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepTime As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepRamp As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepTimeUnits As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepValves As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_StepMFCs As System.Windows.Forms.ColumnHeader
	Friend WithEvents ListView_Routines As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader_RoutineIndex As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineName As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineDescription As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader_RoutineSteps As System.Windows.Forms.ColumnHeader
	Friend WithEvents Button_AddRoutine As System.Windows.Forms.Button
	Friend WithEvents GroupBox_StepDetails As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox_RoutineDetails As System.Windows.Forms.GroupBox
	Friend WithEvents TextBox_RoutineDescription As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents TextBox_RoutineName As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button_ShowSteps As System.Windows.Forms.Button
	Friend WithEvents ButtonLoadRoutine As System.Windows.Forms.Button
	Friend WithEvents Button_StepIndexUp As System.Windows.Forms.Button
	Friend WithEvents Button_StepIndexDown As System.Windows.Forms.Button
	Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintPreviewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RedoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ContentsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents FileToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SaveToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents PrintToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PrintPreviewToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UndoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RedoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents CutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CopyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SelectAllToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CustomizeToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ContentsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents IndexToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SearchToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents toolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ComboBox_Ramp As System.Windows.Forms.ComboBox
	Friend WithEvents TextBox_StepSelectedIndex As System.Windows.Forms.TextBox
	Friend WithEvents Button_RoutineIndexDown As System.Windows.Forms.Button
	Friend WithEvents Button_RoutineIndexUp As System.Windows.Forms.Button
	Friend WithEvents TextBox_RoutineSelectedIndex As System.Windows.Forms.TextBox

End Class
