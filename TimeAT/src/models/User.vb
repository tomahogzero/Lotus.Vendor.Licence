Namespace Model
    Public Class User
        Private _Name As String
        Private _DateOfBirth As Date
        Private _UserType As String
        Private _ComID As String
        Private _UsrID As String

        Public Property UserID() As String
            Get
                Return _UsrID
            End Get
            Set(value As String)
                _UsrID = value
            End Set
        End Property

        'Public ReadOnly Property Name() As String
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(value As String)
                _Name = value
            End Set
        End Property

        Public ReadOnly Property DateOfBirth() As Date
            Get
                Return _DateOfBirth
            End Get
        End Property

        Public Property UserType() As String
            Get
                Return _UserType
            End Get
            Set(value As String)
                _UserType = value
            End Set
        End Property

        Public Property ComID() As String
            Get
                Return _ComID
            End Get
            Set(value As String)
                _ComID = value
            End Set
        End Property

        Public Sub New()

        End Sub

        Public Sub New(ByVal cID As String, ByVal usrId As String, Nm As String, ByVal sType As String)
            _Name = Nm
            _UsrID = usrId
            _ComID = cID
            _UserType = sType
        End Sub
    End Class
End Namespace
