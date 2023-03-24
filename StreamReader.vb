
Class StreamReader

    Private _fs As IO.FileStream

    Sub New(ByVal fs As IO.FileStream)
        ' TODO: Complete member initialization 
        _fs = fs
    End Sub

    Function Peek() As Integer
        Throw New NotImplementedException
    End Function

    Function ReadLine() As String
        Throw New NotImplementedException
    End Function

End Class
