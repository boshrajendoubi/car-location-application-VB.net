Imports System.IO

Public Class ford

    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader


     
    Private Sub ford_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\ford.txt", FileMode.Open, FileAccess.Write)
        sr = New StreamReader(fs)




























        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click

    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        Me.Hide()
        renault.Show()
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click
        Me.Hide()
        bmw.Show()
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

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        valider.Show()

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Hide()
        modifiercommande.Show()

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        Me.Hide()
        valider.Show()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim x As Integer
        x = CInt(TextBox4.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox4.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Dim prixbmwx1 As Integer
        prixbmwx1 = 120
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        TextBox5.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox5.Text = ((CInt(ch) + 1) * 68 + prixbmwx1) * CInt(TextBox4.Text)
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
        fs = New FileStream("D:\projet\ford.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox4.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker3.Text = "") Or (DateTimePicker4.Text = "") Then

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
                If (t(0) = Label25.Text) And (ComboBox4.Text = t(1)) And (CDate(t(2)) < DateTimePicker3.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox4.Text + "#" + Label25.Text + "#" + ComboBox4.Text + "#" + DateTimePicker3.Text + "#" + DateTimePicker4.Text + "#" + TextBox5.Text)
                TextBox4.Text = ""
                ComboBox4.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox4.Focus()
                TextBox4.Text = ""
                ComboBox4.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            End If

        End If
        fs1.Close()
        sw1.Close()
        fs.Close()
        sr.Close()

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

        Dim x As Integer
        x = CInt(TextBox7.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox7.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If


    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

        Dim x As Integer
        x = CInt(TextBox9.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox9.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Dim x As Integer
        x = CInt(TextBox11.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox11.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim prixbmwx1 As Integer
        prixbmwx1 = 100
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        TextBox5.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox5.Text = ((CInt(ch) + 1) * 68 + prixbmwx1) * CInt(TextBox7.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\ford.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (ComboBox5.Text = "") Or (DateTimePicker2.Text = "") Or (DateTimePicker1.Text = "") Or (TextBox7.Text = "") Then

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
                If (t(0) = Label7.Text) And (ComboBox5.Text = t(1)) And (CDate(t(2)) < DateTimePicker2.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox7.Text + "#" + Label7.Text + "#" + ComboBox5.Text + "#" + DateTimePicker2.Text + "#" + DateTimePicker1.Text + "#" + TextBox6.Text)
                TextBox3.Text = ""
                ComboBox1.Text = ""
                DateTimePicker5.Text = ""
                DateTimePicker6.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox3.Focus()
                TextBox7.Text = ""
                ComboBox5.Text = ""
                DateTimePicker2.Text = ""
                DateTimePicker1.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\ford.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (ComboBox6.Text = "") Or (DateTimePicker5.Text = "") Or (DateTimePicker6.Text = "") Or (TextBox9.Text = "") Then

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
                If (t(0) = Label15.Text) And (ComboBox6.Text = t(1)) And (CDate(t(2)) < DateTimePicker5.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox9.Text + "#" + Label15.Text + "#" + ComboBox6.Text + "#" + DateTimePicker5.Text + "#" + DateTimePicker6.Text + "#" + TextBox8.Text)
                TextBox9.Text = ""
                ComboBox6.Text = ""
                DateTimePicker5.Text = ""
                DateTimePicker6.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox9.Focus()
                TextBox9.Text = ""
                ComboBox6.Text = ""
                DateTimePicker5.Text = ""
                DateTimePicker6.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\ford.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (ComboBox7.Text = "") Or (DateTimePicker8.Text = "") Or (DateTimePicker7.Text = "") Or (TextBox11.Text = "") Then

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
                If (t(0) = Label33.Text) And (ComboBox7.Text = t(1)) And (CDate(t(2)) < DateTimePicker8.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox11.Text + "#" + Label33.Text + "#" + ComboBox7.Text + "#" + DateTimePicker8.Text + "#" + DateTimePicker7.Text + "#" + TextBox10.Text)
                TextBox11.Text = ""
                ComboBox7.Text = ""
                DateTimePicker8.Text = ""
                DateTimePicker7.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox3.Focus()
                TextBox3.Text = ""
                ComboBox1.Text = ""
                DateTimePicker5.Text = ""
                DateTimePicker6.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()

    End Sub

    Private Sub DateTimePicker7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker7.ValueChanged
        Dim prixbmwx6 As Integer
        prixbmwx6 = 150
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker8.Value.Date, DateTimePicker7.Value.Date)
        TextBox10.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox10.Text = ((CInt(ch) + 1) * 70 + prixbmwx6) * CInt(TextBox11.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker5.ValueChanged
        Dim prixbmwx6 As Integer
        prixbmwx6 = 140
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker6.Value.Date, DateTimePicker5.Value.Date)
        TextBox6.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox8.Text = ((CInt(ch) + 1) * 70 + prixbmwx6) * CInt(TextBox9.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged
        Dim prixbmwx6 As Integer
        prixbmwx6 = 180
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
        TextBox5.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            TextBox5.Text = ((CInt(ch) + 1) * 70 + prixbmwx6) * CInt(TextBox4.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        DateTimePicker3.Visible = True
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        DateTimePicker4.Visible = True
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        DateTimePicker2.Visible = True
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        DateTimePicker1.Visible = True
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        DateTimePicker6.Visible = True
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        DateTimePicker5.Visible = True
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
        DateTimePicker8.Visible = True
    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click
        DateTimePicker7.Visible = True
    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

    End Sub
End Class

