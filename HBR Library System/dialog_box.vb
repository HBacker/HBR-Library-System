Public Class dialog_box
    Dim data As String = my.Settings.dialog
    Private Sub button_bot_Click(sender As Object, e As EventArgs) 

    End Sub
    Function dialog(x As String)
     Colormaster.Start()
        If x = "AddBook-empty_area" Then
            title.Text = "Uyarı"
            message.Location = new Point(86, 118)
            message.Text = "Lütfen Zorunlu 
Alanları Boş Bırakmayın!
"
            btnHelp.Enabled = True
            ElseIf x = "AddBook-success" Then
                title.Text = "Mesaj"
                message.Location = New Point(96, 118)
                message.Text = "Kitap Başarıyla Eklendi!"
            btnHelp.Enabled = False
             ElseIf x = "NewMember-success" Then
                title.Text = "Mesaj"
                message.Location = New Point( 105, 139)
                message.Text = "Üye Başarıyla Eklendi!"
                btnHelp.Enabled = False
        ElseIf x = "NewMember-error" Then
            title.Text = "Mesaj"
            message.Location = New Point( 66, 101)
            message.Text = "Oops!
 Üye Eklenemedi! 
Lütfen Geliştiriciye ulaşınız.
"
            btnHelp.Enabled = True
                 elseIf x = "NewMember-empty_area" Then
                     title.Text = "Uyarı"
                     message.Location = new Point(86, 118)
                     message.Text = "Lütfen Zorunlu 
Alanları Boş Bırakmayın!
"
                     btnHelp.Enabled = True
        Else 
               
        End If
        End Function
    Private Sub dialog_box_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dialog(data)
    End Sub
    Sub DefaultDialog
        colorMASTER.Stop()
        btnHelp.Enabled = False
        title.Text = "$Title"
        message.Text = "$Message"
        End Sub
    Private Sub btnINSERT_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DefaultDialog()
        Me.Close()
    End Sub

    Private Sub colorMASTER_Tick(sender As Object, e As EventArgs) Handles colorMASTER.Tick
        If btnOK.LineColor = Color.FromArgb(4, 175, 175) Then
            btnOK.LineColor = color.FromArgb(66, 58, 170)
            Else 
                btnOK.LineColor = color.FromArgb(4, 175, 175)
        End If
    End Sub
End Class