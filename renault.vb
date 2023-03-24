Imports System.IO
Public Class renault
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader


     
    Private Sub renault_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs1)
        fs = New FileStream("D:\projet\renault.txt", FileMode.Open, FileAccess.Write)
        sr = New StreamReader(fs)























        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click

    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click

    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        Me.Hide()
        bmw.Show()

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        Me.Hide()
        ford.Show()

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        Me.Hide()
        ford.Show()

    End Sub

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged

        Dim prixbmwx1 As Integer
        prixbmwx1 = 100
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        TextBox5.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox5.Text = ((CInt(ch) + 1) * 50 + prixbmwx1) * CInt(TextBox2.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\renault.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox2.Text = "") Or (ComboBox3.Text = "") Or (DateTimePicker3.Text = "") Or (DateTimePicker4.Text = "") Then

            Beep()
            MsgBox("les données sont incorrectes", vbInformation, "attention")
        Else
            Dim p As String
            Dim t() As String
            Dim trouve As Boolean
            trouve = False
            While sr.Peek > -1

                p = sr.ReadLine()
                t = p.Split("#")
                If (t(0) = Label25.Text) And (ComboBox3.Text = t(1)) And (CDate(t(2)) < DateTimePicker3.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox2.Text + "#" + Label25.Text + "#" + ComboBox3.Text + "#" + DateTimePicker3.Text + "#" + DateTimePicker4.Text + "#" + TextBox5.Text)
                TextBox2.Text = ""
                ComboBox2.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox2.Focus()
                TextBox2.Text = ""
                ComboBox2.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim x As Integer
        x = CInt(TextBox6.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox6.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim x As Integer
        x = CInt(TextBox2.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox2.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim x As Integer
        x = CInt(TextBox8.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox8.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim x As Integer
        x = CInt(TextBox3.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox3.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker5.ValueChanged

        Dim prixrenault As Integer
        prixrenault = 100
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        TextBox4.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox4.Text = ((CInt(ch) + 1) * 68 + prixrenault) * CInt(TextBox6.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub DateTimePicker7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker7.ValueChanged

        Dim prixbmwx1 As Integer
        prixbmwx1 = 100
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        TextBox7.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox7.Text = ((CInt(ch) + 1) * 50 + prixbmwx1) * CInt(TextBox8.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Dim prixbmwx1 As Integer
        prixbmwx1 = 100
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        TextBox1.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox1.Text = ((CInt(ch) + 1) * 68 + prixbmwx1) * CInt(TextBox8.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\renault.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox6.Text = "") Or (ComboBox2.Text = "") Or (DateTimePicker6.Text = "") Or (DateTimePicker5.Text = "") Then

            Beep()
            MsgBox("les données sont incorrectes", vbInformation, "attention")
        Else
            Dim p As String
            Dim t() As String
            Dim trouve As Boolean
            trouve = False
            While sr.Peek > -1

                p = sr.ReadLine()
                t = p.Split("#")
                If (t(0) = Label32.Text) And (ComboBox2.Text = t(1)) And (CDate(t(2)) < DateTimePicker6.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox6.Text + "#" + Label32.Text + "#" + ComboBox2.Text + "#" + DateTimePicker6.Text + "#" + DateTimePicker5.Text + "#" + TextBox4.Text)
                TextBox6.Text = ""
                ComboBox2.Text = ""
                DateTimePicker6.Text = ""
                DateTimePicker5.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox6.Text = ""
                ComboBox2.Text = ""
                DateTimePicker6.Text = ""
                DateTimePicker5.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click

        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\renault.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox8.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker8.Text = "") Or (DateTimePicker7.Text = "") Then

            Beep()
            MsgBox("les données sont incorrectes", vbInformation, "attention")
        Else
            Dim p As String
            Dim t() As String
            Dim trouve As Boolean
            trouve = False
            While sr.Peek > -1

                p = sr.ReadLine()
                t = p.Split("#")
                If (t(0) = Label39.Text) And (ComboBox4.Text = t(1)) And (CDate(t(2)) < DateTimePicker8.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox8.Text + "#" + Label39.Text + "#" + ComboBox4.Text + "#" + DateTimePicker8.Text + "#" + DateTimePicker7.Text + "#" + TextBox7.Text)
                TextBox8.Text = ""
                ComboBox4.Text = ""
                DateTimePicker8.Text = ""
                DateTimePicker7.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox4.Focus()
                TextBox8.Text = ""
                ComboBox4.Text = ""
                DateTimePicker8.Text = ""
                DateTimePicker7.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\renault.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox3.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker1.Text = "") Or (DateTimePicker2.Text = "") Then

            Beep()
            MsgBox("les données sont incorrectes", vbInformation, "attention")
        Else
            Dim p As String
            Dim t() As String
            Dim trouve As Boolean
            trouve = False
            While sr.Peek > -1

                p = sr.ReadLine()
                t = p.Split("#")
                If (t(0) = Label10.Text) And (ComboBox1.Text = t(1)) And (CDate(t(2)) < DateTimePicker2.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox3.Text + "#" + Label10.Text + "#" + ComboBox1.Text + "#" + DateTimePicker2.Text + "#" + DateTimePicker1.Text + "#" + TextBox1.Text)
                TextBox4.Text = ""
                ComboBox4.Text = ""
                DateTimePicker1.Text = ""
                DateTimePicker2.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox4.Focus()
                TextBox3.Text = ""
                ComboBox1.Text = ""
                DateTimePicker1.Text = ""
                DateTimePicker2.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

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


        fs1.Close()
        sw1.Close()
        sr1.Close()
        Me.Hide()
        Bienvenue.Show()

    End Sub

    Private Sub DateTimePicker6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker6.ValueChanged

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        DateTimePicker6.Visible = True
    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click
        DateTimePicker8.Visible = True
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        DateTimePicker5.Visible = True
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        DateTimePicker3.Visible = True
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        DateTimePicker4.Visible = True
    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click
        DateTimePicker7.Visible = True
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        DateTimePicker2.Visible = True
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        DateTimePicker1.Visible = True
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Hide()
        modifiercommande.Show()
    End Sub

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        valider.Show()

    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click

    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click

    End Sub
End Class