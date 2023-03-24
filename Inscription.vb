Imports System.IO
Public Class Inscription
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Dim cl As String

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub Inscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Hide()
        Bienvenue.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "") Then
            MessageBox.Show("les données sont incorrectes")
            TextBox1.Focus()
        Else

            fs = New FileStream("D:\projet\user.txt", FileMode.Append, FileAccess.Write)
            sw = New StreamWriter(fs)

            cl = ""
            cl = cl.Insert(Len(cl), TextBox1.Text)
            cl = cl.Insert(Len(cl), "#")
            cl = cl.Insert(Len(cl), TextBox2.Text)
            cl = cl.Insert(Len(cl), "#")
            cl = cl.Insert(Len(cl), TextBox3.Text)
            cl = cl.Insert(Len(cl), "#")
            cl = cl.Insert(Len(cl), TextBox4.Text)
            cl = cl.Insert(Len(cl), "#")
            cl = cl.Insert(Len(cl), TextBox5.Text)
            cl = cl.Insert(Len(cl), "#")
            sw.WriteLine(cl)
            sw.Flush()
            ListBox3.Items.Add(cl)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox1.Focus()

            sw.Close()
            fs.Close()

            Dim j As Integer
            Dim trouve As Boolean
            trouve = False
            Dim p As String
            Dim t() As String

            For j = 0 To ListBox3.Items.Count - 1
                p = ListBox3.Items.Item(j)
                t = p.Split("#")
                If t(1) = TextBox2.Text Then
                    trouve = True
                    MsgBox("cet e-mail est déjà utilisé!", vbInformation, "Attention!")
                    Exit For
                Else
                    trouve = False
                End If
            Next

            If (TextBox3.Text <> TextBox5.Text) Then
                trouve = True
                MsgBox(" veuillez confirmer votre mot de passe")
                TextBox3.Focus()
            Else
                trouve = False
            End If
            If trouve = False Then
                Me.Hide()
                etape1.Show()

            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 91) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120) And Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 32 Then
            Beep()
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 91) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120) And Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 32 Then
            Beep()
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
       

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("Tel doit etre numerique", vbInformation, "Attention")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 91) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120) And Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 32 Then
            Beep()
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged


    End Sub
End Class