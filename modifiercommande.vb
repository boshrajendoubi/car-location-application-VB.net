Imports System.IO
Public Class modifiercommande
    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader
    Dim cl As String
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Hide()
        valider.Show()
    End Sub

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        valider.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Open, FileAccess.Read)
        sr1 = New StreamReader(fs1)

       
        While sr1.Peek > -1
            cl = sr1.ReadLine()
            ListBox1.Items.Add(cl)
        End While

        sr1.Close()
        fs1.Close()

           
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub modifiercommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Dim s As Integer
        s = CInt(TextBox1.Text)
        ListBox1.Items.RemoveAt(s)
        Me.Hide()
        commander.Show()


    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Dim s As Integer
        s = CInt(TextBox1.Text)
        ListBox1.Items.RemoveAt(s)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Deconnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deconnecter.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Open, FileAccess.Read)
        sr1 = New StreamReader(fs1)
        Me.Hide()
        Bienvenue.Show()

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Me.Hide()
        Me.Show()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        

    End Sub
End Class