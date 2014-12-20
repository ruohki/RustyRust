Imports System.Threading
Imports System.IO
Module modMain

    Sub Main()
        Dim strCommandline As String = ""

        Try

            For Each myString As String In My.Application.CommandLineArgs
                strCommandline &= myString & " "
            Next

            Dim myProcess As New Process
            Dim myFile As New FileInfo(My.Application.CommandLineArgs(0))

            With myProcess.StartInfo

                .FileName = strCommandline
                .WorkingDirectory = myFile.DirectoryName
            End With
            myProcess.Start()
            myProcess.WaitForExit()

            Console.WriteLine("Program exited with code: " & myProcess.ExitCode)
            Console.ReadLine()
        Catch

        End Try
    End Sub

End Module
