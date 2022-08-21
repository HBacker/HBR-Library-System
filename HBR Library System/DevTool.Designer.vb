<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevTool))
        Me.log = New System.Windows.Forms.RichTextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.command = New System.Windows.Forms.TextBox()
        Me.execute = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn5 = New HBR_Library_System.FlatButton()
        Me.btn4 = New HBR_Library_System.FlatButton()
        Me.btn3 = New HBR_Library_System.FlatButton()
        Me.btn2 = New HBR_Library_System.FlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New HBR_Library_System.FlatButton()
        Me.current_port = New System.Windows.Forms.TextBox()
        Me.current_db = New System.Windows.Forms.TextBox()
        Me.current_pwd = New System.Windows.Forms.TextBox()
        Me.current_user = New System.Windows.Forms.TextBox()
        Me.current_host = New System.Windows.Forms.TextBox()
        Me.FlatLabel5 = New HBR_Library_System.FlatLabel()
        Me.port = New HBR_Library_System.FlatTextBox()
        Me.FlatLabel4 = New HBR_Library_System.FlatLabel()
        Me.db = New HBR_Library_System.FlatTextBox()
        Me.FlatLabel3 = New HBR_Library_System.FlatLabel()
        Me.pwd = New HBR_Library_System.FlatTextBox()
        Me.FlatLabel2 = New HBR_Library_System.FlatLabel()
        Me.user = New HBR_Library_System.FlatTextBox()
        Me.FlatLabel1 = New HBR_Library_System.FlatLabel()
        Me.host = New HBR_Library_System.FlatTextBox()
        Me.FlatGroupBox1 = New HBR_Library_System.FlatGroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dev_pass = New System.Windows.Forms.TextBox()
        Me.session_status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.FlatGroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(27,Byte),Integer), CType(CType(61,Byte),Integer))
        Me.log.ForeColor = System.Drawing.Color.Aqua
        Me.log.Location = New System.Drawing.Point(13, 13)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(775, 356)
        Me.log.TabIndex = 0
        Me.log.Text = ""
        '
        'clear
        '
        Me.clear.Enabled = false
        Me.clear.Location = New System.Drawing.Point(748, 375)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(40, 23)
        Me.clear.TabIndex = 1
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = true
        '
        'command
        '
        Me.command.BackColor = System.Drawing.Color.FromArgb(CType(CType(14,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(35,Byte),Integer))
        Me.command.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.command.ForeColor = System.Drawing.Color.Aqua
        Me.command.Location = New System.Drawing.Point(13, 375)
        Me.command.Multiline = true
        Me.command.Name = "command"
        Me.command.Size = New System.Drawing.Size(589, 23)
        Me.command.TabIndex = 2
        Me.command.Text = "Command"
        Me.command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'execute
        '
        Me.execute.Enabled = false
        Me.execute.Location = New System.Drawing.Point(608, 375)
        Me.execute.Name = "execute"
        Me.execute.Size = New System.Drawing.Size(65, 23)
        Me.execute.TabIndex = 3
        Me.execute.Text = "Execute"
        Me.execute.UseVisualStyleBackColor = true
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        '
        'Button1
        '
        Me.Button1.Enabled = false
        Me.Button1.Location = New System.Drawing.Point(679, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "TopMost"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn5)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.current_port)
        Me.GroupBox1.Controls.Add(Me.current_db)
        Me.GroupBox1.Controls.Add(Me.current_pwd)
        Me.GroupBox1.Controls.Add(Me.current_user)
        Me.GroupBox1.Controls.Add(Me.current_host)
        Me.GroupBox1.Controls.Add(Me.FlatLabel5)
        Me.GroupBox1.Controls.Add(Me.port)
        Me.GroupBox1.Controls.Add(Me.FlatLabel4)
        Me.GroupBox1.Controls.Add(Me.db)
        Me.GroupBox1.Controls.Add(Me.FlatLabel3)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.FlatLabel2)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Controls.Add(Me.FlatLabel1)
        Me.GroupBox1.Controls.Add(Me.host)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 244)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Application.Settings.DATABASE"
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        Me.btn5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn5.Enabled = false
        Me.btn5.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.btn5.Location = New System.Drawing.Point(352, 169)
        Me.btn5.Name = "btn5"
        Me.btn5.Rounded = false
        Me.btn5.Size = New System.Drawing.Size(52, 29)
        Me.btn5.TabIndex = 20
        Me.btn5.Text = "UPDATE"
        Me.btn5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        Me.btn4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.Enabled = false
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.btn4.Location = New System.Drawing.Point(352, 134)
        Me.btn4.Name = "btn4"
        Me.btn4.Rounded = false
        Me.btn4.Size = New System.Drawing.Size(52, 29)
        Me.btn4.TabIndex = 19
        Me.btn4.Text = "UPDATE"
        Me.btn4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Enabled = false
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.btn3.Location = New System.Drawing.Point(352, 99)
        Me.btn3.Name = "btn3"
        Me.btn3.Rounded = false
        Me.btn3.Size = New System.Drawing.Size(52, 29)
        Me.btn3.TabIndex = 18
        Me.btn3.Text = "UPDATE"
        Me.btn3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Enabled = false
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.btn2.Location = New System.Drawing.Point(352, 64)
        Me.btn2.Name = "btn2"
        Me.btn2.Rounded = false
        Me.btn2.Size = New System.Drawing.Size(52, 29)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "UPDATE"
        Me.btn2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(85, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "HBR DB Connection Credentials"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Enabled = false
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.btn1.Location = New System.Drawing.Point(352, 29)
        Me.btn1.Name = "btn1"
        Me.btn1.Rounded = false
        Me.btn1.Size = New System.Drawing.Size(52, 29)
        Me.btn1.TabIndex = 15
        Me.btn1.Text = "UPDATE"
        Me.btn1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'current_port
        '
        Me.current_port.Location = New System.Drawing.Point(89, 173)
        Me.current_port.Multiline = true
        Me.current_port.Name = "current_port"
        Me.current_port.Size = New System.Drawing.Size(125, 22)
        Me.current_port.TabIndex = 14
        Me.current_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'current_db
        '
        Me.current_db.Location = New System.Drawing.Point(89, 138)
        Me.current_db.Multiline = true
        Me.current_db.Name = "current_db"
        Me.current_db.Size = New System.Drawing.Size(125, 22)
        Me.current_db.TabIndex = 13
        Me.current_db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'current_pwd
        '
        Me.current_pwd.Location = New System.Drawing.Point(89, 103)
        Me.current_pwd.Multiline = true
        Me.current_pwd.Name = "current_pwd"
        Me.current_pwd.Size = New System.Drawing.Size(125, 22)
        Me.current_pwd.TabIndex = 12
        Me.current_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.current_pwd.UseSystemPasswordChar = true
        '
        'current_user
        '
        Me.current_user.Location = New System.Drawing.Point(89, 68)
        Me.current_user.Multiline = true
        Me.current_user.Name = "current_user"
        Me.current_user.Size = New System.Drawing.Size(125, 22)
        Me.current_user.TabIndex = 11
        Me.current_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'current_host
        '
        Me.current_host.Location = New System.Drawing.Point(89, 33)
        Me.current_host.Multiline = true
        Me.current_host.Name = "current_host"
        Me.current_host.Size = New System.Drawing.Size(125, 22)
        Me.current_host.TabIndex = 10
        Me.current_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = true
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(16, 176)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(64, 13)
        Me.FlatLabel5.TabIndex = 9
        Me.FlatLabel5.Text = "Mysql.Port:"
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.Transparent
        Me.port.Location = New System.Drawing.Point(222, 169)
        Me.port.MaxLength = 32767
        Me.port.Multiline = false
        Me.port.Name = "port"
        Me.port.ReadOnly = false
        Me.port.Size = New System.Drawing.Size(124, 29)
        Me.port.TabIndex = 8
        Me.port.Text = "data"
        Me.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.port.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.port.UseSystemPasswordChar = false
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = true
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(16, 141)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(57, 13)
        Me.FlatLabel4.TabIndex = 7
        Me.FlatLabel4.Text = "Mysql.DB:"
        '
        'db
        '
        Me.db.BackColor = System.Drawing.Color.Transparent
        Me.db.Location = New System.Drawing.Point(222, 134)
        Me.db.MaxLength = 32767
        Me.db.Multiline = false
        Me.db.Name = "db"
        Me.db.ReadOnly = false
        Me.db.Size = New System.Drawing.Size(124, 29)
        Me.db.TabIndex = 6
        Me.db.Text = "data"
        Me.db.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.db.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.db.UseSystemPasswordChar = false
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = true
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(16, 106)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(65, 13)
        Me.FlatLabel3.TabIndex = 5
        Me.FlatLabel3.Text = "Mysql.Pwd:"
        '
        'pwd
        '
        Me.pwd.BackColor = System.Drawing.Color.Transparent
        Me.pwd.Location = New System.Drawing.Point(222, 99)
        Me.pwd.MaxLength = 32767
        Me.pwd.Multiline = false
        Me.pwd.Name = "pwd"
        Me.pwd.ReadOnly = false
        Me.pwd.Size = New System.Drawing.Size(124, 29)
        Me.pwd.TabIndex = 4
        Me.pwd.Text = "data"
        Me.pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pwd.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.pwd.UseSystemPasswordChar = false
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = true
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(16, 71)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(66, 13)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "Mysql.User:"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Location = New System.Drawing.Point(222, 64)
        Me.user.MaxLength = 32767
        Me.user.Multiline = false
        Me.user.Name = "user"
        Me.user.ReadOnly = false
        Me.user.Size = New System.Drawing.Size(124, 29)
        Me.user.TabIndex = 2
        Me.user.Text = "data"
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.user.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.user.UseSystemPasswordChar = false
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = true
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(16, 36)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(67, 13)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Mysql.Host:"
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Transparent
        Me.host.Location = New System.Drawing.Point(222, 29)
        Me.host.MaxLength = 32767
        Me.host.Multiline = false
        Me.host.Name = "host"
        Me.host.ReadOnly = false
        Me.host.Size = New System.Drawing.Size(124, 29)
        Me.host.TabIndex = 0
        Me.host.Text = "data"
        Me.host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.host.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.host.UseSystemPasswordChar = false
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.FlatGroupBox1.Controls.Add(Me.Button2)
        Me.FlatGroupBox1.Controls.Add(Me.dev_pass)
        Me.FlatGroupBox1.Controls.Add(Me.session_status)
        Me.FlatGroupBox1.Controls.Add(Me.Label2)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(473, 405)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = true
        Me.FlatGroupBox1.Size = New System.Drawing.Size(315, 244)
        Me.FlatGroupBox1.TabIndex = 6
        Me.FlatGroupBox1.Text = "Credentials"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.Button2.Location = New System.Drawing.Point(126, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'dev_pass
        '
        Me.dev_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(14,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(35,Byte),Integer))
        Me.dev_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dev_pass.ForeColor = System.Drawing.Color.Aqua
        Me.dev_pass.Location = New System.Drawing.Point(21, 66)
        Me.dev_pass.Multiline = true
        Me.dev_pass.Name = "dev_pass"
        Me.dev_pass.Size = New System.Drawing.Size(99, 23)
        Me.dev_pass.TabIndex = 7
        Me.dev_pass.Text = "password"
        Me.dev_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'session_status
        '
        Me.session_status.AutoSize = true
        Me.session_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        Me.session_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.session_status.ForeColor = System.Drawing.Color.Aqua
        Me.session_status.Location = New System.Drawing.Point(111, 38)
        Me.session_status.Name = "session_status"
        Me.session_status.Size = New System.Drawing.Size(80, 20)
        Me.session_status.TabIndex = 21
        Me.session_status.Text = "$session"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SESSION:"
        '
        'DevTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24,Byte),Integer), CType(CType(24,Byte),Integer), CType(CType(24,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.execute)
        Me.Controls.Add(Me.command)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.log)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "DevTool"
        Me.Text = "DevTool"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.FlatGroupBox1.ResumeLayout(false)
        Me.FlatGroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents log As RichTextBox
    Friend WithEvents clear As Button
    Friend WithEvents command As TextBox
    Friend WithEvents execute As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents host As FlatTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As FlatButton
    Friend WithEvents current_port As TextBox
    Friend WithEvents current_db As TextBox
    Friend WithEvents current_pwd As TextBox
    Friend WithEvents current_user As TextBox
    Friend WithEvents current_host As TextBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents port As FlatTextBox
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents db As FlatTextBox
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents pwd As FlatTextBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents user As FlatTextBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents btn5 As FlatButton
    Friend WithEvents btn4 As FlatButton
    Friend WithEvents btn3 As FlatButton
    Friend WithEvents btn2 As FlatButton
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents session_status As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dev_pass As TextBox
End Class
