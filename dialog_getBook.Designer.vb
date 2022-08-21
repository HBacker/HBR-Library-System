<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialog_GetBookx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialog_GetBookx))
        Me.FormSkin1 = New HBR_Library_System.FormSkin()
        Me.title = New Guna.UI.WinForms.GunaLabel()
        Me.btnOK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.name = New Guna.UI.WinForms.GunaLabel()
        Me.no = New Guna.UI.WinForms.GunaLabel()
        Me.book = New Guna.UI.WinForms.GunaLabel()
        Me.pdate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.isbn = New Guna.UI.WinForms.GunaLabel()
        Me.person = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.FormSkin1.SuspendLayout
        Me.SuspendLayout
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(60,Byte),Integer))
        Me.FormSkin1.Controls.Add(Me.title)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.FormSkin1.HeaderMaximize = false
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(545, 48)
        Me.FormSkin1.TabIndex = 88
        Me.FormSkin1.Text = "FormSkin1"
        '
        'title
        '
        Me.title.AutoSize = true
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Montserrat", 20!, System.Drawing.FontStyle.Bold)
        Me.title.Location = New System.Drawing.Point(146, 4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(282, 37)
        Me.title.TabIndex = 0
        Me.title.Text = "Onay: Kitap Teslim"
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
        Me.btnOK.Location = New System.Drawing.Point(377, 279)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOK.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnOK.OnHoverImage = Nothing
        Me.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnOK.OnPressedColor = System.Drawing.Color.Black
        Me.btnOK.Radius = 5
        Me.btnOK.Size = New System.Drawing.Size(156, 50)
        Me.btnOK.TabIndex = 90
        Me.btnOK.Text = "Onayla"
        Me.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnOK.TextOffsetX = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Montserrat", 12!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(20, 62)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(138, 22)
        Me.GunaLabel1.TabIndex = 91
        Me.GunaLabel1.Text = "Teslim Bilgileri;"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.Location = New System.Drawing.Point(19, 90)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(141, 30)
        Me.GunaLabel2.TabIndex = 92
        Me.GunaLabel2.Text = "Adı Soyadı:"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.Location = New System.Drawing.Point(19, 120)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(192, 30)
        Me.GunaLabel3.TabIndex = 93
        Me.GunaLabel3.Text = "Okul Numarası:"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel4.Location = New System.Drawing.Point(19, 150)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(256, 30)
        Me.GunaLabel4.TabIndex = 94
        Me.GunaLabel4.Text = "Teslim Alacağı Kitap:"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel5.Location = New System.Drawing.Point(19, 210)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(75, 30)
        Me.GunaLabel5.TabIndex = 95
        Me.GunaLabel5.Text = "ISBN:"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel6.Location = New System.Drawing.Point(19, 180)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(140, 30)
        Me.GunaLabel6.TabIndex = 96
        Me.GunaLabel6.Text = "Iade Tarihi:"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = true
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel7.Location = New System.Drawing.Point(19, 240)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(160, 30)
        Me.GunaLabel7.TabIndex = 97
        Me.GunaLabel7.Text = "Teslim Eden:"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'name
        '
        Me.name.AutoSize = true
        Me.name.BackColor = System.Drawing.Color.Transparent
        Me.name.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.name.ForeColor = System.Drawing.Color.White
        Me.name.Location = New System.Drawing.Point(166, 90)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(29, 30)
        Me.name.TabIndex = 98
        Me.name.Text = "#"
        Me.name.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'no
        '
        Me.no.AutoSize = true
        Me.no.BackColor = System.Drawing.Color.Transparent
        Me.no.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.no.ForeColor = System.Drawing.Color.White
        Me.no.Location = New System.Drawing.Point(217, 120)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(29, 30)
        Me.no.TabIndex = 99
        Me.no.Text = "#"
        Me.no.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'book
        '
        Me.book.AutoSize = true
        Me.book.BackColor = System.Drawing.Color.Transparent
        Me.book.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.book.ForeColor = System.Drawing.Color.White
        Me.book.Location = New System.Drawing.Point(281, 151)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(29, 30)
        Me.book.TabIndex = 100
        Me.book.Text = "#"
        Me.book.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.pdate.Location = New System.Drawing.Point(165, 183)
        Me.pdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.pdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.pdate.Name = "pdate"
        Me.pdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.pdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pdate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.pdate.OnPressedColor = System.Drawing.Color.Black
        Me.pdate.Radius = 5
        Me.pdate.Size = New System.Drawing.Size(216, 30)
        Me.pdate.TabIndex = 101
        Me.pdate.Text = "Wednesday, April 20, 2022"
        Me.pdate.Value = New Date(2022, 4, 20, 1, 15, 37, 835)
        '
        'isbn
        '
        Me.isbn.AutoSize = true
        Me.isbn.BackColor = System.Drawing.Color.Transparent
        Me.isbn.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.isbn.ForeColor = System.Drawing.Color.White
        Me.isbn.Location = New System.Drawing.Point(100, 210)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(29, 30)
        Me.isbn.TabIndex = 102
        Me.isbn.Text = "#"
        Me.isbn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'person
        '
        Me.person.AutoSize = true
        Me.person.BackColor = System.Drawing.Color.Transparent
        Me.person.Font = New System.Drawing.Font("Montserrat", 16!, System.Drawing.FontStyle.Bold)
        Me.person.ForeColor = System.Drawing.Color.White
        Me.person.Location = New System.Drawing.Point(185, 240)
        Me.person.Name = "person"
        Me.person.Size = New System.Drawing.Size(29, 30)
        Me.person.TabIndex = 103
        Me.person.Text = "#"
        Me.person.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = true
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 5!
        Me.GunaAdvenceButton1.AnimationSpeed = 5!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Aqua
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.cancel_64px
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaAdvenceButton1.LineBottom = 3
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.Crimson
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(215, 279)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 5
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(156, 50)
        Me.GunaAdvenceButton1.TabIndex = 104
        Me.GunaAdvenceButton1.Text = "Vazgeç"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton1.TextOffsetX = 6
        '
        'dialog_GetBookx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.person)
        Me.Controls.Add(Me.pdate)
        Me.Controls.Add(Me.isbn)
        Me.Controls.Add(Me.book)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.FormSkin1)
        Me.Controls.Add(Me.btnOK)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Size = New System.Drawing.Size(545, 340)
        Me.FormSkin1.ResumeLayout(false)
        Me.FormSkin1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents no As Guna.UI.WinForms.GunaLabel
    Friend WithEvents book As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pdate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents isbn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents person As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
