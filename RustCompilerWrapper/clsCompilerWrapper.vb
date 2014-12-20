Imports System.Threading
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions


Public Class CompilerWrapper
    Public Class SCompilerMessage
        Public Enum ECompilerMessageType
            MessageError = 0
            MessageWarning = 1
            MessageAdditional = 2

        End Enum

        Public RawMessage As String
        Public MessageType As ECompilerMessageType
        Public ProblemFile As String
        Public ProblemRow As UInteger
        Public ProblemCol As UInteger
        Public ProblemSnippet As String
        Public ProblemMessage As String
    End Class

    Public Enum ECompilerMessageType
        MessageError = 0
        MessageWarning = 1
        MessageAdditional = 2

    End Enum

    Public Class SCompilerOutput
        Public bSuccessful As Boolean
        Public Messages As List(Of SCompilerMessage)
        Public Executable As String

        Public CompileTimeMilliseconds As Long
    End Class

    Private Shared CompilerBinary As String = ""
    Private Shared bCompileError As Boolean = False
    Private Shared compilerOutput As New SCompilerOutput

    Private Shared processOutput As New StringBuilder
    Private Shared obtainBinaryNames As Boolean = False

    Public Sub New()
        CompilerBinary = GetCompilerPath()

        If CompilerBinary = vbNullString Then
        Else
            CompilerBinary &= "\rustc.exe"
        End If
    End Sub

    Public Sub New(strPathToBinary As String)
        CompilerBinary = strPathToBinary

    End Sub

    Public Function Compile(ByVal strFile As String, Optional strOptionalArgs As String = "") As SCompilerOutput
        Dim compilerProcess As New Process
        Dim filetoCompile As New FileInfo(strFile)

        compilerOutput = New SCompilerOutput
        compilerOutput.Messages = New List(Of SCompilerMessage)()

        processOutput.Clear()
        bCompileError = False
        obtainBinaryNames = False

        Dim TimeElapsed As Stopwatch = Stopwatch.StartNew

        With compilerProcess.StartInfo
            .CreateNoWindow = True
            .UseShellExecute = False
            .FileName = CompilerBinary
            .WorkingDirectory = filetoCompile.DirectoryName & "\"
            .Arguments = strFile & " " & strOptionalArgs
            .RedirectStandardError = True
            .RedirectStandardOutput = True
        End With

        AddHandler compilerProcess.OutputDataReceived, AddressOf process_OutputDatReceived
        AddHandler compilerProcess.ErrorDataReceived, AddressOf process_OutputErrReceived
        processOutput.Clear()

        compilerProcess.Start()
        compilerProcess.BeginOutputReadLine()
        compilerProcess.BeginErrorReadLine()
        compilerProcess.WaitForExit()

        If Not bCompileError Then
            compilerProcess = New Process
            obtainBinaryNames = True

            With compilerProcess.StartInfo
                .CreateNoWindow = True
                .UseShellExecute = False
                .FileName = CompilerBinary
                .WorkingDirectory = filetoCompile.DirectoryName & "\"
                .Arguments = strFile & " --print-file-name"
                .RedirectStandardOutput = True
            End With

            AddHandler compilerProcess.OutputDataReceived, AddressOf process_OutputDatReceived
            processOutput.Clear()

            compilerProcess.Start()
            compilerProcess.BeginOutputReadLine()
            compilerProcess.WaitForExit()

            compilerOutput.Executable = Split(processOutput.ToString, vbCrLf, 2)(0)
        End If

        TimeElapsed.Stop()
        compilerOutput.CompileTimeMilliseconds = TimeElapsed.ElapsedMilliseconds

        compilerOutput.bSuccessful = Not bCompileError

        Return compilerOutput
    End Function


    Private Sub process_OutputDatReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            If obtainBinaryNames Then
                processOutput.AppendLine(e.Data)
            End If
        End If
    End Sub

    Private Sub process_OutputErrReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then

            Dim outputData As New SCompilerMessage
            outputData.RawMessage = e.Data

            If Regex.Match(e.Data, "^[ ].*").Success = True Then
                Exit Sub
            End If

            Select Case Regex.Match(e.Data, "(?<= )((error)|(warning))(?=\:)").ToString.ToLower
                Case "error"
                    outputData.MessageType = ECompilerMessageType.MessageError
                    bCompileError = True

                Case "warning"
                    outputData.MessageType = ECompilerMessageType.MessageWarning
                Case Else
                    If Regex.Match(e.Data, "^(error):[ ]").Success = True Then
                        outputData.MessageType = ECompilerMessageType.MessageError
                        compilerOutput.Messages.Add(outputData)
                        Exit Sub

                    Else
                        Try
                            Dim lastMessage As SCompilerMessage = compilerOutput.Messages.Last()

                            outputData.MessageType = ECompilerMessageType.MessageAdditional

                            compilerOutput.Messages.Last.ProblemSnippet = Regex.Match(e.Data, "(?<=((.+).rs(?=\:)(\:\d+)[ ])).*").Value
                        Catch
                        End Try
                    End If
            End Select

            If Not (outputData.MessageType = ECompilerMessageType.MessageAdditional) Then

                Dim strRowCol As String() = Split(Regex.Match(e.Data, "(?<=\:)(\d+:\d+)").Value, ":")
                outputData.ProblemRow = strRowCol(0)
                outputData.ProblemCol = strRowCol(1)

                Dim strFile As String = Regex.Match(e.Data, "(.+).rs(?=\:)").Value
                Try
                    Dim myFile As New FileInfo(strFile)

                    outputData.ProblemFile = myFile.Name
                Catch
                    outputData.ProblemFile = strFile
                End Try


                Dim strMessage As String = Regex.Match(e.Data, "(?<=((?<= )((error)|(warning))(?=\:))\:\ ).*").Value
                outputData.ProblemMessage = strMessage

                compilerOutput.Messages.Add(outputData)
            End If
        End If
    End Sub

    Private Function GetCompilerPath() As String
        Dim strEnvironmentVar As String = Environment.GetEnvironmentVariable("PATH")

        For Each myString As String In Split(strEnvironmentVar, ";")
            If (myString.ToLower.Contains("rust/bin") Or myString.ToLower.Contains("rust\bin")) Then
                Return myString
                Exit Function
            End If
        Next

        Return vbNullString

    End Function

End Class
