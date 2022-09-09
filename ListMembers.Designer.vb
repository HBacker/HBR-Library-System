<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListMembers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListMembers))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.elipse_dataList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.occurred = New Guna.UI.WinForms.GunaLabel()
        Me.bookList = New Guna.UI.WinForms.GunaDataGridView()
        Me.elipse_databookList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_occurred = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btn_FulLScreen = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dataUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.member_find = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.method_name = New Guna.UI.WinForms.GunaRadioButton()
        Me.method_no = New Guna.UI.WinForms.GunaRadioButton()
        Me.REFRESH = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.member_finder = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dataLoader = New HBR_Library_System.sd()
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Light", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(310, 2)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(160, 45)
        Me.GunaLabel1.TabIndex = 82
        Me.GunaLabel1.Text = "Üye Listesi"
        '
        'elipse_dataList
        '
        Me.elipse_dataList.TargetControl = Me
        '
        'occurred
        '
        Me.occurred.AutoSize = true
        Me.occurred.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.occurred.Font = New System.Drawing.Font("Segoe UI", 16!)
        Me.occurred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.occurred.Location = New System.Drawing.Point(272, 188)
        Me.occurred.Name = "occurred"
        Me.occurred.Size = New System.Drawing.Size(228, 30)
        Me.occurred.TabIndex = 84
        Me.occurred.Text = "Oops! Bir Hata Oluştu!"
        Me.occurred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.occurred.Visible = false
        '
        'bookList
        '
        Me.bookList.AllowUserToAddRows = false
        Me.bookList.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.bookList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bookList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.bookList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(18,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.bookList.ColumnHeadersHeight = 27
        Me.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(94,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookList.DefaultCellStyle = DataGridViewCellStyle3
        Me.bookList.EnableHeadersVisualStyles = false
        Me.bookList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.bookList.Location = New System.Drawing.Point(20, 64)
        Me.bookList.Name = "bookList"
        Me.bookList.ReadOnly = true
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.bookList.RowHeadersVisible = false
        Me.bookList.RowTemplate.Height = 31
        Me.bookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bookList.Size = New System.Drawing.Size(725, 624)
        Me.bookList.TabIndex = 83
        Me.bookList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.bookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.bookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.bookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.bookList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.bookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Indigo
        Me.bookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.bookList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.bookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.bookList.ThemeStyle.HeaderStyle.Height = 27
        Me.bookList.ThemeStyle.ReadOnly = true
        Me.bookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.bookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(94,Byte),Integer))
        Me.bookList.ThemeStyle.RowsStyle.Height = 31
        Me.bookList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        '
        'elipse_databookList
        '
        Me.elipse_databookList.Radius = 5
        Me.elipse_databookList.TargetControl = Me.bookList
        '
        'elipse_occurred
        '
        Me.elipse_occurred.Radius = 5
        Me.elipse_occurred.TargetControl = Me.occurred
        '
        'GunaElipse3
        '
        Me.GunaElipse3.TargetControl = Me
        '
        'btn_FulLScreen
        '
        Me.btn_FulLScreen.Animated = true
        Me.btn_FulLScreen.AnimationHoverSpeed = 3!
        Me.btn_FulLScreen.AnimationSpeed = 3!
        Me.btn_FulLScreen.BackColor = System.Drawing.Color.Transparent
        Me.btn_FulLScreen.BaseColor = System.Drawing.Color.White
        Me.btn_FulLScreen.BorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_FulLScreen.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.CheckedForeColor = System.Drawing.Color.White
        Me.btn_FulLScreen.CheckedImage = CType(resources.GetObject("btn_FulLScreen.CheckedImage"),System.Drawing.Image)
        Me.btn_FulLScreen.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_FulLScreen.FocusedColor = System.Drawing.Color.Empty
        Me.btn_FulLScreen.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btn_FulLScreen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_FulLScreen.Image = Global.HBR_Library_System.My.Resources.Resources.fit_to_width_64px
        Me.btn_FulLScreen.ImageSize = New System.Drawing.Size(36, 36)
        Me.btn_FulLScreen.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_FulLScreen.Location = New System.Drawing.Point(269, 694)
        Me.btn_FulLScreen.Name = "btn_FulLScreen"
        Me.btn_FulLScreen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_FulLScreen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_FulLScreen.OnHoverImage = Nothing
        Me.btn_FulLScreen.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_FulLScreen.OnPressedColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.Radius = 5
        Me.btn_FulLScreen.Size = New System.Drawing.Size(110, 42)
        Me.btn_FulLScreen.TabIndex = 85
        Me.btn_FulLScreen.Text = "Tam Ekran"
        Me.btn_FulLScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = true
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 3!
        Me.GunaAdvenceButton1.AnimationSpeed = 3!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.contact_details_96px
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(136, 694)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(127, 42)
        Me.GunaAdvenceButton1.TabIndex = 86
        Me.GunaAdvenceButton1.Text = "Yeni Üye Ekle"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dataUpdater
        '
        Me.dataUpdater.Enabled = true
        Me.dataUpdater.Interval = 1000
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 5
        Me.GunaElipse2.TargetControl = Me
        '
        'member_find
        '
        Me.member_find.Animated = true
        Me.member_find.AnimationHoverSpeed = 10!
        Me.member_find.AnimationSpeed = 10!
        Me.member_find.BackColor = System.Drawing.Color.Transparent
        Me.member_find.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.member_find.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.member_find.BorderSize = 1
        Me.member_find.CheckedBaseColor = System.Drawing.Color.White
        Me.member_find.CheckedBorderColor = System.Drawing.Color.Black
        Me.member_find.CheckedForeColor = System.Drawing.Color.Indigo
        Me.member_find.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.book_96px
        Me.member_find.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.member_find.FocusedColor = System.Drawing.Color.Empty
        Me.member_find.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.member_find.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.member_find.Image = Global.HBR_Library_System.My.Resources.Resources.search_64px
        Me.member_find.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.member_find.ImageSize = New System.Drawing.Size(32, 32)
        Me.member_find.LineColor = System.Drawing.Color.Indigo
        Me.member_find.LineLeft = 4
        Me.member_find.LineRight = 4
        Me.member_find.Location = New System.Drawing.Point(400, 694)
        Me.member_find.Name = "member_find"
        Me.member_find.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.member_find.OnHoverBorderColor = System.Drawing.Color.Black
        Me.member_find.OnHoverForeColor = System.Drawing.Color.White
        Me.member_find.OnHoverImage = Nothing
        Me.member_find.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.member_find.OnPressedColor = System.Drawing.Color.Black
        Me.member_find.Radius = 6
        Me.member_find.Size = New System.Drawing.Size(345, 53)
        Me.member_find.TabIndex = 96
        Me.member_find.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.member_find.TextOffsetX = 53
        '
        'method_name
        '
        Me.method_name.BackColor = System.Drawing.Color.Transparent
        Me.method_name.BaseColor = System.Drawing.SystemColors.Control
        Me.method_name.CheckedOffColor = System.Drawing.Color.Gray
        Me.method_name.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.method_name.FillColor = System.Drawing.Color.White
        Me.method_name.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.method_name.Location = New System.Drawing.Point(415, 722)
        Me.method_name.Name = "method_name"
        Me.method_name.Size = New System.Drawing.Size(62, 20)
        Me.method_name.TabIndex = 98
        Me.method_name.Text = "Üye Adı"
        '
        'method_no
        '
        Me.method_no.BackColor = System.Drawing.Color.Transparent
        Me.method_no.BaseColor = System.Drawing.SystemColors.Control
        Me.method_no.Checked = true
        Me.method_no.CheckedOffColor = System.Drawing.Color.Gray
        Me.method_no.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.method_no.FillColor = System.Drawing.Color.White
        Me.method_no.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.method_no.Location = New System.Drawing.Point(416, 700)
        Me.method_no.Name = "method_no"
        Me.method_no.Size = New System.Drawing.Size(61, 20)
        Me.method_no.TabIndex = 99
        Me.method_no.Text = "Üye No"
        '
        'REFRESH
        '
        Me.REFRESH.Animated = true
        Me.REFRESH.AnimationHoverSpeed = 3!
        Me.REFRESH.AnimationSpeed = 3!
        Me.REFRESH.BackColor = System.Drawing.Color.Transparent
        Me.REFRESH.BaseColor = System.Drawing.Color.White
        Me.REFRESH.BorderColor = System.Drawing.Color.Black
        Me.REFRESH.CheckedBaseColor = System.Drawing.Color.Gray
        Me.REFRESH.CheckedBorderColor = System.Drawing.Color.Black
        Me.REFRESH.CheckedForeColor = System.Drawing.Color.White
        Me.REFRESH.CheckedImage = CType(resources.GetObject("REFRESH.CheckedImage"),System.Drawing.Image)
        Me.REFRESH.CheckedLineColor = System.Drawing.Color.DimGray
        Me.REFRESH.FocusedColor = System.Drawing.Color.Empty
        Me.REFRESH.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.REFRESH.ForeColor = System.Drawing.Color.MidnightBlue
        Me.REFRESH.Image = Global.HBR_Library_System.My.Resources.Resources.available_updates_64px
        Me.REFRESH.ImageSize = New System.Drawing.Size(36, 36)
        Me.REFRESH.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.REFRESH.Location = New System.Drawing.Point(20, 694)
        Me.REFRESH.Name = "REFRESH"
        Me.REFRESH.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.REFRESH.OnHoverBorderColor = System.Drawing.Color.Black
        Me.REFRESH.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.REFRESH.OnHoverImage = Nothing
        Me.REFRESH.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.REFRESH.OnPressedColor = System.Drawing.Color.Black
        Me.REFRESH.Radius = 5
        Me.REFRESH.Size = New System.Drawing.Size(110, 42)
        Me.REFRESH.TabIndex = 100
        Me.REFRESH.Text = "Yenile"
        Me.REFRESH.TextOffsetX = 3
        '
        'member_finder
        '
        Me.member_finder.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.member_finder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.member_finder.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.member_finder.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.member_finder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.member_finder.LineColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.member_finder.LineSize = 1
        Me.member_finder.Location = New System.Drawing.Point(489, 702)
        Me.member_finder.Name = "member_finder"
        Me.member_finder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.member_finder.Size = New System.Drawing.Size(203, 37)
        Me.member_finder.TabIndex = 101
        Me.member_finder.Text = "Üye Ara..."
        Me.member_finder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me.method_name
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 5
        Me.GunaElipse4.TargetControl = Me.method_no
        '
        'dataLoader
        '
        Me.dataLoader.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.dataLoader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dataLoader.Location = New System.Drawing.Point(17, 50)
        Me.dataLoader.Name = "dataLoader"
        Me.dataLoader.Size = New System.Drawing.Size(733, 697)
        Me.dataLoader.TabIndex = 102
        '
        'ListMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.dataLoader)
        Me.Controls.Add(Me.member_finder)
        Me.Controls.Add(Me.REFRESH)
        Me.Controls.Add(Me.method_no)
        Me.Controls.Add(Me.method_name)
        Me.Controls.Add(Me.member_find)
        Me.Controls.Add(Me.btn_FulLScreen)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.occurred)
        Me.Controls.Add(Me.bookList)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "ListMembers"
        Me.Size = New System.Drawing.Size(766, 750)
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipse_dataList As Guna.UI.WinForms.GunaElipse
    Friend WithEvents occurred As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bookList As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btn_FulLScreen As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents elipse_databookList As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_occurred As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dataUpdater As Timer
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents method_name As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents member_find As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents method_no As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents REFRESH As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents member_finder As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dataLoader As sd
End Class
