Imports MySql.Data.MySqlClient
Public Class ListMembers
    'Section MySQL
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim db As New MySqlConnection(db_credentials)

    'END Section MySQL

    'Section boolean_controllers
    Dim SectionName As String = "ListMembers"
    Dim bookList_AutoSize As Boolean

    'END Section boolean_controllers

    Private Sub ListMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function sendLog(title As String, message As String, ex As String)
        DevTool.log.Text = DevTool.log.Text + vbNewLine + "[" + dashboard.lTime.Text + "]" + "{" + SectionName + "}---" + title + " ==> " + message + " #ERR_BASE=>" + vbNewLine + "[" + ex + "]"
    End Function
    Function getData()
        Try
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("Select * FROM members", db)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            bookList.DataSource = dt3
            db.Dispose()
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
            sendLog("SUCCESS!", "getData executed!", ":)")
            db.Dispose()
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
            sendLog("ERROR!", "getData occurred!", ErrorEX.Message)
        End Try

    End Function


    Private Sub data_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim index As Integer = e.RowIndex
        Dim x As String
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = bookList.Rows(index)
            x = selectedRow.Cells(2).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_AutoSize_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookList.CellContentClick

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        dashboard.AddNewMember.PerformClick()
    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub
End Class
