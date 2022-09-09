Public Class dialog_box
    Dim data As String = my.Settings.dialog
    Dim data_help as String = my.Settings.dialog_help
    Dim ExpandFrom as Boolean
    Private Sub button_bot_Click(sender As Object, e As EventArgs)

    End Sub
   Function dialog(x As String) 
       
                            help_message.Text = "MESAJ AÇIKLAMASI"
        Colormaster.Start()
        If x = "AddBook-empty_area" Then
            title.Text = "Uyarı"
            message.Location = new Point(86, 118)
            message.Text = "Lütfen Zorunlu 
Alanları Boş Bırakmayın!
"
            btnHelp.Enabled = True
        ElseIf x = "AddBook-success" Then
            title.Text = "Mesaj"
            message.Location = New Point(96, 118)
            message.Text = "Kitap Başarıyla Eklendi!"
            btnHelp.Enabled = False
        ElseIf x = "NewMember-success" Then
            title.Text = "Mesaj"
            message.Location = New Point(105, 139)
            message.Text = "Üye Başarıyla Eklendi!"
            btnHelp.Enabled = False
        ElseIf x = "NewMember-error" Then
            title.Text = "Mesaj"
            message.Location = New Point(66, 101)
            message.Text = "Oops!
 Üye Eklenemedi! 
Lütfen Geliştiriciye ulaşınız.
"
            btnHelp.Enabled = True
        elseIf x = "NewMember-empty_area" Then
            title.Text = "Uyarı"
            message.Location = new Point(86, 118)
            message.Text = "Lütfen Zorunlu 
Alanları Boş Bırakmayın!
"
            btnHelp.Enabled = True
        elseIf x = "NewMember-UserExist" Then
            title.Text = "Dikkat"
            message.Location = new Point(120, 148)
            message.Text = "Bu Üye zaten Kayıtlı!"
            btnHelp.Enabled = False
        elseIf x = "BookList-search.404" Then
            title.Text = "Mesaj"
            message.Location = new Point(51, 112)
            message.Text = "Aradığınız kriterlere 
uygun herhangi bir kitap
 kayıtlarda yer almamaktadır

"
            btnHelp.Enabled = False
            elseIf x = "NewAuth-help_button" Then
            title.Text = "Yardım"
            message.Location = new Point(34, 69)
            message.Text = "Ad Soyad, K.Adı ve Şifre alanları
minimum 6 karakter içermelidir.
-
Aynı K.Adı'na sahip maximum
1 Yetkili Bulunabilir"
            btnHelp.Enabled = True

            elseIf x = "Config-success" Then
            title.Text = "Mesaj"
            message.Location = new Point(91, 122)
            message.Text = "Konfigürasyon Dosyası
Başarıyla Yapılandırıldı!"
            btnHelp.Enabled = False
            configuration.Hide
            AppLoader.GET_Dialog(True)
        elseIf x = "MemberList-search.404" Then
            title.Text = "Mesaj"
            message.Location = new Point(151, 141)
            message.Text = "Üye Bulunamadı!
"
            btnHelp.Enabled = False
             elseIf x = "AppLoader-ConfigFileMissing" Then
            title.Text = "Uyarı"
            message.Location = new Point(41, 94)
            message.Text = "Konfigürasyon Dosyanız Eksik!
Yeniden oluşturmak için
Yapılandırıcıya 
Yönlendiriliyorsunuz..."
            btnHelp.Enabled = True
            elseIf x = "BookList-search.404" Then
            title.Text = "Mesaj"
            message.Location = new Point(151, 141)
            message.Text = "Kitap Bulunamadı!
"
            btnHelp.Enabled = False

        Else

        End If
        If btnHelp.Enabled = false Then

        Else
            help_message.Text = data_help.ToString()
        End If
                      
       
    End Function
    Private Sub dialog_box_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dialog(data)
    End Sub
    Sub DefaultDialog
        colorMASTER.Stop()
        btnHelp.Enabled = False
        title.Text = "$Title"
        message.Text = "$Message"
        HELP_message.Text = "MESAJ AÇIKLAMASI"
    End Sub
    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DefaultDialog()
        Me.Close()
    End Sub

    Private Sub colorMASTER_Tick(sender As Object, e As EventArgs) Handles colorMASTER.Tick
        If btnOK.LineColor = Color.FromArgb(4, 175, 175) Then
            btnOK.LineColor = color.FromArgb(66, 58, 170)
        Else
            btnOK.LineColor = color.FromArgb(4, 175, 175)
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        If ExpandFrom = false Then
            ExpandFrom = True
            'EXPAND: YES
            Me.Height = 460
            'EXPAND: YES
        Else
            ExpandFrom = False
            'EXPAND: NO
            Me.Height = 340
            'EXPAND: NO
        End If
    End Sub

    Private Sub message_Click(sender As Object, e As EventArgs) Handles message.Click

    End Sub
End Class