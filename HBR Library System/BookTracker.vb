Imports MySql.Data.MySqlClient
Public Class BookTracker
    Dim SectionName As String = "BookTracker"
    Dim sDate As String
    Private Sub BookTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim db As New MySqlConnection(db_credentials)

    'END Section MySQL

    'Section boolean_controllers

    Dim bookList_AutoSize As Boolean

    'END Section boolean_controllers
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles header_text.Click

    End Sub

    Private Sub Book_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    Function sleeper(i As Integer)
        System.Threading.Thread.Sleep(i)

        Return Nothing
    End Function



    Function getData()
        sDate = dashboard.vdate.Text.ToString()
        Try
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("SELECT * FROM members WHERE TeslimTarihi <= " & "'" & sDate & "'", db)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            trackList.DataSource = dt3
           
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
         
            sendLog("Function.getData","Tracker: SUCCESS ", "Working!")
        Catch ErrorEX As Exception
            occurred.Visible = True
            
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
      sendLog("Function.getData","Tracker: ERROR ", ErrorEX.Message)
      Finally
          db.Dispose()
        End Try

    End Function
    Function sendLog(title As String, message As String, ex As String)
        DevTool.log.Text = DevTool.log.Text + vbNewLine + "[" + dashboard.lTime.Text + "]" + "{" + SectionName + "}---" + title + " ==> " + message + " #BASE=>" + vbNewLine + "[" + ex + "]"
    End Function

    Private Sub data_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim index As Integer = e.RowIndex
        Dim x As String
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = trackList.Rows(index)
            x = selectedRow.Cells(2).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_AutoSize.Click
      
        If bookList_AutoSize = False Then
            bookList_AutoSize = True
            btn_AutoSize.Text = "Daralt"
            trackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader

        Else
            bookList_AutoSize = False
            btn_AutoSize.Text = "Genişlet"
            trackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub bookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles trackList.CellContentClick

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        getData()
    End Sub

    Private Sub btn_FulLScreen_Click(sender As Object, e As EventArgs) Handles btn_FulLScreen.Click
    
    End Sub

 
End Class
