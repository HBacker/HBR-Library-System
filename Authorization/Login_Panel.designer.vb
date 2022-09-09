<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Panel
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Panel))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.uname = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.pw = New Guna.UI.WinForms.GunaTextBox()
        Me.gb_verify = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.n4 = New System.Windows.Forms.Label()
        Me.n3 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.Label()
        Me.n1 = New System.Windows.Forms.Label()
        Me.kod4 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod3 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod2 = New Guna.UI.WinForms.GunaTextBox()
        Me.kod1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGradientButton3 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.block = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnOK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nulltime = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.verify_box = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.error_desc = New Guna.UI.WinForms.GunaLabel()
        Me.block_box = New System.Windows.Forms.PictureBox()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.verifybox = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.boxerrorheader_radius = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.header_switcher = New System.Windows.Forms.Timer(Me.components)
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.header_title = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.time_updater = New System.Windows.Forms.Timer(Me.components)
        Me.Header = New HBR_Library_System.FormSkin()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.header_icon = New Guna.UI.WinForms.GunaPictureBox()
        Me.piyon = New HBR_Library_System.FlatTextBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnContact = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.gb_verify.SuspendLayout
        Me.GunaGradient2Panel3.SuspendLayout
        Me.block.SuspendLayout
        Me.verify_box.SuspendLayout
        CType(Me.block_box,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Header.SuspendLayout
        CType(Me.header_icon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'uname
        '
        Me.uname.BackColor = System.Drawing.Color.Transparent
        Me.uname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.uname.BorderColor = System.Drawing.Color.Aqua
        Me.uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.uname.FocusedBaseColor = System.Drawing.Color.White
        Me.uname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.uname.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.uname.Font = New System.Drawing.Font("Tahoma", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.uname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.uname.Location = New System.Drawing.Point(151, 70)
        Me.uname.MaxLength = 16
        Me.uname.Name = "uname"
        Me.uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.uname.Radius = 5
        Me.uname.Size = New System.Drawing.Size(327, 55)
        Me.uname.TabIndex = 23
        Me.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 82)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(129, 24)
        Me.GunaLabel1.TabIndex = 31
        Me.GunaLabel1.Text = "Kullanıcı Adı:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel2.Location = New System.Drawing.Point(21, 157)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(59, 24)
        Me.GunaLabel2.TabIndex = 32
        Me.GunaLabel2.Text = "Şifre:"
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.Transparent
        Me.pw.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.pw.BorderColor = System.Drawing.Color.Aqua
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.FocusedBaseColor = System.Drawing.Color.White
        Me.pw.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pw.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.pw.Font = New System.Drawing.Font("Tahoma", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.pw.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pw.Location = New System.Drawing.Point(151, 141)
        Me.pw.MaxLength = 20
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.pw.Radius = 5
        Me.pw.Size = New System.Drawing.Size(327, 55)
        Me.pw.TabIndex = 33
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pw.UseSystemPasswordChar = true
        '
        'gb_verify
        '
        Me.gb_verify.BackColor = System.Drawing.Color.Transparent
        Me.gb_verify.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer))
        Me.gb_verify.BorderColor = System.Drawing.Color.MidnightBlue
        Me.gb_verify.Controls.Add(Me.GunaGradient2Panel3)
        Me.gb_verify.Controls.Add(Me.kod4)
        Me.gb_verify.Controls.Add(Me.kod3)
        Me.gb_verify.Controls.Add(Me.kod2)
        Me.gb_verify.Controls.Add(Me.kod1)
        Me.gb_verify.Controls.Add(Me.GunaGradientButton3)
        Me.gb_verify.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb_verify.LineColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.gb_verify.Location = New System.Drawing.Point(8, 211)
        Me.gb_verify.Name = "gb_verify"
        Me.gb_verify.Radius = 10
        Me.gb_verify.Size = New System.Drawing.Size(470, 129)
        Me.gb_verify.TabIndex = 34
        Me.gb_verify.Text = "Captcha"
        Me.gb_verify.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.n4)
        Me.GunaGradient2Panel3.Controls.Add(Me.n3)
        Me.GunaGradient2Panel3.Controls.Add(Me.n2)
        Me.GunaGradient2Panel3.Controls.Add(Me.n1)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(58,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(58,Byte),Integer))
        Me.GunaGradient2Panel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(15, 47)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(219, 75)
        Me.GunaGradient2Panel3.TabIndex = 35
        '
        'n4
        '
        Me.n4.AutoSize = true
        Me.n4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n4.Location = New System.Drawing.Point(163, 11)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(50, 55)
        Me.n4.TabIndex = 3
        Me.n4.Text = "_"
        '
        'n3
        '
        Me.n3.AutoSize = true
        Me.n3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n3.Location = New System.Drawing.Point(110, 11)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(50, 55)
        Me.n3.TabIndex = 2
        Me.n3.Text = "_"
        '
        'n2
        '
        Me.n2.AutoSize = true
        Me.n2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n2.Location = New System.Drawing.Point(59, 11)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(50, 55)
        Me.n2.TabIndex = 1
        Me.n2.Text = "_"
        '
        'n1
        '
        Me.n1.AutoSize = true
        Me.n1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n1.Location = New System.Drawing.Point(10, 11)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(50, 55)
        Me.n1.TabIndex = 0
        Me.n1.Text = "_"
        '
        'kod4
        '
        Me.kod4.BackColor = System.Drawing.Color.Transparent
        Me.kod4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod4.BorderColor = System.Drawing.Color.Aqua
        Me.kod4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod4.FocusedBaseColor = System.Drawing.Color.White
        Me.kod4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod4.Location = New System.Drawing.Point(405, 49)
        Me.kod4.MaxLength = 1
        Me.kod4.Name = "kod4"
        Me.kod4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod4.Radius = 5
        Me.kod4.Size = New System.Drawing.Size(46, 70)
        Me.kod4.TabIndex = 34
        Me.kod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod3
        '
        Me.kod3.BackColor = System.Drawing.Color.Transparent
        Me.kod3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod3.BorderColor = System.Drawing.Color.Aqua
        Me.kod3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod3.FocusedBaseColor = System.Drawing.Color.White
        Me.kod3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod3.Location = New System.Drawing.Point(353, 49)
        Me.kod3.MaxLength = 1
        Me.kod3.Name = "kod3"
        Me.kod3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod3.Radius = 5
        Me.kod3.Size = New System.Drawing.Size(46, 70)
        Me.kod3.TabIndex = 33
        Me.kod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod2
        '
        Me.kod2.BackColor = System.Drawing.Color.Transparent
        Me.kod2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod2.BorderColor = System.Drawing.Color.Aqua
        Me.kod2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod2.FocusedBaseColor = System.Drawing.Color.White
        Me.kod2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod2.Location = New System.Drawing.Point(301, 49)
        Me.kod2.MaxLength = 1
        Me.kod2.Name = "kod2"
        Me.kod2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod2.Radius = 5
        Me.kod2.Size = New System.Drawing.Size(46, 70)
        Me.kod2.TabIndex = 32
        Me.kod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod1
        '
        Me.kod1.BackColor = System.Drawing.Color.Transparent
        Me.kod1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod1.BorderColor = System.Drawing.Color.Aqua
        Me.kod1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod1.FocusedBaseColor = System.Drawing.Color.White
        Me.kod1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod1.Location = New System.Drawing.Point(249, 49)
        Me.kod1.MaxLength = 1
        Me.kod1.Name = "kod1"
        Me.kod1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod1.Radius = 5
        Me.kod1.Size = New System.Drawing.Size(46, 69)
        Me.kod1.TabIndex = 31
        Me.kod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGradientButton3
        '
        Me.GunaGradientButton3.Animated = true
        Me.GunaGradientButton3.AnimationHoverSpeed = 10!
        Me.GunaGradientButton3.AnimationSpeed = 10!
        Me.GunaGradientButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton3.BaseColor1 = System.Drawing.Color.Indigo
        Me.GunaGradientButton3.BaseColor2 = System.Drawing.Color.MidnightBlue
        Me.GunaGradientButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaGradientButton3.BorderSize = 1
        Me.GunaGradientButton3.Enabled = false
        Me.GunaGradientButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton3.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GunaGradientButton3.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.GunaGradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaGradientButton3.ImageOffsetX = -5
        Me.GunaGradientButton3.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaGradientButton3.Location = New System.Drawing.Point(116, 148)
        Me.GunaGradientButton3.Name = "GunaGradientButton3"
        Me.GunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(117,Byte),Integer), CType(CType(252,Byte),Integer))
        Me.GunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(106,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(203,Byte),Integer))
        Me.GunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton3.OnHoverImage = Nothing
        Me.GunaGradientButton3.OnPressedColor = System.Drawing.Color.Crimson
        Me.GunaGradientButton3.Radius = 5
        Me.GunaGradientButton3.Size = New System.Drawing.Size(235, 60)
        Me.GunaGradientButton3.TabIndex = 29
        Me.GunaGradientButton3.Text = "Gönder"
        Me.GunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 10
        Me.GunaElipse2.TargetControl = Me
        '
        'block
        '
        Me.block.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.block.BaseColor = System.Drawing.Color.Transparent
        Me.block.Controls.Add(Me.btnOK)
        Me.block.Controls.Add(Me.nulltime)
        Me.block.Controls.Add(Me.GunaLabel5)
        Me.block.Controls.Add(Me.verify_box)
        Me.block.Controls.Add(Me.block_box)
        Me.block.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.block.Location = New System.Drawing.Point(-2, 53)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(492, 388)
        Me.block.TabIndex = 43
        Me.block.Visible = false
        '
        'btnOK
        '
        Me.btnOK.Animated = true
        Me.btnOK.AnimationHoverSpeed = 5!
        Me.btnOK.AnimationSpeed = 5!
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.btnOK.BorderColor = System.Drawing.Color.Black
        Me.btnOK.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnOK.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnOK.CheckedForeColor = System.Drawing.Color.White
        Me.btnOK.CheckedImage = CType(resources.GetObject("btnOK.CheckedImage"),System.Drawing.Image)
        Me.btnOK.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnOK.FocusedColor = System.Drawing.Color.Empty
        Me.btnOK.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Aqua
        Me.btnOK.Image = Global.HBR_Library_System.My.Resources.Resources.approval_96px
        Me.btnOK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnOK.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnOK.LineBottom = 3
        Me.btnOK.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.btnOK.Location = New System.Drawing.Point(151, 293)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOK.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnOK.OnHoverImage = Nothing
        Me.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnOK.OnPressedColor = System.Drawing.Color.Black
        Me.btnOK.Radius = 5
        Me.btnOK.Size = New System.Drawing.Size(190, 61)
        Me.btnOK.TabIndex = 88
        Me.btnOK.Text = "Tamam"
        Me.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnOK.TextOffsetX = 15
        '
        'nulltime
        '
        Me.nulltime.AutoSize = true
        Me.nulltime.Font = New System.Drawing.Font("Trebuchet MS", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.nulltime.ForeColor = System.Drawing.Color.White
        Me.nulltime.Location = New System.Drawing.Point(182, 306)
        Me.nulltime.Name = "nulltime"
        Me.nulltime.Size = New System.Drawing.Size(7, 2)
        Me.nulltime.TabIndex = 48
        Me.nulltime.Text = "wnull"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Trebuchet MS", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(113, 40)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(247, 24)
        Me.GunaLabel5.TabIndex = 46
        Me.GunaLabel5.Text = "Oops! bir hata oldu galiba.."
        '
        'verify_box
        '
        Me.verify_box.BackColor = System.Drawing.Color.Transparent
        Me.verify_box.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer))
        Me.verify_box.BorderColor = System.Drawing.Color.MidnightBlue
        Me.verify_box.Controls.Add(Me.GunaLabel9)
        Me.verify_box.Controls.Add(Me.error_desc)
        Me.verify_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.verify_box.LineColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.verify_box.Location = New System.Drawing.Point(16, 78)
        Me.verify_box.Name = "verify_box"
        Me.verify_box.Size = New System.Drawing.Size(462, 206)
        Me.verify_box.TabIndex = 47
        Me.verify_box.Text = "HATA"
        Me.verify_box.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = true
        Me.GunaLabel9.Font = New System.Drawing.Font("Trebuchet MS", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Gray
        Me.GunaLabel9.Location = New System.Drawing.Point(6, 183)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(140, 16)
        Me.GunaLabel9.TabIndex = 39
        Me.GunaLabel9.Text = "Lütfen Tekrar Deneyiniz..."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'error_desc
        '
        Me.error_desc.AutoSize = true
        Me.error_desc.Font = New System.Drawing.Font("Trebuchet MS", 19!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.error_desc.ForeColor = System.Drawing.Color.White
        Me.error_desc.Location = New System.Drawing.Point(11, 59)
        Me.error_desc.Name = "error_desc"
        Me.error_desc.Size = New System.Drawing.Size(179, 33)
        Me.error_desc.TabIndex = 38
        Me.error_desc.Text = "#error_name#"
        '
        'block_box
        '
        Me.block_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.block_box.Location = New System.Drawing.Point(3, 19)
        Me.block_box.Name = "block_box"
        Me.block_box.Size = New System.Drawing.Size(484, 348)
        Me.block_box.TabIndex = 45
        Me.block_box.TabStop = false
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 6
        Me.GunaElipse3.TargetControl = Me
        '
        'verifybox
        '
        Me.verifybox.Radius = 7
        Me.verifybox.TargetControl = Me.verify_box
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = true
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.GunaLabel10.Location = New System.Drawing.Point(59, 423)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(263, 18)
        Me.GunaLabel10.TabIndex = 46
        Me.GunaLabel10.Text = "hbr.a9c591e493cd681ace9fdd66999a1215+3"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = true
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(7, 422)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(49, 18)
        Me.GunaLabel11.TabIndex = 47
        Me.GunaLabel11.Text = "Debug:"
        '
        'boxerrorheader_radius
        '
        Me.boxerrorheader_radius.Radius = 7
        Me.boxerrorheader_radius.TargetControl = Me.gb_verify
        '
        'header_switcher
        '
        Me.header_switcher.Enabled = true
        Me.header_switcher.Interval = 5000
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HIDE
        Me.GunaAnimateWindow1.Interval = 1000
        Me.GunaAnimateWindow1.TargetControl = Me.header_title
        '
        'header_title
        '
        Me.header_title.AutoSize = true
        Me.header_title.BackColor = System.Drawing.Color.Transparent
        Me.header_title.Font = New System.Drawing.Font("Trebuchet MS", 17!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.header_title.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.header_title.Location = New System.Drawing.Point(110, 7)
        Me.header_title.Name = "header_title"
        Me.header_title.Size = New System.Drawing.Size(265, 28)
        Me.header_title.TabIndex = 32
        Me.header_title.Text = "HBR Kütüphane Sistemi"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(328, 422)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(98, 15)
        Me.GunaLabel3.TabIndex = 48
        Me.GunaLabel3.Text = "app version: 4.0.0"
        '
        'time_updater
        '
        Me.time_updater.Enabled = true
        Me.time_updater.Interval = 1000
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Header.BorderColor = System.Drawing.Color.Transparent
        Me.Header.Controls.Add(Me.header_title)
        Me.Header.Controls.Add(Me.GunaLabel4)
        Me.Header.Controls.Add(Me.header_kapat)
        Me.Header.Controls.Add(Me.header_icon)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.Header.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.Header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.Header.HeaderMaximize = false
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(490, 52)
        Me.Header.TabIndex = 30
        Me.Header.Text = "Header"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(199, 33)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(82, 18)
        Me.GunaLabel4.TabIndex = 89
        Me.GunaLabel4.Text = "Yetkili Girişi"
        '
        'header_kapat
        '
        Me.header_kapat.Animated = true
        Me.header_kapat.AnimationHoverSpeed = 10!
        Me.header_kapat.AnimationSpeed = 10!
        Me.header_kapat.BackColor = System.Drawing.Color.Transparent
        Me.header_kapat.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(241,Byte),Integer))
        Me.header_kapat.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(92,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.header_kapat.BorderColor = System.Drawing.Color.Black
        Me.header_kapat.FocusedColor = System.Drawing.Color.Empty
        Me.header_kapat.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.header_kapat.ForeColor = System.Drawing.Color.White
        Me.header_kapat.Image = Nothing
        Me.header_kapat.ImageSize = New System.Drawing.Size(20, 20)
        Me.header_kapat.Location = New System.Drawing.Point(435, 11)
        Me.header_kapat.Name = "header_kapat"
        Me.header_kapat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(99,Byte),Integer))
        Me.header_kapat.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.header_kapat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.header_kapat.OnHoverForeColor = System.Drawing.Color.White
        Me.header_kapat.OnHoverImage = Nothing
        Me.header_kapat.OnPressedColor = System.Drawing.Color.Black
        Me.header_kapat.Radius = 6
        Me.header_kapat.Size = New System.Drawing.Size(43, 33)
        Me.header_kapat.TabIndex = 4
        Me.header_kapat.Text = "X"
        Me.header_kapat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'header_icon
        '
        Me.header_icon.BackColor = System.Drawing.Color.Transparent
        Me.header_icon.BaseColor = System.Drawing.Color.Transparent
        Me.header_icon.Image = Global.HBR_Library_System.My.Resources.Resources.password_96px
        Me.header_icon.InitialImage = CType(resources.GetObject("header_icon.InitialImage"),System.Drawing.Image)
        Me.header_icon.Location = New System.Drawing.Point(-2, 3)
        Me.header_icon.Name = "header_icon"
        Me.header_icon.Size = New System.Drawing.Size(59, 44)
        Me.header_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header_icon.TabIndex = 3
        Me.header_icon.TabStop = false
        '
        'piyon
        '
        Me.piyon.BackColor = System.Drawing.Color.Transparent
        Me.piyon.Location = New System.Drawing.Point(311, 359)
        Me.piyon.MaxLength = 32767
        Me.piyon.Multiline = false
        Me.piyon.Name = "piyon"
        Me.piyon.ReadOnly = false
        Me.piyon.Size = New System.Drawing.Size(10, 29)
        Me.piyon.TabIndex = 33
        Me.piyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.piyon.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.piyon.UseSystemPasswordChar = false
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = true
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 10!
        Me.GunaAdvenceButton1.AnimationSpeed = 10!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.icons8_plus_96px
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Aqua
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.developer_64px
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaAdvenceButton1.LineBottom = 3
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.Aqua
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(12, 353)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 8
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(107, 49)
        Me.GunaAdvenceButton1.TabIndex = 87
        Me.GunaAdvenceButton1.Text = "Developer"
        '
        'login
        '
        Me.login.Animated = true
        Me.login.AnimationHoverSpeed = 5!
        Me.login.AnimationSpeed = 5!
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.login.BorderColor = System.Drawing.Color.Black
        Me.login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.login.CheckedBorderColor = System.Drawing.Color.Black
        Me.login.CheckedForeColor = System.Drawing.Color.White
        Me.login.CheckedImage = CType(resources.GetObject("login.CheckedImage"),System.Drawing.Image)
        Me.login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.login.FocusedColor = System.Drawing.Color.Empty
        Me.login.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.login.ForeColor = System.Drawing.Color.Aqua
        Me.login.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.login.ImageSize = New System.Drawing.Size(32, 32)
        Me.login.LineBottom = 3
        Me.login.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.login.Location = New System.Drawing.Point(257, 346)
        Me.login.Name = "login"
        Me.login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.login.OnHoverBorderColor = System.Drawing.Color.Black
        Me.login.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.login.OnHoverImage = Nothing
        Me.login.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.login.OnPressedColor = System.Drawing.Color.Black
        Me.login.Radius = 10
        Me.login.Size = New System.Drawing.Size(221, 60)
        Me.login.TabIndex = 86
        Me.login.Text = "Giriş Yap"
        Me.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnContact
        '
        Me.btnContact.Animated = true
        Me.btnContact.AnimationHoverSpeed = 10!
        Me.btnContact.AnimationSpeed = 10!
        Me.btnContact.BackColor = System.Drawing.Color.Transparent
        Me.btnContact.BaseColor = System.Drawing.Color.Transparent
        Me.btnContact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnContact.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnContact.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnContact.CheckedForeColor = System.Drawing.Color.White
        Me.btnContact.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.icons8_plus_96px
        Me.btnContact.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnContact.FocusedColor = System.Drawing.Color.Empty
        Me.btnContact.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btnContact.ForeColor = System.Drawing.Color.Aqua
        Me.btnContact.Image = Global.HBR_Library_System.My.Resources.Resources.collaboration_96px
        Me.btnContact.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnContact.LineBottom = 3
        Me.btnContact.LineColor = System.Drawing.Color.Aqua
        Me.btnContact.Location = New System.Drawing.Point(123, 346)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.btnContact.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.btnContact.OnHoverForeColor = System.Drawing.Color.White
        Me.btnContact.OnHoverImage = Nothing
        Me.btnContact.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnContact.OnPressedColor = System.Drawing.Color.Black
        Me.btnContact.Radius = 8
        Me.btnContact.Size = New System.Drawing.Size(128, 60)
        Me.btnContact.TabIndex = 50
        Me.btnContact.Text = "İletişim"
        '
        'Login_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24,Byte),Integer), CType(CType(27,Byte),Integer), CType(CType(33,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(490, 441)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.btnContact)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel11)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.gb_verify)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.piyon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Login_Panel"
        Me.Text = "Oturum Aç"
        Me.gb_verify.ResumeLayout(false)
        Me.GunaGradient2Panel3.ResumeLayout(false)
        Me.GunaGradient2Panel3.PerformLayout
        Me.block.ResumeLayout(false)
        Me.block.PerformLayout
        Me.verify_box.ResumeLayout(false)
        Me.verify_box.PerformLayout
        CType(Me.block_box,System.ComponentModel.ISupportInitialize).EndInit
        Me.Header.ResumeLayout(false)
        Me.Header.PerformLayout
        CType(Me.header_icon,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents uname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents user As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents pw As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Header As FormSkin
    Friend WithEvents header_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents gb_verify As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents n4 As Label
    Friend WithEvents n3 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents n1 As Label
    Friend WithEvents kod4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents piyon As FlatTextBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents block As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents verify_box As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_desc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents block_box As PictureBox
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents nulltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents verifybox As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents boxerrorheader_radius As Guna.UI.WinForms.GunaElipse
    Friend WithEvents header_switcher As Timer
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents btnContact As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents time_updater As Timer
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
