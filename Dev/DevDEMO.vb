Imports MySql.Data.MySqlClient
Imports HtmlAgilityPack
Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Web.Script.Serialization

Imports System.Threading.Tasks
Public Class DevDEMO
     Dim x As String
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim DNICol As String = "04.20.2022"
        For i As Integer = DataGridView1.Rows.Count - 1 To 0
            If DataGridView1.Rows(i).Cells(DNICol).ToString = "DNI" Then
                DataGridView1.Rows.RemoveAt(i)
            End If
        Next
    End Sub


    
    Function getLinkByAPI(ReqUrl As String, ISBN As String)
       ServicePointManager.Expect100Continue = true
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3
        Dim api As String = ""
        Dim link As String = ""
       Dim password As String = ""
   
        Dim base As String = My.Settings.api_url
        Dim baseModule As String = "getLink.php/"
        Dim code As String = My.Settings.code
        Try
            Dim Uri As String
            Dim url As String = base & baseModule

            Uri = url + "?api=" + api _
                   + "&link=" + link _
                   + "&password=" + password
            Console.WriteLine("WEB Request: " + Uri.ToString())
            
                       
            Dim webClient As New Net.WebClient
     
            Dim getOutput As String = webClient.DownloadString(Uri)
        
            Console.WriteLine("Web Request[getLink.php]: OUTPUT. " + getOutput.TrimEnd().ToString())
            'sendLog("Function.getLinkByAPI", "API/WEB Request: SUCCESS", writeÇıktı.TrimEnd().ToString())
        Catch ex As Exception
            Console.WriteLine("WEB Request[getLink.php]: ERROR.  " + ex.Message)
            'sendLog("Function.getLinkByAPI", "API/WEB Request: ERROR", EX.Message)
        End Try

    End Function
    Function getData() Handles MyBase.Load
        Try
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("SELECT * FROM books", db)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            DataGridView1.DataSource = dt3
            db.Dispose()
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
            db.Dispose()
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
        End Try

    End Function
    Function Dialog(data As String)
        My.Settings.dialog = data
        dialog_box.Close()
        dialog_box.show()
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        xtext.Text = xtextraw.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim backup As String
       
        Try
                Dim document = New HtmlWeb().Load("http://www.toplukatalog.gov.tr/?_f=1&the_page=1&cwid=2&keyword=" & isbn.Text & "&tokat_search_field=1&order=0&command=Tara#alt")        
                Dim veri = document.DocumentNode.SelectSingleNode(xpath.Text)
                Try
                   backup = veri.GetDirectInnerText
                subjectLOGx.Text = backup.ToString.ToLower
                Catch ex As Exception

                End Try
                
                System.Threading.Thread.Sleep(3)
                x = backup.ToString().ToLower()
                
               
            Catch ex As Exception
            MsgBox(ex.Message)
            End Try
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
         If x.Contains("ingilizce hikaye") Then
                    combo_Subject.SelectedText = ""
                ElseIf x.Contains("çocuk edebiyatı") Then
                    combo_Subject.SelectedText = "Edebiyat"
                ElseIf x.Contains("genç edebiyatı") Then
                    combo_Subject.SelectedText = "Edebiyat"
                ElseIf x.Contains("rus romanı") or x.Contains("rus edebiyatı") Then
                    combo_Subject.SelectedText = "Rus Romanı"
                ElseIf x.Contains("ingiliz romanı") or x.Contains("ingiliz edebiyatı") Then
                    combo_Subject.SelectedText = ""
                ElseIf x.Contains("roman") Then
                    combo_Subject.SelectedText = "Roman"
                ElseIf x.Contains("edebiyat") Then
                    combo_Subject.SelectedText = "Edebiyat"
                    ElseIf x.Contains("mutluluk") Then
                    combo_Subject.SelectedText = "Diğer"
                Else
                    MsgBox("KONU BULUNAMADI")
                End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
    
    End Sub
End Class