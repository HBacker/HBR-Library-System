<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppLoader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppLoader))
        Me.group_update = New Guna.UI.WinForms.GunaGroupBox()
        Me.checkingText = New Guna.UI.WinForms.GunaLabel()
        Me.update_text = New Guna.UI.WinForms.GunaLabel()
        Me.btnUPDATE = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.elipse_form = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_updategroup = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.FormSkin1 = New HBR_Library_System.FormSkin()
        Me.title = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.versionText = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.configText = New Guna.UI.WinForms.GunaLabel()
        Me.checkStatus = New System.Windows.Forms.Timer(Me.components)
        Me.restarter = New System.Windows.Forms.Timer(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.group_update.SuspendLayout
        Me.FormSkin1.SuspendLayout
        Me.GunaGroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'group_update
        '
        Me.group_update.BackColor = System.Drawing.Color.Transparent
        Me.group_update.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.group_update.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.group_update.Controls.Add(Me.checkingText)
        Me.group_update.Controls.Add(Me.versionText)
        Me.group_update.Controls.Add(Me.GunaLabel1)
        Me.group_update.Controls.Add(Me.update_text)
        Me.group_update.Controls.Add(Me.btnUPDATE)
        Me.group_update.LineColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.group_update.Location = New System.Drawing.Point(12, 69)
        Me.group_update.Name = "group_update"
        Me.group_update.Radius = 5
        Me.group_update.Size = New System.Drawing.Size(526, 108)
        Me.group_update.TabIndex = 2
        Me.group_update.Text = "Güncellemeleri Kontrol Et"
        Me.group_update.TextLocation = New System.Drawing.Point(10, 8)
        '
        'checkingText
        '
        Me.checkingText.AutoSize = true
        Me.checkingText.Font = New System.Drawing.Font("Trebuchet MS", 18!, System.Drawing.FontStyle.Bold)
        Me.checkingText.Location = New System.Drawing.Point(69, 53)
        Me.checkingText.Name = "checkingText"
        Me.checkingText.Size = New System.Drawing.Size(391, 29)
        Me.checkingText.TabIndex = 90
        Me.checkingText.Text = "Güncelleştirmeler Denetleniyor..."
        Me.checkingText.Visible = false
        '
        'update_text
        '
        Me.update_text.AutoSize = true
        Me.update_text.Font = New System.Drawing.Font("Trebuchet MS", 18!, System.Drawing.FontStyle.Bold)
        Me.update_text.Location = New System.Drawing.Point(80, 53)
        Me.update_text.Name = "update_text"
        Me.update_text.Size = New System.Drawing.Size(375, 29)
        Me.update_text.TabIndex = 2
        Me.update_text.Text = "En Son Sürümü Kullanıyorsunuz!"
        Me.update_text.Visible = false
        '
        'btnUPDATE
        '
        Me.btnUPDATE.Animated = true
        Me.btnUPDATE.AnimationHoverSpeed = 5!
        Me.btnUPDATE.AnimationSpeed = 5!
        Me.btnUPDATE.BackColor = System.Drawing.Color.Transparent
        Me.btnUPDATE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.btnUPDATE.BorderColor = System.Drawing.Color.Black
        Me.btnUPDATE.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUPDATE.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUPDATE.CheckedForeColor = System.Drawing.Color.White
        Me.btnUPDATE.CheckedImage = CType(resources.GetObject("btnUPDATE.CheckedImage"),System.Drawing.Image)
        Me.btnUPDATE.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUPDATE.FocusedColor = System.Drawing.Color.Empty
        Me.btnUPDATE.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btnUPDATE.ForeColor = System.Drawing.Color.Aqua
        Me.btnUPDATE.Image = Global.HBR_Library_System.My.Resources.Resources.downcloud_gradient_32
        Me.btnUPDATE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUPDATE.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnUPDATE.LineBottom = 3
        Me.btnUPDATE.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.btnUPDATE.Location = New System.Drawing.Point(50, 44)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnUPDATE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUPDATE.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnUPDATE.OnHoverImage = Nothing
        Me.btnUPDATE.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnUPDATE.OnPressedColor = System.Drawing.Color.Black
        Me.btnUPDATE.Radius = 5
        Me.btnUPDATE.Size = New System.Drawing.Size(432, 50)
        Me.btnUPDATE.TabIndex = 89
        Me.btnUPDATE.Text = "En Son Sürüme Güncelle"
        Me.btnUPDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUPDATE.TextOffsetX = 15
        Me.btnUPDATE.Visible = false
        '
        'elipse_form
        '
        Me.elipse_form.TargetControl = Me
        '
        'elipse_updategroup
        '
        Me.elipse_updategroup.Radius = 3
        Me.elipse_updategroup.TargetControl = Me.group_update
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(60,Byte),Integer))
        Me.FormSkin1.Controls.Add(Me.GunaAdvenceButton1)
        Me.FormSkin1.Controls.Add(Me.title)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.FormSkin1.HeaderMaximize = false
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(552, 48)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "FormSkin1"
        '
        'title
        '
        Me.title.AutoSize = true
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Montserrat", 20!, System.Drawing.FontStyle.Bold)
        Me.title.Location = New System.Drawing.Point(124, 5)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(321, 37)
        Me.title.TabIndex = 0
        Me.title.Text = "HBRLib Önyükleyicisi"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel1.Location = New System.Drawing.Point(378, 6)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(91, 18)
        Me.GunaLabel1.TabIndex = 90
        Me.GunaLabel1.Text = "mevcut sürüm:"
        '
        'versionText
        '
        Me.versionText.AutoSize = true
        Me.versionText.BackColor = System.Drawing.Color.Transparent
        Me.versionText.Font = New System.Drawing.Font("Trebuchet MS", 9!, System.Drawing.FontStyle.Bold)
        Me.versionText.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.versionText.Location = New System.Drawing.Point(464, 6)
        Me.versionText.Name = "versionText"
        Me.versionText.Size = New System.Drawing.Size(56, 18)
        Me.versionText.TabIndex = 91
        Me.versionText.Text = "$version"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.GunaGroupBox1.Controls.Add(Me.configText)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 194)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 5
        Me.GunaGroupBox1.Size = New System.Drawing.Size(526, 86)
        Me.GunaGroupBox1.TabIndex = 91
        Me.GunaGroupBox1.Text = "Konfigürasyon Dosyası Kontrol Ediliyor"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'configText
        '
        Me.configText.AutoSize = true
        Me.configText.Font = New System.Drawing.Font("Trebuchet MS", 18!, System.Drawing.FontStyle.Bold)
        Me.configText.Location = New System.Drawing.Point(42, 42)
        Me.configText.Name = "configText"
        Me.configText.Size = New System.Drawing.Size(434, 29)
        Me.configText.TabIndex = 91
        Me.configText.Text = "Konfigürasyon Dosyası Doğrulanıyor..."
        '
        'checkStatus
        '
        Me.checkStatus.Enabled = true
        Me.checkStatus.Interval = 1500
        '
        'restarter
        '
        Me.restarter.Interval = 3000
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Trebuchet MS", 9!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaLabel2.Location = New System.Drawing.Point(53, 291)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(428, 18)
        Me.GunaLabel2.TabIndex = 92
        Me.GunaLabel2.Text = "Önyükleyici Kontrollerini Tamamladığında Otomatik olarak Kapanacaktır..."
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(483, 5)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 3
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(55, 38)
        Me.GunaAdvenceButton1.TabIndex = 93
        Me.GunaAdvenceButton1.Text = "X"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.TextOffsetX = 18
        '
        'AppLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(552, 313)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.group_update)
        Me.Controls.Add(Me.FormSkin1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "AppLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HBRLib Önyükleyicisi"
        Me.group_update.ResumeLayout(false)
        Me.group_update.PerformLayout
        Me.FormSkin1.ResumeLayout(false)
        Me.FormSkin1.PerformLayout
        Me.GunaGroupBox1.ResumeLayout(false)
        Me.GunaGroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents group_update As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents update_text As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipse_form As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_updategroup As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnUPDATE As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents versionText As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents checkingText As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents configText As Guna.UI.WinForms.GunaLabel
    Friend WithEvents checkStatus As Timer
    Friend WithEvents restarter As Timer
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
