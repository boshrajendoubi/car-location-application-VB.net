Imports System.IO
Public Class bmw
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Dim fs1 As FileStream
    Dim sw1 As StreamWriter
    Dim sr1 As StreamReader


    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click


        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\bmw.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox4.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker1.Text = "") Or (DateTimePicker2.Text = "") Then

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
                If (t(0) = Label6.Text) And (ComboBox4.Text = t(1)) And (CDate(t(2)) < DateTimePicker1.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox4.Text + "#" + Label6.Text + "#" + ComboBox4.Text + "#" + DateTimePicker1.Text + "#" + DateTimePicker7.Text + "#" + prix.Text)
                TextBox4.Text = ""
                ComboBox4.Text = ""
                DateTimePicker1.Text = ""
                DateTimePicker2.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox4.Focus()
                TextBox4.Text = ""
                ComboBox4.Text = ""
                DateTimePicker1.Text = ""
                DateTimePicker7.Text = ""
            End If

        End If
        sw1.Close()
        sr.Close()
        fs.Close()
        fs1.Close()
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

    Private Sub DateTimePicker7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker7.ValueChanged

        Dim prixbmwx1 As Integer
        prixbmwx1 = 180
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker1.Value.Date, DateTimePicker7.Value.Date)
        prix.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            prix.Text = ((CInt(ch) + 1) * 68 + prixbmwx1) * CInt(TextBox4.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        DateTimePicker7.Visible = True
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        DateTimePicker5.Visible = True
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        DateTimePicker6.Visible = True
    End Sub

    Private Sub prix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prix.TextChanged

    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

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

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker6.ValueChanged
        Dim prixbmwx2 As Integer
        prixbmwx2 = 180
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker5.Value.Date, DateTimePicker6.Value.Date)
        prix.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            prix.Text = ((CInt(ch) + 1) * 68 + prixbmwx2) * CInt(TextBox3.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\bmw.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (ComboBox1.Text = "") Or (DateTimePicker5.Text = "") Or (DateTimePicker6.Text = "") Or (TextBox3.Text = "") Then

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
                If (t(0) = Label7.Text) And (ComboBox1.Text = t(1)) And (CDate(t(2)) < DateTimePicker5.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox3.Text + "#" + Label7.Text + "#" + ComboBox1.Text + "#" + DateTimePicker5.Text + "#" + DateTimePicker6.Text + "#" + TextBox7.Text)
                TextBox3.Text = ""
                ComboBox1.Text = ""
                DateTimePicker5.Text = ""
                DateTimePicker6.Text = ""
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

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim x As Integer
        x = CInt(TextBox1.Text)
        If (x < 0) Or (x > 9) Then
            Beep()
            TextBox1.Text = ""
            MsgBox("le nombre doit etre un chiffre", vbInformation, "attention")
        End If
    End Sub

    Private Sub DateTimePicker8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker8.ValueChanged
        Dim prixbmwx6 As Integer
        prixbmwx6 = 180
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker2.Value.Date, DateTimePicker8.Value.Date)
        TextBox6.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            prix.Text = ((CInt(ch) + 1) * 70 + prixbmwx6) * CInt(TextBox1.Text)
        ElseIf (CInt(ch) + 1 < 0) Then
            Beep()
            MsgBox("la durée est invalide, veuillez vérifier", vbInformation, "attention")
        ElseIf (CInt(ch) + 1 > 60) Then
            MsgBox("la durée choisie ne doit pas dépasser 60 jours")
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        fs1 = New FileStream("D:\projet\la commande.txt", FileMode.Append, FileAccess.Write)
        sw1 = New StreamWriter(fs)
        fs = New FileStream("D:\projet\bmw.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox1.Text = "") Or (ComboBox2.Text = "") Or (DateTimePicker2.Text = "") Or (DateTimePicker8.Text = "") Then

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
                If (t(0) = Label15.Text) And (ComboBox2.Text = t(1)) And (CDate(t(2)) < DateTimePicker2.Text) Then
                    trouve = True
                Else
                    trouve = False
                End If
            End While
            If trouve = True Then
                sw1.WriteLine(TextBox1.Text + "#" + Label15.Text + "#" + ComboBox2.Text + "#" + DateTimePicker2.Text + "#" + DateTimePicker8.Text + "#" + TextBox6.Text)
                TextBox1.Text = ""
                ComboBox2.Text = ""
                DateTimePicker2.Text = ""
                DateTimePicker8.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox1.Focus()
                TextBox1.Text = ""
                ComboBox2.Text = ""
                DateTimePicker2.Text = ""
                DateTimePicker8.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()
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

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged
        Dim prixbmwix As Integer
        prixbmwix = 180
        Dim ch As String
        ch = DateDiff(DateInterval.Day, DateTimePicker3.Value.Date, DateTimePicker4.Value.Date)
        prix.Text = ""
        If ((CInt(ch) + 1 > 0) And (CInt(ch) + 1 < 31)) Then
            prix.Text = ((CInt(ch) + 1) * 68 + prixbmwix) * CInt(TextBox5.Text)
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
        fs = New FileStream("D:\projet\bmw.txt", FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        If (TextBox2.Text = "") Or (ComboBox4.Text = "") Or (DateTimePicker1.Text = "") Or (DateTimePicker2.Text = "") Then

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
                ComboBox3.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            Else
                Beep()
                MsgBox(" cette voiture est non disponible ", vbInformation, "Attention!")
                TextBox2.Focus()
                TextBox2.Text = ""
                ComboBox3.Text = ""
                DateTimePicker3.Text = ""
                DateTimePicker4.Text = ""
            End If

        End If
        sw1.Close()
        fs1.Close()
        sr.Close()
        fs.Close()
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        Me.Hide()
        renault.Show()

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click
        Me.Hide()
        renault.Show()
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click
        Me.Hide()
        ford.Show()

    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click
        Me.Hide()
        renault.Show()

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

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        DateTimePicker1.Visible = True
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        DateTimePicker2.Visible = True
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        DateTimePicker8.Visible = True
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click
        DateTimePicker3.Visible = True
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click
        DateTimePicker4.Visible = True
    End Sub

    Private Sub Accueil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accueil.Click
        Me.Hide()
        valider.Show()

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
         Me.Hide()
        modifiercommande.Show()
    End Sub
End Class