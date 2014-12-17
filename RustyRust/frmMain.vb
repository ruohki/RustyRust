Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Management
Imports System.Drawing
Imports System.Threading
Imports System.Text

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


        sender.LeftBracket = "("
        sender.RightBracket = ")"
        sender.LeftBracket2 = "\x0"
        sender.RightBracket2 = "\x0"
        'clear style of changed range
        sender.Range.ClearStyle(KeywordStyle, ConstantStyle, CommentStyle, OperatorStyle, StringStyle, NumberStyle, HyperlinkStyle)

        'hyperlinks
        sender.Range.SetStyle(HyperlinkStyle, "(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?")


        'comment highlighting
        sender.Range.SetStyle(CommentStyle, "//.*$", RegexOptions.Multiline)
        sender.Range.SetStyle(CommentStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
        sender.Range.SetStyle(CommentStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)


        'function
        sender.Range.SetStyle(KeywordStyle, "\b(fn)(\s+)([a-zA-Z_][a-zA-Z0-9_][\w\:,+ \'<>]*)(\s*\()")
        'token: "keyword.source.rust",
        sender.Range.SetStyle(KeywordStyle, "\b(?:as|assert|break|claim|const|copy|Copy|do|drop|else|extern|fail|for|if|impl|in|let|log|loop|match|mod|module|move|mut|Owned|priv|pub|pure|ref|return|unchecked|unsafe|use|while|mod|Send|static|trait|class|struct|enum|type)\b")

        'string highlighting
        sender.Range.SetStyle(StringStyle, """.+?""")
        sender.Range.SetStyle(StringStyle, "(\"".*?\"")|(\"".*)", RegexOptions.Singleline)
        sender.Range.SetStyle(StringStyle, "(\"".*?\"")|(.*\"")", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        'Keywords1 Arduino
        '
        'token: "variable.other.source.rust",
        sender.range.setstyle(StringStyle, "'[a-zA-Z_][a-zA-Z0-9_]*'")
        'token: "storage.type.source.rust",
        sender.Range.SetStyle(KeywordStyle, "\b(?:Self|m32|m64|m128|f80|f16|f128|int|uint|float|char|bool|u8|u16|u32|u64|f32|f64|i8|i16|i32|i64|str|option|either|c_float|c_double|c_void|FILE|fpos_t|DIR|dirent|c_char|c_schar|c_uchar|c_short|c_ushort|c_int|c_uint|c_long|c_ulong|size_t|ptrdiff_t|clock_t|time_t|c_longlong|c_ulonglong|intptr_t|uintptr_t|off_t|dev_t|ino_t|pid_t|mode_t|ssize_t)\b")
        'token: "keyword.operator",
        sender.Range.SetStyle(OperatorStyle, "/!|\$|\*|\-\-|\-|\+\+|\+|-->|===|==|=|!=|!==|<=|>=|<<=|>>=|>>>=|<>|<|>|!|&&|\|\||\?\:|\*=|/=|%=|\+=|\-=|&=|\^=|,|;")
        'token: "support.constant",
        sender.range.setstyle(ConstantStyle, "\b[a-zA-Z_][\w\d]*::")
        'token: "variable.language.source.rust",
        sender.range.setstyle(ConstantStyle, "\bself\b")
        'token: "support.constant.source.rust",
        sender.range.setstyle(ConstantStyle, "\b(?:EXIT_FAILURE|EXIT_SUCCESS|RAND_MAX|EOF|SEEK_SET|SEEK_CUR|SEEK_END|_IOFBF|_IONBF|_IOLBF|BUFSIZ|FOPEN_MAX|FILENAME_MAX|L_tmpnam|TMP_MAX|O_RDONLY|O_WRONLY|O_RDWR|O_APPEND|O_CREAT|O_EXCL|O_TRUNC|S_IFIFO|S_IFCHR|S_IFBLK|S_IFDIR|S_IFREG|S_IFMT|S_IEXEC|S_IWRITE|S_IREAD|S_IRWXU|S_IXUSR|S_IWUSR|S_IRUSR|F_OK|R_OK|W_OK|X_OK|STDIN_FILENO|STDOUT_FILENO|STDERR_FILENO)\b")
        'token: "meta.preprocessor.source.rust",
        sender.range.setstyle(OperatorStyle, "\b\w\(\w\)*!|#\[[\w=\(\)_]+\]\b")
        'token: "constant.language.source.rust",
        sender.range.setstyle(ConstantStyle, "\b(?:true|false|Some|None|Left|Right|Ok|Err)\b")
        'token: "constant.numeric.integer.source.rust",
        sender.range.setstyle(NumberStyle, "\b(?:[0-9][0-9_]*|[0-9][0-9_]*(?:u|u8|u16|u32|u64)|[0-9][0-9_]*(?:i|i8|i16|i32|i64))\b")
        'token: "constant.numeric.hex.source.rust",
        sender.range.setstyle(NumberStyle, "\b(?:0x[a-fA-F0-9_]+|0x[a-fA-F0-9_]+(?:u|u8|u16|u32|u64)|0x[a-fA-F0-9_]+(?:i|i8|i16|i32|i64))\b")
        'token: "constant.numeric.binary.source.rust",
        sender.range.setstyle(NumberStyle, "\b(?:0b[01_]+|0b[01_]+(?:u|u8|u16|u32|u64)|0b[01_]+(?:i|i8|i16|i32|i64))\b")
        'token: "constant.numeric.float.source.rust",
        sender.range.setstyle(NumberStyle, "[0-9][0-9_]*(?:f32|f64|f)|[0-9][0-9_]*[eE][+-]=[0-9_]+|[0-9][0-9_]*[eE][+-]=[0-9_]+(?:f32|f64|f)|[0-9][0-9_]*\.[0-9_]+|[0-9][0-9_]*\.[0-9_]+(?:f32|f64|f)|[0-9][0-9_]*\.[0-9_]+%[eE][+-]=[0-9_]+|[0-9][0-9_]*\.[0-9_]+%[eE][+-]=[0-9_]+(?:f32|f64|f)")
        'token: "constant.character.escape.source.rust",
        sender.range.setstyle(CommentStyle, "\\(?:x[\da-fA-F]{2}|[0-2][0-7]{,2}|3[0-6][0-7]?|37[0-7]?|[4-7][0-7]?|.)")

        'clear folding markers
        sender.Range.ClearFoldingMarkers()
        'set folding markers
        'start: /(\{|\[)[^\}\]]*$|^\s*(\/\*)/
        'ende: /^[^\[\{]*(\}|\])|^[\s\*]*(\*\/)/
        sender.Range.SetFoldingMarkers("{", "}") 'allow to collapse brackets block
        sender.Range.SetFoldingMarkers("\[", "\]") 'allow to collapse brackets block
        'sender.Range.SetFoldingMarkers("(", ")") 'allow to collapse brackets block
        sender.Range.SetFoldingMarkers("/\*", "\*/") 'allow to collapse comment block


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
        Dim p = sender.PointToPlace(e.Location)
        If CharIsHyperlink(sender, p) Then
            sender.Cursor = Cursors.Hand
        Else
            sender.Cursor = Cursors.IBeam
        End If
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
        Dim PATH As String = Environment.GetEnvironmentVariable("")
        Dim myProcess As Process = New Process()


        Dim myDoc As Document = Nothing

        Try
            runProcess.Kill()
        Catch
        End Try

        Try
            myDoc = tsTabs.SelectedTab.Tag
            SaveFile(myDoc)

            bCompileError = False

            With myProcess.StartInfo
                .UseShellExecute = False
                .FileName = "rustc"
                .Arguments = "-o " & myDoc.FileInfo.Name.Remove(myDoc.FileInfo.Name.Length - myDoc.FileInfo.Extension.Length) & " " & myDoc.FileInfo.Name
                .WorkingDirectory = myDoc.FileInfo.DirectoryName & "\"
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .RedirectStandardInput = True
                .CreateNoWindow = True
                .WindowStyle = ProcessWindowStyle.Normal
            End With
            AddHandler myProcess.OutputDataReceived, AddressOf process_OutputDatReceived
            AddHandler myProcess.ErrorDataReceived, AddressOf process_OutputErrReceived
            processOutput.Clear()

            myProcess.Start()
            myProcess.BeginOutputReadLine()
            myProcess.BeginErrorReadLine()
            myProcess.WaitForExit()

            txtOutput.Text = processOutput.ToString

            If bCompileError = False Then
                runProcess = New Process()

                With runProcess.StartInfo
                    .UseShellExecute = False
                    .FileName = myDoc.FileInfo.FullName.Remove(myDoc.FileInfo.FullName.Length - myDoc.FileInfo.Extension.Length) & ".exe"
                    .WorkingDirectory = myDoc.FileInfo.DirectoryName & "\"
                    .WindowStyle = ProcessWindowStyle.Normal
                End With
                runProcess.Start()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


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
End Class
