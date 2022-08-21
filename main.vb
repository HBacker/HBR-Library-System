Public Class main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=185.126.218.133;userid=hbackerd_ryzen;pwd=Dev_DB1780+;database=hbackerd_data;port=3306;SslMode=None;charset=utf8;")
        Try
            conn.Open()
            MsgBox("Başarılı!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class
