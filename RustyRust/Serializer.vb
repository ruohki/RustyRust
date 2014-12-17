Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.IO.Compression

Public Class Serializer
    Public Shared Sub Serialize(Of T)(ByVal compression As Boolean, _
      ByVal path As String, ByVal instance As T)

        Try
            Dim fs As Stream = New FileStream(path, FileMode.Create)
            Dim bf As New BinaryFormatter
            If compression Then fs = New GZipStream(fs, CompressionMode.Compress)

            bf.Serialize(fs, instance)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub Serialize(Of T)(ByVal path As String, ByVal instance As T)
        Serialize(False, path, instance)
    End Sub

    Public Shared Function DeSerialize(Of T)(ByVal compression As Boolean, _
      ByVal path As String, ByVal defaultInstance As T) As T

        Try
            If Not File.Exists(path) Then
                Return defaultInstance
            End If
            Dim fs As Stream = New FileStream(path, FileMode.OpenOrCreate)
            Dim bf As New BinaryFormatter
            If compression Then fs = New GZipStream(fs, CompressionMode.Decompress)

            DeSerialize = CType(bf.Deserialize(fs), T)
            fs.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shared Function DeSerialize(Of T)(ByVal path As String, _
      ByVal defaultInstance As T) As T

        Return DeSerialize(Of T)(False, path, defaultInstance)
    End Function

    Public Shared Function DeSerialize(Of T As New)(ByVal path As String) As T
        Return DeSerialize(Of T)(path, New T)
    End Function

    Public Shared Function DeSerialize(Of T As New)( _
      ByVal compression As Boolean, ByVal path As String) As T

        Return DeSerialize(Of T)(compression, path, New T)
    End Function
End Class