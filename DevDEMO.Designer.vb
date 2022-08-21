<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevDEMO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevDEMO))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.occurred = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.xtextraw = New System.Windows.Forms.TextBox()
        Me.xtext = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New HBR_Library_System.RadioButton()
        Me.RadioButton1 = New HBR_Library_System.RadioButton()
        Me.FlatButton2 = New HBR_Library_System.FlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.attributee = New HBR_Library_System.FlatTextBox()
        Me.FlatButton4 = New HBR_Library_System.FlatButton()
        Me.subjectLOGx = New System.Windows.Forms.RichTextBox()
        Me.xpath = New HBR_Library_System.FlatTextBox()
        Me.combo_Subject = New Guna.UI.WinForms.GunaComboBox()
        Me.isbn = New HBR_Library_System.FlatTextBox()
        Me.FlatButton3 = New HBR_Library_System.FlatButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.xtext.SuspendLayout
        Me.GunaGradient2Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.Size = New System.Drawing.Size(259, 274)
        Me.DataGridView1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(13, 297)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(152, 160)
        Me.ListBox1.TabIndex = 1
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"),System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(180, 387)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(592, 70)
        Me.GunaAdvenceButton1.TabIndex = 2
        Me.GunaAdvenceButton1.Text = "TEST"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'occurred
        '
        Me.occurred.AutoSize = true
        Me.occurred.BackColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(39,Byte),Integer), CType(CType(50,Byte),Integer))
        Me.occurred.Font = New System.Drawing.Font("Segoe UI", 16!)
        Me.occurred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.occurred.Location = New System.Drawing.Point(32, 126)
        Me.occurred.Name = "occurred"
        Me.occurred.Size = New System.Drawing.Size(228, 30)
        Me.occurred.TabIndex = 78
        Me.occurred.Text = "Oops! Bir Hata Oluştu!"
        Me.occurred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.occurred.Visible = false
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.xtextraw)
        Me.Panel1.Controls.Add(Me.xtext)
        Me.Panel1.Location = New System.Drawing.Point(180, 297)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 84)
        Me.Panel1.TabIndex = 79
        '
        'xtextraw
        '
        Me.xtextraw.Location = New System.Drawing.Point(450, 18)
        Me.xtextraw.Name = "xtextraw"
        Me.xtextraw.Size = New System.Drawing.Size(126, 20)
        Me.xtextraw.TabIndex = 1
        '
        'xtext
        '
        Me.xtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.xtext.Controls.Add(Me.Label1)
        Me.xtext.Location = New System.Drawing.Point(23, 18)
        Me.xtext.Name = "xtext"
        Me.xtext.Size = New System.Drawing.Size(420, 33)
        Me.xtext.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(175, 0, 100, 0)
        Me.Label1.Size = New System.Drawing.Size(597, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bu bir Deneme yazısıdır"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.VScrollBar1)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.GunaGradient2Panel1.Controls.Add(Me.RadioButton3)
        Me.GunaGradient2Panel1.Controls.Add(Me.RadioButton2)
        Me.GunaGradient2Panel1.Controls.Add(Me.RadioButton1)
        Me.GunaGradient2Panel1.Controls.Add(Me.FlatButton2)
        Me.GunaGradient2Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.DarkGray
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.LightGray
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(279, 13)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(493, 278)
        Me.GunaGradient2Panel1.TabIndex = 80
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(473, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 278)
        Me.VScrollBar1.TabIndex = 5
        '
        'GunaAdvenceTileButton1
        '
        Me.GunaAdvenceTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Image = CType(resources.GetObject("GunaAdvenceTileButton1.Image"),System.Drawing.Image)
        Me.GunaAdvenceTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(79, 205)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(160, 160)
        Me.GunaAdvenceTileButton1.TabIndex = 4
        Me.GunaAdvenceTileButton1.Text = "GunaAdvenceTileButton1"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = true
        Me.RadioButton3.Location = New System.Drawing.Point(62, 181)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = true
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = true
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.RadioButton2.Checked = false
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.RadioButton2.Location = New System.Drawing.Point(41, 120)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Options = HBR_Library_System.RadioButton._Options.Style1
        Me.RadioButton2.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "RadioButton2"
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.RadioButton1.Checked = false
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 10!)
        Me.RadioButton1.Location = New System.Drawing.Point(13, 74)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Options = HBR_Library_System.RadioButton._Options.Style1
        Me.RadioButton1.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "RadioButton1"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FlatButton2.Location = New System.Drawing.Point(13, 25)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = false
        Me.FlatButton2.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton2.TabIndex = 0
        Me.FlatButton2.Text = "FlatButton2"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.attributee)
        Me.Panel2.Controls.Add(Me.FlatButton4)
        Me.Panel2.Controls.Add(Me.subjectLOGx)
        Me.Panel2.Controls.Add(Me.xpath)
        Me.Panel2.Controls.Add(Me.combo_Subject)
        Me.Panel2.Controls.Add(Me.isbn)
        Me.Panel2.Controls.Add(Me.FlatButton3)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(778, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 448)
        Me.Panel2.TabIndex = 81
        '
        'attributee
        '
        Me.attributee.BackColor = System.Drawing.Color.Transparent
        Me.attributee.Location = New System.Drawing.Point(16, 91)
        Me.attributee.MaxLength = 32767
        Me.attributee.Multiline = false
        Me.attributee.Name = "attributee"
        Me.attributee.ReadOnly = false
        Me.attributee.Size = New System.Drawing.Size(103, 29)
        Me.attributee.TabIndex = 12
        Me.attributee.Text = "src"
        Me.attributee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.attributee.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.attributee.UseSystemPasswordChar = false
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.MidnightBlue
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FlatButton4.Location = New System.Drawing.Point(184, 18)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = false
        Me.FlatButton4.Size = New System.Drawing.Size(74, 32)
        Me.FlatButton4.TabIndex = 11
        Me.FlatButton4.Text = "Convert"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'subjectLOGx
        '
        Me.subjectLOGx.Location = New System.Drawing.Point(16, 162)
        Me.subjectLOGx.Name = "subjectLOGx"
        Me.subjectLOGx.Size = New System.Drawing.Size(242, 74)
        Me.subjectLOGx.TabIndex = 10
        Me.subjectLOGx.Text = ""
        '
        'xpath
        '
        Me.xpath.BackColor = System.Drawing.Color.Transparent
        Me.xpath.Location = New System.Drawing.Point(16, 56)
        Me.xpath.MaxLength = 32767
        Me.xpath.Multiline = false
        Me.xpath.Name = "xpath"
        Me.xpath.ReadOnly = false
        Me.xpath.Size = New System.Drawing.Size(242, 29)
        Me.xpath.TabIndex = 9
        Me.xpath.Text = "//*[@id='search_results']/table[1]"
        Me.xpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.xpath.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.xpath.UseSystemPasswordChar = false
        '
        'combo_Subject
        '
        Me.combo_Subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.combo_Subject.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.combo_Subject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.combo_Subject.BorderSize = 1
        Me.combo_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combo_Subject.FocusedColor = System.Drawing.Color.Indigo
        Me.combo_Subject.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.combo_Subject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.combo_Subject.FormattingEnabled = true
        Me.combo_Subject.Items.AddRange(New Object() {"Seçiniz...", "Dünya Klasikleri", "Aşk", "Psikoloji", "Roman", "Rus Romanı", "İngiliz Romanı", "Gençlik", "Din", "Tarih", "Siyaset-Politika", "Kişisel Gelişim", "Çocuk", "Macera-Aksiyon", "Şiir", "Felsefe-Düşünce", "Korku-Gerilim", "Polisiye", "Bilim Kurgu-Fantastik", "Hikaye", "Edebiyat", "Sosyoloji", "Biyografi", "Araştırma", "Deneme-İnceleme", "Spiritüalizm", "Ekonomi-İş Dünyası", "Eğlence-Mizah", "Manga", "Masal", "Anı-Mektup-Günlük", "Sağlık-Tıp", "İnsan ve Toplum", "Bilim-Teknoloji-Mühendislik", "Eğitim", "Türk Klasikleri", "Tiyatro", "Çizgi Roman", "Tasavvuf-Mezhepler-Tarikatlar", "Bilgisayar-İnternet", "Hukuk", "Sanat", "Spor", "Gezi", "Kadın-Erkek", "Anlatı", "Dergi", "Hobi", "Sinema", "Yemek", "Söyleşi-Röportaj", "Özlü Sözler", "Ders Kitapları", "Antoloji", "Astroloji", "Müzik", "Halk Edebiyatı", "Senaryo", "İletişim", "Moda", "Kültür", "Sözlük-Kılavuz-Ansiklopedi", "Diğer"})
        Me.combo_Subject.Location = New System.Drawing.Point(20, 126)
        Me.combo_Subject.Name = "combo_Subject"
        Me.combo_Subject.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.combo_Subject.OnHoverItemForeColor = System.Drawing.Color.White
        Me.combo_Subject.Size = New System.Drawing.Size(238, 30)
        Me.combo_Subject.TabIndex = 8
        '
        'isbn
        '
        Me.isbn.BackColor = System.Drawing.Color.Transparent
        Me.isbn.Location = New System.Drawing.Point(125, 91)
        Me.isbn.MaxLength = 32767
        Me.isbn.Multiline = false
        Me.isbn.Name = "isbn"
        Me.isbn.ReadOnly = false
        Me.isbn.Size = New System.Drawing.Size(133, 29)
        Me.isbn.TabIndex = 3
        Me.isbn.Text = "9786052951569"
        Me.isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.isbn.TextColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.isbn.UseSystemPasswordChar = false
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Indigo
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FlatButton3.Location = New System.Drawing.Point(16, 18)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = false
        Me.FlatButton3.Size = New System.Drawing.Size(162, 32)
        Me.FlatButton3.TabIndex = 2
        Me.FlatButton3.Text = "GET"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer), CType(CType(243,Byte),Integer))
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = true
        Me.ListBox2.Location = New System.Drawing.Point(16, 242)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(242, 95)
        Me.ListBox2.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 340)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(242, 96)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'DevDEMO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1062, 467)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.occurred)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "DevDEMO"
        Me.Text = " "
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.xtext.ResumeLayout(false)
        Me.xtext.PerformLayout
        Me.GunaGradient2Panel1.ResumeLayout(false)
        Me.GunaGradient2Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents occurred As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents xtextraw As TextBox
    Friend WithEvents xtext As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents isbn As FlatTextBox
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents combo_Subject As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents xpath As FlatTextBox
    Friend WithEvents subjectLOGx As RichTextBox
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents attributee As FlatTextBox
End Class
