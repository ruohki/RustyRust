Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Management
Imports System.Drawing
Imports System.Threading
Imports System.Text

Imports RustCompilerWrapper

Public Class frmMain
    Dim KeywordStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(137, 89, 168)), Nothing, FontStyle.Regular)
    Dim ConstantStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(245, 135, 31)), Nothing, FontStyle.Regular)
    Dim CommentStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(153, 154, 151)), Nothing, FontStyle.Regular)
    Dim OperatorStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(62, 153, 159)), Nothing, FontStyle.Regular)
    Dim StringStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(127, 152, 26)), Nothing, FontStyle.Regular)
    Dim NumberStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(249, 156, 31)), Nothing, FontStyle.Regular)
    Dim HyperlinkStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(66, 139, 202)), Nothing, FontStyle.Underline)

    Dim DocCounter As Integer = 0
    Dim Documents As New List(Of Document)


    Dim myProject As New clsProject
    Dim myTranslator As New Translator

    Public Shared bCompileError As Boolean = False
    Public Shared processOutput As New StringBuilder()
    Public runProcess As New Process()

#Region "Main Form & Load"

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each myDoc As Document In Documents
            tsTabs.SelectedTab = myDoc.Page

            If myDoc.Changed = True Then
                Dim erg As MsgBoxResult = MsgBox(" Die Datei wurde verändert. Möchte sie die Änderungen speichern?", vbYesNoCancel + vbQuestion, "Änderungen Speichern?")
                If erg = MsgBoxResult.Yes Then
                    SaveFile(myDoc)
                ElseIf erg = vbCancel Then
                    e.Cancel = True
                    Exit Sub
                ElseIf erg = vbNo Then
                End If
            End If
        Next


    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        scSplit2.Location = New Point(0, tsMenu.Height + tsTools.Height)

        scSplit2.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - tsMenu.Height - tsTools.Height - tsStatus.Height)

        Dim ColLeft As UInteger

        For i = 0 To lsMessages.Columns.Count - 2
            ColLeft += lsMessages.Columns(i).Width
        Next

        lsMessages.Columns(lsMessages.Columns.Count - 1).Width = lsMessages.Width - ColLeft - 24
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myTranslator.LoadLanguage("C:\de_german.xml")
        myTranslator.Localize(Me, myTranslator.ReturnParentNodeByName(Me.Name))
        myTranslator.Localize(tvProjectItems, myTranslator.ReturnParentNodeByName(Me.Name))

        If My.Application.CommandLineArgs.Count > 0 Then
            For Each myString As String In My.Application.CommandLineArgs()
                Dim fs As New StreamReader(myString)
                Dim myContent As String = fs.ReadToEnd
                fs.Close()

                Dim myDoc As Document = CreateNewFile()
                myDoc.FileInfo = New FileInfo(myString)


                myDoc.Editor.Text = myContent
                myDoc.Editor.IsChanged = False
                myDoc.Editor.ClearUndo()
                myDoc.Changed = False
                myDoc.Page.Text = myDoc.FileInfo.Name

                tsTabs.SelectedTab = myDoc.Page
            Next
        Else
            CreateNewFile()
        End If


        For Each dummyItem As ToolStripMenuItem In tsMenu.Items
            Dim args As New ToolStripItemClickedEventArgs(dummyItem)

            AddHandler dummyItem.DropDownItemClicked, AddressOf tsMenu_ItemClicked
        Next
    End Sub
#End Region

