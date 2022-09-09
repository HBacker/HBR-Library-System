Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text

Public Class Login_Panel
    Shared random As New Random()
    Dim version_app As String = "1.0.0"
    Dim version_ui As String = "4.0.0"
     Dim zaman As String = System.DateTime.Now.ToString("dd.MM.yyyy")
     Dim saat As String = System.DateTime.Now.ToString("HH:mm:ss")
    Dim nv1 As String
    Dim nv2 As String
    Dim nv3 As String
    Dim nv4 As String
    Dim nV As String
    Dim ip_data As String = "#bekleniyor#"
     Dim db_string As String = "server=127.0.0.1;username=root;password=;database=library;port=3306;charset=utf8;"
    Dim veritabanı As New MySqlConnection(db_string)
    Dim veritabanı2 As New MySqlConnection(db_string)
   
    Dim okuyucu As MySqlDataReader
    Dim komut As New MySqlCommand
    Dim okuyucu2 As MySqlDataReader
    Dim komut2 As New MySqlCommand

    Dim veritabanı3 As New MySqlConnection(db_string)

    Dim okuyucu3 As MySqlDataReader
    Dim komut3 As New MySqlCommand

    Dim veritabanıban As New MySqlConnection(db_string)

    Dim okuyucuban As MySqlDataReader
    Dim komutban As New MySqlCommand

    Private Sub Kullanıcı_Arayüz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        nVerifer()
       
        kod1.Text = n1.Text
        kod2.Text = n2.Text
        kod3.Text = n3.Text
        kod4.Text = n4.Text
        pw.Text = "admin"
        uname.Text = "admin"
    End Sub
    Public Function vRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 9)
    End Function
    Public Function vRandom2(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(4, 8)
    End Function
    Public Function vRandom3(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(1, 7)
    End Function
    Public Function vRandom4(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(0, 5)
    End Function
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
    Sub nVerifer()
        nv1 = vRandom(1, 9)
        nv2 = vRandom2(2, 8)
        nv3 = vRandom3(3, 9)
        nv4 = vRandom4(0, 5)
        n1.Text = nv1.ToString
        n2.Text = nv2.ToString
        n3.Text = nv3.ToString
        n4.Text = nv4.ToString
        nV = nv1 + nv2 + nv3 + nv4

    End Sub
    Sub hata_ban()
        block.Visible = True
        verify_box.Text = "HATA >> " & "Erişim Sorunu"
        error_desc.Text = "Panele Erişiminiz bulunmamaktadır."
    End Sub
    'BEGIN of Section Giriş

    Sub user_login()
       

        Try
            veritabanı.Open() 'bağlantı start

            komut.Connection = veritabanı
            Dim encode_pw As String = encrypt_hbr(pw.Text)
            komut.CommandText = "SELECT kullaniciAdi, Sifre FROM yetkililer WHERE kullaniciAdi = '" & uname.Text & "' AND Sifre = '" & encode_pw.ToString.Trimend & "'"

            okuyucu = komut.ExecuteReader


           

            Try
                veritabanıban.Open() 'bağlantı start

                komutban.Connection = veritabanıban

                komutban.CommandText = "SELECT kullaniciAdi, yetki FROM yetkililer WHERE kullaniciAdi = '" & uname.Text & "' AND yetki = '" & "0" & "'"

                okuyucuban = komutban.ExecuteReader
                If okuyucuban.HasRows Then
                    hata_ban() 'EVENT: BAN
                    
                Else
                    If okuyucu.HasRows Then
                        'EVENT: Success Login
                        pw.Text = ""
                        nVerifer()
                           Me.Hide
                        dashboard.Show
                     
                        Try
                            veritabanı2.Open()
                            komut2.Connection = veritabanı2

                            komut2.CommandText = "UPDATE yetkililer SET sonHareket = '" & zaman.ToString & " - " & saat.ToString & "' WHERE kullaniciAdi= '" & uname.Text & "'"

                            komut2.ExecuteNonQuery()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Else
                        nVerifer()
                        hata_cr()
                        pw.Text = ""
                      


                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




        Catch ex As Exception
           ' Try
            '    Dim Smtp_Server As New SmtpClient
             '   Dim e_mail As New MailMessage()
              '  Smtp_Server.UseDefaultCredentials = False
             '   Smtp_Server.Credentials = New Net.NetworkCredential("#MAIL_ADDRESS#", "#MAIL_PASSWORD#")
              '  Smtp_Server.Port = 587
               ' Smtp_Server.EnableSsl = True
            '    Smtp_Server.Host = "smtp.yandex.com.tr"
            '
          '      e_mail = New MailMessage()
           '     e_mail.From = New MailAddress("#MAIL_ADDRESS#")
          '      e_mail.To.Add(")
          '      e_mail.Subject = "BUG / HATA # Kullanıcı_Arayüz #"
          '      e_mail.IsBodyHtml = False
          '      e_mail.Body = "Gönderen Nick: " + "Giriş Yapılmamış / " + "'" + uname.Text + "'" + vbNewLine + "Mail: " + "Mail yok." + vbNewLine + "HATA; " + ex.Message + vbNewLine + "ip: " + ip_data.ToString + vbNewLine + "BUG Build Time: " + zaman.ToString
          '      Smtp_Server.Send(e_mail)
        
            Catch error_t As Exception

            End Try
        'End Try
        veritabanı.Dispose()
        veritabanı2.Dispose()
        veritabanıban.Dispose()
        login.Enabled = True
    End Sub
  '  Private Function ip_data_cek() As Net.IPAddress // CANCELLED SECTION: GET_IP
      '  Dim client As New WebClient
      '  client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)")
      '  Dim baseurl As String = "http://checkip.dyndns.org/"
      '  Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
       ' proxy.Credentials = CredentialCache.DefaultNetworkCredentials
      '  client.Proxy = proxy
        'Dim data As Stream
     '   'Try
      '      data = client.OpenRead(baseurl)
       ' Catch ex As Exception
        'End Try
     '   Try
      '      Dim reader As StreamReader = New StreamReader(data)
       '     ip_data = reader.ReadToEnd()
        '    data.Close()
         '   reader.Close()
          '  ip_data = ip_data.Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address:", "").Replace("</body></html>", "").ToString()
 '          ' ip_data = ip_data.Trim
  '      Catch ex As Exception
   '         MsgBox("Program Başlatılırken bir hata oluştu. Lütfen Daha Sonra Tekrar Deneyiniz... (hata yeri: ex.1intP_drw)")
    '    End Try

    'End Function

    Sub hata_rc()
        block.Visible = True
        verify_box.Text = "HATA >> " & "Captcha"
        error_desc.Text = "hatalı Captcha kodu."
    End Sub
    Sub hata_cr()
        block.Visible = True
        verify_box.Text = "HATA >> " & "Giriş Bilgileri"
        error_desc.Text = "Kullanıcı Adı veya Şifre hatalı!"
    End Sub
    'END of Section Giriş
    'Sub go_online() // CANCELLED SECTION: UPDATE-STATUS_ONLINE
       ' Dim veritabanı As New MySqlConnection(db_string)
       ' Dim vcom As New MySqlCommand
       ' Try
        '    veritabanı.Open()
         '   vcom.Connection = veritabanı
         '   vcom.CommandText = "UPDATE kullanıcılar SET status= 'online' WHERE nick= '" & uname.Text & "'"
         '   vcom.ExecuteNonQuery()
         '   veritabanı.Dispose()

 '       Catch ex As Exception

  '      End Try
   ' End Sub
    'Sub go_offline() // CANCELLED SECTION: UPDATE-STATUS_OFFLINE
        'Dim veritabanı As New MySqlConnection(db_string)
       ' Dim vcom As New MySqlCommand
       ' Try
          '  veritabanı.Open()
          '  vcom.Connection = veritabanı
          '  vcom.CommandText = "UPDATE kullanıcılar SET status= 'offline' WHERE nick= '" & uname.Text & "'"
         '   vcom.ExecuteNonQuery()
          '  veritabanı.Dispose()

        'Catch ex As Exception

       ' End Try
   ' End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) 
       
    End Sub
    Sub login_event
         login.Enabled = False

        Try
            veritabanı.Dispose()
            veritabanı2.Dispose()
            veritabanıban.Dispose()
        Catch ex As Exception

        End Try
        If kod1.Text + kod2.Text + kod3.Text + kod4.Text = nV.ToString Then
            user_login()
            

            nVerifer()
        Else
            nVerifer()
            hata_rc()
            kod1.Text = ""
            kod2.Text = ""
            kod3.Text = ""
            kod4.Text = ""
            kod1.Select()

        End If
    End Sub

    Private Sub x2_Click(sender As Object, e As EventArgs)

    End Sub

   

  

    Private Sub GunaTextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        piyon.Text = ""
        piyon.Select()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) 
       

    End Sub
  
    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) Handles header_title.Click

    End Sub

    Private Sub yeni_uye_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        'EVENT: Register Page
    End Sub

    Private Sub header_kapat_Click(sender As Object, e As EventArgs) Handles header_kapat.Click

        Try
          'EVENT: CLOSE
          Application.Exit
        Catch ex As Exception
            Me.Close()
        End Try


    End Sub

    Private Sub block_box_Click(sender As Object, e As EventArgs) Handles block_box.Click

    End Sub

    Private Sub GunaLabel8_Click(sender As Object, e As EventArgs) 
        'EVENT: Contact
    End Sub

    Private Sub Kullanıcı_Arayüz_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        
    End Sub

    Private Sub Kullanıcı_Arayüz_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
       
    End Sub
    Sub arg()
        Dim x As String

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) 
        
    End Sub


    Private Sub Header_Click(sender As Object, e As EventArgs) Handles Header.Click

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs) Handles GunaLabel5.Click

    End Sub

    Private Sub block_Paint(sender As Object, e As PaintEventArgs) Handles block.Paint

    End Sub

    Private Sub header_switcher_Tick(sender As Object, e As EventArgs) Handles header_switcher.Tick
       
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub verify_box_Click(sender As Object, e As EventArgs) Handles verify_box.Click

    End Sub

    Private Sub yeni_uye_Click_1(sender As Object, e As EventArgs) Handles btnContact.Click

    End Sub

    Private Sub login_Click_1(sender As Object, e As EventArgs) 
        login_event
    End Sub

    Private Sub login_Click_2(sender As Object, e As EventArgs) Handles login.Click
        If uname.Text.Contains(" ") Then
            uname.Text = uname.Text.Replace(" ", "")
            Else

        End If
        login_event
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
         nVerifer()
        pw.Text = ""
        block.Visible = False
    End Sub

    Private Sub time_updater_Tick(sender As Object, e As EventArgs) Handles time_updater.Tick
       zaman = System.DateTime.Now.ToString("dd.MM.yyyy")
    saat = System.DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub GunaLabel4_Click(sender As Object, e As EventArgs) Handles GunaLabel4.Click
        Register_Panel.Show
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

    Private Sub GunaLabel9_Click(sender As Object, e As EventArgs) Handles GunaLabel9.Click
        
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        DevDEMO.Show
    End Sub
End Class