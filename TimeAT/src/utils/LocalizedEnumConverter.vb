Imports San.Utils

Namespace utils
    Public Class LocalizedEnumConverter
        Inherits ResourceEnumConverter

        Public Sub New(ByVal type As Type)
            MyBase.New(type, My.Resources.ResourceManager)
        End Sub
    End Class
End Namespace