Imports System.Xml

Public Class Translator
    Public Structure structChildren
        Dim Name As String
        Dim Text As String
    End Structure

    Public Structure structParent
        Dim Name As String
        Dim Title As String
        Dim Children As List(Of structChildren)
    End Structure

    Public Structure structLanguage
        Dim NameShort As String
        Dim NameLong As String
        Dim Children As List(Of structParent)
    End Structure

    Public Language As structLanguage
    Dim myXML As New XmlDocument

    Public Sub New()
        Language = New structLanguage
        Language.Children = New List(Of structParent)

    End Sub

    Public Function AddParent(ByVal Name As String, ByVal Titel As String) As structParent
        Dim myParent As New structParent
        myParent.Name = Name
        myParent.Title = Titel
        myParent.Children = New List(Of structChildren)

        Language.Children.Add(myParent)
        Return myParent
    End Function

    Public Function AddChildren(ByVal Parent As structParent, ByVal Name As String, ByVal Text As String) As structChildren
        Dim myChild As New structChildren
        myChild.Name = Name
        myChild.Text = Text

        Parent.Children.Add(myChild)
        Return myChild
    End Function

    Public Function ReturnParentNodeByName(ByVal Name As String) As structParent
        For Each myParent As structParent In Language.Children
            If LCase(myParent.Name) = LCase(Name) Then
                Return myParent
                Exit Function
            End If
        Next

        Return Nothing
    End Function

    Public Function GetValueByPath(ByVal strPath As String) As String
        Dim strReturn As String = myXML.SelectNodes(strPath)(0).InnerText
        Return strReturn
    End Function

    Private Function ReturnText(ByVal ParentNode As structParent, ByVal Name As String) As String
        For Each myNode As structChildren In ParentNode.Children
            If LCase(myNode.Name) = LCase(Name) Then
                Return myNode.Text
                Exit Function
            End If
        Next

        Return ""
    End Function

    Private Function HasProperty(ByVal myObject As Object, ByVal myProperty As String) As Boolean
        Dim myType As Type = myObject.GetType

        If myType.GetProperty(myProperty) IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Localize(ByVal FirstObject As Object, ByVal ParentNode As structParent) As Boolean
        Try
            If HasProperty(FirstObject, "Controls") = True Then
                For Each myObj As Object In FirstObject.Controls
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If
        Catch
        End Try
        Try

            If HasProperty(FirstObject, "Items") = True Then
                For Each myObj As Object In FirstObject.Items
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If

            If HasProperty(FirstObject, "DropDownItems") = True Then
                For Each myObj As Object In FirstObject.DropDownItems
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If


            If HasProperty(FirstObject, "Nodes") = True Then
                For Each myObj As Object In FirstObject.Nodes
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If

            If (HasProperty(FirstObject, "Panel1") = True) Then
                For Each myObj As Object In FirstObject.Panel1.Controls
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If

            If (HasProperty(FirstObject, "Panel2") = True) Then
                For Each myObj As Object In FirstObject.Panel2.Controls
                    Localize(myObj, ParentNode)

                    Dim strTrans As String = ReturnText(ParentNode, myObj.Name)
                    If Not strTrans = "" Then
                        myObj.Text = strTrans
                    End If
                    'Debug.Print(myObj.Name)
                Next
            End If

            If FirstObject.GetType.Name.ToLower = LCase(FirstObject.Name) Then
                FirstObject.Text = ParentNode.Title

            End If


            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation + vbOKOnly)
            Return False
        End Try
    End Function

    Public Sub LoadLanguage(ByVal strFilename As String)
        Try

            myXML.Load(strFilename)


            Language.NameShort = myXML.SelectNodes("/language").Item(0).Attributes("short").Value
            Language.NameLong = myXML.SelectNodes("/language").Item(0).Attributes("name").Value

            For Each myParentXml As XmlNode In myXML.SelectNodes("/language/*")
                Dim myParent As Translator.structParent = AddParent(myParentXml.Name, myParentXml.Attributes("title").Value)

                For Each myChildXml As XmlNode In myXML.SelectNodes("/language/" & myParentXml.Name & "/*")
                    Dim myChild As Translator.structChildren = AddChildren(myParent, myChildXml.Name, myChildXml.InnerText)

                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class