Public Class Document
    Private _Editor As FastColoredTextBoxNS.FastColoredTextBox
    Public Property Editor() As FastColoredTextBoxNS.FastColoredTextBox
        Get
            Return _Editor
        End Get
        Set(ByVal value As FastColoredTextBoxNS.FastColoredTextBox)
            _Editor = value
        End Set
    End Property

    Private _Page As TabPage
    Public Property Page() As TabPage
        Get
            Return _Page
        End Get
        Set(ByVal value As TabPage)
            _Page = value
        End Set
    End Property

    Private _Changed As Boolean
    Public Property Changed() As Boolean
        Get
            Return _Changed
        End Get
        Set(ByVal value As Boolean)
            _Changed = value
        End Set
    End Property

    Private _FileInfo As IO.FileInfo
    Public Property FileInfo() As IO.FileInfo
        Get
            Return _FileInfo
        End Get
        Set(ByVal value As IO.FileInfo)
            _FileInfo = value
        End Set
    End Property

    Public Sub New(ByVal tPage As TabPage, ByVal eEditor As FastColoredTextBoxNS.FastColoredTextBox)
        _Page = tPage
        _Editor = eEditor
        _Changed = True

    End Sub
End Class
