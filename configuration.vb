Imports MySql.Data
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.IO
Public Class configuration
    Dim result_db As String
    Dim result_webAPI As String
    Dim application_path As String = Application.StartupPath() & "\"
    Dim type As Boolean
    Dim success As Boolean
    Private Sub configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbServer.Text = ""
        dbPassword.Text=""
        dbUserID.Text=""
        dbName.Text=""
        webAPI_url.Text=""
        webAPI_key.Text=""
        INSERTFromJSONFileToTextFields
    End Sub

    Private Sub GunaLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub combo_Subject_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Public Class config_credentials
    Public Property db_server As String
    Public Property db_userid As String
    Public Property db_password As String
    Public Property db_name As String

        Public Property api_url As String
    Public Property api_key As String
End Class
    Function LockEvent(eventx As string)
        If  eventx = "lock" Then
            Me.Width = 800
           ' LoaderX.Size = New Point(485, 467)
           ' LoaderX.Location = New Point(12,67)
            LoaderX.Refresh
            loaderX.Visible = True
            dbServer.Enabled = False
            dbUserID.Enabled = False
            dbPassword.Enabled = False
            dbName.Enabled = False
            save.Enabled = False
            Else
            Me.Width = 513
            dbServer.Enabled = True
            dbUserID.Enabled = True
            dbPassword.Enabled = True 
            dbName.Enabled = True
            save.Enabled = True
            loaderX.Visible = False
        End If
        End Function
    Async Function CreateConfig As Task
         System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        LockEvent("lock")
         Dim createConfigFile As IO.StreamWriter
        Await Task.Run(Sub()
                                    Dim credentials As New config_credentials
        credentials.db_server = dbServer.Text
        credentials.db_userid = dbUserID.Text
        credentials.db_password = dbPassword.Text
        credentials.db_name = dbName.Text

        credentials.api_url = webAPI_url.Text
        credentials.api_key = webAPI_key.Text 
                            If System.IO.File.Exists(application_path & "config.json") = True Then
                               System.IO.File.Delete(application_path & "config.json")              
     End If
                           Try
                                 Dim json As String = JsonConvert.SerializeObject(credentials)
                          
                           createConfigFile = My.Computer.FileSystem.OpenTextFileWriter(application_path & "config.json", True)
                        createConfigFile.WriteLine(json)
                               createConfigFile.Close
                               success = True
                           Catch ex As Exception
                               
                           End Try
     
        End Sub)
        If success = True Then
            Dialog("Config-success", "")
            Else
        End If
         LockEvent("unlock")
    End Function
    Function Dialog(data As String, help_message As String)      
       
 My.Settings.dialog = data
        My.Settings.dialog_help = help_message     
                      
       dialog_box.Close()
        dialog_box.show()
    End Function
    Function INSERTFromJSONFileToTextFields
          If System.IO.File.Exists(application_path & "config.json") = True Then
            'BEGIN INSERT_StringsFromCurrentConfigFile
            Try
            Dim json_path As String = File.ReadAllText(application_path & "config.json")
           Dim json As JObject = JObject.Parse(json_path)
           
        dbServer.Text = json.SelectToken("db_server")
       dbUserID.Text =   json.SelectToken("db_userid")
        dbPassword.Text =  json.SelectToken("db_password")
       dbName.Text = json.SelectToken("db_name")
       webAPI_url.Text =  json.SelectToken("api_url")
      webAPI_key.Text =  json.SelectToken("api_key")          
            Catch ex As Exception
            End Try
            Else
           End if
            'END INSERT_StringsFromCurrentConfigFile
    End Function
   
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        log.Text = ""
        If type = True Then
            CreateConfig
            Else
             ConnectionTester
        End If
       
    End Sub
    Function logger(title As String,status As String, message As String)
        log.Text = log.Text & vbNewLine & title & " Sonuç: " & status & vbNewLine & "Çıktı: " & "[" & message & "]"
    End Function
    Async Function ConnectionTester() As Task
               System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        
        LockEvent("lock")
        log.Text = ""
        Await Task.Run(Sub()
            Try
            Dim conn As New MySqlClient.MySqlConnection("server=" & dbServer.Text & ";" & "userid=" & dbUserID.Text & ";" & "pwd=" & dbPassword.Text & ";" & "database=" & dbName.Text & ";port=3306;charset=utf8;SslMode=None;") 
            conn.Open
        logger("Veritabanı Testi","BAŞARILI!","Veritabanı Bağlantısı Başarıyla Tamamlandı.")
                               result_db = "OK"
            Catch ex As Exception
        logger("Veritabanı Testi","BAŞARISIZ!","Veritabanı Bağlantısı Kurulamadı! Lütfen Geçerli Bir Veritabanı Sağlayın." & vbNewLine & ex.Message)
           result_db = "FAIL"
                           End Try
    Try
        log.Text = log.Text & vbNewLine & "_- API Sunucusu Testi Başlatılıyor(getImage.php)"
        Dim base As String = webAPI_url.Text
        Dim baseModule As String = "getImage.php/"
        Dim code As String = My.Settings.code
        Try
             

            Dim GETx As String


            Dim url As String = base & baseModule

            GETx = url + "?image-url=" + "ConfigurationManager" _
                   + "&key=" + webAPI_key.Text
            Console.WriteLine("WEB Request: " + GETx.ToString())
            
                        ServicePointManager.Expect100Continue = true
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
            Dim webClient As New Net.WebClient
     
            Dim web_output As String = webClient.DownloadString(GETx)
            'BEGIN Json Parse
            Dim json_web As JObject = JObject.Parse(web_output.TrimEnd)                     
            'END Json Parge
             Dim webstatus As String = json_web.SelectToken("status")
             If webstatus = "200" Then
         logger("_- API Sunucusu Testi Tamamlandı(getImage.php) -_","BAŞARILI!","API Sunucusu Testi Başarıyla Tamamlandı!")
          result_webAPI = "OK"
                                   Else
        logger("_- API Sunucusu Testi Tamamlandı(getImage.php) -_","BAŞARISIZ!","API Sunucusu ile Bağlantı Kurulamadı! Lütfen Yapılandırma Ayarlarını Kontrol ediniz." & vbNewLine & "Web çıktısı doğrulanamadı.")
          result_webAPI = "FAIL"
                                   End If
        Catch exWEB As Exception
 result_webAPI = "FAIL"
          
        End Try
    Catch ex As Exception

    End Try
                       End Sub)
        LockEvent("unlock")     
        If result_db = "OK" And result_webAPI = "OK"
               type = True
            save.Text = "Konfigürasyonu Kaydet"
            save.BaseColor = Color.White
            save.LineColor = Color.Indigo
            save.ForeColor = Color.MidnightBlue
            save.OnHoverBaseColor = Color.Silver
            Else
            type = False
            save.Text = "Konfigürasyonu Doğrula"
            Me.Width = 800
        End If
        End Function

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
      
      
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) 
        Application.Exit
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Application.Exit
    End Sub

    Private Sub LoaderX_Click(sender As Object, e As EventArgs) Handles LoaderX.Click

    End Sub
End Class