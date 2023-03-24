Imports System.IO
Public Class valider

    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader
    Dim cl As String
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Facture.Show()
    End Sub

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        Me.Show()

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

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

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

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox5.Focus()

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And (Len(TextBox5.Text) <> 10) Then
            e.KeyChar = ""
            Me.Hide()
            commandeechec.Show()

        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
       
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And (Len(TextBox5.Text) <> 15) Then
            e.KeyChar = ""
            Me.Hide()
            commandeechec.Show()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub valider_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And (Len(TextBox5.Text) <> 20) Then
            e.KeyChar = ""
            Me.Hide()
            commandeechec.Show()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Me.Hide()
        modifiercommande.Show()
    End Sub
End Class