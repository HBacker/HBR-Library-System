Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Book_List
    'Section MySQL
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim db As New MySqlConnection(db_credentials)
    Dim index As Integer
    Dim indexX As Integer
    Dim api_url As String = My.Settings.api_url
    Dim api_key As String = My.Settings.api_key
    Dim api_application_directory As String = My.Settings.api_application_directory
    Dim api_ImageBook_folder As String = My.Settings.api_ImageBook_folder
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



    Async Function getBooks() As Task
        Dim status_dt As Boolean = False

                  System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
               dataLoader.Enabled = True
        'DataLoader load()
         dataLoader.Visible = True
        dataLoader.loading.Text = "Yükleniyor..."
          Dim dt3 As New DataTable
        Await Task.Run(Sub ()
                           
          Try                    
            Dim db As New MySqlConnection(db_credentials)

            Dim dap3 As New MySqlDataAdapter("Select id,Kitap,Yazar,Yayıncı,ISBN FROM books", db)
          
            dap3.Fill(dt3)
           status_dt = True
            db.Dispose()
            occurred.Visible = False
            Console.WriteLine("Veri Başarıyla Çekildi location=getData")
            db.Dispose()
            delete_column
     
        dataLoader.loading.Text = "Yükleniyor"
        Catch ErrorEX As Exception
         
            Console.WriteLine("Veri Çekilemedi! location=BookList_Function.getBooks" + vbNewLine + ErrorEX.Message)
             
        dataLoader.loading.Text = "HATA >> Veritabanı ile bağlantı kurulurken bir hata meydana geldi! location=BookList_Function.getBooks"
        End Try
                       End Sub)
        If status_dt = True
               BookList_X.DataSource = DT3
            bookList.DataSource = dt3
            status_dt = False
            Else

        End If
      status_dt = False
       dataLoader.Visible = False
       dataLoader.Enabled = False
        
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
       Dim selectedRow As DataGridViewRow
       Dim selectedRowX As DataGridViewRow
       selectedRow = bookList.Rows(index)
       selectedRowX = BookList_X.Rows(index)
        'BEGIN Integers of DB
        Dim id_i as integer = 0
        Dim BookName_i as integer= 2
        Dim Author_i as integer = 3
        Dim Publisher_i as integer = 1
        Dim Image_i as integer = 1
        Dim ISBN_i as integer = 4
        Dim ISBN_selected As String

        'END Integers of DB
        Dim image As String
        api_ImageBook_folder = "book_cover/"
        api_application_directory = "application/library_system/"
        Dim i As Integer = 0
        Try
                    index = e.RowIndex
         
           
         selected_BookName.Text = selectedRow.Cells(BookName_i).Value.ToString()
         selected_Author.Text = selectedRow.Cells(Author_i).Value.ToString()
          selected_Publisher.Text = selectedRow.Cells(Publisher_i).Value.ToString()
            selected_ISBN.Text = selectedRow.Cells(ISBN_i).Value.ToString()
            ISBN_selected = selectedRow.Cells(ISBN_i).Value.ToString()
            getBook_id.Text = selectedRow.Cells(id_i).Value.ToString()
            'image = selectedRowX.Cells(Image_i).Value.ToString()
           Catch ex As Exception
            MsgBox( "A "& ex.Message)
            End Try
        Try
            If ISBN_selected Is Nothing Then
                               book_poster.Image = My.Resources.Resources.HBR
                 Else
                  If ISBN_selected.Length < 5 Then
                book_poster.Image = My.Resources.Resources.HBR
                Else
                book_poster.Load(api_url.ToString & api_application_directory & api_ImageBook_folder & selectedRow.Cells(ISBN_i).Value.ToString() & ".jpg")
                    
           End If  
            End If     
           
        Catch ex As Exception

          book_poster.Image = My.Resources.Resources.HBR
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

    Private Sub dataLoader_Load(sender As Object, e As EventArgs) Handles dataLoader.Load

    End Sub
End Class

