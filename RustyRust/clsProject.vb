Imports System.IO
Imports System.Runtime.Serialization

<Serializable()> _
Public Structure _projectFile
    Public FileName As String
    Public FilePath As String
    Public Changed As Boolean

    <NonSerialized()> _
    Public WindowID As Object

    Public Sub New(ByVal fname As String, ByVal fpath As String)
        FileName = fname
        FilePath = fpath
        Changed = True
    End Sub
End Structure

<Serializable()> _
Public Class clsProject
    Public projectName As String
    Public projectFiles As New List(Of _projectFile)

    <NonSerialized()> _
    Public Changed As Boolean


    Public Sub Save(ByVal filename As String)
        Serializer.Serialize(Of clsProject)(True, filename, Me)
    End Sub

    Public Shared Function Load(ByVal filename As String) As clsProject
        Return Serializer.DeSerialize(Of clsProject)(True, filename)
    End Function
End Class
