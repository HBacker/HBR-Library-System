<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMember
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMember))
        Me.group_MemberInfo = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.combo_Class = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.text_Contact = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_clear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.text_No = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.text_Surname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.text_Name = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.warn_data = New Guna.UI.WinForms.GunaLabel()
        Me.warnTime = New System.Windows.Forms.Timer(Me.components)
        Me.warn_status = New Guna.UI.WinForms.GunaLabel()
        Me.dataUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.button_redirect_memberList = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.button_add = New Guna.UI.WinForms.GunaGradientButton()
        Me.group_MemberInfo.SuspendLayout
        Me.SuspendLayout
        '
        'group_MemberInfo
        '
        Me.group_MemberInfo.BackColor = System.Drawing.Color.Transparent
        Me.group_MemberInfo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_MemberInfo.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel7)
        Me.group_MemberInfo.Controls.Add(Me.combo_Class)
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel6)
        Me.group_MemberInfo.Controls.Add(Me.text_Contact)
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel5)
        Me.group_MemberInfo.Controls.Add(Me.btn_clear)
        Me.group_MemberInfo.Controls.Add(Me.text_No)
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel4)
        Me.group_MemberInfo.Controls.Add(Me.text_Surname)
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel3)
        Me.group_MemberInfo.Controls.Add(Me.text_Name)
        Me.group_MemberInfo.Controls.Add(Me.GunaLabel1)
        Me.group_MemberInfo.LineColor = System.Drawing.Color.Indigo
        Me.group_MemberInfo.Location = New System.Drawing.Point(159, 103)
        Me.group_MemberInfo.Name = "group_MemberInfo"
        Me.group_MemberInfo.Radius = 5
        Me.group_MemberInfo.Size = New System.Drawing.Size(412, 318)
        Me.group_MemberInfo.TabIndex = 3
        Me.group_MemberInfo.Text = "Üye Bilgileri"
        Me.group_MemberInfo.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = true
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel7.Location = New System.Drawing.Point(25, 287)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(53, 12)
        Me.GunaLabel7.TabIndex = 90
        Me.GunaLabel7.Text = "(opsiyonel)"
        Me.GunaLabel7.Visible = false
        '
        'combo_Class
        '
        Me.combo_Class.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.combo_Class.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.combo_Class.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.combo_Class.BorderSize = 1
        Me.combo_Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combo_Class.FocusedColor = System.Drawing.Color.Indigo
        Me.combo_Class.Font = New System.Drawing.Font("Segoe UI", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.combo_Class.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.combo_Class.FormattingEnabled = true
        Me.combo_Class.Items.AddRange(New Object() {"Seçiniz...", "Diğer", "9-A [AT]", "9-A [AMP]", "9-B", "9-C", "9-D", "9-E", "10-A [AT]", "10-A [AMP]", "10-B", "10-C", "10-D", "10-E", "11-A [AT]", "11-A [AMP]", "11-B", "11-C", "11-D", "11-E", "12-A [AT]", "12-A [AMP]", "12-B", "12-C", "12-D", "12-E"})
        Me.combo_Class.Location = New System.Drawing.Point(115, 202)
        Me.combo_Class.Name = "combo_Class"
        Me.combo_Class.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.combo_Class.OnHoverItemForeColor = System.Drawing.Color.White
        Me.combo_Class.Size = New System.Drawing.Size(282, 44)
        Me.combo_Class.TabIndex = 90
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel6.Location = New System.Drawing.Point(17, 213)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(53, 25)
        Me.GunaLabel6.TabIndex = 85
        Me.GunaLabel6.Text = "Sınıf:"
        '
        'text_Contact
        '
        Me.text_Contact.Animated = true
        Me.text_Contact.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Contact.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Contact.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Contact.LineColor = System.Drawing.Color.Aqua
        Me.text_Contact.Location = New System.Drawing.Point(115, 255)
        Me.text_Contact.Name = "text_Contact"
        Me.text_Contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Contact.Size = New System.Drawing.Size(282, 47)
        Me.text_Contact.TabIndex = 82
        Me.text_Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel5.Location = New System.Drawing.Point(17, 262)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(76, 25)
        Me.GunaLabel5.TabIndex = 83
        Me.GunaLabel5.Text = "İletişim:"
        '
        'btn_clear
        '
        Me.btn_clear.Animated = true
        Me.btn_clear.AnimationHoverSpeed = 3!
        Me.btn_clear.AnimationSpeed = 3!
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.btn_clear.BorderColor = System.Drawing.Color.Black
        Me.btn_clear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_clear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_clear.CheckedForeColor = System.Drawing.Color.White
        Me.btn_clear.CheckedImage = CType(resources.GetObject("btn_clear.CheckedImage"),System.Drawing.Image)
        Me.btn_clear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_clear.FocusedColor = System.Drawing.Color.Empty
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btn_clear.ForeColor = System.Drawing.Color.Aqua
        Me.btn_clear.Image = Global.HBR_Library_System.My.Resources.Resources.available_updates_64px
        Me.btn_clear.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_clear.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_clear.Location = New System.Drawing.Point(310, 3)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_clear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_clear.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_clear.OnHoverImage = Nothing
        Me.btn_clear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_clear.OnPressedColor = System.Drawing.Color.Black
        Me.btn_clear.Radius = 10
        Me.btn_clear.Size = New System.Drawing.Size(87, 23)
        Me.btn_clear.TabIndex = 81
        Me.btn_clear.Text = "Sıfırla"
        '
        'text_No
        '
        Me.text_No.Animated = true
        Me.text_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_No.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_No.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_No.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_No.LineColor = System.Drawing.Color.Aqua
        Me.text_No.Location = New System.Drawing.Point(115, 149)
        Me.text_No.MaxLength = 6
        Me.text_No.Name = "text_No"
        Me.text_No.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_No.Size = New System.Drawing.Size(282, 47)
        Me.text_No.TabIndex = 4
        Me.text_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel4.Location = New System.Drawing.Point(17, 160)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(85, 25)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Okul No:"
        '
        'text_Surname
        '
        Me.text_Surname.Animated = true
        Me.text_Surname.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Surname.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Surname.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Surname.LineColor = System.Drawing.Color.Aqua
        Me.text_Surname.Location = New System.Drawing.Point(115, 96)
        Me.text_Surname.Name = "text_Surname"
        Me.text_Surname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Surname.Size = New System.Drawing.Size(282, 47)
        Me.text_Surname.TabIndex = 2
        Me.text_Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel3.Location = New System.Drawing.Point(17, 105)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(72, 25)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Soyadı:"
        '
        'text_Name
        '
        Me.text_Name.Animated = true
        Me.text_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Name.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Name.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Name.LineColor = System.Drawing.Color.Aqua
        Me.text_Name.Location = New System.Drawing.Point(115, 43)
        Me.text_Name.Name = "text_Name"
        Me.text_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Name.Size = New System.Drawing.Size(282, 47)
        Me.text_Name.TabIndex = 0
        Me.text_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel1.Location = New System.Drawing.Point(17, 52)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(44, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Adı:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Light", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(277, 3)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(196, 45)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Yeni Üye Ekle"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me.text_No
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 5
        Me.GunaElipse2.TargetControl = Me.text_Contact
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 5
        Me.GunaElipse3.TargetControl = Me.text_Name
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 5
        Me.GunaElipse4.TargetControl = Me.text_Surname
        '
        'warn_data
        '
        Me.warn_data.AutoSize = true
        Me.warn_data.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.warn_data.ForeColor = System.Drawing.Color.Crimson
        Me.warn_data.Location = New System.Drawing.Point(203, 80)
        Me.warn_data.Name = "warn_data"
        Me.warn_data.Size = New System.Drawing.Size(320, 17)
        Me.warn_data.TabIndex = 88
        Me.warn_data.Text = "Lütfen tüm alanları doldurduğunuzdan emin olun."
        Me.warn_data.Visible = false
        '
        'warnTime
        '
        Me.warnTime.Interval = 7500
        '
        'warn_status
        '
        Me.warn_status.AutoSize = true
        Me.warn_status.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.warn_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.warn_status.Location = New System.Drawing.Point(166, 441)
        Me.warn_status.Name = "warn_status"
        Me.warn_status.Size = New System.Drawing.Size(143, 17)
        Me.warn_status.TabIndex = 89
        Me.warn_status.Text = "Üye Başarıyla Eklendi!"
        Me.warn_status.Visible = false
        '
        'dataUpdater
        '
        Me.dataUpdater.Enabled = true
        Me.dataUpdater.Interval = 1000
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 5
        Me.GunaElipse5.TargetControl = Me
        '
        'button_redirect_memberList
        '
        Me.button_redirect_memberList.Animated = true
        Me.button_redirect_memberList.AnimationHoverSpeed = 3!
        Me.button_redirect_memberList.AnimationSpeed = 3!
        Me.button_redirect_memberList.BackColor = System.Drawing.Color.Transparent
        Me.button_redirect_memberList.BaseColor = System.Drawing.Color.White
        Me.button_redirect_memberList.BorderColor = System.Drawing.Color.Black
        Me.button_redirect_memberList.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_redirect_memberList.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_redirect_memberList.CheckedForeColor = System.Drawing.Color.White
        Me.button_redirect_memberList.CheckedImage = CType(resources.GetObject("button_redirect_memberList.CheckedImage"),System.Drawing.Image)
        Me.button_redirect_memberList.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_redirect_memberList.FocusedColor = System.Drawing.Color.Empty
        Me.button_redirect_memberList.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.button_redirect_memberList.ForeColor = System.Drawing.Color.MidnightBlue
        Me.button_redirect_memberList.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.button_redirect_memberList.ImageSize = New System.Drawing.Size(36, 36)
        Me.button_redirect_memberList.LineBottom = 3
        Me.button_redirect_memberList.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.button_redirect_memberList.Location = New System.Drawing.Point(329, 427)
        Me.button_redirect_memberList.Name = "button_redirect_memberList"
        Me.button_redirect_memberList.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.button_redirect_memberList.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_redirect_memberList.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.button_redirect_memberList.OnHoverImage = Nothing
        Me.button_redirect_memberList.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.button_redirect_memberList.OnPressedColor = System.Drawing.Color.Black
        Me.button_redirect_memberList.Radius = 5
        Me.button_redirect_memberList.Size = New System.Drawing.Size(118, 47)
        Me.button_redirect_memberList.TabIndex = 87
        Me.button_redirect_memberList.Text = "Üye Listesi"
        Me.button_redirect_memberList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.button_redirect_memberList.TextOffsetX = 3
        '
        'button_add
        '
        Me.button_add.Animated = true
        Me.button_add.AnimationHoverSpeed = 3!
        Me.button_add.AnimationSpeed = 3!
        Me.button_add.BackColor = System.Drawing.Color.Transparent
        Me.button_add.BaseColor1 = System.Drawing.Color.MidnightBlue
        Me.button_add.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.button_add.BorderColor = System.Drawing.Color.Black
        Me.button_add.FocusedColor = System.Drawing.Color.Empty
        Me.button_add.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.button_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.button_add.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.button_add.ImageSize = New System.Drawing.Size(42, 42)
        Me.button_add.Location = New System.Drawing.Point(453, 427)
        Me.button_add.Name = "button_add"
        Me.button_add.OnHoverBaseColor1 = System.Drawing.Color.White
        Me.button_add.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.button_add.OnHoverBorderColor = System.Drawing.Color.Indigo
        Me.button_add.OnHoverForeColor = System.Drawing.Color.MidnightBlue
        Me.button_add.OnHoverImage = Nothing
        Me.button_add.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.button_add.Radius = 5
        Me.button_add.Size = New System.Drawing.Size(118, 47)
        Me.button_add.TabIndex = 5
        Me.button_add.Text = "Ekle"
        '
        'NewMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.warn_status)
        Me.Controls.Add(Me.warn_data)
        Me.Controls.Add(Me.button_redirect_memberList)
        Me.Controls.Add(Me.button_add)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.group_MemberInfo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "NewMember"
        Me.Size = New System.Drawing.Size(764, 530)
        Me.group_MemberInfo.ResumeLayout(false)
        Me.group_MemberInfo.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents group_MemberInfo As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_clear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Surname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Name As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Contact As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents button_add As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents button_redirect_memberList As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents warn_data As Guna.UI.WinForms.GunaLabel
    Friend WithEvents warnTime As Timer
    Friend WithEvents text_No As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents combo_Class As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents warn_status As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dataUpdater As Timer
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
End Class
