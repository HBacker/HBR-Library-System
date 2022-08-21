﻿Public Class dashboard

    'BEGIN Themes Strings
    Dim devX as String
    Dim xdate As String
    Dim xtime As String

    'END Themes Strings
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.session = "user"
        My.Settings.Save
        Console.Write("Status: Running")
        xtime = DateAndTime.Now.ToString("HH:mm")
        xdate = DateAndTime.Now.ToString("dd.MM.yyyy")
        lTime.Text = xtime
        vdate.Text = xdate
        DevTool.Size = New Point(1, 1)
        DevTool.Show
        DevTool.Hide
        DevTool.Size = New Point(816, 700)
        
        pdate.Value = Date.Now.ToString
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    'BEGIN Themes
    '---
    'BEGIN Sub Theme DARK

    Sub theme_dark()



        apply_theme()
    End Sub

    'END Sub Theme DARK
    '---
    'BEGIN Sub Theme LIGHT

    Sub theme_light()


        apply_theme()
    End Sub

    'END Sub Theme Light
    '---

    'BEGIN ApplyTheme
    Sub apply_theme()

    End Sub
    Function mod_change(x As String)
        BookList.Checked = False
        MemberList.Checked = False
        BookNew.Checked = False
        AddNewMember.Checked = False
        BookTrack.Checked = False


        Section_Add_Book.Visible = False
        Section_Book_List.Visible = False
        Section_List_Members.Visible = False
        Section_AddNewMember.Visible = False
        Section_Track_Book.Visible = False

        If x = "" Then
        ElseIf x = "addBook" Then
            BookNew.Checked = True
            Section_Add_Book.Visible = True
        ElseIf x = "listBook" Then
            BookList.Checked = True
            Section_Book_List.getData()
            Section_Book_List.getBook_reset.PerformClick
            Section_Book_List.Visible = True
        ElseIf x = "listMembers" Then
            MemberList.Checked = True
            Section_List_Members.Visible = True
            Section_List_Members.getData()
        ElseIf x = "addNewMember" Then
            AddNewMember.Checked = True
            Section_AddNewMember.Visible = True
        ElseIf x = "BookTracker" Then
            BookTrack.Checked = True
            Section_Track_Book.Visible = True
            Section_Track_Book.getData()
        End If
    End Function

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles BookNew.Click
        mod_change("addBook")


    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)
        theme_dark()
    End Sub

    'END ApplyTheme

    'END Themes

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles info.Click
        dev_login_pass.Visible = True
        dev_login_button.Visible = True
        dev_login_pass.Select()
    End Sub

    Private Sub panel_head_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub header_Click(sender As Object, e As EventArgs) Handles header.Click

    End Sub

    Private Sub Book_List1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub book_list_Click(sender As Object, e As EventArgs) Handles BookList.Click
        mod_change("listBook")

    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        Application.Exit()
    End Sub

    Private Sub MemberList_Click(sender As Object, e As EventArgs) Handles MemberList.Click
        mod_change("listMembers")
    End Sub

    Private Sub AddNewMember_Click(sender As Object, e As EventArgs) Handles AddNewMember.Click
        mod_change("addNewMember")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles slider.Tick
        Dim i As Integer = GunaLabel2.Location.X - 1
        dim y as Integer = gunalabel2.Location.Y

        GunaLabel2.Location = New Point(i, y)
        If GunaLabel2.Location.X < -4000 Then
            GunaLabel2.Location = New Point(1080, y)
        End If
    End Sub

    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub GunaLabel2_MouseHover(sender As Object, e As EventArgs) Handles GunaLabel2.MouseHover
        slider.Stop()
    End Sub

    Private Sub GunaLabel2_MouseLeave(sender As Object, e As EventArgs) Handles GunaLabel2.MouseLeave
        slider.Start()
    End Sub

    Private Sub Section_AddNewMember_Load(sender As Object, e As EventArgs) Handles Section_AddNewMember.Load

    End Sub

    Private Sub time_Tick(sender As Object, e As EventArgs) Handles time.Tick
        lTime.Text = xtime
        xtime = DateAndTime.Now.ToString("HH:mm")
        xdate = DateAndTime.Now.ToString("dd.MM.yyyy")
        lTime.Text = xtime
        vdate.Text = xdate
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles BookTrack.Click
        mod_change("BookTracker")
    End Sub

    Private Sub GunaAdvenceButton1_Click_2(sender As Object, e As EventArgs) Handles dev_login_button.Click
        DevTool.Show()
        Dim pass As String = my.Settings.devpass.ToString()
        if dev_login_pass.Text = pass Then
            DevTool.Show()
            dev_login_button.Visible = False
            dev_login_pass.Visible = False
            dev_login_pass.Text = ""
        Else
            dev_login_button.Visible = False
            dev_login_pass.Visible = False
            dev_login_pass.Text = ""
        End If
    End Sub
    sub dev_login(x As String)

    End sub

    Private Sub dev_login_pass_TextChanged(sender As Object, e As EventArgs) Handles dev_login_pass.TextChanged

    End Sub

    Private Sub dev_login_pass_KeyUp(sender As Object, e As KeyEventArgs) Handles dev_login_pass.KeyUp
        If e.KeyCode = keys.Enter Then
            dev_login_button.PerformClick()
        Else
        End If
    End Sub

    Private Sub Section_Book_List_Load(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Section_Book_List_Load_1(sender As Object, e As EventArgs) Handles Section_Book_List.Load

    End Sub
End Class
