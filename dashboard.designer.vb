<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.elipse_main = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.panel_menu = New Guna.UI.WinForms.GunaElipsePanel()
        Me.dev_login_pass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.vdate = New Guna.UI.WinForms.GunaLabel()
        Me.lTime = New Guna.UI.WinForms.GunaLabel()
        Me.pdate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.panel_dash = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Section_Add_Book = New HBR_Library_System.Add_Book()
        Me.Section_Book_List = New HBR_Library_System.Book_List()
        Me.Section_Track_Book = New HBR_Library_System.BookTracker()
        Me.Section_AddNewMember = New HBR_Library_System.NewMember()
        Me.Section_List_Members = New HBR_Library_System.ListMembers()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.slider = New System.Windows.Forms.Timer(Me.components)
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.anim = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.header = New HBR_Library_System.FormSkin()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.group_extra = New Guna.UI.WinForms.GunaGroupBox()
        Me.auth_name = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.auth_username = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.auth_image = New System.Windows.Forms.PictureBox()
        Me.dev_login_button = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BookTrack = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.AddNewMember = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BookList = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.MemberList = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BookNew = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_menu.SuspendLayout
        Me.panel_dash.SuspendLayout
        Me.header.SuspendLayout
        Me.group_extra.SuspendLayout
        CType(Me.auth_image,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'elipse_main
        '
        Me.elipse_main.Radius = 5
        Me.elipse_main.TargetControl = Me
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.Transparent
        Me.panel_menu.BaseColor = System.Drawing.Color.FromArgb(CType(CType(7,Byte),Integer), CType(CType(3,Byte),Integer), CType(CType(20,Byte),Integer))
        Me.panel_menu.Controls.Add(Me.Label2)
        Me.panel_menu.Controls.Add(Me.dev_login_button)
        Me.panel_menu.Controls.Add(Me.group_extra)
        Me.panel_menu.Controls.Add(Me.dev_login_pass)
        Me.panel_menu.Controls.Add(Me.vdate)
        Me.panel_menu.Controls.Add(Me.lTime)
        Me.panel_menu.Controls.Add(Me.pdate)
        Me.panel_menu.Controls.Add(Me.BookTrack)
        Me.panel_menu.Controls.Add(Me.AddNewMember)
        Me.panel_menu.Controls.Add(Me.BookList)
        Me.panel_menu.Controls.Add(Me.MemberList)
        Me.panel_menu.Controls.Add(Me.BookNew)
        Me.panel_menu.Location = New System.Drawing.Point(12, 67)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Radius = 7
        Me.panel_menu.Size = New System.Drawing.Size(261, 760)
        Me.panel_menu.TabIndex = 2
        '
        'dev_login_pass
        '
        Me.dev_login_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.dev_login_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dev_login_pass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.dev_login_pass.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.dev_login_pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dev_login_pass.LineColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.dev_login_pass.LineSize = 1
        Me.dev_login_pass.Location = New System.Drawing.Point(90, 611)
        Me.dev_login_pass.Name = "dev_login_pass"
        Me.dev_login_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.dev_login_pass.Size = New System.Drawing.Size(101, 26)
        Me.dev_login_pass.TabIndex = 8
        Me.dev_login_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dev_login_pass.UseSystemPasswordChar = true
        Me.dev_login_pass.Visible = false
        '
        'vdate
        '
        Me.vdate.AutoSize = true
        Me.vdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(202,Byte),Integer), CType(CType(202,Byte),Integer), CType(CType(202,Byte),Integer))
        Me.vdate.Font = New System.Drawing.Font("Segoe UI", 11!)
        Me.vdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.vdate.Location = New System.Drawing.Point(33, 8)
        Me.vdate.Name = "vdate"
        Me.vdate.Size = New System.Drawing.Size(17, 20)
        Me.vdate.TabIndex = 5
        Me.vdate.Text = "0"
        Me.vdate.Visible = false
        '
        'lTime
        '
        Me.lTime.AutoSize = true
        Me.lTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(202,Byte),Integer), CType(CType(202,Byte),Integer), CType(CType(202,Byte),Integer))
        Me.lTime.Font = New System.Drawing.Font("Segoe UI", 11!)
        Me.lTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.lTime.Location = New System.Drawing.Point(192, 8)
        Me.lTime.Name = "lTime"
        Me.lTime.Size = New System.Drawing.Size(44, 20)
        Me.lTime.TabIndex = 2
        Me.lTime.Text = "00:00"
        '
        'pdate
        '
        Me.pdate.BackColor = System.Drawing.Color.Transparent
        Me.pdate.BaseColor = System.Drawing.Color.White
        Me.pdate.BorderColor = System.Drawing.Color.Silver
        Me.pdate.CustomFormat = Nothing
        Me.pdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.pdate.Enabled = false
        Me.pdate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pdate.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.pdate.ForeColor = System.Drawing.Color.Black
        Me.pdate.Location = New System.Drawing.Point(4, 4)
        Me.pdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.pdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.pdate.Name = "pdate"
        Me.pdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.pdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pdate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pdate.OnPressedColor = System.Drawing.Color.Black
        Me.pdate.Radius = 5
        Me.pdate.Size = New System.Drawing.Size(251, 30)
        Me.pdate.TabIndex = 4
        Me.pdate.Text = "Wednesday, April 20, 2022"
        Me.pdate.Value = New Date(2022, 4, 20, 1, 15, 37, 835)
        '
        'panel_dash
        '
        Me.panel_dash.BackColor = System.Drawing.Color.Transparent
        Me.panel_dash.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.panel_dash.Controls.Add(Me.Section_Add_Book)
        Me.panel_dash.Controls.Add(Me.Section_Book_List)
        Me.panel_dash.Controls.Add(Me.Section_Track_Book)
        Me.panel_dash.Controls.Add(Me.Section_AddNewMember)
        Me.panel_dash.Controls.Add(Me.Section_List_Members)
        Me.panel_dash.Location = New System.Drawing.Point(279, 67)
        Me.panel_dash.Name = "panel_dash"
        Me.panel_dash.Radius = 7
        Me.panel_dash.Size = New System.Drawing.Size(766, 760)
        Me.panel_dash.TabIndex = 3
        '
        'Section_Add_Book
        '
        Me.Section_Add_Book.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Section_Add_Book.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Section_Add_Book.Location = New System.Drawing.Point(-1, 0)
        Me.Section_Add_Book.Name = "Section_Add_Book"
        Me.Section_Add_Book.Size = New System.Drawing.Size(764, 760)
        Me.Section_Add_Book.TabIndex = 1
        Me.Section_Add_Book.Visible = false
        '
        'Section_Book_List
        '
        Me.Section_Book_List.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Section_Book_List.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Section_Book_List.Location = New System.Drawing.Point(-1, 0)
        Me.Section_Book_List.Name = "Section_Book_List"
        Me.Section_Book_List.Size = New System.Drawing.Size(768, 752)
        Me.Section_Book_List.TabIndex = 5
        Me.Section_Book_List.Visible = false
        '
        'Section_Track_Book
        '
        Me.Section_Track_Book.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Section_Track_Book.Location = New System.Drawing.Point(-1, 0)
        Me.Section_Track_Book.Name = "Section_Track_Book"
        Me.Section_Track_Book.Size = New System.Drawing.Size(764, 760)
        Me.Section_Track_Book.TabIndex = 4
        Me.Section_Track_Book.Visible = false
        '
        'Section_AddNewMember
        '
        Me.Section_AddNewMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Section_AddNewMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Section_AddNewMember.Location = New System.Drawing.Point(-1, 0)
        Me.Section_AddNewMember.Name = "Section_AddNewMember"
        Me.Section_AddNewMember.Size = New System.Drawing.Size(764, 760)
        Me.Section_AddNewMember.TabIndex = 3
        Me.Section_AddNewMember.Visible = false
        '
        'Section_List_Members
        '
        Me.Section_List_Members.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Section_List_Members.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Section_List_Members.Location = New System.Drawing.Point(-1, 0)
        Me.Section_List_Members.Name = "Section_List_Members"
        Me.Section_List_Members.Size = New System.Drawing.Size(764, 771)
        Me.Section_List_Members.TabIndex = 2
        Me.Section_List_Members.Visible = false
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(1074, 830)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(2312, 15)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = resources.GetString("GunaLabel2.Text")
        '
        'slider
        '
        Me.slider.Enabled = true
        Me.slider.Interval = 30
        '
        'time
        '
        Me.time.Enabled = true
        Me.time.Interval = 60000
        '
        'Timer1
        '
        '
        'anim
        '
        Me.anim.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.anim.Interval = 5000
        Me.anim.TargetControl = Me
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me.dev_login_pass
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.Controls.Add(Me.GunaGradientButton2)
        Me.header.Controls.Add(Me.GunaLabel1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.header.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.header.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.header.HeaderMaximize = false
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1059, 61)
        Me.header.TabIndex = 4
        Me.header.Text = "FormSkin1"
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
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(358, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(388, 45)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "HBR - Kütüphane Sistemi"
        '
        'group_extra
        '
        Me.group_extra.BackColor = System.Drawing.Color.Transparent
        Me.group_extra.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16,Byte),Integer), CType(CType(8,Byte),Integer), CType(CType(31,Byte),Integer))
        Me.group_extra.BorderColor = System.Drawing.Color.MidnightBlue
        Me.group_extra.BorderSize = 1
        Me.group_extra.Controls.Add(Me.auth_image)
        Me.group_extra.Controls.Add(Me.auth_username)
        Me.group_extra.Controls.Add(Me.auth_name)
        Me.group_extra.Controls.Add(Me.Label1)
        Me.group_extra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.group_extra.LineBottom = 3
        Me.group_extra.LineColor = System.Drawing.Color.FromArgb(CType(CType(28,Byte),Integer), CType(CType(2,Byte),Integer), CType(CType(48,Byte),Integer))
        Me.group_extra.LineTop = 12
        Me.group_extra.Location = New System.Drawing.Point(16, 655)
        Me.group_extra.Name = "group_extra"
        Me.group_extra.Radius = 5
        Me.group_extra.Size = New System.Drawing.Size(227, 93)
        Me.group_extra.TabIndex = 9
        Me.group_extra.TextLocation = New System.Drawing.Point(10, 8)
        '
        'auth_name
        '
        Me.auth_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(22,Byte),Integer), CType(CType(19,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.auth_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.auth_name.Enabled = false
        Me.auth_name.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.auth_name.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.auth_name.LineColor = System.Drawing.Color.Gainsboro
        Me.auth_name.LineSize = 1
        Me.auth_name.Location = New System.Drawing.Point(64, 23)
        Me.auth_name.Name = "auth_name"
        Me.auth_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.auth_name.Size = New System.Drawing.Size(150, 26)
        Me.auth_name.TabIndex = 6
        Me.auth_name.Text = "Gökhan Özsoy"
        Me.auth_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(96, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Yetkili"
        '
        'auth_username
        '
        Me.auth_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(22,Byte),Integer), CType(CType(19,Byte),Integer), CType(CType(38,Byte),Integer))
        Me.auth_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.auth_username.Enabled = false
        Me.auth_username.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.auth_username.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.auth_username.LineColor = System.Drawing.Color.Gainsboro
        Me.auth_username.LineSize = 1
        Me.auth_username.Location = New System.Drawing.Point(64, 55)
        Me.auth_username.Name = "auth_username"
        Me.auth_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.auth_username.Size = New System.Drawing.Size(150, 26)
        Me.auth_username.TabIndex = 8
        Me.auth_username.Text = "admin"
        Me.auth_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 5
        Me.GunaElipse2.TargetControl = Me.auth_name
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 5
        Me.GunaElipse3.TargetControl = Me.auth_username
        '
        'auth_image
        '
        Me.auth_image.Image = Global.HBR_Library_System.My.Resources.Resources.user_shield_64px
        Me.auth_image.InitialImage = Nothing
        Me.auth_image.Location = New System.Drawing.Point(12, 23)
        Me.auth_image.Name = "auth_image"
        Me.auth_image.Size = New System.Drawing.Size(45, 58)
        Me.auth_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.auth_image.TabIndex = 9
        Me.auth_image.TabStop = false
        '
        'dev_login_button
        '
        Me.dev_login_button.Animated = true
        Me.dev_login_button.AnimationHoverSpeed = 10!
        Me.dev_login_button.AnimationSpeed = 10!
        Me.dev_login_button.BackColor = System.Drawing.Color.Transparent
        Me.dev_login_button.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.dev_login_button.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.dev_login_button.BorderSize = 1
        Me.dev_login_button.CheckedBaseColor = System.Drawing.Color.White
        Me.dev_login_button.CheckedBorderColor = System.Drawing.Color.Black
        Me.dev_login_button.CheckedForeColor = System.Drawing.Color.Indigo
        Me.dev_login_button.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.book_96px
        Me.dev_login_button.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.dev_login_button.FocusedColor = System.Drawing.Color.Empty
        Me.dev_login_button.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.dev_login_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dev_login_button.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.dev_login_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dev_login_button.ImageSize = New System.Drawing.Size(32, 32)
        Me.dev_login_button.LineColor = System.Drawing.Color.Indigo
        Me.dev_login_button.LineLeft = 4
        Me.dev_login_button.LineRight = 4
        Me.dev_login_button.Location = New System.Drawing.Point(47, 555)
        Me.dev_login_button.Name = "dev_login_button"
        Me.dev_login_button.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.dev_login_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.dev_login_button.OnHoverForeColor = System.Drawing.Color.White
        Me.dev_login_button.OnHoverImage = Nothing
        Me.dev_login_button.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dev_login_button.OnPressedColor = System.Drawing.Color.Black
        Me.dev_login_button.Radius = 6
        Me.dev_login_button.Size = New System.Drawing.Size(165, 35)
        Me.dev_login_button.TabIndex = 7
        Me.dev_login_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dev_login_button.TextOffsetX = 53
        Me.dev_login_button.Visible = false
        '
        'BookTrack
        '
        Me.BookTrack.Animated = true
        Me.BookTrack.AnimationHoverSpeed = 10!
        Me.BookTrack.AnimationSpeed = 10!
        Me.BookTrack.BackColor = System.Drawing.Color.Transparent
        Me.BookTrack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.BookTrack.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.BookTrack.BorderSize = 1
        Me.BookTrack.CheckedBaseColor = System.Drawing.Color.White
        Me.BookTrack.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookTrack.CheckedForeColor = System.Drawing.Color.Indigo
        Me.BookTrack.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.timesheet_96px
        Me.BookTrack.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookTrack.FocusedColor = System.Drawing.Color.Empty
        Me.BookTrack.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.BookTrack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookTrack.Image = Global.HBR_Library_System.My.Resources.Resources.timesheet_96px
        Me.BookTrack.ImageOffsetX = 15
        Me.BookTrack.ImageSize = New System.Drawing.Size(48, 48)
        Me.BookTrack.LineColor = System.Drawing.Color.Indigo
        Me.BookTrack.LineLeft = 4
        Me.BookTrack.LineRight = 4
        Me.BookTrack.Location = New System.Drawing.Point(0, 96)
        Me.BookTrack.Name = "BookTrack"
        Me.BookTrack.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.BookTrack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BookTrack.OnHoverForeColor = System.Drawing.Color.White
        Me.BookTrack.OnHoverImage = Nothing
        Me.BookTrack.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookTrack.OnPressedColor = System.Drawing.Color.Black
        Me.BookTrack.Radius = 6
        Me.BookTrack.Size = New System.Drawing.Size(261, 82)
        Me.BookTrack.TabIndex = 3
        Me.BookTrack.Text = "Kitap Takibi"
        Me.BookTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BookTrack.TextOffsetX = 33
        '
        'AddNewMember
        '
        Me.AddNewMember.Animated = true
        Me.AddNewMember.AnimationHoverSpeed = 10!
        Me.AddNewMember.AnimationSpeed = 10!
        Me.AddNewMember.BackColor = System.Drawing.Color.Transparent
        Me.AddNewMember.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.AddNewMember.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.AddNewMember.BorderSize = 1
        Me.AddNewMember.CheckedBaseColor = System.Drawing.Color.White
        Me.AddNewMember.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.AddNewMember.CheckedForeColor = System.Drawing.Color.Indigo
        Me.AddNewMember.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.AddNewMember.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.AddNewMember.FocusedColor = System.Drawing.Color.Empty
        Me.AddNewMember.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.AddNewMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.AddNewMember.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.AddNewMember.ImageOffsetX = 15
        Me.AddNewMember.ImageSize = New System.Drawing.Size(48, 48)
        Me.AddNewMember.LineColor = System.Drawing.Color.Indigo
        Me.AddNewMember.LineLeft = 4
        Me.AddNewMember.LineRight = 4
        Me.AddNewMember.Location = New System.Drawing.Point(0, 448)
        Me.AddNewMember.Name = "AddNewMember"
        Me.AddNewMember.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.AddNewMember.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AddNewMember.OnHoverForeColor = System.Drawing.Color.White
        Me.AddNewMember.OnHoverImage = Nothing
        Me.AddNewMember.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.AddNewMember.OnPressedColor = System.Drawing.Color.Black
        Me.AddNewMember.Radius = 6
        Me.AddNewMember.Size = New System.Drawing.Size(261, 82)
        Me.AddNewMember.TabIndex = 0
        Me.AddNewMember.Text = "Yeni Üye Ekle"
        Me.AddNewMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AddNewMember.TextOffsetX = 17
        '
        'BookList
        '
        Me.BookList.Animated = true
        Me.BookList.AnimationHoverSpeed = 10!
        Me.BookList.AnimationSpeed = 10!
        Me.BookList.BackColor = System.Drawing.Color.Transparent
        Me.BookList.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.BookList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.BookList.BorderSize = 1
        Me.BookList.CheckedBaseColor = System.Drawing.Color.White
        Me.BookList.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList.CheckedForeColor = System.Drawing.Color.Indigo
        Me.BookList.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.bulleted_list_64px
        Me.BookList.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList.FocusedColor = System.Drawing.Color.Empty
        Me.BookList.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.BookList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList.Image = Global.HBR_Library_System.My.Resources.Resources.bulleted_list_64px
        Me.BookList.ImageOffsetX = 15
        Me.BookList.ImageSize = New System.Drawing.Size(48, 48)
        Me.BookList.LineColor = System.Drawing.Color.Indigo
        Me.BookList.LineLeft = 4
        Me.BookList.LineRight = 4
        Me.BookList.Location = New System.Drawing.Point(0, 184)
        Me.BookList.Name = "BookList"
        Me.BookList.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.BookList.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BookList.OnHoverForeColor = System.Drawing.Color.White
        Me.BookList.OnHoverImage = Nothing
        Me.BookList.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList.OnPressedColor = System.Drawing.Color.Black
        Me.BookList.Radius = 6
        Me.BookList.Size = New System.Drawing.Size(261, 82)
        Me.BookList.TabIndex = 0
        Me.BookList.Text = "Kitap Listesi"
        Me.BookList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BookList.TextOffsetX = 30
        '
        'MemberList
        '
        Me.MemberList.Animated = true
        Me.MemberList.AnimationHoverSpeed = 10!
        Me.MemberList.AnimationSpeed = 10!
        Me.MemberList.BackColor = System.Drawing.Color.Transparent
        Me.MemberList.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.MemberList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.MemberList.BorderSize = 1
        Me.MemberList.CheckedBaseColor = System.Drawing.Color.White
        Me.MemberList.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.MemberList.CheckedForeColor = System.Drawing.Color.Indigo
        Me.MemberList.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.conference_64px
        Me.MemberList.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.MemberList.FocusedColor = System.Drawing.Color.Empty
        Me.MemberList.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.MemberList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.MemberList.Image = Global.HBR_Library_System.My.Resources.Resources.conference_64px
        Me.MemberList.ImageOffsetX = 15
        Me.MemberList.ImageSize = New System.Drawing.Size(48, 48)
        Me.MemberList.LineColor = System.Drawing.Color.Indigo
        Me.MemberList.LineLeft = 4
        Me.MemberList.LineRight = 4
        Me.MemberList.Location = New System.Drawing.Point(0, 360)
        Me.MemberList.Name = "MemberList"
        Me.MemberList.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.MemberList.OnHoverBorderColor = System.Drawing.Color.Black
        Me.MemberList.OnHoverForeColor = System.Drawing.Color.White
        Me.MemberList.OnHoverImage = Nothing
        Me.MemberList.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.MemberList.OnPressedColor = System.Drawing.Color.Black
        Me.MemberList.Radius = 6
        Me.MemberList.Size = New System.Drawing.Size(261, 82)
        Me.MemberList.TabIndex = 0
        Me.MemberList.Text = "Üye Listesi"
        Me.MemberList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MemberList.TextOffsetX = 47
        '
        'BookNew
        '
        Me.BookNew.Animated = true
        Me.BookNew.AnimationHoverSpeed = 10!
        Me.BookNew.AnimationSpeed = 10!
        Me.BookNew.BackColor = System.Drawing.Color.Transparent
        Me.BookNew.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.BookNew.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.BookNew.BorderSize = 1
        Me.BookNew.CheckedBaseColor = System.Drawing.Color.White
        Me.BookNew.CheckedBorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookNew.CheckedForeColor = System.Drawing.Color.Indigo
        Me.BookNew.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.book_96px
        Me.BookNew.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookNew.FocusedColor = System.Drawing.Color.Empty
        Me.BookNew.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.BookNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookNew.Image = Global.HBR_Library_System.My.Resources.Resources.book_96px
        Me.BookNew.ImageOffsetX = 15
        Me.BookNew.ImageSize = New System.Drawing.Size(48, 48)
        Me.BookNew.LineColor = System.Drawing.Color.Indigo
        Me.BookNew.LineLeft = 4
        Me.BookNew.LineRight = 4
        Me.BookNew.Location = New System.Drawing.Point(0, 272)
        Me.BookNew.Name = "BookNew"
        Me.BookNew.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.BookNew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BookNew.OnHoverForeColor = System.Drawing.Color.White
        Me.BookNew.OnHoverImage = Nothing
        Me.BookNew.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookNew.OnPressedColor = System.Drawing.Color.Black
        Me.BookNew.Radius = 6
        Me.BookNew.Size = New System.Drawing.Size(261, 82)
        Me.BookNew.TabIndex = 0
        Me.BookNew.Text = "Kitap Ekle"
        Me.BookNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BookNew.TextOffsetX = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 537)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Developer"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(2,Byte),Integer), CType(CType(21,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 850)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.panel_dash)
        Me.Controls.Add(Me.panel_menu)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.panel_menu.ResumeLayout(false)
        Me.panel_menu.PerformLayout
        Me.panel_dash.ResumeLayout(false)
        Me.header.ResumeLayout(false)
        Me.header.PerformLayout
        Me.group_extra.ResumeLayout(false)
        Me.group_extra.PerformLayout
        CType(Me.auth_image,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents elipse_main As Guna.UI.WinForms.GunaElipse
    Friend WithEvents panel_dash As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents panel_menu As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents BookNew As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents AddNewMember As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BookList As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents MemberList As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header As FormSkin
    Friend WithEvents Section_Add_Book As Add_Book
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Section_List_Members As ListMembers
    Friend WithEvents Section_AddNewMember As NewMember
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents slider As Timer
    Friend WithEvents lTime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents time As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents anim As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents BookTrack As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Section_Track_Book As BookTracker
    Friend WithEvents pdate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents vdate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dev_login_pass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dev_login_button As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Section_Book_List As Book_List
    Friend WithEvents group_extra As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents auth_name As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents auth_username As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents auth_image As PictureBox
    Friend WithEvents Label2 As Label
End Class
