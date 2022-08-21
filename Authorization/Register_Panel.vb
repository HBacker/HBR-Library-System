Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.WebUtility
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Public Class Register_Panel
    Shared random As New Random()
    Dim version_app As String = "3.0.0"
    Dim version_ui As String = "4.0.0"
    Dim nv1 As String
    Dim nv2 As String
    Dim nv3 As String
   dim zaman As String= System.DateTime.Now.ToString("dd.MM.yyyy")
   dim saat as string = System.DateTime.Now.ToString("HH:mm:ss")
    Dim nv4 As String
    Dim nV As String
    Dim identity As String
    Dim ip_data As String
    Dim veritabanı As New MySqlConnection("server=localhost;userid=root;password=;database=library;port=3306;SslMode=None;charset=utf8;")
    Dim komut As New MySqlCommand
    Dim okuyucu As MySqlDataReader

    Dim veritabanı2 As New MySqlConnection("server=localhost;userid=root;password=;database=library;port=3306;SslMode=None;charset=utf8;")
    Dim komut2 As New MySqlCommand
    Dim okuyucu2 As MySqlDataReader

    Dim veritabanı3 As New MySqlConnection("server=localhost;userid=root;password=;database=library;port=3306;SslMode=None;charset=utf8;")
    Dim komut3 As New MySqlCommand
    Dim okuyucu3 As MySqlDataReader
    Public Function idverify() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        'çıktı
        identity = DriveSerial.ToString
        Return DriveSerial.ToString("X2")

    End Function
    Sub hata_rc()
        block.Visible = True
        error_box.Text = "HATA >> " & "reCaptcha"
        error_desc.Text = "hatalı reCaptcha kodu."
    End Sub
    Sub hata_cr()
        block.Visible = True
        error_box.Text = "HATA >> " & "Kayıt Bilgileri"
        error_desc.Text = "     Üzgünüz, Böyle bir 
     Yetkili zaten mevcut!"
    End Sub
    Sub hata_empty()
        block.Visible = True
        error_box.Text = "HATA >> " & "Eksik veya Hatalı Kayıt Bilgileri"
        error_desc.Text = "Eksik veya hatalı bilgiler."
    End Sub
    Sub success()

    End Sub


    Sub kayıt_ol()
        Dim perm As String = "0"

         nVerifer()
        If username.Text = "" Or password.Text = "" Or auth_name.Text = "" Then
            hata_empty()
            Else
            If username.Text.Length < 6 Or password.Text.Length < 6 Or auth_name.Text.Length < 6 Then
                hata_empty
                Else
                
            If username.Text.Contains(" ") Then
                username.Text = username.Text.Replace(" ", "")
            Else

            End If

            'sORGU
            Try
                veritabanı2.Open()
                veritabanı3.Open()
                veritabanı.Open()

                komut.Connection = veritabanı
                komut2.Connection = veritabanı2
                komut3.Connection = veritabanı3




                komut2.CommandText = "SELECT kullaniciAdi FROM yetkililer WHERE kullaniciAdi = '" & username.Text & "'"
                komut2.ExecuteNonQuery()
                okuyucu2 = komut2.ExecuteReader

                If okuyucu2.HasRows Then
                    hata_cr()
                Else
                  
                        Try


                            If level_standart.Checked = True Then
                            perm = "1"
                            Else
                            perm = "2"
                            End If
                            Dim encode_pw As String = encrypt_hbr(password.Text)
                            komut.CommandText = "INSERT INTO yetkililer (yetkili,kullaniciAdi,Sifre,kayitTarihi,yetki) VALUES ('" & auth_name.Text & "','" & username.Text & "','" & encode_pw & "','" & zaman.ToString & " - " & saat.ToString & "','" & perm.ToString & "')"
                            register.Text = "Eklendi!"
                            komut.ExecuteNonQuery()
                           
                           
                            wc1.Start()
                        Catch ex_mailer As Exception
                        MsgBox(ex_mailer.Message)
                            MsgBox("Oops! kayıt sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz. 'Lütfen Sistem Yöneticisi ile irtibata geçiniz. hbryzen@gmail.com'")
                            register.Enabled = True
                  
                        End Try

                End If

            Catch ex_sql As Exception
                MsgBox("Oops! kayıt sırasında bir hata oluştu, lütfen daha sonra tekrar deneyiniz. 'Lütfen Sistem Yöneticisi ile irtibata geçiniz. hbryzen@gmail.com'")
               MsgBox(ex_sql.Message)
                    register.Enabled = True
            End Try
        End If
            End If
        
           

        veritabanı.Dispose()
        veritabanı2.Dispose()
        veritabanı3.Dispose()

        username.Enabled = True
        auth_name.Enabled = True
        password.Enabled = True
        level_standart.Enabled = True
        level_high.Enabled = True
        register.Enabled = True
        If register.Text = "Eklendi!"Then
            event_locker
            Else
            event_unlocker
        End If
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) 
        
    End Sub
    Sub event_register_button
        Try
      
                veritabanı.Dispose()
                veritabanı2.Dispose()
                veritabanı3.Dispose()

                If kod1.Text + kod2.Text + kod3.Text + kod4.Text = nV.ToString Then
                    register.Enabled = False
                    username.Enabled = False
                    auth_name.Enabled = False
                    password.Enabled = False
                level_high.Enabled = False
                level_standart.Enabled = False
                    kayıt_ol()

                Else
                    nVerifer()
                    hata_rc()
                End If

        Catch ex As Exception
            block.Visible = True
            error_box.Text = "HATA >> " & "Yürütme Hatası"
            error_desc.Text = "Oops, Komutlar Yürütülürken
