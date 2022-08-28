<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_List
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.elipse_dataList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.occurred = New Guna.UI.WinForms.GunaLabel()
        Me.bookList = New Guna.UI.WinForms.GunaDataGridView()
        Me.elipse_databookList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_occurred = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btn_AutoSize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_FulLScreen = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Controller = New System.Windows.Forms.Timer(Me.components)
        Me.dataUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.group_bot = New Guna.UI.WinForms.GunaGroupBox()
        Me.button_GetBook = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.getBook_id = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.getBook_date = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.getBook_reset = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.getBook_no = New Guna.UI.WinForms.GunaLineTextBox()
        Me.group_extra = New Guna.UI.WinForms.GunaGroupBox()
        Me.selected_ISBN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.selected_Publisher = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.selected_Author = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.book_poster = New Guna.UI.WinForms.GunaPictureBox()
        Me.selected_BookName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.method_author = New Guna.UI.WinForms.GunaRadioButton()
        Me.book_finder = New Guna.UI.WinForms.GunaLineTextBox()
        Me.method_bookname = New Guna.UI.WinForms.GunaRadioButton()
        Me.method_isbn = New Guna.UI.WinForms.GunaRadioButton()
        Me.book_find = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BookList_X = New Guna.UI.WinForms.GunaDataGridView()
        Me.dataLoader = New HBR_Library_System.loader()
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).BeginInit
        Me.group_bot.SuspendLayout
        Me.group_extra.SuspendLayout
        CType(Me.book_poster,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BookList_X,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Light", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(294, 2)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(176, 45)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Kitap Listesi"
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
        Me.occurred.TabIndex = 77
        Me.occurred.Text = "Oops! Bir Hata Oluştu!"
        Me.occurred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.occurred.Visible = false
        '
        'bookList
        '
        Me.bookList.AllowUserToAddRows = false
        Me.bookList.AllowUserToDeleteRows = false
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.bookList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.bookList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.bookList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(18,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.bookList.ColumnHeadersHeight = 27
        Me.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bookList.DefaultCellStyle = DataGridViewCellStyle7
        Me.bookList.EnableHeadersVisualStyles = false
        Me.bookList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.bookList.Location = New System.Drawing.Point(20, 49)
        Me.bookList.Name = "bookList"
        Me.bookList.ReadOnly = true
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bookList.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.bookList.RowHeadersVisible = false
        Me.bookList.RowTemplate.Height = 31
        Me.bookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bookList.Size = New System.Drawing.Size(725, 375)
        Me.bookList.TabIndex = 76
        Me.bookList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.bookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.bookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.bookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.bookList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.bookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.bookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.bookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.bookList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.bookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.bookList.ThemeStyle.HeaderStyle.Height = 27
        Me.bookList.ThemeStyle.ReadOnly = true
        Me.bookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.bookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bookList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.bookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
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
        'btn_AutoSize
        '
        Me.btn_AutoSize.Animated = true
        Me.btn_AutoSize.AnimationHoverSpeed = 3!
        Me.btn_AutoSize.AnimationSpeed = 3!
        Me.btn_AutoSize.BackColor = System.Drawing.Color.Transparent
        Me.btn_AutoSize.BaseColor = System.Drawing.Color.White
        Me.btn_AutoSize.BorderColor = System.Drawing.Color.Black
        Me.btn_AutoSize.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_AutoSize.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_AutoSize.CheckedForeColor = System.Drawing.Color.White
        Me.btn_AutoSize.CheckedImage = CType(resources.GetObject("btn_AutoSize.CheckedImage"),System.Drawing.Image)
        Me.btn_AutoSize.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_AutoSize.FocusedColor = System.Drawing.Color.Empty
        Me.btn_AutoSize.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btn_AutoSize.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_AutoSize.Image = Global.HBR_Library_System.My.Resources.Resources.resize_horizontal_96px
        Me.btn_AutoSize.ImageSize = New System.Drawing.Size(36, 36)
        Me.btn_AutoSize.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_AutoSize.Location = New System.Drawing.Point(265, 435)
        Me.btn_AutoSize.Name = "btn_AutoSize"
        Me.btn_AutoSize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_AutoSize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_AutoSize.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_AutoSize.OnHoverImage = Nothing
        Me.btn_AutoSize.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_AutoSize.OnPressedColor = System.Drawing.Color.Black
        Me.btn_AutoSize.Radius = 5
        Me.btn_AutoSize.Size = New System.Drawing.Size(110, 48)
        Me.btn_AutoSize.TabIndex = 81
        Me.btn_AutoSize.Text = "Genişlet"
        Me.btn_AutoSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_AutoSize.TextOffsetX = 7
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
        Me.btn_FulLScreen.Location = New System.Drawing.Point(149, 435)
        Me.btn_FulLScreen.Name = "btn_FulLScreen"
        Me.btn_FulLScreen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_FulLScreen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_FulLScreen.OnHoverImage = Nothing
        Me.btn_FulLScreen.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_FulLScreen.OnPressedColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.Radius = 5
        Me.btn_FulLScreen.Size = New System.Drawing.Size(110, 48)
        Me.btn_FulLScreen.TabIndex = 80
        Me.btn_FulLScreen.Text = "Tam Ekran"
        Me.btn_FulLScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Controller
        '
        Me.Controller.Enabled = true
        Me.Controller.Interval = 1
        '
        'dataUpdater
        '
        Me.dataUpdater.Enabled = true
        Me.dataUpdater.Interval = 1000
        '
        'group_bot
        '
        Me.group_bot.BackColor = System.Drawing.Color.Transparent
        Me.group_bot.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_bot.BorderColor = System.Drawing.Color.MidnightBlue
        Me.group_bot.BorderSize = 1
        Me.group_bot.Controls.Add(Me.button_GetBook)
        Me.group_bot.Controls.Add(Me.getBook_id)
        Me.group_bot.Controls.Add(Me.GunaLabel4)
        Me.group_bot.Controls.Add(Me.GunaLabel3)
        Me.group_bot.Controls.Add(Me.GunaLabel2)
        Me.group_bot.Controls.Add(Me.getBook_date)
        Me.group_bot.Controls.Add(Me.getBook_reset)
        Me.group_bot.Controls.Add(Me.getBook_no)
        Me.group_bot.LineBottom = 3
        Me.group_bot.LineColor = System.Drawing.Color.Indigo
        Me.group_bot.Location = New System.Drawing.Point(488, 500)
        Me.group_bot.Name = "group_bot"
        Me.group_bot.Radius = 5
        Me.group_bot.Size = New System.Drawing.Size(257, 235)
        Me.group_bot.TabIndex = 83
        Me.group_bot.Text = "Kitap Teslim"
        Me.group_bot.TextLocation = New System.Drawing.Point(10, 8)
        '
        'button_GetBook
        '
        Me.button_GetBook.Animated = true
        Me.button_GetBook.AnimationHoverSpeed = 5!
        Me.button_GetBook.AnimationSpeed = 5!
        Me.button_GetBook.BackColor = System.Drawing.Color.Transparent
        Me.button_GetBook.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.button_GetBook.BorderColor = System.Drawing.Color.Black
        Me.button_GetBook.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_GetBook.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_GetBook.CheckedForeColor = System.Drawing.Color.White
        Me.button_GetBook.CheckedImage = CType(resources.GetObject("button_GetBook.CheckedImage"),System.Drawing.Image)
        Me.button_GetBook.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_GetBook.FocusedColor = System.Drawing.Color.Empty
        Me.button_GetBook.Font = New System.Drawing.Font("Montserrat", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.button_GetBook.ForeColor = System.Drawing.Color.Aqua
        Me.button_GetBook.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.button_GetBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.button_GetBook.ImageSize = New System.Drawing.Size(28, 28)
        Me.button_GetBook.LineBottom = 3
        Me.button_GetBook.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.button_GetBook.Location = New System.Drawing.Point(27, 188)
        Me.button_GetBook.Name = "button_GetBook"
        Me.button_GetBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.button_GetBook.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_GetBook.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.button_GetBook.OnHoverImage = Nothing
        Me.button_GetBook.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.button_GetBook.OnPressedColor = System.Drawing.Color.Black
        Me.button_GetBook.Radius = 5
        Me.button_GetBook.Size = New System.Drawing.Size(214, 38)
        Me.button_GetBook.TabIndex = 86
        Me.button_GetBook.Text = "Teslim Et"
        Me.button_GetBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'getBook_id
        '
        Me.getBook_id.AutoSize = true
        Me.getBook_id.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.getBook_id.Location = New System.Drawing.Point(72, 162)
        Me.getBook_id.Name = "getBook_id"
        Me.getBook_id.Size = New System.Drawing.Size(79, 13)
        Me.getBook_id.TabIndex = 85
        Me.getBook_id.Text = "kitap seçiniz..."
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 8!)
        Me.GunaLabel4.Location = New System.Drawing.Point(24, 162)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(49, 13)
        Me.GunaLabel4.TabIndex = 10
        Me.GunaLabel4.Text = "kitap id:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.GunaLabel3.Location = New System.Drawing.Point(25, 101)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(130, 21)
        Me.GunaLabel3.TabIndex = 84
        Me.GunaLabel3.Text = "Geri Teslim Tarihi:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.GunaLabel2.Location = New System.Drawing.Point(18, 58)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(105, 21)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Öğr. Okul No:"
        '
        'getBook_date
        '
        Me.getBook_date.BackColor = System.Drawing.Color.Transparent
        Me.getBook_date.BaseColor = System.Drawing.Color.White
        Me.getBook_date.BorderColor = System.Drawing.Color.Silver
        Me.getBook_date.CustomFormat = Nothing
        Me.getBook_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.getBook_date.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.getBook_date.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.getBook_date.ForeColor = System.Drawing.Color.Black
        Me.getBook_date.Location = New System.Drawing.Point(22, 126)
        Me.getBook_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.getBook_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.getBook_date.Name = "getBook_date"
        Me.getBook_date.OnHoverBaseColor = System.Drawing.Color.White
        Me.getBook_date.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.getBook_date.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.getBook_date.OnPressedColor = System.Drawing.Color.Black
        Me.getBook_date.Radius = 5
        Me.getBook_date.Size = New System.Drawing.Size(214, 30)
        Me.getBook_date.TabIndex = 83
        Me.getBook_date.Text = "Wednesday, April 20, 2022"
        Me.getBook_date.Value = New Date(2022, 4, 20, 1, 15, 37, 835)
        '
        'getBook_reset
        '
        Me.getBook_reset.Animated = true
        Me.getBook_reset.AnimationHoverSpeed = 3!
        Me.getBook_reset.AnimationSpeed = 3!
        Me.getBook_reset.BackColor = System.Drawing.Color.Transparent
        Me.getBook_reset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.getBook_reset.BorderColor = System.Drawing.Color.Black
        Me.getBook_reset.CheckedBaseColor = System.Drawing.Color.Gray
        Me.getBook_reset.CheckedBorderColor = System.Drawing.Color.Black
        Me.getBook_reset.CheckedForeColor = System.Drawing.Color.White
        Me.getBook_reset.CheckedImage = CType(resources.GetObject("getBook_reset.CheckedImage"),System.Drawing.Image)
        Me.getBook_reset.CheckedLineColor = System.Drawing.Color.DimGray
        Me.getBook_reset.FocusedColor = System.Drawing.Color.Empty
        Me.getBook_reset.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.getBook_reset.ForeColor = System.Drawing.Color.Aqua
        Me.getBook_reset.Image = Global.HBR_Library_System.My.Resources.Resources.available_updates_64px1
        Me.getBook_reset.ImageSize = New System.Drawing.Size(22, 22)
        Me.getBook_reset.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.getBook_reset.Location = New System.Drawing.Point(154, 3)
        Me.getBook_reset.Name = "getBook_reset"
        Me.getBook_reset.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.getBook_reset.OnHoverBorderColor = System.Drawing.Color.Black
        Me.getBook_reset.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.getBook_reset.OnHoverImage = Nothing
        Me.getBook_reset.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.getBook_reset.OnPressedColor = System.Drawing.Color.Black
        Me.getBook_reset.Radius = 3
        Me.getBook_reset.Size = New System.Drawing.Size(87, 23)
        Me.getBook_reset.TabIndex = 82
        Me.getBook_reset.Text = "Sıfırla"
        '
        'getBook_no
        '
        Me.getBook_no.Animated = true
        Me.getBook_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.getBook_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.getBook_no.FocusedLineColor = System.Drawing.Color.Indigo
        Me.getBook_no.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.getBook_no.LineColor = System.Drawing.Color.Aqua
        Me.getBook_no.Location = New System.Drawing.Point(129, 46)
        Me.getBook_no.MaxLength = 6
        Me.getBook_no.Name = "getBook_no"
        Me.getBook_no.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.getBook_no.Size = New System.Drawing.Size(107, 47)
        Me.getBook_no.TabIndex = 4
        Me.getBook_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'group_extra
        '
        Me.group_extra.BackColor = System.Drawing.Color.Transparent
        Me.group_extra.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_extra.BorderColor = System.Drawing.Color.MidnightBlue
        Me.group_extra.BorderSize = 1
        Me.group_extra.Controls.Add(Me.selected_ISBN)
        Me.group_extra.Controls.Add(Me.GunaLabel7)
        Me.group_extra.Controls.Add(Me.selected_Publisher)
        Me.group_extra.Controls.Add(Me.GunaLabel8)
        Me.group_extra.Controls.Add(Me.selected_Author)
        Me.group_extra.Controls.Add(Me.GunaLabel5)
        Me.group_extra.Controls.Add(Me.GunaAdvenceButton2)
        Me.group_extra.Controls.Add(Me.book_poster)
        Me.group_extra.Controls.Add(Me.selected_BookName)
        Me.group_extra.Controls.Add(Me.GunaLabel6)
        Me.group_extra.LineBottom = 3
        Me.group_extra.LineColor = System.Drawing.Color.Indigo
        Me.group_extra.Location = New System.Drawing.Point(20, 500)
        Me.group_extra.Name = "group_extra"
        Me.group_extra.Radius = 5
        Me.group_extra.Size = New System.Drawing.Size(462, 235)
        Me.group_extra.TabIndex = 82
        Me.group_extra.Text = "Seçilen Kitap Bilgileri"
        Me.group_extra.TextLocation = New System.Drawing.Point(10, 8)
        '
        'selected_ISBN
        '
        Me.selected_ISBN.Animated = true
        Me.selected_ISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.selected_ISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.selected_ISBN.FocusedLineColor = System.Drawing.Color.Indigo
        Me.selected_ISBN.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.selected_ISBN.LineColor = System.Drawing.Color.DarkSlateGray
        Me.selected_ISBN.LineSize = 1
        Me.selected_ISBN.Location = New System.Drawing.Point(79, 153)
        Me.selected_ISBN.Name = "selected_ISBN"
        Me.selected_ISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.selected_ISBN.Size = New System.Drawing.Size(242, 30)
        Me.selected_ISBN.TabIndex = 92
        Me.selected_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = true
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.GunaLabel7.Location = New System.Drawing.Point(6, 157)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(41, 19)
        Me.GunaLabel7.TabIndex = 93
        Me.GunaLabel7.Text = "ISBN:"
        '
        'selected_Publisher
        '
        Me.selected_Publisher.Animated = true
        Me.selected_Publisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.selected_Publisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.selected_Publisher.FocusedLineColor = System.Drawing.Color.Indigo
        Me.selected_Publisher.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.selected_Publisher.LineColor = System.Drawing.Color.DarkSlateGray
        Me.selected_Publisher.LineSize = 1
        Me.selected_Publisher.Location = New System.Drawing.Point(79, 117)
        Me.selected_Publisher.Name = "selected_Publisher"
        Me.selected_Publisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.selected_Publisher.Size = New System.Drawing.Size(242, 30)
        Me.selected_Publisher.TabIndex = 90
        Me.selected_Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = true
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.GunaLabel8.Location = New System.Drawing.Point(6, 121)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(61, 19)
        Me.GunaLabel8.TabIndex = 91
        Me.GunaLabel8.Text = "Yayınevi:"
        '
        'selected_Author
        '
        Me.selected_Author.Animated = true
        Me.selected_Author.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.selected_Author.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.selected_Author.FocusedLineColor = System.Drawing.Color.Indigo
        Me.selected_Author.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.selected_Author.LineColor = System.Drawing.Color.DarkSlateGray
        Me.selected_Author.LineSize = 1
        Me.selected_Author.Location = New System.Drawing.Point(79, 81)
        Me.selected_Author.Name = "selected_Author"
        Me.selected_Author.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.selected_Author.Size = New System.Drawing.Size(242, 30)
        Me.selected_Author.TabIndex = 88
        Me.selected_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.GunaLabel5.Location = New System.Drawing.Point(6, 85)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(44, 19)
        Me.GunaLabel5.TabIndex = 89
        Me.GunaLabel5.Text = "Yazar:"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.Animated = true
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 5!
        Me.GunaAdvenceButton2.AnimationSpeed = 5!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Montserrat", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.Aqua
        Me.GunaAdvenceButton2.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.GunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaAdvenceButton2.LineBottom = 3
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(79, 188)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 3
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(242, 38)
        Me.GunaAdvenceButton2.TabIndex = 87
        Me.GunaAdvenceButton2.Text = "Bilgileri Güncelle"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'book_poster
        '
        Me.book_poster.BackColor = System.Drawing.Color.Transparent
        Me.book_poster.BaseColor = System.Drawing.Color.White
        Me.book_poster.Image = Global.HBR_Library_System.My.Resources.Resources.HBR
        Me.book_poster.ImageLocation = ""
        Me.book_poster.Location = New System.Drawing.Point(330, 41)
        Me.book_poster.Name = "book_poster"
        Me.book_poster.Radius = 6
        Me.book_poster.Size = New System.Drawing.Size(122, 185)
        Me.book_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.book_poster.TabIndex = 10
        Me.book_poster.TabStop = false
        '
        'selected_BookName
        '
        Me.selected_BookName.Animated = true
        Me.selected_BookName.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.selected_BookName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.selected_BookName.FocusedLineColor = System.Drawing.Color.Indigo
        Me.selected_BookName.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.selected_BookName.LineColor = System.Drawing.Color.DarkSlateGray
        Me.selected_BookName.LineSize = 1
        Me.selected_BookName.Location = New System.Drawing.Point(79, 45)
        Me.selected_BookName.Name = "selected_BookName"
        Me.selected_BookName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.selected_BookName.Size = New System.Drawing.Size(242, 30)
        Me.selected_BookName.TabIndex = 2
        Me.selected_BookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.GunaLabel6.Location = New System.Drawing.Point(6, 49)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "Kitap Adı:"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 6
        Me.GunaElipse1.TargetControl = Me.getBook_no
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 3
        Me.GunaElipse2.TargetControl = Me.method_author
        '
        'method_author
        '
        Me.method_author.BackColor = System.Drawing.Color.Transparent
        Me.method_author.BaseColor = System.Drawing.SystemColors.Control
        Me.method_author.CheckedOffColor = System.Drawing.Color.Gray
        Me.method_author.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.method_author.FillColor = System.Drawing.Color.White
        Me.method_author.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.method_author.Location = New System.Drawing.Point(401, 453)
        Me.method_author.Name = "method_author"
        Me.method_author.Size = New System.Drawing.Size(52, 20)
        Me.method_author.TabIndex = 102
        Me.method_author.Text = "Yazar"
        '
        'book_finder
        '
        Me.book_finder.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.book_finder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.book_finder.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.book_finder.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.book_finder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.book_finder.LineColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.book_finder.LineSize = 1
        Me.book_finder.Location = New System.Drawing.Point(472, 446)
        Me.book_finder.Name = "book_finder"
        Me.book_finder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.book_finder.Size = New System.Drawing.Size(221, 37)
        Me.book_finder.TabIndex = 105
        Me.book_finder.Text = "Kitap Ara..."
        Me.book_finder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'method_bookname
        '
        Me.method_bookname.BackColor = System.Drawing.Color.Transparent
        Me.method_bookname.BaseColor = System.Drawing.SystemColors.Control
        Me.method_bookname.Checked = true
        Me.method_bookname.CheckedOffColor = System.Drawing.Color.Gray
        Me.method_bookname.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.method_bookname.FillColor = System.Drawing.Color.White
        Me.method_bookname.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.method_bookname.Location = New System.Drawing.Point(401, 435)
        Me.method_bookname.Name = "method_bookname"
        Me.method_bookname.Size = New System.Drawing.Size(68, 20)
        Me.method_bookname.TabIndex = 104
        Me.method_bookname.Text = "Kitap Adı"
        '
        'method_isbn
        '
        Me.method_isbn.BackColor = System.Drawing.Color.Transparent
        Me.method_isbn.BaseColor = System.Drawing.SystemColors.Control
        Me.method_isbn.CheckedOffColor = System.Drawing.Color.Gray
        Me.method_isbn.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.method_isbn.FillColor = System.Drawing.Color.White
        Me.method_isbn.Font = New System.Drawing.Font("Segoe UI", 7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.method_isbn.Location = New System.Drawing.Point(401, 472)
        Me.method_isbn.Name = "method_isbn"
        Me.method_isbn.Size = New System.Drawing.Size(49, 20)
        Me.method_isbn.TabIndex = 103
        Me.method_isbn.Text = "ISBN"
        '
        'book_find
        '
        Me.book_find.Animated = true
        Me.book_find.AnimationHoverSpeed = 10!
        Me.book_find.AnimationSpeed = 10!
        Me.book_find.BackColor = System.Drawing.Color.Transparent
        Me.book_find.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.book_find.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.book_find.BorderSize = 1
        Me.book_find.CheckedBaseColor = System.Drawing.Color.White
        Me.book_find.CheckedBorderColor = System.Drawing.Color.Black
        Me.book_find.CheckedForeColor = System.Drawing.Color.Indigo
        Me.book_find.CheckedImage = Global.HBR_Library_System.My.Resources.Resources.book_96px
        Me.book_find.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(2,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(39,Byte),Integer))
        Me.book_find.FocusedColor = System.Drawing.Color.Empty
        Me.book_find.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.book_find.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.book_find.Image = Global.HBR_Library_System.My.Resources.Resources.search_64px
        Me.book_find.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.book_find.ImageSize = New System.Drawing.Size(32, 32)
        Me.book_find.LineColor = System.Drawing.Color.Indigo
        Me.book_find.LineLeft = 4
        Me.book_find.LineRight = 4
        Me.book_find.Location = New System.Drawing.Point(389, 431)
        Me.book_find.Name = "book_find"
        Me.book_find.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.book_find.OnHoverBorderColor = System.Drawing.Color.Black
        Me.book_find.OnHoverForeColor = System.Drawing.Color.White
        Me.book_find.OnHoverImage = Nothing
        Me.book_find.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.book_find.OnPressedColor = System.Drawing.Color.Black
        Me.book_find.Radius = 6
        Me.book_find.Size = New System.Drawing.Size(356, 63)
        Me.book_find.TabIndex = 102
        Me.book_find.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.book_find.TextOffsetX = 53
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 3
        Me.GunaElipse4.TargetControl = Me.method_isbn
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 3
        Me.GunaElipse5.TargetControl = Me.method_bookname
        '
        'GunaElipse6
        '
        Me.GunaElipse6.TargetControl = Me
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
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.bulleted_list_64px
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaAdvenceButton1.LineBottom = 3
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(20, 435)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(123, 48)
        Me.GunaAdvenceButton1.TabIndex = 106
        Me.GunaAdvenceButton1.Text = "Kitap Listesi"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton1.TextOffsetX = 4
        '
        'BookList_X
        '
        Me.BookList_X.AllowUserToAddRows = false
        Me.BookList_X.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList_X.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookList_X.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BookList_X.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.BookList_X.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookList_X.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookList_X.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.BookList_X.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(18,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookList_X.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BookList_X.ColumnHeadersHeight = 27
        Me.BookList_X.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookList_X.DefaultCellStyle = DataGridViewCellStyle3
        Me.BookList_X.EnableHeadersVisualStyles = false
        Me.BookList_X.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BookList_X.Location = New System.Drawing.Point(704, 22)
        Me.BookList_X.Name = "BookList_X"
        Me.BookList_X.ReadOnly = true
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookList_X.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BookList_X.RowHeadersVisible = false
        Me.BookList_X.RowTemplate.Height = 31
        Me.BookList_X.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookList_X.Size = New System.Drawing.Size(41, 21)
        Me.BookList_X.TabIndex = 107
        Me.BookList_X.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.BookList_X.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BookList_X.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BookList_X.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.BookList_X.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.BookList_X.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList_X.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.BookList_X.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BookList_X.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BookList_X.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookList_X.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BookList_X.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BookList_X.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BookList_X.ThemeStyle.HeaderStyle.Height = 27
        Me.BookList_X.ThemeStyle.ReadOnly = true
        Me.BookList_X.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BookList_X.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookList_X.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BookList_X.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(61,Byte),Integer), CType(CType(59,Byte),Integer))
        Me.BookList_X.ThemeStyle.RowsStyle.Height = 31
        Me.BookList_X.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.BookList_X.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BookList_X.Visible = false
        '
        'dataLoader
        '
        Me.dataLoader.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.dataLoader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dataLoader.Location = New System.Drawing.Point(9, 49)
        Me.dataLoader.Name = "dataLoader"
        Me.dataLoader.Size = New System.Drawing.Size(745, 686)
        Me.dataLoader.TabIndex = 108
        '
        'Book_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.dataLoader)
        Me.Controls.Add(Me.book_finder)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.method_author)
        Me.Controls.Add(Me.method_bookname)
        Me.Controls.Add(Me.method_isbn)
        Me.Controls.Add(Me.book_find)
        Me.Controls.Add(Me.group_bot)
        Me.Controls.Add(Me.group_extra)
        Me.Controls.Add(Me.btn_AutoSize)
        Me.Controls.Add(Me.btn_FulLScreen)
        Me.Controls.Add(Me.occurred)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.BookList_X)
        Me.Controls.Add(Me.bookList)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "Book_List"
        Me.Size = New System.Drawing.Size(768, 752)
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).EndInit
        Me.group_bot.ResumeLayout(false)
        Me.group_bot.PerformLayout
        Me.group_extra.ResumeLayout(false)
        Me.group_extra.PerformLayout
        CType(Me.book_poster,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BookList_X,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipse_dataList As Guna.UI.WinForms.GunaElipse
    Friend WithEvents occurred As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bookList As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents elipse_databookList As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipse_occurred As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_FulLScreen As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_AutoSize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Controller As Timer
    Friend WithEvents dataUpdater As Timer
    Friend WithEvents group_bot As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents getBook_reset As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents getBook_no As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents group_extra As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents selected_BookName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents getBook_date As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents getBook_id As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents button_GetBook As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents selected_ISBN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents selected_Publisher As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents selected_Author As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents book_poster As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents book_finder As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents method_author As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents method_bookname As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents method_isbn As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents book_find As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BookList_X As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents dataLoader As loader
End Class
