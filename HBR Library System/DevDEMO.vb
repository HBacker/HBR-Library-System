Imports MySql.Data.MySqlClient
Public Class DevDEMO
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim DNICol As String = "04.20.2022"
        For i As Integer = DataGridView1.Rows.Count - 1 To 0
            If DataGridView1.Rows(i).Cells(DNICol).ToString = "DNI" Then
                DataGridView1.Rows.RemoveAt(i)
            End If
        Next
    End Sub
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
End Class