bir HATA Meydana geldi.
(hata yeri: ex.reg_Ebtn)"

        End Try


    End Sub
 

    Private Sub giris_yap_Click(sender As Object, e As EventArgs) 
        nVerifer()
        Me.Close()
        
    End Sub
    Sub event_locker
        register.Text = "Tamamlandı!"
        register.Image = My.Resources.Resources.approval_96px
        auth_name.Text = ""
        password.Text = ""
        username.Text = ""
        auth_name.Enabled = False
        password.Enabled = False
        username.Enabled = False
        level_standart.Checked = True
        level_high.Checked = False
        level_high.Enabled = False
        level_standart.Enabled = False
        nVerifer
        kod1.Enabled = False
        kod2.Enabled = False
        kod3.Enabled = False
        kod4.Enabled = False
        register.Enabled = False
    End Sub
    Sub event_unlocker
        register.Text = "Ekle"
        register.Image = My.Resources.Resources.forward_96px
        auth_name.Enabled = True
        password.Enabled = True
        username.Enabled = True
        level_standart.Checked = True
        level_high.Checked = False
        level_high.Enabled = True
        level_standart.Enabled = True
        nVerifer
        kod1.Enabled = True
        kod2.Enabled = True
        kod3.Enabled = True
        kod4.Enabled = True
        register.Enabled = True
    End Sub

    Private Sub Kullanıcı_Kayıt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth_name.Select
        nVerifer()
        idverify()
       
    End Sub
    Public Function vRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(2, 8)
    End Function
    Public Function vRandom2(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 6)
    End Function
    Public Function vRandom3(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(3, 9)
    End Function
    Public Function vRandom4(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 5)
    End Function
    Sub nVerifer()
         kod1.Text = ""
        kod2.Text = ""
        kod3.Text = ""
        kod4.Text = ""
        nv1 = vRandom(2, 8)
        nv2 = vRandom2(1, 6)
        nv3 = vRandom3(3, 9)
        nv4 = vRandom4(1, 5)
        n1.Text = nv1.ToString
        n2.Text = nv2.ToString
        n3.Text = nv3.ToString
        n4.Text = nv4.ToString
        nV = nv1 + nv2 + nv3 + nv4

    End Sub


    Private Sub kod1_KeyDown(sender As Object, e As KeyEventArgs) Handles kod1.KeyDown
        kod2.Text = ""
        kod2.Select()
    End Sub

    Private Sub kod2_KeyDown(sender As Object, e As KeyEventArgs) Handles kod2.KeyDown
        kod3.Text = ""
        kod3.Select()
    End Sub

    Private Sub kod3_KeyDown(sender As Object, e As KeyEventArgs) Handles kod3.KeyDown
        kod4.Text = ""
        kod4.Select()
    End Sub

    Private Sub kod4_KeyDown(sender As Object, e As KeyEventArgs) Handles kod4.KeyDown
        piyon.Text = ""
        piyon.Select()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) 
       
    End Sub
    Sub event_ok
         nVerifer()
        password.Text = ""
        block.Visible = False
    End Sub

    Private Sub w3_Tick(sender As Object, e As EventArgs) Handles wc1.Tick
       
        wc2.Start()
        wc1.Stop()
    End Sub



    Private Sub wc2_Tick(sender As Object, e As EventArgs) Handles wc2.Tick
       
        wc1.Start()
        wc2.Stop()
    End Sub

    Private Sub header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click
        Me.Close()
        
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       zaman = System.DateTime.Now.ToString("dd.MM.yyyy")
   saat = System.DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        event_locker
        Me.Hide

    End Sub

    Function encrypt_hbr(ByVal x As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(x))
        Dim output_hbr As New StringBuilder()
        For i As Integer = 0 To result.Length - 1
            output_hbr.Append(result(i).ToString("x2"))
        Next
        Return output_hbr.ToString.TrimEnd()
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        event_ok
    End Sub

    Private Sub login_Click_1(sender As Object, e As EventArgs) Handles register.Click
        event_register_button
    End Sub

    Private Sub btnContact_Click(sender As Object, e As EventArgs) Handles btnNew.Click
     event_unlocker
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dialog("NewAuth-help_button", "[1] Ad Soyad, Kullanıcı adı veya Şifre yazarken minimum 6 karakter içerdiğinden emin olun aksi takdirde kayıt alınmaz! [2] Kullanıcı adına sahip maksimum 1 Yetkili bulunabilir. [3] Herhangi bir sorunda lütfen Sistem Yöneticisine başvurunuz.")
    End Sub
    Function Dialog(data As String, help_message As String)
        My.Settings.dialog = data
        My.Settings.dialog_help = help_message
        dialog_box.Close()
        dialog_box.show()
    End Function
End Class