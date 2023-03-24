
Class StreamWriter

    Private _fs As IO.FileStream

    Sub New(ByVal fs As IO.FileStream)
        ' TODO: Complete member initialization 
        _fs = fs
    End Sub

    Sub WriteLine(ByVal cl As String)
        Throw New NotImplementedException
    End Sub

    Sub Flush()
        Throw New NotImplementedException
    End Sub

    Sub Close()
        Throw New NotImplementedException
    End Sub

End Class
