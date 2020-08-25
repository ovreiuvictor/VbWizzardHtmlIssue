Public Class Equipment
    Private descriptionValue As String
    Public Property Description() As String
        Get
            Return descriptionValue
        End Get
        Set(ByVal value As String)
            descriptionValue = value
        End Set
    End Property

    Private symbolValue As String
    Public Property Symbol() As String
        Get
            Return symbolValue
        End Get
        Set(ByVal value As String)
            symbolValue = value
        End Set
    End Property
End Class
