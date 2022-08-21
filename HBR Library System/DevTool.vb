Imports System.Runtime.Serialization.Formatters
Imports MySql.Data.MySqlClient

Public Class DevTool
    Dim db_credentials As String = "server=" & My.Settings.sqlhost & ";" & "userid=" & My.Settings.sqluser & ";" & "pwd=" & My.Settings.sqlpwd & ";" & "database=" & My.Settings.sqldb & ";" & "port=" & My.Settings.sqlport & ";" & "charset=" & My.Settings.sqlcharset & ";" & "SslMode=" & My.Settings.sqlssl & ";"
    Dim xbool As Boolean
    Dim session  As String = my.Settings.session.ToString()
    Dim dev as Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
        getSettings()
    End Sub
    Function getSettings
        Dim shost As String = my.Settings.sqlhost
        Dim suser As String = my.Settings.sqluser
        Dim spwd As String = my.Settings.sqlpwd
        Dim sdb As String = my.Settings.sqldb
        Dim sport As String  = my.Settings.sqlport

        current_host.Text = shost
        current_user.Text = suser
        current_db.Text = sdb
        current_pwd.Text = spwd
        current_port.Text = sport


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If xbool = False Then
            xbool = True
            Me.TopMost = True
            Button1.Text = "Topmost +"
            
        Else
            xbool = False
            Me.TopMost = False
            Button1.Text = "Topmost -"
        End If
    End Sub

    Private Sub DevTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        session_status.Text = session.ToString()
    End Sub

    Private Sub db_update_Click(sender As Object, e As EventArgs) Handles btn1.Click
        my.Settings.sqlhost = host.Text
        My.Settings.Save()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles btn2.Click
        my.Settings.sqluser = user.Text
        My.Settings.Save()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles btn3.Click
        my.Settings.sqlpwd = pwd.Text
        My.Settings.Save()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles btn4.Click
        my.Settings.sqldb = db.Text
        My.Settings.Save()
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles btn5.Click
        my.Settings.sqlport = port.Text
        My.Settings.Save()
    End Sub
    Function dev_login(x As String)
        If x = "90481780" Then
            My.Settings.session = "developer"
            session_status.Text = my.Settings.session
            session_developer()
            log.Text = log.Text + vbNewLine + "[" & dashboard.lTime.Text & "]" & " {SESSION UPDATED:==>  " & session & "  >>  developer"& "}"
            Button2.Text = "Logout"
            dev_pass.Text = ""
            dev = True
            My.Settings.Save()
        Else 
             dev = False
            dev_pass.Text = ""
            Button2.Text = "Login"
            My.Settings.session = "user"
            session_status.Text = my.Settings.session
            log.Text = log.Text + vbNewLine + "[" & dashboard.lTime.Text & "]" & " {SESSION UPDATED:==>  " & session & "  >>  user" & "}"
        My.Settings.Save()
        End If
    End Function
    Private Sub execute_Click(sender As Object, e As EventArgs) Handles execute.Click
       If command.Text.Contains("?dev_code") Then
           If command.Text = "?dev_code/module=developer" Then
               My.Settings.session = "developer"
               session_status.Text = my.Settings.session
               session_developer()
               log.Text = log.Text + vbNewLine + "[" & dashboard.lTime.Text & "]" & " {SESSION UPDATED:==>  " & session & "  >>  developer"& "}"
           Else 
             
               My.Settings.session = "user"
               session_status.Text = my.Settings.session
               log.Text = log.Text + vbNewLine + "[" & dashboard.lTime.Text & "]" & " {SESSION UPDATED:==>  " & session & "  >>  user" & "}"
           End If
           Else 
               Dim db As New MySqlConnection(db_credentials)
               dim cmd as New MySqlCommand
               cmd.Connection = db
               Try
                  
               db.Open()
                   cmd.CommandText = command.Text
                   cmd.ExecuteNonQuery()
                   sendLog("DEV_COMMAND: SUCCESS","COMMAND HAS EXECUTED! ")
               Catch ex As Exception
                sendLogX("DEV_COMMAND: ERROR", "AN ERROR OCCURRED WHILE COMMAND EXECUTE ", ex.Message)
               End Try
       End If
       
    End Sub
    Function sendLogX(title As String, message As String, ex As String)
        log.Text = log.Text + vbNewLine + "[" + dashboard.lTime.Text + "]" + "{" + "DEVTOOL" + "}---" + title + " ==> " + message + " #BASE=>" + vbNewLine + "[" + ex + "]"
    End Function
    Function sendLog(title As String, message As String)
        log.Text = log.Text + vbNewLine + "[" + dashboard.lTime.Text + "]" + "{" + "DEVTOOL" + "}---" + title + " ==> " + message + "]"
    End Function
    sub session_developer
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        clear.enabled = true
        execute.enabled = true
    End sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dev_login(dev_pass.Text)
    End Sub
End Class