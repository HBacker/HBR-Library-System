<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Panel
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_Panel))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
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
        Me.block = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnOK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.nulltime = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.error_box = New Guna.UI.WinForms.GunaGroupBox()
        Me.error_desc = New Guna.UI.WinForms.GunaLabel()
        Me.piyon = New System.Windows.Forms.TextBox()
        Me.block_box = New System.Windows.Forms.PictureBox()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.wc1 = New System.Windows.Forms.Timer(Me.components)
        Me.wc2 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.header_kapat = New Guna.UI.WinForms.GunaGradientButton()
        Me.header_icon = New Guna.UI.WinForms.GunaPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Header = New HBR_Library_System.FormSkin()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.auth_name = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.username = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.password = New Guna.UI.WinForms.GunaTextBox()
        Me.level_standart = New Guna.UI.WinForms.GunaRadioButton()
        Me.level_high = New Guna.UI.WinForms.GunaRadioButton()
        Me.register = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnNew = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.header_title = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btnHelp = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.gb_verify.SuspendLayout
        Me.GunaGradient2Panel3.SuspendLayout
        Me.block.SuspendLayout
        Me.error_box.SuspendLayout
        CType(Me.block_box,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.header_icon,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Header.SuspendLayout
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 7
        Me.GunaElipse2.TargetControl = Me.gb_verify
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
        Me.gb_verify.Location = New System.Drawing.Point(8, 254)
        Me.gb_verify.Name = "gb_verify"
        Me.gb_verify.Size = New System.Drawing.Size(433, 108)
        Me.gb_verify.TabIndex = 56
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
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(13, 38)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(199, 61)
        Me.GunaGradient2Panel3.TabIndex = 35
        '
        'n4
        '
        Me.n4.AutoSize = true
        Me.n4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n4.Location = New System.Drawing.Point(148, 6)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(50, 55)
        Me.n4.TabIndex = 3
        Me.n4.Text = "_"
        '
        'n3
        '
        Me.n3.AutoSize = true
        Me.n3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n3.Location = New System.Drawing.Point(96, 6)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(50, 55)
        Me.n3.TabIndex = 2
        Me.n3.Text = "_"
        '
        'n2
        '
        Me.n2.AutoSize = true
        Me.n2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n2.Location = New System.Drawing.Point(46, 6)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(50, 55)
        Me.n2.TabIndex = 1
        Me.n2.Text = "_"
        '
        'n1
        '
        Me.n1.AutoSize = true
        Me.n1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.n1.Location = New System.Drawing.Point(2, 6)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(50, 55)
        Me.n1.TabIndex = 0
        Me.n1.Text = "_"
        '
        'kod4
        '
        Me.kod4.BackColor = System.Drawing.Color.Transparent
        Me.kod4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod4.FocusedBaseColor = System.Drawing.Color.White
        Me.kod4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod4.Location = New System.Drawing.Point(374, 38)
        Me.kod4.MaxLength = 1
        Me.kod4.Name = "kod4"
        Me.kod4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod4.Radius = 5
        Me.kod4.Size = New System.Drawing.Size(46, 61)
        Me.kod4.TabIndex = 34
        Me.kod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod3
        '
        Me.kod3.BackColor = System.Drawing.Color.Transparent
        Me.kod3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod3.FocusedBaseColor = System.Drawing.Color.White
        Me.kod3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod3.Location = New System.Drawing.Point(321, 38)
        Me.kod3.MaxLength = 1
        Me.kod3.Name = "kod3"
        Me.kod3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod3.Radius = 5
        Me.kod3.Size = New System.Drawing.Size(46, 61)
        Me.kod3.TabIndex = 33
        Me.kod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod2
        '
        Me.kod2.BackColor = System.Drawing.Color.Transparent
        Me.kod2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod2.FocusedBaseColor = System.Drawing.Color.White
        Me.kod2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod2.Location = New System.Drawing.Point(270, 38)
        Me.kod2.MaxLength = 1
        Me.kod2.Name = "kod2"
        Me.kod2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod2.Radius = 5
        Me.kod2.Size = New System.Drawing.Size(46, 61)
        Me.kod2.TabIndex = 32
        Me.kod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kod1
        '
        Me.kod1.BackColor = System.Drawing.Color.Transparent
        Me.kod1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.kod1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kod1.FocusedBaseColor = System.Drawing.Color.White
        Me.kod1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.kod1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.kod1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.kod1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kod1.Location = New System.Drawing.Point(218, 38)
        Me.kod1.MaxLength = 1
        Me.kod1.Name = "kod1"
        Me.kod1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kod1.Radius = 5
        Me.kod1.Size = New System.Drawing.Size(46, 61)
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
        'block
        '
        Me.block.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.block.BaseColor = System.Drawing.Color.Transparent
        Me.block.Controls.Add(Me.btnOK)
        Me.block.Controls.Add(Me.nulltime)
        Me.block.Controls.Add(Me.GunaLabel9)
        Me.block.Controls.Add(Me.GunaLabel5)
        Me.block.Controls.Add(Me.error_box)
        Me.block.Controls.Add(Me.piyon)
        Me.block.Controls.Add(Me.block_box)
        Me.block.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.block.Location = New System.Drawing.Point(0, 53)
        Me.block.Name = "block"
        Me.block.Size = New System.Drawing.Size(449, 379)
        Me.block.TabIndex = 57
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
        Me.btnOK.Location = New System.Drawing.Point(134, 251)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOK.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnOK.OnHoverImage = Nothing
        Me.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnOK.OnPressedColor = System.Drawing.Color.Black
        Me.btnOK.Radius = 5
        Me.btnOK.Size = New System.Drawing.Size(190, 61)
        Me.btnOK.TabIndex = 89
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
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = true
        Me.GunaLabel9.Font = New System.Drawing.Font("Trebuchet MS", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(12, 329)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(197, 22)
        Me.GunaLabel9.TabIndex = 39
        Me.GunaLabel9.Text = "Lütfen Tekrar Deneyiniz..."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(70, 29)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(348, 35)
        Me.GunaLabel5.TabIndex = 46
        Me.GunaLabel5.Text = "Oops! bir hata oldu galiba.."
        '
        'error_box
        '
        Me.error_box.BackColor = System.Drawing.Color.Transparent
        Me.error_box.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer), CType(CType(14,Byte),Integer))
        Me.error_box.BorderColor = System.Drawing.Color.MidnightBlue
        Me.error_box.Controls.Add(Me.error_desc)
        Me.error_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.error_box.LineColor = System.Drawing.Color.MidnightBlue
        Me.error_box.Location = New System.Drawing.Point(16, 78)
        Me.error_box.Name = "error_box"
        Me.error_box.Size = New System.Drawing.Size(425, 167)
        Me.error_box.TabIndex = 47
        Me.error_box.Text = "HATA"
        Me.error_box.TextLocation = New System.Drawing.Point(10, 8)
        '
        'error_desc
        '
        Me.error_desc.AutoSize = true
        Me.error_desc.Dock = System.Windows.Forms.DockStyle.Left
        Me.error_desc.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.error_desc.ForeColor = System.Drawing.Color.White
        Me.error_desc.Location = New System.Drawing.Point(0, 0)
        Me.error_desc.Name = "error_desc"
        Me.error_desc.Padding = New System.Windows.Forms.Padding(17, 45, 0, 0)
        Me.error_desc.Size = New System.Drawing.Size(215, 82)
        Me.error_desc.TabIndex = 38
        Me.error_desc.Text = "#error_name#"
        Me.error_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'piyon
        '
        Me.piyon.Location = New System.Drawing.Point(172, 275)
        Me.piyon.Name = "piyon"
        Me.piyon.Size = New System.Drawing.Size(13, 20)
        Me.piyon.TabIndex = 49
        '
        'block_box
        '
        Me.block_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.block_box.Location = New System.Drawing.Point(3, 20)
        Me.block_box.Name = "block_box"
        Me.block_box.Size = New System.Drawing.Size(446, 337)
        Me.block_box.TabIndex = 45
        Me.block_box.TabStop = false
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 7
        Me.GunaElipse3.TargetControl = Me.error_box
        '
        'wc1
        '
        Me.wc1.Interval = 1000
        '
        'wc2
        '
        Me.wc2.Interval = 1000
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GunaLabel3.Location = New System.Drawing.Point(96, 15)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(250, 27)
        Me.GunaLabel3.TabIndex = 32
        Me.GunaLabel3.Text = "Kullanıcı Arayüzü >> Kayıt"
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
        Me.header_kapat.Location = New System.Drawing.Point(398, 9)
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
        Me.header_icon.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.header_icon.InitialImage = CType(resources.GetObject("header_icon.InitialImage"),System.Drawing.Image)
        Me.header_icon.Location = New System.Drawing.Point(44, 5)
        Me.header_icon.Name = "header_icon"
        Me.header_icon.Size = New System.Drawing.Size(59, 44)
        Me.header_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.header_icon.TabIndex = 3
        Me.header_icon.TabStop = false
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1000
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.White
        Me.Header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Header.BorderColor = System.Drawing.Color.Transparent
        Me.Header.Controls.Add(Me.header_title)
        Me.Header.Controls.Add(Me.GunaLabel7)
        Me.Header.Controls.Add(Me.GunaGradientButton2)
        Me.Header.Controls.Add(Me.GunaPictureBox1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.Header.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.Header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.Header.HeaderMaximize = false
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(449, 52)
        Me.Header.TabIndex = 58
        Me.Header.Text = "Header"
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.Animated = true
        Me.GunaGradientButton2.AnimationHoverSpeed = 10!
        Me.GunaGradientButton2.AnimationSpeed = 10!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(241,Byte),Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(40,Byte),Integer), CType(CType(92,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(397, 9)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(186,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(99,Byte),Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 6
        Me.GunaGradientButton2.Size = New System.Drawing.Size(43, 33)
        Me.GunaGradientButton2.TabIndex = 4
        Me.GunaGradientButton2.Text = "X"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.GunaPictureBox1.InitialImage = CType(resources.GetObject("GunaPictureBox1.InitialImage"),System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-2, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(59, 44)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = false
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel2.Location = New System.Drawing.Point(17, 76)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(98, 24)
        Me.GunaLabel2.TabIndex = 61
        Me.GunaLabel2.Text = "Ad Soyad:"
        '
        'auth_name
        '
        Me.auth_name.BackColor = System.Drawing.Color.Transparent
        Me.auth_name.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.auth_name.BorderColor = System.Drawing.Color.Aqua
        Me.auth_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.auth_name.FocusedBaseColor = System.Drawing.Color.White
        Me.auth_name.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.auth_name.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.auth_name.Font = New System.Drawing.Font("Tahoma", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.auth_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.auth_name.Location = New System.Drawing.Point(161, 68)
        Me.auth_name.MaxLength = 16
        Me.auth_name.Name = "auth_name"
        Me.auth_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.auth_name.Radius = 5
        Me.auth_name.Size = New System.Drawing.Size(276, 43)
        Me.auth_name.TabIndex = 60
        Me.auth_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel1.Location = New System.Drawing.Point(17, 125)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(129, 24)
        Me.GunaLabel1.TabIndex = 63
        Me.GunaLabel1.Text = "Kullanıcı Adı:"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.Transparent
        Me.username.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.username.BorderColor = System.Drawing.Color.Aqua
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.FocusedBaseColor = System.Drawing.Color.White
        Me.username.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.username.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.username.Font = New System.Drawing.Font("Tahoma", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.username.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.username.Location = New System.Drawing.Point(161, 117)
        Me.username.MaxLength = 16
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.Radius = 5
        Me.username.Size = New System.Drawing.Size(276, 43)
        Me.username.TabIndex = 62
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel4.Location = New System.Drawing.Point(17, 220)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(129, 24)
        Me.GunaLabel4.TabIndex = 67
        Me.GunaLabel4.Text = "Yetki Düzeyi:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.Aqua
        Me.GunaLabel6.Location = New System.Drawing.Point(17, 174)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(59, 24)
        Me.GunaLabel6.TabIndex = 65
        Me.GunaLabel6.Text = "Şifre:"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(47,Byte),Integer))
        Me.password.BorderColor = System.Drawing.Color.Aqua
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.FocusedBaseColor = System.Drawing.Color.White
        Me.password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.password.FocusedForeColor = System.Drawing.Color.MidnightBlue
        Me.password.Font = New System.Drawing.Font("Tahoma", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.password.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.password.Location = New System.Drawing.Point(161, 166)
        Me.password.MaxLength = 16
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Radius = 5
        Me.password.Size = New System.Drawing.Size(276, 43)
        Me.password.TabIndex = 64
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.UseSystemPasswordChar = true
        '
        'level_standart
        '
        Me.level_standart.BaseColor = System.Drawing.SystemColors.Control
        Me.level_standart.Checked = true
        Me.level_standart.CheckedOffColor = System.Drawing.Color.Gray
        Me.level_standart.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.level_standart.FillColor = System.Drawing.Color.White
        Me.level_standart.Font = New System.Drawing.Font("Trebuchet MS", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.level_standart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.level_standart.Location = New System.Drawing.Point(163, 219)
        Me.level_standart.Name = "level_standart"
        Me.level_standart.Size = New System.Drawing.Size(111, 28)
        Me.level_standart.TabIndex = 68
        Me.level_standart.Text = "Standart"
        '
        'level_high
        '
        Me.level_high.BaseColor = System.Drawing.SystemColors.Control
        Me.level_high.CheckedOffColor = System.Drawing.Color.Gray
        Me.level_high.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.level_high.FillColor = System.Drawing.Color.White
        Me.level_high.Font = New System.Drawing.Font("Trebuchet MS", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.level_high.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.level_high.Location = New System.Drawing.Point(280, 219)
        Me.level_high.Name = "level_high"
        Me.level_high.Size = New System.Drawing.Size(125, 28)
        Me.level_high.TabIndex = 69
        Me.level_high.Text = "Üst-Düzey"
        '
        'register
        '
        Me.register.Animated = true
        Me.register.AnimationHoverSpeed = 5!
        Me.register.AnimationSpeed = 5!
        Me.register.BackColor = System.Drawing.Color.Transparent
        Me.register.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.register.BorderColor = System.Drawing.Color.Black
        Me.register.CheckedBaseColor = System.Drawing.Color.Gray
        Me.register.CheckedBorderColor = System.Drawing.Color.Black
        Me.register.CheckedForeColor = System.Drawing.Color.White
        Me.register.CheckedImage = CType(resources.GetObject("register.CheckedImage"),System.Drawing.Image)
        Me.register.CheckedLineColor = System.Drawing.Color.DimGray
        Me.register.FocusedColor = System.Drawing.Color.Empty
        Me.register.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.register.ForeColor = System.Drawing.Color.Aqua
        Me.register.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.register.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.register.ImageSize = New System.Drawing.Size(32, 32)
        Me.register.LineBottom = 3
        Me.register.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.register.Location = New System.Drawing.Point(226, 368)
        Me.register.Name = "register"
        Me.register.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.register.OnHoverBorderColor = System.Drawing.Color.Black
        Me.register.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.register.OnHoverImage = Nothing
        Me.register.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.register.OnPressedColor = System.Drawing.Color.Black
        Me.register.Radius = 10
        Me.register.Size = New System.Drawing.Size(214, 53)
        Me.register.TabIndex = 87
        Me.register.Text = "Ekle"
        Me.register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNew
        '
        Me.btnNew.Animated = true
        Me.btnNew.AnimationHoverSpeed = 10!
        Me.btnNew.AnimationSpeed = 10!
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BaseColor = System.Drawing.Color.Transparent
        Me.btnNew.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnNew.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNew.CheckedBorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNew.CheckedForeColor = System.Drawing.Color.White
        Me.btnNew.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.icons8_plus_96px
        Me.btnNew.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnNew.FocusedColor = System.Drawing.Color.Empty
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btnNew.ForeColor = System.Drawing.Color.Aqua
        Me.btnNew.Image = Global.HBR_Library_System.My.Resources.Resources.icons8_plus_96px
        Me.btnNew.ImageSize = New System.Drawing.Size(42, 42)
        Me.btnNew.LineBottom = 3
        Me.btnNew.LineColor = System.Drawing.Color.Aqua
        Me.btnNew.Location = New System.Drawing.Point(91, 368)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.btnNew.OnHoverBorderColor = System.Drawing.Color.MidnightBlue
        Me.btnNew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNew.OnHoverImage = Nothing
        Me.btnNew.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnNew.OnPressedColor = System.Drawing.Color.Black
        Me.btnNew.Radius = 8
        Me.btnNew.Size = New System.Drawing.Size(128, 53)
        Me.btnNew.TabIndex = 88
        Me.btnNew.Text = "Yeni Kayıt"
        '
        'header_title
        '
        Me.header_title.AutoSize = true
        Me.header_title.BackColor = System.Drawing.Color.Transparent
        Me.header_title.Font = New System.Drawing.Font("Trebuchet MS", 17!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.header_title.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.header_title.Location = New System.Drawing.Point(99, 7)
        Me.header_title.Name = "header_title"
        Me.header_title.Size = New System.Drawing.Size(265, 28)
        Me.header_title.TabIndex = 33
        Me.header_title.Text = "HBR Kütüphane Sistemi"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = true
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Trebuchet MS", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(181, 32)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(76, 18)
        Me.GunaLabel7.TabIndex = 90
        Me.GunaLabel7.Text = "Yetkili Ekle"
        '
        'btnHelp
        '
        Me.btnHelp.Animated = true
        Me.btnHelp.AnimationHoverSpeed = 3!
        Me.btnHelp.AnimationSpeed = 3!
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.btnHelp.BorderColor = System.Drawing.Color.Black
        Me.btnHelp.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHelp.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHelp.CheckedForeColor = System.Drawing.Color.White
        Me.btnHelp.CheckedImage = CType(resources.GetObject("btnHelp.CheckedImage"),System.Drawing.Image)
        Me.btnHelp.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHelp.FocusedColor = System.Drawing.Color.Empty
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.btnHelp.ForeColor = System.Drawing.Color.Aqua
        Me.btnHelp.Image = Global.HBR_Library_System.My.Resources.Resources.help_gradient_32
        Me.btnHelp.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnHelp.LineBottom = 1
        Me.btnHelp.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnHelp.LineLeft = 1
        Me.btnHelp.LineRight = 1
        Me.btnHelp.LineTop = 1
        Me.btnHelp.Location = New System.Drawing.Point(12, 378)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnHelp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHelp.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnHelp.OnHoverImage = Nothing
        Me.btnHelp.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnHelp.OnPressedColor = System.Drawing.Color.Black
        Me.btnHelp.Radius = 2
        Me.btnHelp.Size = New System.Drawing.Size(52, 38)
        Me.btnHelp.TabIndex = 89
        Me.btnHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnHelp.TextOffsetX = 18
        '
        'Kullanıcı_Kayıt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(449, 428)
        Me.Controls.Add(Me.block)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.level_high)
        Me.Controls.Add(Me.level_standart)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.auth_name)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.gb_verify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Kullanıcı_Kayıt"
        Me.Text = "Yeni Kullanıcı Kaydı"
        Me.TopMost = true
        Me.gb_verify.ResumeLayout(false)
        Me.GunaGradient2Panel3.ResumeLayout(false)
        Me.GunaGradient2Panel3.PerformLayout
        Me.block.ResumeLayout(false)
        Me.block.PerformLayout
        Me.error_box.ResumeLayout(false)
        Me.error_box.PerformLayout
        CType(Me.block_box,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.header_icon,System.ComponentModel.ISupportInitialize).EndInit
        Me.Header.ResumeLayout(false)
        Me.Header.PerformLayout
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents block As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents nulltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_box As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents error_desc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents block_box As PictureBox
    Friend WithEvents piyon As TextBox
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
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents wc1 As Timer
    Friend WithEvents wc2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Header As FormSkin
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents level_high As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents level_standart As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents auth_name As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents register As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnNew As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents header_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnHelp As Guna.UI.WinForms.GunaAdvenceButton
End Class