#Region "Open, Save, New, Load, Close..."
    Private Function CreateNewFile() As Document
        DocCounter += 1

        Dim myTab As New TabPage
        Dim myEditor As New FastColoredTextBox


        myTab.Text = "Unnamed " & DocCounter & "*"
        tsTabs.TabPages.Add(myTab)

        myEditor.Dock = DockStyle.Fill
        myEditor.Margin = New Padding(0)
        myEditor.ClearUndo()
        myEditor.ForeColor = Color.FromArgb(77, 77, 77)

        AddHandler myEditor.TextChanged, AddressOf Editor_TextChanged
        AddHandler myEditor.Load, AddressOf Editor_Load
        AddHandler myEditor.MouseMove, AddressOf Editor_MouseMove
        AddHandler myEditor.MouseDown, AddressOf Editor_MouseDown

        myTab.Controls.Add(myEditor)
        tsTabs.SelectedTab = myTab
        Dim myDoc As New Document(myTab, myEditor)

        myTab.Tag = myDoc
        Documents.Add(myDoc)

        myEditor.Text = "//" & vbCrLf & _
                        "//" & vbTab & "Sketch: Unnamed " & DocCounter & vbCrLf & _
                        "//" & vbTab & "Created: " & Now & vbCrLf & _
                        "//" & vbCrLf & "#![crate_name = """ & "Unnamed" & DocCounter & """]" & vbCrLf & vbCrLf & _
                        "fn main() {" & vbCrLf & vbCrLf & "}" & vbCrLf & vbCrLf

        myEditor.IsChanged = False
        myDoc.Changed = False
        Return myDoc
    End Function

    Private Sub CreateNewProject()
        myProject = New clsProject
        myProject.Changed = True
        myProject.projectName = "Unnamed"

        myProject.projectFiles.Add(New _projectFile("", ""))

        DocCounter = 0
        tsTabs.TabPages.Clear()
        CreateNewTab(0)

    End Sub

    Private Sub CreateNewTab(Optional ByVal itemTag As Object = Nothing)
        DocCounter += 1
        Dim myTab As New TabPage
        myTab.Text = "Unnamed " & DocCounter
        myTab.Tag = itemTag

        tsTabs.TabPages.Add(myTab)

        Dim myEditor As New FastColoredTextBox
        myEditor.Dock = DockStyle.Fill

        myTab.Controls.Add(myEditor)
    End Sub

    Private Sub OpenFile()
        If dlgOpen.ShowDialog = vbOK Then
            Dim fs As New StreamReader(dlgOpen.FileName)
            Dim myString As String = fs.ReadToEnd
            fs.Close()

            Dim myDoc As Document = CreateNewFile()
            myDoc.FileInfo = New FileInfo(dlgOpen.FileName)


            myDoc.Editor.Text = myString
            myDoc.Editor.IsChanged = False
            myDoc.Editor.ClearUndo()
            myDoc.Changed = False
            myDoc.Page.Text = myDoc.FileInfo.Name

            tsTabs.SelectedTab = myDoc.Page
        End If
    End Sub

    Private Sub SaveAllFiles()
        For Each myDoc As Document In Documents

            If myDoc.Changed = True Then
                If myDoc.FileInfo Is Nothing Then
                    SaveFileAs(myDoc)
                Else
                    SaveFile(myDoc)
                End If
            End If
        Next
    End Sub

    Private Sub SaveFile(ByVal myDoc As Document)
        If myDoc.FileInfo Is Nothing Then
            SaveFileAs(myDoc)
        Else
            Dim fs As New StreamWriter(myDoc.FileInfo.FullName, False)
            fs.Write(myDoc.Editor.Text)
            fs.Close()

            myDoc.Page.Text = myDoc.FileInfo.Name

        End If
    End Sub

    Private Sub SaveFileAs(ByVal myDoc As Document)
        If myDoc.FileInfo Is Nothing Then
            dlgSave.FileName = Replace(myDoc.Page.Text, "*", "")
        Else
            dlgSave.FileName = myDoc.FileInfo.Name
        End If

        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New StreamWriter(dlgSave.FileName)
            fs.Write(myDoc.Editor.Text)
            fs.Close()
            myDoc.Changed = False

            Dim myFile As New FileInfo(dlgSave.FileName)
            myDoc.Page.Text = myFile.Name

            myDoc.FileInfo = myFile
        End If
    End Sub

    Private Sub CloseFile(ByVal myDoc As Document)
        If myDoc.Changed = True Then
            Dim erg As MsgBoxResult = MsgBox(" Die Datei wurde verändert. Möchte sie die Änderungen speichern?", vbYesNoCancel + vbQuestion, "Änderungen Speichern?")
            If erg = MsgBoxResult.Yes Then
                SaveFile(myDoc)
            ElseIf erg = vbCancel Then
                Exit Sub
            End If
        End If

        myDoc.Editor.Dispose()
        myDoc.Page.Dispose()

        Documents.Remove(myDoc)
    End Sub

    Private Sub ExitProgramm()
        For Each myDoc As Document In Documents
            If myDoc.Changed = True Then
                Dim erg As MsgBoxResult = MsgBox(" Die Datei wurde verändert. Möchte sie die Änderungen speichern?", vbYesNoCancel + vbQuestion, "Änderungen Speichern?")
                If erg = MsgBoxResult.Yes Then
                    SaveFile(myDoc)
                ElseIf erg = vbCancel Then
                    Exit Sub
                End If
            End If
        Next

        End
    End Sub
#End Region

#Region "Fast Colored Textbox Events & Suff"
    Private Sub Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myEditor As FastColoredTextBox = sender
        myEditor.Language = Language.Custom
        myEditor.LeftPadding = 15

    End Sub

    Private Sub Editor_TextChanged(ByVal sender As Object, ByVal e As FastColoredTextBoxNS.TextChangedEventArgs)
        Dim myDoc As Document = sender.Parent.Tag

        If Not myDoc.FileInfo Is Nothing Then
            myDoc.Page.Text = myDoc.FileInfo.Name & "*"
        End If

        myDoc.Changed = True


        With sender
            .LeftBracket = "("
            .RightBracket = ")"
            .LeftBracket2 = "\x0"
            .RightBracket2 = "\x0"

            'clear style of changed range
            .Range.ClearStyle(KeywordStyle, ConstantStyle, CommentStyle, OperatorStyle, StringStyle, NumberStyle, HyperlinkStyle)

            'hyperlinks
            .Range.SetStyle(HyperlinkStyle, "(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?")

            '/* somecomments */
            .Range.SetStyle(CommentStyle, "//.*$", RegexOptions.Multiline)
            .Range.SetStyle(CommentStyle, "/\*(?>(?:(?>[^*]+)|\*(?!/))*)\*/", RegexOptions.Multiline)
            '//somecomment

            'Escape Chars
            .Range.SetStyle(CommentStyle, "\\(x\\h{2}|[0-2][0-7]{,2}|3[0-6][0-7]?|37[0-7]?|[4-7][0-7]?|.)")

            'sigils
            .range.SetStyle(KeywordStyle, "[&*](?=[a-zA-Z0-9_\(\[\|\""]+)")

            'raw string litertal
            .range.Setstyle(StringStyle, "r(#*)"".*?""(\1)")
            .Range.SetStyle(StringStyle, """(?>(?:(?>[^*]+)|""(?!))*)""", RegexOptions.Multiline)

            'clear folding markers
            .Range.ClearFoldingMarkers()
            'set folding markers
            'start: /(\{|\[)[^\}\]]*$|^\s*(\/\*)/
            'ende: /^[^\[\{]*(\}|\])|^[\s\*]*(\*\/)/
            .Range.SetFoldingMarkers("{", "}") 'allow to collapse brackets block
            .Range.SetFoldingMarkers("\[", "\]") 'allow to collapse brackets block
            'sender.Range.SetFoldingMarkers("(", ")") 'allow to collapse brackets block
            .Range.SetFoldingMarkers("/\*", "\*/") 'allow to collapse comment block
        End With


    End Sub

    Private Function CharIsHyperlink(ByVal myEditor As FastColoredTextBox, ByVal place As Place) As Boolean
        Dim mask = myEditor.GetStyleIndexMask(New Style() {HyperlinkStyle})
        If place.iChar < myEditor.GetLineLength(place.iLine) Then
            If (myEditor(place).style And mask) <> 0 Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Sub Editor_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        'Dim p = sender.PointToPlace(e.Location)

        'If CharIsHyperlink(sender, p) Then
        '    sender.Cursor = Cursors.Hand
        'Else : e()

        'sender.Cursor = Cursors.IBeam
        'End If
    End Sub

    Private Sub Editor_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim p = sender.PointToPlace(e.Location)
        If CharIsHyperlink(sender, p) Then
            Dim url = sender.GetRange(p, p).GetFragment("[\S]").Text
            Process.Start(url)
        End If
    End Sub
#End Region


#Region "Menu & Co"

#End Region

    Private Sub txtRustLookup_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRustLookup.GotFocus
        Dim myFont As Font = New System.Drawing.Font(txtRustLookup.Font.Name, txtRustLookup.Font.SizeInPoints, FontStyle.Regular)
        txtRustLookup.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
        txtRustLookup.Font = myFont
        txtRustLookup.Text = ""
    End Sub

    Private Sub txtRustLookup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRustLookup.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim mySearchText As String = myTranslator.GetValueByPath("/language/frmMain/txtRustLookup")

            If Not sender.text = mySearchText Then
                Process.Start("http://doc.rust-lang.org/std/index.html?search=" & txtRustLookup.Text)
            End If
        End If
    End Sub

    Private Sub txtRustLookup_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRustLookup.LostFocus
        Dim myFont As Font = New System.Drawing.Font(txtRustLookup.Font.Name, txtRustLookup.Font.SizeInPoints, FontStyle.Italic)
        txtRustLookup.ForeColor = Color.FromKnownColor(KnownColor.WindowFrame)
        txtRustLookup.Font = myFont
        txtRustLookup.Text = myTranslator.GetValueByPath("/language/frmMain/txtRustLookup")

    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub


    Private Sub tsTools_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsTools.ItemClicked
        Dim myDoc As Document = Nothing

        Try
            myDoc = tsTabs.SelectedTab.Tag

        Catch
        End Try
        Dim btnClicked As ToolStripItem = e.ClickedItem
        Select Case True
            Case btnClicked Is btnNew
                CreateNewFile()
            Case btnClicked Is btnOpenFile
                OpenFile()
            Case btnClicked Is btnSaveFile
                SaveFile(myDoc)
            Case btnClicked Is mnuSaveAllFiles
                SaveAllFiles()
            Case btnClicked Is btnCut
                myDoc.Editor.Cut()
            Case btnClicked Is btnCopy
                myDoc.Editor.Copy()
            Case btnClicked Is btnPaste
                myDoc.Editor.Paste()
            Case btnClicked Is btnUndo
                myDoc.Editor.Undo()
            Case btnClicked Is btnComments
                myDoc.Editor.CommentSelected()
        End Select
    End Sub

    Private Sub tsMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tsMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsMenu.ItemClicked
        Dim myDoc As Document = Nothing
        Dim mnuClicked As ToolStripItem = e.ClickedItem

        Try
            myDoc = tsTabs.SelectedTab.Tag
        Catch ex As Exception

        End Try
        Select Case True
            Case mnuClicked Is mnuCreateNewFile
                CreateNewFile()
            Case mnuClicked Is mnuOpenFile
                OpenFile()
            Case mnuClicked Is mnuCloseFile
                CloseFile(myDoc)
            Case mnuClicked Is mnuSaveFile
                SaveFile(myDoc)
            Case mnuClicked Is mnuSaveFileAs
                SaveFileAs(myDoc)
            Case mnuClicked Is mnuSaveAllFiles
                SaveAllFiles()
            Case mnuClicked Is mnuExit
                ExitProgramm()
            Case mnuClicked Is mnuUndo
                myDoc.Editor.Undo()
            Case mnuClicked Is mnuRedo
                myDoc.Editor.Redo()
            Case mnuClicked Is mnuCut
                myDoc.Editor.Cut()
            Case mnuClicked Is mnuCopy
                myDoc.Editor.Copy()
            Case mnuClicked Is mnuPaste
                myDoc.Editor.Paste()
            Case mnuClicked Is mnuDelete
                myDoc.Editor.ClearSelected()
            Case mnuClicked Is mnuSelectAll
                myDoc.Editor.SelectAll()
            Case mnuClicked Is mnuFind
                myDoc.Editor.ShowFindDialog()
            Case mnuClicked Is mnuReplace
                myDoc.Editor.ShowReplaceDialog()
        End Select
    End Sub

    Private Sub tsTabs_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tsTabs.MouseUp
        Try
            If e.Button = MouseButtons.Right Then
                For tabIndex As Integer = 0 To tsTabs.TabCount - 1
                    If tsTabs.GetTabRect(tabIndex).Contains(e.Location) Then
                        tsTabs.SelectedIndex = tabIndex
                        MsgBox(tsTabs.TabPages(tabIndex).Text)
                    End If
                Next
            End If
        Catch ex As Exception
            ErrorHandler(ex, "TabMouseUp")
        End Try
    End Sub

    Public Sub ErrorHandler(ByVal ex As Exception, Optional ByVal strIdentifier As String = "Error")
        MsgBox(ex.Message, vbExclamation + vbOKOnly, strIdentifier)
    End Sub

    Private Sub mnuSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSerial.Click
        'mnuSerialDevice.DropDownItems.Add()

        mnuSerialDevice.DropDownItems.Clear()

        Dim mySearcher As New Management.ManagementObjectSearcher("root\cimv2", "SELECT * FROM Win32_SerialPort")
        For Each myObject As ManagementObject In mySearcher.Get
            Dim mnuItem As New ToolStripMenuItem(CStr(myObject("Name")))
            mnuItem.Tag = CStr(myObject("Port"))
            mnuSerialDevice.DropDownItems.Add(mnuItem)

            mnuItem.Width = mnuItem.GetPreferredSize(mnuSerialDevice.Size).Width

        Next


    End Sub

    Private Sub txtRustLookup_Click(sender As Object, e As EventArgs) Handles txtRustLookup.Click

    End Sub

    Private Sub mnuSaveFileAs_Click(sender As Object, e As EventArgs) Handles mnuSaveFileAs.Click

    End Sub

    Private Sub dlgSave_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgSave.FileOk

    End Sub

    Private Sub btnBuildRun_Click(sender As Object, e As EventArgs) Handles btnBuildRun.Click
        Dim compileWrapper As New CompilerWrapper
        Dim compilerOutput As CompilerWrapper.SCompilerOutput

        Dim myProcess As Process = New Process()


        Dim myDoc As Document = Nothing

        Try
            runProcess.Kill()
        Catch
        End Try


        myDoc = tsTabs.SelectedTab.Tag
        SaveFile(myDoc)

        compilerOutput = compileWrapper.Compile(myDoc.FileInfo.DirectoryName & "\" & myDoc.FileInfo.Name)

        lsMessages.Items.Clear()
        For Each myMessage As CompilerWrapper.SCompilerMessage In compilerOutput.Messages
            Dim myItem As New ListViewItem

            Select Case myMessage.MessageType
                Case CompilerWrapper.SCompilerMessage.ECompilerMessageType.MessageAdditional
                Case CompilerWrapper.SCompilerMessage.ECompilerMessageType.MessageError : myItem.Text = "Error" : myItem.ForeColor = Color.Red : myItem.ImageKey = "error"
                Case CompilerWrapper.SCompilerMessage.ECompilerMessageType.MessageWarning : myItem.Text = "Warning" : myItem.ForeColor = Color.LimeGreen : myItem.ImageKey = "warning"
            End Select

            myItem.SubItems.Add(myMessage.ProblemFile)
            myItem.SubItems.Add(myMessage.ProblemRow)
            myItem.SubItems.Add(myMessage.ProblemCol)
            Dim mySecondItem = myItem.SubItems.Add(myMessage.ProblemMessage)
            mySecondItem.Tag = myMessage.ProblemSnippet




            lsMessages.Items.Add(myItem)
        Next

        If compilerOutput.bSuccessful = True Then
            runProcess = New Process()

            With runProcess.StartInfo
                .UseShellExecute = False
                .FileName = myDoc.FileInfo.DirectoryName & "\" & compilerOutput.Executable
                .WorkingDirectory = myDoc.FileInfo.DirectoryName & "\"
                .WindowStyle = ProcessWindowStyle.Normal
            End With

            runProcess.Start()
        End If


        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try


    End Sub

    Private Function ObtainExecutable(DirInfo1 As DirectoryInfo, DirInfo2 As DirectoryInfo) As FileInfo
        For Each myFile In DirInfo1.EnumerateFiles
            If Not DirInfo2.EnumerateFiles.Contains(myFile) Then
                If myFile.Extension.ToLower = ".exe" Then
                    Return myFile
                    Exit Function
                End If
            End If
        Next

        Return Nothing
    End Function

    Private Sub process_OutputDatReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            processOutput.AppendLine(e.Data)

        End If
    End Sub

    Private Sub process_OutputErrReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            processOutput.AppendLine(e.Data)

            If (e.Data.ToLower.Contains("error")) Then
                bCompileError = True
            End If
        End If
    End Sub

    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click

    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub lsMessages_DoubleClick(sender As Object, e As EventArgs) Handles lsMessages.DoubleClick
        If Not lsMessages.SelectedItems(0) Is Nothing Then
            For Each myDoc As Document In Documents
                Try
                    If myDoc.FileInfo.Name.ToLower = lsMessages.SelectedItems(0).SubItems(1).Text Then
                        myDoc.Editor.Selection.Start = New Place(lsMessages.SelectedItems(0).SubItems(3).Text - 1, lsMessages.SelectedItems(0).SubItems(2).Text - 1)  'New Range(myDoc.Editor,, lsMessages.SelectedItems(0).SubItems(2).Text, lsMessages.SelectedItems(0).SubItems(3).Text)
                        myDoc.Editor.Selection.End = New Place(lsMessages.SelectedItems(0).SubItems(4).Tag.ToString.Length, lsMessages.SelectedItems(0).SubItems(2).Text - 1)

                        myDoc.Editor.CurrentLineColor = Color.FromArgb(100, 210, 210, 255)
                    End If
                Catch
                End Try
            Next
        End If
    End Sub

    Private Sub lsMessages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsMessages.SelectedIndexChanged

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub
End Class
