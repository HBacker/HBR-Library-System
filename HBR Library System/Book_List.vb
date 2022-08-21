Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Book_List
    'Section MySQL
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim db As New MySqlConnection(db_credentials)

    'END Section MySQL

    'Section boolean_controllers

    Dim bookList_AutoSize As Boolean

    'END Section boolean_controllers
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

    End Sub

    Private Sub Book_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    Function sleeper(i As Integer)
        System.Threading.Thread.Sleep(i)

        Return Nothing
    End Function



    Function getData()
        Try
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("Select id,Kitap,Yazar,Yayıncı,Konu,Durum from books", db)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            bookList.DataSource = dt3
      
            db.Dispose()
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
            db.Dispose()
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
        End Try

    End Function


    Private Sub data_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim index As Integer = e.RowIndex
        Dim x As String
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = BookList.Rows(index)
            x = selectedRow.Cells(2).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        If bookList_AutoSize = False Then
            bookList_AutoSize = True
            btn_AutoSize.Text = "Daralt"
            bookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader

        Else
            bookList_AutoSize = False
            btn_AutoSize.Text = "Genişlet"
            bookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub bookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookList.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials =  "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub

    Private Sub go_tracker_Click(sender As Object, e As EventArgs) Handles go_tracker.Click
        dashboard.mod_change("BookTracker")
    End Sub
End Class
