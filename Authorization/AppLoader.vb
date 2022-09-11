Imports System.Net.NetworkInformation
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO
Imports System.Text
Public Class AppLoader
    Dim app_version As String = My.Settings.version.ToString
    Dim version_status As String
    Dim web_version As String
     Dim application_path As String = Application.StartupPath() & "\"
    Dim result_update As Boolean
    Dim result_configFile As Boolean
    Dim update_link As String
    Dim Configration_Update As Boolean
    Private Sub btnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        If update_link = "" or update_link = "null" Or update_link = "NULL" Then
            Else
            Process.Start(update_link)
        End If
        
    End Sub
   Public Async Function CheckForUpdates() As Task
                 System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        checkingText.Visible = True     
        Await Task.Run(Sub()
                      If My.Computer.Network.IsAvailable = True Then
              Try
                  Dim base As String = "https://api.hbacker.dev/"
        Dim baseModule As String = "application/library_system/update_check.php"
        Dim key As String = "HBR"
        Try        
            Dim GETx As String
            Dim url As String = base & baseModule
           GETx = url + "?application_version=" +  app_version _
                   + "&key=" + key
           Console.WriteLine("WEB Request[update_check.php]: " + GETx.ToString())            
                        ServicePointManager.Expect100Continue = true
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
          Try
            Dim webClient As New Net.WebClient
     
            Dim web_output As String = webClient.DownloadString(GETx)
            'BEGIN Json Parse
            Dim json_web As JObject = JObject.Parse(web_output.TrimEnd)     
            'END Json Parge
             
            version_status = json_web.SelectToken("status")
                                          
            web_version = json_web.SelectToken("latest_version")
            
            update_link = json_web.SelectToken("download")

            Console.Writeline(web_output.TrimEnd)
         
          Catch ex As Exception
Console.WriteLine(ex.Message)
                                           group_update.text = "Sunucu Kaynaklı bir HATA meydana geldi. Lütfen Daha Sonra Tekrar Deneyiniz."
          End Try
                                          
Catch ex As Exception
             update_text.Visible = True
            update_text.Text = "Internet Bağlantısı Mevcut Değil!"  
             End Try
    Catch ex As Exception
              update_text.Visible = True
               update_text.Text = "Internet Bağlantısı Mevcut Değil!!"                                 
    End Try
                Else
                update_text.Visible = True
           update_text.Text = "Internet Bağlantısı Mevcut Değil!"
            End If
           checkingText.Visible = False
                          
                 End Sub)
   
     If version_status = "200" Then
           update_status("200")
            Else
           update_status("426")
       End If
End Function
    Function update_status(status_code As String)
        If status_code = "200" Then
             btnUPDATE.Text = "En Son Sürüme Güncelle"
             btnUPDATE.Visible = False
           
              update_text.Visible = True
              update_text.Text = "En Son Sürümü Kullanıyorsunuz!"
            result_update = True
            Else
           update_text.Visible = False
             update_text.Text = ""
            btnUPDATE.Visible = True
            btnUPDATE.Text = "En Son Sürüme Güncelle" & "[" & web_version & "]"
             result_update = False
             

        End If
    End Function
     Function config_status(status As String)
        If status = "OK" Then
            configText.Text = "    Konfigürasyon Dosyası Doğrulandı!"
            
            Else
           configText.Text = " Konfigürasyon Dosyası Doğrulanmadı!"
            Dialog("AppLoader-ConfigFileMissing","Uygulama, Çalışırken Veritabanı ve Web İşlemleri yürütmek için Sunuculara belirli Komut Dizeleri gönderir ve Bu Komutların doğru adreslere gitmesi ya da bazı Kimlik Doğrulamaları geçmesi gerekmektedir işte bu gibi Veriler Konfigürasyon dosyasında saklanır ve Uygulamanın buna ihtiyacı vardır.")
            Me.Hide
            configuration.Show
        End If
    End Function
    Function CheckTheConfigFile()
         If System.IO.File.Exists(application_path & "config.json") = True Then
             result_configFile = True
           ConfigurationUPDATE
            Else
             result_configFile = False
                config_status("FAIL")
         End If
    End Function
    Function ConfigurationUPDATE
         Try
            Dim json_path As String = File.ReadAllText(application_path & "config.json")
           Dim json As JObject = JObject.Parse(json_path)
            'BEGIN Update_Strings
         My.Settings.sqlhost = json.SelectToken("db_server")
         My.Settings.sqluser = json.SelectToken("db_userid")
         My.Settings.sqlpwd = json.SelectToken("db_password")
         My.Settings.sqldb = json.SelectToken("db_name")

         My.Settings.api_url = json.SelectToken("api_url")
         My.Settings.api_key = json.SelectToken("api_key")   
              
            'END Update_Strings
            My.Settings.Save
            Console.WriteLine("Application Configration Updated! " & vbNewLine & json_path.ToString)
          
        Catch ex As Exception
            Console.WriteLine("ERROR(UPDATE CONFIGS); " & vbNewLine & ex.Message)
            Configration_Update = False
            Finally
            If My.Settings.sqlhost = "" Or My.Settings.sqluser = "" Or My.Settings.sqldb = "" Or My.Settings.api_url = "" Or My.Settings.api_key = "" Then
                 Configration_Update = False
                config_status("FAIL")
                Dialog("AppLoader-ConfigFileMissing","Uygulama, Çalışırken Veritabanı ve Web İşlemleri yürütmek için Sunuculara belirli Komut Dizeleri gönderir ve Bu Komutların doğru adreslere gitmesi ya da bazı Kimlik Doğrulamaları geçmesi gerekmektedir işte bu gibi Veriler Konfigürasyon dosyasında saklanır ve Uygulamanın buna ihtiyacı vardır.")
                
                configuration.Show
               
            Else
                config_status("OK")
                Configration_Update = True
            End If
        End Try    
              
    End Function
    Private Sub AppLoader_Load(sender As Object, e As EventArgs) Handles Me.Load
        versionText.Text = My.Settings.version.ToString
                Task.Delay(500)
           CheckForUpdates
   CheckTheConfigFile
    End Sub

     Function Dialog(data As String, help_message As String)      
       
 My.Settings.dialog = data
        My.Settings.dialog_help = help_message     
                      
       dialog_box.Close()
        dialog_box.show()
    End Function


    Private Sub checkStatus_Tick(sender As Object, e As EventArgs) Handles checkStatus.Tick
        If result_update = True And result_configFile = True And Configration_Update = True Then
            Me.Hide
            checkStatus.Stop
            Login_Panel.Show
            Else

        End If
    End Sub

    Public Function GET_Dialog(dialogGET As Boolean)
        If dialogGET = True Then
            restarter.Start
            Else

        End If
        End Function
Private Sub restarter_Tick(sender As Object, e As EventArgs) Handles restarter.Tick
        restarter.Stop
        Application.Restart
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Application.Exit
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
     
    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs) 
      
    End Sub
End Class