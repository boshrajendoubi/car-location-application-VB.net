Imports System.IO
Public Class Facture
    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader
    Dim cl As String
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Me.Hide()
        modifiercommande.Show()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Open, FileAccess.Read)
        sr1 = New StreamReader(fs1)
        While sr1.Peek > -1
            cl = sr1.ReadLine()
            ListBox1.Items.Add(cl)

        End While
        fs1.Close()
        sr1.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim t() As String
        Dim i As Integer
        Dim p As String
        TextBox1.Text = "0"
        For i = 0 To ListBox1.Items.Count - 1
            p = ListBox1.Items.Item(i)
            t = p.Split("#")
            TextBox1.Text = CInt(TextBox1.Text) + CInt(t(5))
        Next
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = CInt(TextBox1.Text) * 0.19
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = CInt(TextBox1.Text) * 1.19
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Hide()
        succes.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        succes.Show()
    End Sub

    Private Sub Facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Deconnecter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deconnecter.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs1)
        sr1 = New StreamReader(fs1)
        Me.Hide()
        Bienvenue.Show()
        Dim ch As String
        ch = ""
        While sr1.Peek > -1

            sw1.WriteLine(ch)

        End While
        ListBox1.Items.Clear()

        fs1.Close()
        sw1.Close()
        sr1.Close()
        Me.Hide()
        Bienvenue.Show()

    End Sub

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        valider.Show()

    End Sub
End Class