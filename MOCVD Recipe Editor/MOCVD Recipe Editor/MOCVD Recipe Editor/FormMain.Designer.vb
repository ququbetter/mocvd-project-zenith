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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
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
		Me.Label_Delay = New System.Windows.Forms.Label()
		Me.NumericUpDown_Ramp = New System.Windows.Forms.NumericUpDown()
		Me.NumericUpDown_Delay = New System.Windows.Forms.NumericUpDown()
		Me.ComboBox_TimeUnits = New System.Windows.Forms.ComboBox()
		Me.ComboBox_RampUnits = New System.Windows.Forms.ComboBox()
		Me.ComboBox_DelayUnits = New System.Windows.Forms.ComboBox()
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
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_Ramp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxValves.SuspendLayout()
		Me.ContextMenuStrip_ValveList.SuspendLayout()
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxTiming.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(731, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
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
		'Label_Delay
		'
		Me.Label_Delay.AutoSize = True
		Me.Label_Delay.Location = New System.Drawing.Point(15, 73)
		Me.Label_Delay.Name = "Label_Delay"
		Me.Label_Delay.Size = New System.Drawing.Size(37, 13)
		Me.Label_Delay.TabIndex = 6
		Me.Label_Delay.Text = "Delay:"
		'
		'NumericUpDown_Ramp
		'
		Me.NumericUpDown_Ramp.Location = New System.Drawing.Point(54, 45)
		Me.NumericUpDown_Ramp.Name = "NumericUpDown_Ramp"
		Me.NumericUpDown_Ramp.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Ramp.TabIndex = 7
		'
		'NumericUpDown_Delay
		'
		Me.NumericUpDown_Delay.Location = New System.Drawing.Point(54, 71)
		Me.NumericUpDown_Delay.Name = "NumericUpDown_Delay"
		Me.NumericUpDown_Delay.Size = New System.Drawing.Size(81, 20)
		Me.NumericUpDown_Delay.TabIndex = 8
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
		'ComboBox_RampUnits
		'
		Me.ComboBox_RampUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_RampUnits.FormattingEnabled = True
		Me.ComboBox_RampUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_RampUnits.Location = New System.Drawing.Point(141, 45)
		Me.ComboBox_RampUnits.MaxLength = 3
		Me.ComboBox_RampUnits.Name = "ComboBox_RampUnits"
		Me.ComboBox_RampUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_RampUnits.TabIndex = 10
		'
		'ComboBox_DelayUnits
		'
		Me.ComboBox_DelayUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox_DelayUnits.FormattingEnabled = True
		Me.ComboBox_DelayUnits.Items.AddRange(New Object() {"min", "sec", "ms"})
		Me.ComboBox_DelayUnits.Location = New System.Drawing.Point(141, 71)
		Me.ComboBox_DelayUnits.MaxLength = 3
		Me.ComboBox_DelayUnits.Name = "ComboBox_DelayUnits"
		Me.ComboBox_DelayUnits.Size = New System.Drawing.Size(42, 21)
		Me.ComboBox_DelayUnits.TabIndex = 11
		'
		'Button_AddStep
		'
		Me.Button_AddStep.Location = New System.Drawing.Point(458, 396)
		Me.Button_AddStep.Name = "Button_AddStep"
		Me.Button_AddStep.Size = New System.Drawing.Size(75, 23)
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
		Me.GroupBoxValves.Location = New System.Drawing.Point(367, 134)
		Me.GroupBoxValves.Name = "GroupBoxValves"
		Me.GroupBoxValves.Size = New System.Drawing.Size(151, 202)
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
		Me.ListView_ValveList.Size = New System.Drawing.Size(139, 97)
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
		Me.Button_AddValve.Location = New System.Drawing.Point(6, 65)
		Me.Button_AddValve.Name = "Button_AddValve"
		Me.Button_AddValve.Size = New System.Drawing.Size(139, 23)
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
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_TimeUnits)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Time)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Ramp)
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_DelayUnits)
		Me.GroupBoxTiming.Controls.Add(Me.Label_Delay)
		Me.GroupBoxTiming.Controls.Add(Me.ComboBox_RampUnits)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Ramp)
		Me.GroupBoxTiming.Controls.Add(Me.NumericUpDown_Delay)
		Me.GroupBoxTiming.Location = New System.Drawing.Point(367, 27)
		Me.GroupBoxTiming.Name = "GroupBoxTiming"
		Me.GroupBoxTiming.Size = New System.Drawing.Size(192, 101)
		Me.GroupBoxTiming.TabIndex = 14
		Me.GroupBoxTiming.TabStop = False
		Me.GroupBoxTiming.Text = "Timing"
		'
		'ListView1
		'
		Me.ListView1.Location = New System.Drawing.Point(63, 100)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(121, 97)
		Me.ListView1.TabIndex = 15
		Me.ListView1.UseCompatibleStateImageBehavior = False
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(731, 610)
		Me.Controls.Add(Me.ListView1)
		Me.Controls.Add(Me.GroupBoxTiming)
		Me.Controls.Add(Me.GroupBoxValves)
		Me.Controls.Add(Me.Button_AddStep)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FormMain"
		Me.Text = "MOCVD Recipe Editor"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.NumericUpDown_Time, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_Ramp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown_Delay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxValves.ResumeLayout(False)
		Me.GroupBoxValves.PerformLayout()
		Me.ContextMenuStrip_ValveList.ResumeLayout(False)
		CType(Me.NumericUpDownValveIndex, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxTiming.ResumeLayout(False)
		Me.GroupBoxTiming.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
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
	Friend WithEvents Label_Delay As System.Windows.Forms.Label
	Friend WithEvents NumericUpDown_Ramp As System.Windows.Forms.NumericUpDown
	Friend WithEvents NumericUpDown_Delay As System.Windows.Forms.NumericUpDown
	Friend WithEvents ComboBox_TimeUnits As System.Windows.Forms.ComboBox
	Friend WithEvents ComboBox_RampUnits As System.Windows.Forms.ComboBox
	Friend WithEvents ComboBox_DelayUnits As System.Windows.Forms.ComboBox
	Friend WithEvents Button_AddStep As System.Windows.Forms.Button
	Friend WithEvents GroupBoxValves As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBoxTiming As System.Windows.Forms.GroupBox
	Friend WithEvents NumericUpDownValveIndex As System.Windows.Forms.NumericUpDown
	Friend WithEvents RadioButton_ValveClose As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton_ValveOpen As System.Windows.Forms.RadioButton
	Friend WithEvents LabelValveIndex As System.Windows.Forms.Label
	Friend WithEvents Button_AddValve As System.Windows.Forms.Button
	Friend WithEvents ListView_ValveList As System.Windows.Forms.ListView
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeaderValve As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeaderAction As System.Windows.Forms.ColumnHeader
	Friend WithEvents ContextMenuStrip_ValveList As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents SetToCloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RemoveItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SetToOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
