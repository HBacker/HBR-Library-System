Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Book_List
    'Section MySQL
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim db As New MySqlConnection(db_credentials)
    Dim index As Integer
    Dim indexX As Integer
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
        dataLoader.Visible = True
        dataLoader.loading.Text = "Yükleniyor..."
        Try
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("Select * FROM books", db)
            Dim dt3 As New DataTable
            dap3.Fill(dt3)
            BookList_X.DataSource = DT3
            bookList.DataSource = dt3
            db.Dispose()
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
            db.Dispose()
            delete_column
             dataLoader.Visible = False
        dataLoader.loading.Text = "Yükleniyor"
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
             dataLoader.Visible = True
        dataLoader.loading.Text = "HATA >> Veritabanı ile bağlantı kurulurken bir hata meydana geldi! location=BookList.getData"
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
    Sub GetImages
        Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
         Dim dbImage As New MySqlConnection(db_credentials)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_AutoSize.Click
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

    Private Sub bookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookList.CellContentClick, bookList.RowEnter
        Dim image As String
        Dim i As Integer = 0
        Try
                    index = e.RowIndex
         
            Dim selectedRow As DataGridViewRow
            Dim selectedRowX As DataGridViewRow
            selectedRow = bookList.Rows(index)
            selectedRowX = BookList_X.Rows(index)
            selected_BookName.Text = selectedRow.Cells(2).Value.ToString()
            selected_Author.Text = selectedRow.Cells(3).Value.ToString()
            selected_Publisher.Text = selectedRow.Cells(4).Value.ToString()
            selected_ISBN.Text = selectedRow.Cells(7).Value.ToString()
            getBook_id.Text = selectedRow.Cells(0).Value.ToString()
            image = selectedRowX.Cells(1).Value.ToString()
           
            If image.Length < 6 Then
                book_poster.Image = My.Resources.Resources.HBR
                Elseif image.Contains("/library-posters/HBR.") Then
            book_poster.Image = My.Resources.Resources.HBR   
                ElseIf image.Contains("/library-posters/.jpg") Then
            book_poster.Image = My.Resources.Resources.HBR
            Else
                book_poster.Load(image.ToString)
            End If
        Catch ex As Exception
            book_poster.Image = My.Resources.Resources.HBR
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Sub delete_column
        bookList.Columns.Remove("Kapak")
    End Sub
    Private Sub Controller_Tick(sender As Object, e As EventArgs) Handles Controller.Tick
        If getBook_no.Text.Length > 2 Then
        button_GetBook.Enabled = True    
        Else
            button_GetBook.Enabled = False
        End If
    End Sub

    Private Sub dataUpdater_Tick(sender As Object, e As EventArgs) Handles dataUpdater.Tick
        db_credentials =  "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    End Sub

    Private Sub libbo_isbn_TextChanged(sender As Object, e As EventArgs) Handles getBook_no.TextChanged

    End Sub

    Private Sub getBook_reset_Click(sender As Object, e As EventArgs) Handles getBook_reset.Click
        getBook_date.Value = DateAndTime.Now
        getBook_no.Text = ""
    End Sub

    Private Sub book_find_Click(sender As Object, e As EventArgs) Handles book_find.Click
         If method_bookname.Checked = True Then
            search(book_finder.Text, "Kitap")
        Elseif method_author.Checked = True Then
            search(book_finder.Text, "Yazar")
            Elseif method_isbn.Checked = True Then
             search(book_finder.Text, "ISBN")
        End If
    End Sub
    Function Dialog(data As String, help_message As String)
        My.Settings.dialog = data
        My.Settings.dialog_help = help_message
        dialog_box.Close()
        dialog_box.show()
    End Function
    Function search(keyword as string, method As String)

        Try
            Dim dbx As New MySqlConnection(db_credentials)

            Dim dap3x As New MySqlDataAdapter("Select * FROM books WHERE " & method.ToString & " LIKE " & "'" & keyword.ToString() & "'", dbx)

            Dim dt3x As New DataTable
            dap3x.Fill(dt3x)
            BookList_X.DataSource = dt3x
            bookList.DataSource = dt3x

            db.Dispose()
            occurred.Visible = False

            db.Dispose()
            delete_column
        Catch ErrorEX As Exception
            occurred.Visible = True
            Console.WriteLine("Veri Çekilemedi! location=getData" + vbNewLine + ErrorEX.Message)
        Finally
            dim i As Integer = bookList.RowCount
            if i <= 0 Then
                Dialog("BookList-search.404", "")
            Else
            End If
        End Try

    End Function

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
      Try

                bookList.Columns.Remove("Kapak")   
      Catch ex As Exception
            
      End Try
    
    End Sub

    Private Sub BookList_X_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookList_X.CellContentClick

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click

    End Sub
End Class

