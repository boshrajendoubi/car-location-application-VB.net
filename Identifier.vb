Imports System.IO

Public Class Identifier

    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Dim p As String
    Dim t() As String

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inscrire.Click
        Me.Hide()
        Inscription.Show()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Hide()
        Inscription.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        fs = New FileStream("D:\projet\user.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        Dim trouve As Boolean
        trouve = False

        If (TextBox1.Text = "") Or (TextBox3.Text = "") Then
            MessageBox.Show("les coordonnées sont incorrectes")
            TextBox1.Focus()
        Else
            While (sr.Peek() > -1)
                p = sr.ReadLine()
                t = p.Split("#")

                If (t(2) = TextBox2.Text) And (t(1) = TextBox1.Text) Then
                    trouve = True

                Else
                    trouve = False
                End If

            End While

            If trouve = True Then
                Me.Hide()
                etape1.Show()
            Else
                Beep()
                TextBox1.Focus()
                MsgBox("les coordonnées sont incorrectes", vbInformation, "attenion")
            End If
        End If
        sr.Close()
        fs.Close()


    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If Len(TextBox3.Text) < 6 Then
            MsgBox("mot de passe doit depasser 6 caracteres", vbInformation, "Attention")

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Identifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = True
        Else
            TextBox3.UseSystemPasswordChar = False
        End If
    End Sub
End Class