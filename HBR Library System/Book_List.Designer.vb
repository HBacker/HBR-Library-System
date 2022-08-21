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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_List))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.elipse_dataList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.occurred = New Guna.UI.WinForms.GunaLabel()
        Me.bookList = New Guna.UI.WinForms.GunaDataGridView()
        Me.elipse_databookList = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipse_occurred = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dataUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.go_tracker = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_AutoSize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_FulLScreen = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.elipse_dataList.Radius = 5
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.bookList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
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
        Me.bookList.Location = New System.Drawing.Point(20, 50)
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
        'Timer1
        '
        '
        'dataUpdater
        '
        Me.dataUpdater.Enabled = true
        Me.dataUpdater.Interval = 1000
        '
        'go_tracker
        '
        Me.go_tracker.Animated = true
        Me.go_tracker.AnimationHoverSpeed = 3!
        Me.go_tracker.AnimationSpeed = 3!
        Me.go_tracker.BackColor = System.Drawing.Color.Transparent
        Me.go_tracker.BaseColor = System.Drawing.Color.White
        Me.go_tracker.BorderColor = System.Drawing.Color.Black
        Me.go_tracker.CheckedBaseColor = System.Drawing.Color.Gray
        Me.go_tracker.CheckedBorderColor = System.Drawing.Color.Black
        Me.go_tracker.CheckedForeColor = System.Drawing.Color.White
        Me.go_tracker.CheckedImage = CType(resources.GetObject("go_tracker.CheckedImage"),System.Drawing.Image)
        Me.go_tracker.CheckedLineColor = System.Drawing.Color.DimGray
        Me.go_tracker.FocusedColor = System.Drawing.Color.Empty
        Me.go_tracker.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.go_tracker.ForeColor = System.Drawing.Color.MidnightBlue
        Me.go_tracker.Image = Global.HBR_Library_System.My.Resources.Resources.timesheet_96px
        Me.go_tracker.ImageSize = New System.Drawing.Size(36, 36)
        Me.go_tracker.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.go_tracker.Location = New System.Drawing.Point(20, 431)
        Me.go_tracker.Name = "go_tracker"
        Me.go_tracker.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.go_tracker.OnHoverBorderColor = System.Drawing.Color.Black
        Me.go_tracker.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.go_tracker.OnHoverImage = Nothing
        Me.go_tracker.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.go_tracker.OnPressedColor = System.Drawing.Color.Black
        Me.go_tracker.Radius = 5
        Me.go_tracker.Size = New System.Drawing.Size(122, 42)
        Me.go_tracker.TabIndex = 93
        Me.go_tracker.Text = "Takip Listesi"
        Me.go_tracker.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.go_tracker.TextOffsetX = 4
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
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.available_updates_64px
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(36, 36)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(635, 431)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(110, 42)
        Me.GunaAdvenceButton1.TabIndex = 92
        Me.GunaAdvenceButton1.Text = "Yenile"
        Me.GunaAdvenceButton1.TextOffsetX = 3
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
        Me.btn_AutoSize.Location = New System.Drawing.Point(519, 431)
        Me.btn_AutoSize.Name = "btn_AutoSize"
        Me.btn_AutoSize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_AutoSize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_AutoSize.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_AutoSize.OnHoverImage = Nothing
        Me.btn_AutoSize.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_AutoSize.OnPressedColor = System.Drawing.Color.Black
        Me.btn_AutoSize.Radius = 5
        Me.btn_AutoSize.Size = New System.Drawing.Size(110, 42)
        Me.btn_AutoSize.TabIndex = 91
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
        Me.btn_FulLScreen.Location = New System.Drawing.Point(403, 431)
        Me.btn_FulLScreen.Name = "btn_FulLScreen"
        Me.btn_FulLScreen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_FulLScreen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_FulLScreen.OnHoverImage = Nothing
        Me.btn_FulLScreen.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_FulLScreen.OnPressedColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.Radius = 5
        Me.btn_FulLScreen.Size = New System.Drawing.Size(110, 42)
        Me.btn_FulLScreen.TabIndex = 90
        Me.btn_FulLScreen.Text = "Tam Ekran"
        Me.btn_FulLScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Book_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.go_tracker)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btn_AutoSize)
        Me.Controls.Add(Me.btn_FulLScreen)
        Me.Controls.Add(Me.occurred)
        Me.Controls.Add(Me.bookList)
        Me.Controls.Add(Me.GunaLabel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "Book_List"
        Me.Size = New System.Drawing.Size(766, 532)
        CType(Me.bookList,System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dataUpdater As Timer
    Friend WithEvents go_tracker As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_AutoSize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_FulLScreen As Guna.UI.WinForms.GunaAdvenceButton
End Class
