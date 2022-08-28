<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTracker
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookTracker))
        Me.header_text = New Guna.UI.WinForms.GunaLabel()
        Me.trackList = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.occurred = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_AutoSize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_FulLScreen = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.dataLoader = New HBR_Library_System.loader()
        CType(Me.trackList,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'header_text
        '
        Me.header_text.AutoSize = true
        Me.header_text.BackColor = System.Drawing.Color.Transparent
        Me.header_text.Font = New System.Drawing.Font("Segoe UI Light", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.header_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.header_text.Location = New System.Drawing.Point(310, 2)
        Me.header_text.Name = "header_text"
        Me.header_text.Size = New System.Drawing.Size(170, 45)
        Me.header_text.TabIndex = 83
        Me.header_text.Text = "Kitap Takibi"
        '
        'trackList
        '
        Me.trackList.AllowUserToAddRows = false
        Me.trackList.AllowUserToDeleteRows = false
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.trackList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.trackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.trackList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trackList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.trackList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.trackList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(18,Byte),Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trackList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.trackList.ColumnHeadersHeight = 27
        Me.trackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(94,Byte),Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.trackList.DefaultCellStyle = DataGridViewCellStyle11
        Me.trackList.EnableHeadersVisualStyles = false
        Me.trackList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.trackList.Location = New System.Drawing.Point(20, 50)
        Me.trackList.Name = "trackList"
        Me.trackList.ReadOnly = true
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trackList.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.trackList.RowHeadersVisible = false
        Me.trackList.RowTemplate.Height = 31
        Me.trackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.trackList.Size = New System.Drawing.Size(725, 614)
        Me.trackList.TabIndex = 84
        Me.trackList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.trackList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.trackList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.trackList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.trackList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.trackList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.trackList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.trackList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(229,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.trackList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Indigo
        Me.trackList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.trackList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.trackList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.trackList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.trackList.ThemeStyle.HeaderStyle.Height = 27
        Me.trackList.ThemeStyle.ReadOnly = true
        Me.trackList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.trackList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.trackList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.trackList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71,Byte),Integer), CType(CType(69,Byte),Integer), CType(CType(94,Byte),Integer))
        Me.trackList.ThemeStyle.RowsStyle.Height = 31
        Me.trackList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19,Byte),Integer), CType(CType(25,Byte),Integer), CType(CType(34,Byte),Integer))
        Me.trackList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me.trackList
        '
        'occurred
        '
        Me.occurred.AutoSize = true
        Me.occurred.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.occurred.Font = New System.Drawing.Font("Segoe UI", 16!)
        Me.occurred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.occurred.Location = New System.Drawing.Point(261, 338)
        Me.occurred.Name = "occurred"
        Me.occurred.Size = New System.Drawing.Size(228, 30)
        Me.occurred.TabIndex = 85
        Me.occurred.Text = "Oops! Bir Hata Oluştu!"
        Me.occurred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.occurred.Visible = false
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 5
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 5
        Me.GunaElipse3.TargetControl = Me.occurred
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(635, 685)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(110, 42)
        Me.GunaAdvenceButton1.TabIndex = 89
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
        Me.btn_AutoSize.Location = New System.Drawing.Point(519, 685)
        Me.btn_AutoSize.Name = "btn_AutoSize"
        Me.btn_AutoSize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_AutoSize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_AutoSize.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_AutoSize.OnHoverImage = Nothing
        Me.btn_AutoSize.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_AutoSize.OnPressedColor = System.Drawing.Color.Black
        Me.btn_AutoSize.Radius = 5
        Me.btn_AutoSize.Size = New System.Drawing.Size(110, 42)
        Me.btn_AutoSize.TabIndex = 87
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
        Me.btn_FulLScreen.Location = New System.Drawing.Point(403, 685)
        Me.btn_FulLScreen.Name = "btn_FulLScreen"
        Me.btn_FulLScreen.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_FulLScreen.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_FulLScreen.OnHoverImage = Nothing
        Me.btn_FulLScreen.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_FulLScreen.OnPressedColor = System.Drawing.Color.Black
        Me.btn_FulLScreen.Radius = 5
        Me.btn_FulLScreen.Size = New System.Drawing.Size(110, 42)
        Me.btn_FulLScreen.TabIndex = 86
        Me.btn_FulLScreen.Text = "Tam Ekran"
        Me.btn_FulLScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dataLoader
        '
        Me.dataLoader.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.dataLoader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.dataLoader.Location = New System.Drawing.Point(14, 50)
        Me.dataLoader.Name = "dataLoader"
        Me.dataLoader.Size = New System.Drawing.Size(740, 614)
        Me.dataLoader.TabIndex = 90
        Me.dataLoader.Visible = false
        '
        'BookTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.dataLoader)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btn_AutoSize)
        Me.Controls.Add(Me.btn_FulLScreen)
        Me.Controls.Add(Me.occurred)
        Me.Controls.Add(Me.trackList)
        Me.Controls.Add(Me.header_text)
        Me.Name = "BookTracker"
        Me.Size = New System.Drawing.Size(768, 752)
        CType(Me.trackList,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents header_text As Guna.UI.WinForms.GunaLabel
    Friend WithEvents trackList As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_AutoSize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_FulLScreen As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents occurred As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dataLoader As loader
End Class
