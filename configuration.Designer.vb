<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuration))
        Me.elipse_form = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.group_config_database = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dbName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.dbUserID = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dbPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.dbServer = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.group_config_web = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.webAPI_key = New Guna.UI.WinForms.GunaLineTextBox()
        Me.webAPI_url = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.elipse_dbServer = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_dbUserID = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_dbPassword = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_dbName = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_webapiurl = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_apikeyshortener = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.log = New System.Windows.Forms.RichTextBox()
        Me.save = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.LoaderX = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.header = New HBR_Library_System.FormSkin()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.group_config_database.SuspendLayout
        Me.group_config_web.SuspendLayout
        Me.LoaderX.SuspendLayout
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.header.SuspendLayout
        Me.SuspendLayout
        '
        'elipse_form
        '
        Me.elipse_form.Radius = 12
        Me.elipse_form.TargetControl = Me
        '
        'group_config_database
        '
        Me.group_config_database.BackColor = System.Drawing.Color.Transparent
        Me.group_config_database.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(31,Byte),Integer))
        Me.group_config_database.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.group_config_database.BorderSize = 1
        Me.group_config_database.Controls.Add(Me.Label1)
        Me.group_config_database.Controls.Add(Me.dbName)
        Me.group_config_database.Controls.Add(Me.GunaLabel2)
        Me.group_config_database.Controls.Add(Me.GunaLabel10)
        Me.group_config_database.Controls.Add(Me.dbUserID)
        Me.group_config_database.Controls.Add(Me.dbPassword)
        Me.group_config_database.Controls.Add(Me.GunaLabel5)
        Me.group_config_database.Controls.Add(Me.dbServer)
        Me.group_config_database.Controls.Add(Me.GunaLabel6)
        Me.group_config_database.LineBottom = 2
        Me.group_config_database.LineColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(2,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.group_config_database.Location = New System.Drawing.Point(28, 78)
        Me.group_config_database.Name = "group_config_database"
        Me.group_config_database.Radius = 5
        Me.group_config_database.Size = New System.Drawing.Size(450, 250)
        Me.group_config_database.TabIndex = 7
        Me.group_config_database.Text = "Veritabanı Konfigürasyonu"
        Me.group_config_database.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(13, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "port: 3306"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"charset: utf-8"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dbName
        '
        Me.dbName.Animated = true
        Me.dbName.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.dbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbName.FocusedLineColor = System.Drawing.Color.Indigo
        Me.dbName.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dbName.LineColor = System.Drawing.Color.Aqua
        Me.dbName.LineSize = 2
        Me.dbName.Location = New System.Drawing.Point(138, 182)
        Me.dbName.Name = "dbName"
        Me.dbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbName.Size = New System.Drawing.Size(288, 32)
        Me.dbName.TabIndex = 11
        Me.dbName.Text = "library"
        Me.dbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 182)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(93, 22)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Veritabanı:"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = true
        Me.GunaLabel10.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(11, 88)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(109, 22)
        Me.GunaLabel10.TabIndex = 9
        Me.GunaLabel10.Text = "Kullanıcı Adı:"
        '
        'dbUserID
        '
        Me.dbUserID.Animated = true
        Me.dbUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.dbUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbUserID.FocusedLineColor = System.Drawing.Color.Indigo
        Me.dbUserID.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dbUserID.LineColor = System.Drawing.Color.Aqua
        Me.dbUserID.LineSize = 2
        Me.dbUserID.Location = New System.Drawing.Point(138, 88)
        Me.dbUserID.Name = "dbUserID"
        Me.dbUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbUserID.Size = New System.Drawing.Size(288, 34)
        Me.dbUserID.TabIndex = 5
        Me.dbUserID.Text = "root"
        Me.dbUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dbPassword
        '
        Me.dbPassword.Animated = true
        Me.dbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.dbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbPassword.FocusedLineColor = System.Drawing.Color.Indigo
        Me.dbPassword.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dbPassword.LineColor = System.Drawing.Color.Aqua
        Me.dbPassword.LineSize = 2
        Me.dbPassword.Location = New System.Drawing.Point(138, 135)
        Me.dbPassword.Name = "dbPassword"
        Me.dbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.dbPassword.Size = New System.Drawing.Size(288, 32)
        Me.dbPassword.TabIndex = 6
        Me.dbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dbPassword.UseSystemPasswordChar = true
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(12, 135)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(51, 22)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "Şifre:"
        '
        'dbServer
        '
        Me.dbServer.Animated = true
        Me.dbServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.dbServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dbServer.FocusedLineColor = System.Drawing.Color.Indigo
        Me.dbServer.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dbServer.LineColor = System.Drawing.Color.Aqua
        Me.dbServer.LineSize = 2
        Me.dbServer.Location = New System.Drawing.Point(138, 45)
        Me.dbServer.Name = "dbServer"
        Me.dbServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbServer.Size = New System.Drawing.Size(288, 34)
        Me.dbServer.TabIndex = 4
        Me.dbServer.Text = "localhost"
        Me.dbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(11, 45)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(69, 22)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "Sunucu:"
        '
        'group_config_web
        '
        Me.group_config_web.BackColor = System.Drawing.Color.Transparent
        Me.group_config_web.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(31,Byte),Integer))
        Me.group_config_web.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.group_config_web.BorderSize = 1
        Me.group_config_web.Controls.Add(Me.Label4)
        Me.group_config_web.Controls.Add(Me.Label2)
        Me.group_config_web.Controls.Add(Me.GunaLabel4)
        Me.group_config_web.Controls.Add(Me.webAPI_key)
        Me.group_config_web.Controls.Add(Me.webAPI_url)
        Me.group_config_web.Controls.Add(Me.GunaLabel8)
        Me.group_config_web.LineBottom = 2
        Me.group_config_web.LineColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(2,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.group_config_web.Location = New System.Drawing.Point(28, 334)
        Me.group_config_web.Name = "group_config_web"
        Me.group_config_web.Radius = 5
        Me.group_config_web.Size = New System.Drawing.Size(450, 133)
        Me.group_config_web.TabIndex = 13
        Me.group_config_web.Text = "Web Sunucusu Konfigürasyonu"
        Me.group_config_web.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "/ ile bitmelidir."
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "port: 3306"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"charset: utf-8"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(11, 88)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(81, 18)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "API Anahtarı:"
        '
        'webAPI_key
        '
        Me.webAPI_key.Animated = true
        Me.webAPI_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.webAPI_key.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.webAPI_key.FocusedLineColor = System.Drawing.Color.Indigo
        Me.webAPI_key.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.webAPI_key.LineColor = System.Drawing.Color.Aqua
        Me.webAPI_key.LineSize = 2
        Me.webAPI_key.Location = New System.Drawing.Point(96, 78)
        Me.webAPI_key.Name = "webAPI_key"
        Me.webAPI_key.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.webAPI_key.Size = New System.Drawing.Size(330, 38)
        Me.webAPI_key.TabIndex = 5
        Me.webAPI_key.Tag = ""
        Me.webAPI_key.Text = "878217809048"
        Me.webAPI_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'webAPI_url
        '
        Me.webAPI_url.Animated = true
        Me.webAPI_url.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.webAPI_url.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.webAPI_url.FocusedLineColor = System.Drawing.Color.Indigo
        Me.webAPI_url.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.webAPI_url.LineColor = System.Drawing.Color.Aqua
        Me.webAPI_url.LineSize = 2
        Me.webAPI_url.Location = New System.Drawing.Point(96, 38)
        Me.webAPI_url.Name = "webAPI_url"
        Me.webAPI_url.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.webAPI_url.Size = New System.Drawing.Size(330, 34)
        Me.webAPI_url.TabIndex = 4
        Me.webAPI_url.Tag = ""
        Me.webAPI_url.Text = "https://api.hbacker.dev/"
        Me.webAPI_url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = true
        Me.GunaLabel8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(11, 45)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(70, 20)
        Me.GunaLabel8.TabIndex = 3
        Me.GunaLabel8.Text = "API URL:"
        '
        'elipse_dbServer
        '
        Me.elipse_dbServer.Radius = 2
        Me.elipse_dbServer.TargetControl = Me.dbServer
        '
        'elipse_dbUserID
        '
        Me.elipse_dbUserID.Radius = 2
        Me.elipse_dbUserID.TargetControl = Me.dbUserID
        '
        'elipse_dbPassword
        '
        Me.elipse_dbPassword.Radius = 2
        Me.elipse_dbPassword.TargetControl = Me.dbPassword
        '
        'elipse_dbName
        '
        Me.elipse_dbName.Radius = 2
        Me.elipse_dbName.TargetControl = Me.dbName
        '
        'elipse_webapiurl
        '
        Me.elipse_webapiurl.Radius = 2
        Me.elipse_webapiurl.TargetControl = Me.webAPI_url
        '
        'elipse_apikeyshortener
        '
        Me.elipse_apikeyshortener.Radius = 2
        Me.elipse_apikeyshortener.TargetControl = Me.webAPI_key
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.FromArgb(CType(CType(16,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(31,Byte),Integer))
        Me.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.log.Font = New System.Drawing.Font("Trebuchet MS", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.log.Location = New System.Drawing.Point(518, 78)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(270, 461)
        Me.log.TabIndex = 14
        Me.log.Text = "Konfigürasyon Test Ediliyor..."
        '
        'save
        '
        Me.save.Animated = true
        Me.save.AnimationHoverSpeed = 5!
        Me.save.AnimationSpeed = 5!
        Me.save.BackColor = System.Drawing.Color.Transparent
        Me.save.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.save.BorderColor = System.Drawing.Color.Black
        Me.save.CheckedBaseColor = System.Drawing.Color.Gray
        Me.save.CheckedBorderColor = System.Drawing.Color.Black
        Me.save.CheckedForeColor = System.Drawing.Color.White
        Me.save.CheckedImage = CType(resources.GetObject("save.CheckedImage"),System.Drawing.Image)
        Me.save.CheckedLineColor = System.Drawing.Color.DimGray
        Me.save.FocusedColor = System.Drawing.Color.Empty
        Me.save.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.save.ForeColor = System.Drawing.Color.Aqua
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.save.ImageSize = New System.Drawing.Size(32, 32)
        Me.save.LineBottom = 3
        Me.save.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.save.Location = New System.Drawing.Point(28, 479)
        Me.save.Name = "save"
        Me.save.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.save.OnHoverBorderColor = System.Drawing.Color.Black
        Me.save.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.save.OnHoverImage = Nothing
        Me.save.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.save.OnPressedColor = System.Drawing.Color.Black
        Me.save.Radius = 3
        Me.save.Size = New System.Drawing.Size(450, 60)
        Me.save.TabIndex = 87
        Me.save.Text = "Konfigürasyonu Doğrula"
        Me.save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoaderX
        '
        Me.LoaderX.BackColor = System.Drawing.Color.Transparent
        Me.LoaderX.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(31,Byte),Integer))
        Me.LoaderX.BorderColor = System.Drawing.Color.Gainsboro
        Me.LoaderX.Controls.Add(Me.GunaPictureBox1)
        Me.LoaderX.LineBottom = 5
        Me.LoaderX.LineColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(2,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.LoaderX.LineLeft = 3
        Me.LoaderX.LineRight = 3
        Me.LoaderX.Location = New System.Drawing.Point(12, 78)
        Me.LoaderX.Name = "LoaderX"
        Me.LoaderX.Radius = 5
        Me.LoaderX.Size = New System.Drawing.Size(489, 468)
        Me.LoaderX.TabIndex = 88
        Me.LoaderX.Text = "Konfigürasyonlar Test Ediliyor..."
        Me.LoaderX.TextLocation = New System.Drawing.Point(10, 8)
        Me.LoaderX.Visible = false
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.HBR_Library_System.My.Resources.Resources.loader_booksFAST
        Me.GunaPictureBox1.Location = New System.Drawing.Point(3, 30)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(482, 431)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = false
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.Controls.Add(Me.GunaAdvenceButton1)
        Me.header.Controls.Add(Me.GunaGradientButton2)
        Me.header.Controls.Add(Me.GunaLabel1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.header.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.header.HeaderMaximize = false
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(513, 61)
        Me.header.TabIndex = 5
        Me.header.Text = "FormSkin1"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = true
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 3!
        Me.GunaAdvenceButton1.AnimationSpeed = 3!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Bold)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaAdvenceButton1.LineBottom = 3
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.LineLeft = 3
        Me.GunaAdvenceButton1.LineRight = 3
        Me.GunaAdvenceButton1.LineTop = 3
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(443, 13)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 3
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(55, 38)
        Me.GunaAdvenceButton1.TabIndex = 90
        Me.GunaAdvenceButton1.Text = "X"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.TextOffsetX = 18
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = true
        Me.GunaGradientButton2.AnimationHoverSpeed = 5!
        Me.GunaGradientButton2.AnimationSpeed = 5!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.Indigo
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(984, 12)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.Crimson
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.IndianRed
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 5
        Me.GunaGradientButton2.Size = New System.Drawing.Size(61, 39)
        Me.GunaGradientButton2.TabIndex = 2
        Me.GunaGradientButton2.Text = "X"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(47, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(378, 35)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Konfigürasyon Yapılandırıcısı"
        '
        'configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(513, 552)
        Me.Controls.Add(Me.LoaderX)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.group_config_web)
        Me.Controls.Add(Me.group_config_database)
        Me.Controls.Add(Me.header)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "configuration"
        Me.Text = "Konfig Yapılandırıcısı - HBRLib"
        Me.group_config_database.ResumeLayout(false)
        Me.group_config_database.PerformLayout
        Me.group_config_web.ResumeLayout(false)
        Me.group_config_web.PerformLayout
        Me.LoaderX.ResumeLayout(false)
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.header.ResumeLayout(false)
        Me.header.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents header As FormSkin
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipse_form As Guna.UI.WinForms.GunaElipse
    Friend WithEvents group_config_database As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dbUserID As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dbPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dbServer As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents dbName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents group_config_web As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents webAPI_url As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipse_dbServer As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_dbUserID As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_dbPassword As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_dbName As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_webapiurl As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_apikeyshortener As Guna.UI.WinForms.GunaElipse
    Friend WithEvents log As RichTextBox
    Friend WithEvents save As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents LoaderX As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents webAPI_key As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
