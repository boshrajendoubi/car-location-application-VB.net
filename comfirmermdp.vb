Imports System.IO
Public Class comfirmermdp

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        Inscription.Show()
    End Sub

    Public Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim sr As StreamReader
        Dim s As String
        sr = New StreamReader("E:\test\test.txt")
        s = sr.ReadLine
        Do While Not s Is Nothing
            ListBox1.Items.Add(s)
            s = sr.ReadLine

        Loop
        sr.Close()

    End Sub

    Public Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub comfirmermdp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class