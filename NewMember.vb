Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class NewMember
    'Section MySQL
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"


    'END Section MySQL

    'Section boolean_controllers
    Dim x_status As String = "Veri yok"
    Dim xbool As Boolean

    'END Section boolean_controllers
    Private Sub button_add_Click(sender As Object, e As EventArgs) Handles button_add.Click
        if text_No.text.Contains(" ") Then
            text_No.text = text_no.text.replace(" ", "")
        End If
        If text_No.Text.Length < 2 Or text_Name.Text.Length < 2 Or text_Surname.Text.Length < 2 Or combo_Class.SelectedItem = "Seçiniz..." Then
            warnTime.Start()
            Dialog("NewMember-empty_area", "Yeni eklenecek üye için lütfen gerekli alanları doldurunun. Bu Bilgiler; Ad, Soyad, Sınıf ve Okul Numarasıdır.")
        Else
            Dim vtX As New MySqlConnection(db_credentials)
            Dim comX As New MySqlCommand
            Dim drX As MySqlDataReader
            Try


                vtX.Open()
                comX.Connection = vtX
                comX.CommandText = "SELECT * FROM members WHERE No= '" & text_no.text.tostring & "'"
                comX.ExecuteNonQuery()
                drX = comX.ExecuteReader

                If drX.HasRows Then
                    Dialog("NewMember-UserExist", "")

                Else
                    insertData(text_No.Text, text_Name.Text, text_Surname.Text, combo_Class.SelectedItem.ToString(), x_status, text_Contact.Text)
                End if
            Catch ex as Exception
            Finally
                vtX.Dispose()
            End Try

        End If
    End Sub
     Function hasher(ByVal x As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(x))
        Dim output_hbr As New StringBuilder()
        For i As Integer = 0 To result.Length - 1
            output_hbr.Append(result(i).ToString("x2"))
        Next
        Return output_hbr.ToString.TrimEnd()
    End Function
    Function Dialog(data As String, help_message As String)
        My.Settings.dialog = data
        My.Settings.dialog_help = help_message
        dialog_box.Close()
        dialog_box.show()
    End Function
    Function insertData(x As String, y As String, z As String, a As String, b As String, c As String)
        Try
            Dim db As New MySqlConnection(db_credentials)
            Dim cmd As New MySqlCommand
            db.Open()
            cmd.Connection = db
             Dim time_now As String = dashboard.pdate.Value.ToString("dd-MM-yyyy") & " / " & dashboard.lTime.Text.ToString
            Dim hash As String = hasher(x & " | " & time_now)
            cmd.CommandText = "INSERT INTO members (No,Adı,Soyadı,Sınıf,Durum,İletişim,hash) VALUES ('" & x & "','" & y & "','" & z & "','" & a & "','" & b & "','" & c & "','" & hash & "')"
            cmd.ExecuteNonQuery()
            btn_clear.PerformClick()

            warn_status.ForeColor = Color.MediumAquamarine
            warn_status.Text = "Üye Başarıyla Eklendi!"

            warnTime.Start()
            Dialog("NewMember-success", "Yeni üye başarıyla eklendi!")
        Catch ERR As Exception
            warn_status.ForeColor = Color.Crimson
            warn_status.Text = "Üye Eklenemedi. HATA!"
            Dialog("NewMember-error", "Üye kayıt edilirken bir hataya rastlandı! lütfen Geliştiriciye başvurunuz.")
            warnTime.Start()
        End Try

    End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles button_redirect_memberList.Click
        dashboard.MemberList.PerformClick()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        text_Name.Text = ""
        text_Surname.Text = ""
        text_No.Text = ""
        combo_Class.SelectedItem = "Seçiniz..."
        text_Contact.Text = ""
    End Sub

    Private Sub warnTime_Tick(sender As Object, e As EventArgs) Handles warnTime.Tick
        warnTime.Stop()
        warn_data.Visible = False
        warn_status.Visible = False
    End Sub

    Private Sub text_No_TextChanged(sender As Object, e As EventArgs) Handles text_No.TextChanged

    End Sub

    Private Sub text_No_KeyDown(sender As Object, e As KeyEventArgs) Handles text_No.KeyDown

    End Sub

    Private Sub text_No_KeyUp(sender As Object, e As KeyEventArgs) Handles text_No.KeyUp

    End Sub
    Private Sub text_No_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_No.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub NewMember_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_Class.SelectedItem = "Seçiniz..."
    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub
End Class
