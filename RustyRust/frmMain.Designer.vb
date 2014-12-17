<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("blink.ino")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Blink.inoprj", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("arduino.h")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Not Part of Project", New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.SchließenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjektSchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateiSpeicherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateiSpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleSpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeiteEinrichtenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AllesAuswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErsetzenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjektToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsStatus = New System.Windows.Forms.StatusStrip()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.txtRustLookup = New System.Windows.Forms.ToolStripTextBox()
        Me.btnOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCut = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsButtonIndentLeft = New System.Windows.Forms.ToolStripButton()
        Me.tsButtonIndentRight = New System.Windows.Forms.ToolStripButton()
        Me.btnComments = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuildRun = New System.Windows.Forms.ToolStripButton()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.tsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCloseFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFileAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAllFiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.TargetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArduinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArduinoAsISPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.USBTinyISPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USBaspToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVRIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVRISPMk2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParallelProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuesProjektToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjektÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SdasdToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuildProjectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildUploadProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedUploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTabRightClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseThisTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToCurrentProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFromCurrentProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSerial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSerialDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.DummyitemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSerialConsole = New System.Windows.Forms.ToolStripMenuItem()
        Me.scSplit2 = New System.Windows.Forms.SplitContainer()
        Me.scSplit = New System.Windows.Forms.SplitContainer()
        Me.tlProject = New System.Windows.Forms.TableLayoutPanel()
        Me.tsProject = New System.Windows.Forms.ToolStrip()
        Me.btnNewProject = New System.Windows.Forms.ToolStripButton()
        Me.btnOpenProject = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveProject = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddToProject = New System.Windows.Forms.ToolStripButton()
        Me.btnRemoveFromProject = New System.Windows.Forms.ToolStripButton()
        Me.tvProjectItems = New System.Windows.Forms.TreeView()
        Me.ilTreeview = New System.Windows.Forms.ImageList(Me.components)
        Me.tsTabs = New System.Windows.Forms.TabControl()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lsMessages = New System.Windows.Forms.ListView()
        Me.File = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Row = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tsTools.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        CType(Me.scSplit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSplit2.Panel1.SuspendLayout()
        Me.scSplit2.Panel2.SuspendLayout()
        Me.scSplit2.SuspendLayout()
        CType(Me.scSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSplit.Panel1.SuspendLayout()
        Me.scSplit.Panel2.SuspendLayout()
        Me.scSplit.SuspendLayout()
        Me.tlProject.SuspendLayout()
        Me.tsProject.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.SchließenToolStripMenuItem, Me.SchließenToolStripMenuItem1, Me.ProjektSchließenToolStripMenuItem, Me.ToolStripMenuItem1, Me.DateiSpeicherToolStripMenuItem, Me.DateiSpeichernUnterToolStripMenuItem, Me.AlleSpeichernToolStripMenuItem, Me.ToolStripMenuItem2, Me.SeiteEinrichtenToolStripMenuItem, Me.DruckenToolStripMenuItem, Me.ToolStripMenuItem3, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NeuToolStripMenuItem.Text = "Neues Projekt"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Projekt Öffnen..."
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SpeichernToolStripMenuItem.Text = "Datei Öffnen..."
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(160, 6)
        '
        'SchließenToolStripMenuItem1
        '
        Me.SchließenToolStripMenuItem1.Name = "SchließenToolStripMenuItem1"
        Me.SchließenToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.SchließenToolStripMenuItem1.Text = "Schließen"
        '
        'ProjektSchließenToolStripMenuItem
        '
        Me.ProjektSchließenToolStripMenuItem.Name = "ProjektSchließenToolStripMenuItem"
        Me.ProjektSchließenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ProjektSchließenToolStripMenuItem.Text = "Projekt Schließen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 6)
        '
        'DateiSpeicherToolStripMenuItem
        '
        Me.DateiSpeicherToolStripMenuItem.Name = "DateiSpeicherToolStripMenuItem"
        Me.DateiSpeicherToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DateiSpeicherToolStripMenuItem.Text = "Speichern"
        '
        'DateiSpeichernUnterToolStripMenuItem
        '
        Me.DateiSpeichernUnterToolStripMenuItem.Name = "DateiSpeichernUnterToolStripMenuItem"
        Me.DateiSpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DateiSpeichernUnterToolStripMenuItem.Text = "Speichern Unter..."
        '
        'AlleSpeichernToolStripMenuItem
        '
        Me.AlleSpeichernToolStripMenuItem.Name = "AlleSpeichernToolStripMenuItem"
        Me.AlleSpeichernToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AlleSpeichernToolStripMenuItem.Text = "Alle speichern"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 6)
        '
        'SeiteEinrichtenToolStripMenuItem
        '
        Me.SeiteEinrichtenToolStripMenuItem.Name = "SeiteEinrichtenToolStripMenuItem"
        Me.SeiteEinrichtenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SeiteEinrichtenToolStripMenuItem.Text = "Seite einrichten..."
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DruckenToolStripMenuItem.Text = "Drucken..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(160, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RückgängigToolStripMenuItem.Text = "Rückgängig"
        '
        'WiederholenToolStripMenuItem
        '
        Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
        Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.WiederholenToolStripMenuItem.Text = "Wiederholen"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(155, 6)
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LöschenToolStripMenuItem.Text = "Löschen"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(155, 6)
        '
        'AllesAuswählenToolStripMenuItem
        '
        Me.AllesAuswählenToolStripMenuItem.Name = "AllesAuswählenToolStripMenuItem"
        Me.AllesAuswählenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AllesAuswählenToolStripMenuItem.Text = "Alles auswählen"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(155, 6)
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SuchenToolStripMenuItem.Text = "Suchen"
        '
        'ErsetzenToolStripMenuItem
        '
        Me.ErsetzenToolStripMenuItem.Name = "ErsetzenToolStripMenuItem"
        Me.ErsetzenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ErsetzenToolStripMenuItem.Text = "Ersetzen"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AnsichtToolStripMenuItem.Text = "Ansicht"
        '
        'ProjektToolStripMenuItem
        '
        Me.ProjektToolStripMenuItem.Name = "ProjektToolStripMenuItem"
        Me.ProjektToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjektToolStripMenuItem.Text = "Projekt"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'tsStatus
        '
        Me.tsStatus.Location = New System.Drawing.Point(0, 459)
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(811, 22)
        Me.tsStatus.TabIndex = 3
        Me.tsStatus.Text = "StatusStrip1"
        '
        'tsTools
        '
        Me.tsTools.ImageScalingSize = New System.Drawing.Size(22, 22)
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.txtRustLookup, Me.btnOpenFile, Me.btnSaveFile, Me.btnSaveAll, Me.ToolStripSeparator1, Me.btnCut, Me.btnCopy, Me.btnPaste, Me.ToolStripSeparator2, Me.btnUndo, Me.ToolStripSeparator3, Me.tsButtonIndentLeft, Me.tsButtonIndentRight, Me.btnComments, Me.ToolStripSeparator5, Me.btnBuildRun})
        Me.tsTools.Location = New System.Drawing.Point(0, 24)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(811, 29)
        Me.tsTools.TabIndex = 4
        Me.tsTools.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(26, 26)
        Me.btnNew.Tag = ""
        Me.btnNew.Text = "Create new file and adds it to the current project"
        '
        'txtRustLookup
        '
        Me.txtRustLookup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtRustLookup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRustLookup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRustLookup.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRustLookup.Name = "txtRustLookup"
        Me.txtRustLookup.Size = New System.Drawing.Size(150, 29)
        Me.txtRustLookup.Text = "Search rust-lang.org"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Image)
        Me.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(26, 26)
        Me.btnOpenFile.Tag = ""
        Me.btnOpenFile.Text = "Open existing file..."
        '
        'btnSaveFile
        '
        Me.btnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveFile.Image = CType(resources.GetObject("btnSaveFile.Image"), System.Drawing.Image)
        Me.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(26, 26)
        Me.btnSaveFile.Tag = ""
        Me.btnSaveFile.Text = "Save file"
        '
        'btnSaveAll
        '
        Me.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveAll.Image = CType(resources.GetObject("btnSaveAll.Image"), System.Drawing.Image)
        Me.btnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(26, 26)
        Me.btnSaveAll.Tag = ""
        Me.btnSaveAll.Text = "Save all files"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'btnCut
        '
        Me.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(26, 26)
        Me.btnCut.Tag = ""
        Me.btnCut.Text = "Cut selected text to clipboard"
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(26, 26)
        Me.btnCopy.Tag = ""
        Me.btnCopy.Text = "Copy selected text to clipboard"
        '
        'btnPaste
        '
        Me.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(26, 26)
        Me.btnPaste.Tag = ""
        Me.btnPaste.Text = "Paste from clipboard"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(26, 26)
        Me.btnUndo.Tag = ""
        Me.btnUndo.Text = "Undo last change"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'tsButtonIndentLeft
        '
        Me.tsButtonIndentLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsButtonIndentLeft.Image = CType(resources.GetObject("tsButtonIndentLeft.Image"), System.Drawing.Image)
        Me.tsButtonIndentLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsButtonIndentLeft.Name = "tsButtonIndentLeft"
        Me.tsButtonIndentLeft.Size = New System.Drawing.Size(26, 26)
        Me.tsButtonIndentLeft.Text = "ToolStripButton1"
        Me.tsButtonIndentLeft.Visible = False
        '
        'tsButtonIndentRight
        '
        Me.tsButtonIndentRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsButtonIndentRight.Image = CType(resources.GetObject("tsButtonIndentRight.Image"), System.Drawing.Image)
        Me.tsButtonIndentRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsButtonIndentRight.Name = "tsButtonIndentRight"
        Me.tsButtonIndentRight.Size = New System.Drawing.Size(26, 26)
        Me.tsButtonIndentRight.Text = "ToolStripButton1"
        Me.tsButtonIndentRight.Visible = False
        '
        'btnComments
        '
        Me.btnComments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnComments.Image = CType(resources.GetObject("btnComments.Image"), System.Drawing.Image)
        Me.btnComments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnComments.Name = "btnComments"
        Me.btnComments.Size = New System.Drawing.Size(26, 26)
        Me.btnComments.Tag = ""
        Me.btnComments.Text = "Comment / Uncomment selected text"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 29)
        '
        'btnBuildRun
        '
        Me.btnBuildRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuildRun.Image = CType(resources.GetObject("btnBuildRun.Image"), System.Drawing.Image)
        Me.btnBuildRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuildRun.Name = "btnBuildRun"
        Me.btnBuildRun.Size = New System.Drawing.Size(26, 26)
        Me.btnBuildRun.Text = "ToolStripButton1"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Rust Source Files (*.rs)|*.rs|All Files (*.*)|*.*"
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        Me.dlgOpen.Filter = "Rust Source Files (*.rs)|*.rs|All Files (*.*)|*.*"
        '
        'tsMenu
        '
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp, Me.BuildToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.MnuTabRightClickToolStripMenuItem, Me.mnuSerial})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(811, 24)
        Me.tsMenu.TabIndex = 6
        Me.tsMenu.Text = "tsMenu"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateNewFile, Me.ToolStripMenuItem7, Me.mnuOpenFile, Me.ToolStripMenuItem8, Me.mnuCloseFile, Me.ToolStripMenuItem9, Me.mnuSaveFile, Me.mnuSaveFileAs, Me.mnuSaveAllFiles, Me.ToolStripMenuItem10, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuCreateNewFile
        '
        Me.mnuCreateNewFile.Image = CType(resources.GetObject("mnuCreateNewFile.Image"), System.Drawing.Image)
        Me.mnuCreateNewFile.Name = "mnuCreateNewFile"
        Me.mnuCreateNewFile.Size = New System.Drawing.Size(147, 22)
        Me.mnuCreateNewFile.Tag = ""
        Me.mnuCreateNewFile.Text = "Create new file"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(144, 6)
        '
        'mnuOpenFile
        '
        Me.mnuOpenFile.Image = Global.RustyRust.My.Resources.Resources.document_open
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.Size = New System.Drawing.Size(147, 22)
        Me.mnuOpenFile.Tag = ""
        Me.mnuOpenFile.Text = "Open File..."
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(144, 6)
        '
        'mnuCloseFile
        '
        Me.mnuCloseFile.Image = Global.RustyRust.My.Resources.Resources.x
        Me.mnuCloseFile.Name = "mnuCloseFile"
        Me.mnuCloseFile.Size = New System.Drawing.Size(147, 22)
        Me.mnuCloseFile.Tag = ""
        Me.mnuCloseFile.Text = "Close File"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(144, 6)
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Image = CType(resources.GetObject("mnuSaveFile.Image"), System.Drawing.Image)
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.Size = New System.Drawing.Size(147, 22)
        Me.mnuSaveFile.Tag = ""
        Me.mnuSaveFile.Text = "Save File"
        '
        'mnuSaveFileAs
        '
        Me.mnuSaveFileAs.Image = Global.RustyRust.My.Resources.Resources.document_save_as
        Me.mnuSaveFileAs.Name = "mnuSaveFileAs"
        Me.mnuSaveFileAs.Size = New System.Drawing.Size(147, 22)
        Me.mnuSaveFileAs.Tag = ""
        Me.mnuSaveFileAs.Text = "Save File As..."
        '
        'mnuSaveAllFiles
        '
        Me.mnuSaveAllFiles.Image = CType(resources.GetObject("mnuSaveAllFiles.Image"), System.Drawing.Image)
        Me.mnuSaveAllFiles.Name = "mnuSaveAllFiles"
        Me.mnuSaveAllFiles.Size = New System.Drawing.Size(147, 22)
        Me.mnuSaveAllFiles.Tag = ""
        Me.mnuSaveAllFiles.Text = "Save All"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(144, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Image = Global.RustyRust.My.Resources.Resources.system_log_out
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(147, 22)
        Me.mnuExit.Tag = ""
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.ToolStripMenuItem11, Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuDelete, Me.ToolStripMenuItem12, Me.mnuSelectAll, Me.ToolStripMenuItem13, Me.mnuFind, Me.mnuReplace})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuUndo
        '
        Me.mnuUndo.Image = Global.RustyRust.My.Resources.Resources.edit_undo
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(157, 22)
        Me.mnuUndo.Tag = ""
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Image = Global.RustyRust.My.Resources.Resources.edit_redo
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(157, 22)
        Me.mnuRedo.Tag = ""
        Me.mnuRedo.Text = "Redo"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(154, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Image = Global.RustyRust.My.Resources.Resources.edit_cut
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(157, 22)
        Me.mnuCut.Tag = ""
        Me.mnuCut.Text = "Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = Global.RustyRust.My.Resources.Resources.edit_copy
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(157, 22)
        Me.mnuCopy.Tag = ""
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = Global.RustyRust.My.Resources.Resources.edit_paste
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(157, 22)
        Me.mnuPaste.Tag = ""
        Me.mnuPaste.Text = "Paste"
        '
        'mnuDelete
        '
        Me.mnuDelete.Image = Global.RustyRust.My.Resources.Resources.edit_delete
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(157, 22)
        Me.mnuDelete.Tag = ""
        Me.mnuDelete.Text = "Delete"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(154, 6)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Image = Global.RustyRust.My.Resources.Resources.edit_select_all
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.Size = New System.Drawing.Size(157, 22)
        Me.mnuSelectAll.Tag = ""
        Me.mnuSelectAll.Text = "Select All"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(154, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Image = Global.RustyRust.My.Resources.Resources.edit_find
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(157, 22)
        Me.mnuFind.Tag = ""
        Me.mnuFind.Text = "Find..."
        '
        'mnuReplace
        '
        Me.mnuReplace.Image = Global.RustyRust.My.Resources.Resources.edit_find_replace
        Me.mnuReplace.Name = "mnuReplace"
        Me.mnuReplace.Size = New System.Drawing.Size(157, 22)
        Me.mnuReplace.Tag = ""
        Me.mnuReplace.Text = "Find && Replace..."
        '
        'mnuHelp
        '
        Me.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(115, 22)
        Me.mnuAbout.Text = "About..."
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildToolStripMenuItem1, Me.BuildProjectToolStripMenuItem, Me.ToolStripMenuItem17, Me.TargetToolStripMenuItem, Me.ProgrammerToolStripMenuItem})
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'BuildToolStripMenuItem1
        '
        Me.BuildToolStripMenuItem1.Name = "BuildToolStripMenuItem1"
        Me.BuildToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.BuildToolStripMenuItem1.Text = "Build"
        '
        'BuildProjectToolStripMenuItem
        '
        Me.BuildProjectToolStripMenuItem.Name = "BuildProjectToolStripMenuItem"
        Me.BuildProjectToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BuildProjectToolStripMenuItem.Text = "Build && Upload"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(139, 6)
        '
        'TargetToolStripMenuItem
        '
        Me.TargetToolStripMenuItem.Name = "TargetToolStripMenuItem"
        Me.TargetToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TargetToolStripMenuItem.Text = "Target"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArduinoToolStripMenuItem, Me.ArduinoAsISPToolStripMenuItem, Me.ToolStripMenuItem18, Me.USBTinyISPToolStripMenuItem, Me.USBaspToolStripMenuItem, Me.AVRIToolStripMenuItem, Me.AVRISPMk2ToolStripMenuItem, Me.ParallelProgrammerToolStripMenuItem, Me.ToolStripMenuItem19, Me.CustomToolStripMenuItem})
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProgrammerToolStripMenuItem.Text = "Programmer"
        '
        'ArduinoToolStripMenuItem
        '
        Me.ArduinoToolStripMenuItem.Checked = True
        Me.ArduinoToolStripMenuItem.CheckOnClick = True
        Me.ArduinoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ArduinoToolStripMenuItem.Name = "ArduinoToolStripMenuItem"
        Me.ArduinoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ArduinoToolStripMenuItem.Text = "Arduino"
        '
        'ArduinoAsISPToolStripMenuItem
        '
        Me.ArduinoAsISPToolStripMenuItem.Name = "ArduinoAsISPToolStripMenuItem"
        Me.ArduinoAsISPToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ArduinoAsISPToolStripMenuItem.Text = "Arduino as ISP"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(166, 6)
        '
        'USBTinyISPToolStripMenuItem
        '
        Me.USBTinyISPToolStripMenuItem.Name = "USBTinyISPToolStripMenuItem"
        Me.USBTinyISPToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.USBTinyISPToolStripMenuItem.Text = "USBTinyISP"
        '
        'USBaspToolStripMenuItem
        '
        Me.USBaspToolStripMenuItem.Name = "USBaspToolStripMenuItem"
        Me.USBaspToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.USBaspToolStripMenuItem.Text = "USBasp"
        '
        'AVRIToolStripMenuItem
        '
        Me.AVRIToolStripMenuItem.Name = "AVRIToolStripMenuItem"
        Me.AVRIToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AVRIToolStripMenuItem.Text = "AVR ISP"
        '
        'AVRISPMk2ToolStripMenuItem
        '
        Me.AVRISPMk2ToolStripMenuItem.Name = "AVRISPMk2ToolStripMenuItem"
        Me.AVRISPMk2ToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AVRISPMk2ToolStripMenuItem.Text = "AVR ISP mkII"
        '
        'ParallelProgrammerToolStripMenuItem
        '
        Me.ParallelProgrammerToolStripMenuItem.Name = "ParallelProgrammerToolStripMenuItem"
        Me.ParallelProgrammerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ParallelProgrammerToolStripMenuItem.Text = "Parallel Programmer"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(166, 6)
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CustomToolStripMenuItem.Text = "Custom..."
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuesProjektToolStripMenuItem, Me.ProjektÖffnenToolStripMenuItem, Me.SdasdToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.SaveProjectAsToolStripMenuItem, Me.ToolStripMenuItem14, Me.CloseProjectToolStripMenuItem, Me.ToolStripMenuItem15, Me.BuildProjectToolStripMenuItem1, Me.BuildUploadProjectToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.ToolStripMenuItem16, Me.ProjectSettingsToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'NeuesProjektToolStripMenuItem
        '
        Me.NeuesProjektToolStripMenuItem.Image = Global.RustyRust.My.Resources.Resources.folder_new
        Me.NeuesProjektToolStripMenuItem.Name = "NeuesProjektToolStripMenuItem"
        Me.NeuesProjektToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NeuesProjektToolStripMenuItem.Text = "Create new Project..."
        '
        'ProjektÖffnenToolStripMenuItem
        '
        Me.ProjektÖffnenToolStripMenuItem.Image = Global.RustyRust.My.Resources.Resources.folder_open
        Me.ProjektÖffnenToolStripMenuItem.Name = "ProjektÖffnenToolStripMenuItem"
        Me.ProjektÖffnenToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProjektÖffnenToolStripMenuItem.Text = "Open Project..."
        '
        'SdasdToolStripMenuItem
        '
        Me.SdasdToolStripMenuItem.Name = "SdasdToolStripMenuItem"
        Me.SdasdToolStripMenuItem.Size = New System.Drawing.Size(176, 6)
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'SaveProjectAsToolStripMenuItem
        '
        Me.SaveProjectAsToolStripMenuItem.Name = "SaveProjectAsToolStripMenuItem"
        Me.SaveProjectAsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SaveProjectAsToolStripMenuItem.Text = "Save Project As..."
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(176, 6)
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CloseProjectToolStripMenuItem.Text = "Close Project"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(176, 6)
        '
        'BuildProjectToolStripMenuItem1
        '
        Me.BuildProjectToolStripMenuItem1.Name = "BuildProjectToolStripMenuItem1"
        Me.BuildProjectToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.BuildProjectToolStripMenuItem1.Text = "Build Project"
        '
        'BuildUploadProjectToolStripMenuItem
        '
        Me.BuildUploadProjectToolStripMenuItem.Name = "BuildUploadProjectToolStripMenuItem"
        Me.BuildUploadProjectToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BuildUploadProjectToolStripMenuItem.Text = "Build && Upload Project"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildOptionsToolStripMenuItem, Me.AdvancedUploadToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'BuildOptionsToolStripMenuItem
        '
        Me.BuildOptionsToolStripMenuItem.Name = "BuildOptionsToolStripMenuItem"
        Me.BuildOptionsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BuildOptionsToolStripMenuItem.Text = "Build Options..."
        '
        'AdvancedUploadToolStripMenuItem
        '
        Me.AdvancedUploadToolStripMenuItem.Name = "AdvancedUploadToolStripMenuItem"
        Me.AdvancedUploadToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AdvancedUploadToolStripMenuItem.Text = "Advanced Upload..."
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(176, 6)
        '
        'ProjectSettingsToolStripMenuItem
        '
        Me.ProjectSettingsToolStripMenuItem.Name = "ProjectSettingsToolStripMenuItem"
        Me.ProjectSettingsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProjectSettingsToolStripMenuItem.Text = "Project Settings..."
        '
        'MnuTabRightClickToolStripMenuItem
        '
        Me.MnuTabRightClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseThisTabToolStripMenuItem, Me.ToolStripMenuItem20, Me.AddToCurrentProjectToolStripMenuItem, Me.RemoveFromCurrentProjectToolStripMenuItem})
        Me.MnuTabRightClickToolStripMenuItem.Name = "MnuTabRightClickToolStripMenuItem"
        Me.MnuTabRightClickToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MnuTabRightClickToolStripMenuItem.Text = "mnuTabRightClick"
        Me.MnuTabRightClickToolStripMenuItem.Visible = False
        '
        'CloseThisTabToolStripMenuItem
        '
        Me.CloseThisTabToolStripMenuItem.Name = "CloseThisTabToolStripMenuItem"
        Me.CloseThisTabToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CloseThisTabToolStripMenuItem.Text = "Close this Tab"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(210, 6)
        '
        'AddToCurrentProjectToolStripMenuItem
        '
        Me.AddToCurrentProjectToolStripMenuItem.Name = "AddToCurrentProjectToolStripMenuItem"
        Me.AddToCurrentProjectToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AddToCurrentProjectToolStripMenuItem.Text = "Add to current Project"
        '
        'RemoveFromCurrentProjectToolStripMenuItem
        '
        Me.RemoveFromCurrentProjectToolStripMenuItem.Name = "RemoveFromCurrentProjectToolStripMenuItem"
        Me.RemoveFromCurrentProjectToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.RemoveFromCurrentProjectToolStripMenuItem.Text = "Remove from current Project"
        '
        'mnuSerial
        '
        Me.mnuSerial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSerialDevice, Me.ToolStripMenuItem21, Me.mnuSerialConsole})
        Me.mnuSerial.Name = "mnuSerial"
        Me.mnuSerial.Size = New System.Drawing.Size(45, 20)
        Me.mnuSerial.Text = "Serial"
        '
        'mnuSerialDevice
        '
        Me.mnuSerialDevice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DummyitemToolStripMenuItem})
        Me.mnuSerialDevice.Name = "mnuSerialDevice"
        Me.mnuSerialDevice.Size = New System.Drawing.Size(112, 22)
        Me.mnuSerialDevice.Text = "Device"
        '
        'DummyitemToolStripMenuItem
        '
        Me.DummyitemToolStripMenuItem.Name = "DummyitemToolStripMenuItem"
        Me.DummyitemToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DummyitemToolStripMenuItem.Text = "Dummyitem"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(109, 6)
        '
        'mnuSerialConsole
        '
        Me.mnuSerialConsole.Name = "mnuSerialConsole"
        Me.mnuSerialConsole.Size = New System.Drawing.Size(112, 22)
        Me.mnuSerialConsole.Text = "Console"
        '
        'scSplit2
        '
        Me.scSplit2.Location = New System.Drawing.Point(31, 74)
        Me.scSplit2.Margin = New System.Windows.Forms.Padding(0)
        Me.scSplit2.Name = "scSplit2"
        Me.scSplit2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scSplit2.Panel1
        '
        Me.scSplit2.Panel1.Controls.Add(Me.scSplit)
        '
        'scSplit2.Panel2
        '
        Me.scSplit2.Panel2.Controls.Add(Me.lsMessages)
        Me.scSplit2.Panel2.Controls.Add(Me.txtOutput)
        Me.scSplit2.Size = New System.Drawing.Size(640, 363)
        Me.scSplit2.SplitterDistance = 281
        Me.scSplit2.TabIndex = 7
        '
        'scSplit
        '
        Me.scSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scSplit.Location = New System.Drawing.Point(0, 0)
        Me.scSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.scSplit.Name = "scSplit"
        '
        'scSplit.Panel1
        '
        Me.scSplit.Panel1.Controls.Add(Me.tlProject)
        Me.scSplit.Panel1Collapsed = True
        '
        'scSplit.Panel2
        '
        Me.scSplit.Panel2.Controls.Add(Me.tsTabs)
        Me.scSplit.Size = New System.Drawing.Size(640, 281)
        Me.scSplit.SplitterDistance = 167
        Me.scSplit.TabIndex = 6
        '
        'tlProject
        '
        Me.tlProject.AutoSize = True
        Me.tlProject.ColumnCount = 1
        Me.tlProject.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlProject.Controls.Add(Me.tsProject, 0, 0)
        Me.tlProject.Controls.Add(Me.tvProjectItems, 0, 1)
        Me.tlProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlProject.Location = New System.Drawing.Point(0, 0)
        Me.tlProject.Margin = New System.Windows.Forms.Padding(0)
        Me.tlProject.Name = "tlProject"
        Me.tlProject.RowCount = 2
        Me.tlProject.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlProject.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlProject.Size = New System.Drawing.Size(167, 100)
        Me.tlProject.TabIndex = 2
        Me.tlProject.Visible = False
        '
        'tsProject
        '
        Me.tsProject.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewProject, Me.btnOpenProject, Me.btnSaveProject, Me.ToolStripSeparator4, Me.btnAddToProject, Me.btnRemoveFromProject})
        Me.tsProject.Location = New System.Drawing.Point(0, 0)
        Me.tsProject.Name = "tsProject"
        Me.tsProject.Size = New System.Drawing.Size(167, 25)
        Me.tsProject.TabIndex = 0
        Me.tsProject.Text = "ToolStrip1"
        '
        'btnNewProject
        '
        Me.btnNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNewProject.Image = Global.RustyRust.My.Resources.Resources.folder_new
        Me.btnNewProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(23, 22)
        Me.btnNewProject.Text = "Create new project"
        '
        'btnOpenProject
        '
        Me.btnOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpenProject.Image = Global.RustyRust.My.Resources.Resources.folder_open
        Me.btnOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpenProject.Name = "btnOpenProject"
        Me.btnOpenProject.Size = New System.Drawing.Size(23, 22)
        Me.btnOpenProject.Text = "Open project..."
        '
        'btnSaveProject
        '
        Me.btnSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveProject.Image = CType(resources.GetObject("btnSaveProject.Image"), System.Drawing.Image)
        Me.btnSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveProject.Name = "btnSaveProject"
        Me.btnSaveProject.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveProject.Text = "Save project"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnAddToProject
        '
        Me.btnAddToProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddToProject.Image = Global.RustyRust.My.Resources.Resources.list_add
        Me.btnAddToProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddToProject.Name = "btnAddToProject"
        Me.btnAddToProject.Size = New System.Drawing.Size(23, 22)
        Me.btnAddToProject.Text = "Add existing file to project"
        '
        'btnRemoveFromProject
        '
        Me.btnRemoveFromProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRemoveFromProject.Image = Global.RustyRust.My.Resources.Resources.list_remove
        Me.btnRemoveFromProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveFromProject.Name = "btnRemoveFromProject"
        Me.btnRemoveFromProject.Size = New System.Drawing.Size(23, 22)
        Me.btnRemoveFromProject.Text = "Remove selected file from project"
        '
        'tvProjectItems
        '
        Me.tvProjectItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvProjectItems.ImageIndex = 0
        Me.tvProjectItems.ImageList = Me.ilTreeview
        Me.tvProjectItems.Location = New System.Drawing.Point(2, 25)
        Me.tvProjectItems.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.tvProjectItems.Name = "tvProjectItems"
        TreeNode5.ImageIndex = 5
        TreeNode5.Name = "Knoten2"
        TreeNode5.Text = "blink.ino"
        TreeNode6.Name = "nodeProject"
        TreeNode6.Text = "Blink.inoprj"
        TreeNode7.ImageIndex = 4
        TreeNode7.Name = "Knoten3"
        TreeNode7.Text = "arduino.h"
        TreeNode8.Name = "nodeNotProject"
        TreeNode8.Text = "Not Part of Project"
        Me.tvProjectItems.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode8})
        Me.tvProjectItems.SelectedImageIndex = 0
        Me.tvProjectItems.Size = New System.Drawing.Size(165, 256)
        Me.tvProjectItems.TabIndex = 1
        '
        'ilTreeview
        '
        Me.ilTreeview.ImageStream = CType(resources.GetObject("ilTreeview.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTreeview.TransparentColor = System.Drawing.Color.Transparent
        Me.ilTreeview.Images.SetKeyName(0, "folder-open.png")
        Me.ilTreeview.Images.SetKeyName(1, "folder.png")
        Me.ilTreeview.Images.SetKeyName(2, "c.png")
        Me.ilTreeview.Images.SetKeyName(3, "cpp.png")
        Me.ilTreeview.Images.SetKeyName(4, "h.png")
        Me.ilTreeview.Images.SetKeyName(5, "ino.png")
        '
        'tsTabs
        '
        Me.tsTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsTabs.Location = New System.Drawing.Point(0, 0)
        Me.tsTabs.Margin = New System.Windows.Forms.Padding(0)
        Me.tsTabs.Name = "tsTabs"
        Me.tsTabs.SelectedIndex = 0
        Me.tsTabs.Size = New System.Drawing.Size(640, 281)
        Me.tsTabs.TabIndex = 0
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Black
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.txtOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtOutput.Location = New System.Drawing.Point(0, 0)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(640, 78)
        Me.txtOutput.TabIndex = 0
        '
        'lsMessages
        '
        Me.lsMessages.BackColor = System.Drawing.Color.White
        Me.lsMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.File, Me.Row, Me.Type})
        Me.lsMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsMessages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lsMessages.FullRowSelect = True
        Me.lsMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsMessages.Location = New System.Drawing.Point(0, 0)
        Me.lsMessages.Name = "lsMessages"
        Me.lsMessages.Size = New System.Drawing.Size(640, 78)
        Me.lsMessages.TabIndex = 1
        Me.lsMessages.UseCompatibleStateImageBehavior = False
        Me.lsMessages.View = System.Windows.Forms.View.Details
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 481)
        Me.Controls.Add(Me.scSplit2)
        Me.Controls.Add(Me.tsTools)
        Me.Controls.Add(Me.tsStatus)
        Me.Controls.Add(Me.tsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.tsMenu
        Me.Name = "frmMain"
        Me.Text = "Tribute"
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.scSplit2.Panel1.ResumeLayout(False)
        Me.scSplit2.Panel2.ResumeLayout(False)
        Me.scSplit2.Panel2.PerformLayout()
        CType(Me.scSplit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSplit2.ResumeLayout(False)
        Me.scSplit.Panel1.ResumeLayout(False)
        Me.scSplit.Panel1.PerformLayout()
        Me.scSplit.Panel2.ResumeLayout(False)
        CType(Me.scSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSplit.ResumeLayout(False)
        Me.tlProject.ResumeLayout(False)
        Me.tlProject.PerformLayout()
        Me.tsProject.ResumeLayout(False)
        Me.tsProject.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SchließenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjektSchließenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateiSpeicherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateiSpeichernUnterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlleSpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeiteEinrichtenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DruckenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WiederholenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllesAuswählenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SuchenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErsetzenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjektToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTools As System.Windows.Forms.ToolStrip
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCloseFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveFileAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAllFiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtRustLookup As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnOpenFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsButtonIndentLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsButtonIndentRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnComments As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scSplit2 As System.Windows.Forms.SplitContainer
    Friend WithEvents scSplit As System.Windows.Forms.SplitContainer
    Friend WithEvents tsTabs As System.Windows.Forms.TabControl
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlProject As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tsProject As System.Windows.Forms.ToolStrip
    Friend WithEvents tvProjectItems As System.Windows.Forms.TreeView
    Friend WithEvents btnNewProject As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpenProject As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveProject As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAddToProject As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRemoveFromProject As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCreateNewFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuesProjektToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjektÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SdasdToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveProjectAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuildProjectToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildUploadProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedUploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProjectSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TargetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArduinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArduinoAsISPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents USBTinyISPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USBaspToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVRIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVRISPMk2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParallelProgrammerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilTreeview As System.Windows.Forms.ImageList
    Friend WithEvents MnuTabRightClickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseThisTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToCurrentProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveFromCurrentProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSerial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSerialDevice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSerialConsole As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DummyitemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuildRun As System.Windows.Forms.ToolStripButton
    Friend WithEvents File As System.Windows.Forms.ColumnHeader
    Friend WithEvents Row As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsMessages As System.Windows.Forms.ListView




End Class
