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
         dataLoader.loading.Text = "Yükleniyor..."
            dataLoader.Visible = True
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
             dataLoader.loading.Text = "Yükleniyor..."
            dataLoader.Visible = True
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
            sendLog("ERROR!", "getData occurred!", ErrorEX.Message)
             dataLoader.loading.Text = "HATA >> Veritabanı ile bağlantı kurulurken bir hata meydana geldi! location=BookTracker.getData"
            dataLoader.Visible = True
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
    Function Dialog(data As String, help_message As String)
        My.Settings.dialog = data
        My.Settings.dialog_help = help_message
        dialog_box.Close()
        dialog_box.show()
    End Function

    Private Sub btn_AutoSize_Click(sender As Object, e As EventArgs)

    End Sub
    Function Dialog(data As String)
        My.Settings.dialog = data
        dialog_box.Close()
        dialog_box.show()
    End Function
    Private Sub bookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookList.CellContentClick

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        dashboard.AddNewMember.PerformClick()
    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub
    Function search(keyword as string, method As String)

        Try
            Dim dbx As New MySqlConnection(db_credentials)

            Dim dap3x As New MySqlDataAdapter("Select * FROM members WHERE " & method.ToString & " LIKE " & "'" & keyword.ToString() & "'", dbx)

            Dim dt3x As New DataTable
            dap3x.Fill(dt3x)
            bookList.DataSource = dt3x

            db.Dispose()
            occurred.Visible = False

            db.Dispose()
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
        Finally
            dim i As Integer = bookList.RowCount
            if i <= 0 Then
                Dialog("MemberList-search.404")
            Else
            End If
        End Try

    End Function
    Private Sub book_find_Click(sender As Object, e As EventArgs) Handles member_find.Click
        If method_no.Checked = True Then
            search(member_finder.Text, "No")
        Else
            search(member_finder.Text, "Adı")
        End If
    End Sub

    Private Sub REFRESH_Click(sender As Object, e As EventArgs) Handles REFRESH.Click
        getData()
    End Sub
End Class
