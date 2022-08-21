<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Book
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Book))
        Me.text_bookName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.elipseAuthor = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.text_Author = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.group_information = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_Clear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.text_Publisher = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.group_extra = New Guna.UI.WinForms.GunaGroupBox()
        Me.rate = New Guna.UI.WinForms.GunaLineTextBox()
        Me.combo_Subject = New Guna.UI.WinForms.GunaComboBox()
        Me.text_ISBN = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.text_Release = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.elipseBookName = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipseISBN = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipsePublisher = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.elipseRelease = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.group_bot = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.LibBo_empty = New Guna.UI.WinForms.GunaLabel()
        Me.button_bot = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.libbo_isbn = New Guna.UI.WinForms.GunaLineTextBox()
        Me.LibBoEmpty_timer = New System.Windows.Forms.Timer(Me.components)
        Me.elipse_isbn = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_pbType = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.book_poster = New Guna.UI.WinForms.GunaPictureBox()
        Me.dataUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.libbo_basic = New Guna.UI.WinForms.GunaRadioButton()
        Me.libbo_advanced = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.addedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnINSERT = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.colorMASTER = New System.Windows.Forms.Timer(Me.components)
        Me.colorMASTER_Stopper = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.group_information.SuspendLayout
        Me.group_extra.SuspendLayout
        Me.group_bot.SuspendLayout
        Me.GunaGroupBox1.SuspendLayout
        CType(Me.book_poster,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'text_bookName
        '
        Me.text_bookName.Animated = true
        Me.text_bookName.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_bookName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_bookName.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_bookName.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_bookName.LineColor = System.Drawing.Color.Aqua
        Me.text_bookName.Location = New System.Drawing.Point(115, 43)
        Me.text_bookName.Name = "text_bookName"
        Me.text_bookName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_bookName.Size = New System.Drawing.Size(374, 47)
        Me.text_bookName.TabIndex = 0
        Me.text_bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'elipseAuthor
        '
        Me.elipseAuthor.Radius = 5
        Me.elipseAuthor.TargetControl = Me.text_Author
        '
        'text_Author
        '
        Me.text_Author.Animated = true
        Me.text_Author.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Author.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Author.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Author.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Author.LineColor = System.Drawing.Color.Aqua
        Me.text_Author.Location = New System.Drawing.Point(115, 96)
        Me.text_Author.Name = "text_Author"
        Me.text_Author.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Author.Size = New System.Drawing.Size(374, 47)
        Me.text_Author.TabIndex = 2
        Me.text_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = true
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel1.Location = New System.Drawing.Point(17, 52)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(92, 25)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Kitap Adı:"
        '
        'group_information
        '
        Me.group_information.BackColor = System.Drawing.Color.Transparent
        Me.group_information.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_information.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_information.Controls.Add(Me.btn_Clear)
        Me.group_information.Controls.Add(Me.text_Publisher)
        Me.group_information.Controls.Add(Me.GunaLabel4)
        Me.group_information.Controls.Add(Me.text_Author)
        Me.group_information.Controls.Add(Me.GunaLabel3)
        Me.group_information.Controls.Add(Me.text_bookName)
        Me.group_information.Controls.Add(Me.GunaLabel1)
        Me.group_information.LineColor = System.Drawing.Color.Indigo
        Me.group_information.Location = New System.Drawing.Point(231, 55)
        Me.group_information.Name = "group_information"
        Me.group_information.Radius = 5
        Me.group_information.Size = New System.Drawing.Size(514, 208)
        Me.group_information.TabIndex = 2
        Me.group_information.Text = "Kitap Bilgileri [Zorunlu]"
        Me.group_information.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_Clear
        '
        Me.btn_Clear.Animated = true
        Me.btn_Clear.AnimationHoverSpeed = 3!
        Me.btn_Clear.AnimationSpeed = 3!
        Me.btn_Clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_Clear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.btn_Clear.BorderColor = System.Drawing.Color.Black
        Me.btn_Clear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_Clear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_Clear.CheckedForeColor = System.Drawing.Color.White
        Me.btn_Clear.CheckedImage = CType(resources.GetObject("btn_Clear.CheckedImage"),System.Drawing.Image)
        Me.btn_Clear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_Clear.FocusedColor = System.Drawing.Color.Empty
        Me.btn_Clear.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btn_Clear.ForeColor = System.Drawing.Color.Aqua
        Me.btn_Clear.Image = Global.HBR_Library_System.My.Resources.Resources.available_updates_64px
        Me.btn_Clear.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_Clear.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_Clear.Location = New System.Drawing.Point(402, 3)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_Clear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_Clear.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_Clear.OnHoverImage = Nothing
        Me.btn_Clear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_Clear.OnPressedColor = System.Drawing.Color.Black
        Me.btn_Clear.Radius = 3
        Me.btn_Clear.Size = New System.Drawing.Size(87, 23)
        Me.btn_Clear.TabIndex = 81
        Me.btn_Clear.Text = "Sıfırla"
        '
        'text_Publisher
        '
        Me.text_Publisher.Animated = true
        Me.text_Publisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Publisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Publisher.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Publisher.Font = New System.Drawing.Font("Segoe UI Semibold", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Publisher.LineColor = System.Drawing.Color.Aqua
        Me.text_Publisher.Location = New System.Drawing.Point(115, 149)
        Me.text_Publisher.Name = "text_Publisher"
        Me.text_Publisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Publisher.Size = New System.Drawing.Size(374, 47)
        Me.text_Publisher.TabIndex = 4
        Me.text_Publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = true
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel4.Location = New System.Drawing.Point(17, 158)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(84, 25)
        Me.GunaLabel4.TabIndex = 5
        Me.GunaLabel4.Text = "Yayınevi:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = true
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel3.Location = New System.Drawing.Point(17, 105)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(61, 25)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Yazar:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = true
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Light", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(331, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(150, 45)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Kitap Ekle"
        '
        'group_extra
        '
        Me.group_extra.BackColor = System.Drawing.Color.Transparent
        Me.group_extra.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_extra.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_extra.Controls.Add(Me.rate)
        Me.group_extra.Controls.Add(Me.combo_Subject)
        Me.group_extra.Controls.Add(Me.text_ISBN)
        Me.group_extra.Controls.Add(Me.GunaLabel5)
        Me.group_extra.Controls.Add(Me.text_Release)
        Me.group_extra.Controls.Add(Me.GunaLabel6)
        Me.group_extra.Controls.Add(Me.GunaLabel7)
        Me.group_extra.LineColor = System.Drawing.Color.Indigo
        Me.group_extra.Location = New System.Drawing.Point(18, 280)
        Me.group_extra.Name = "group_extra"
        Me.group_extra.Radius = 5
        Me.group_extra.Size = New System.Drawing.Size(388, 188)
        Me.group_extra.TabIndex = 6
        Me.group_extra.Text = "Ek Bilgiler [Opsiyonel]"
        Me.group_extra.TextLocation = New System.Drawing.Point(10, 8)
        '
        'rate
        '
        Me.rate.Animated = true
        Me.rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.rate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rate.FocusedLineColor = System.Drawing.Color.Indigo
        Me.rate.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.rate.LineColor = System.Drawing.Color.Aqua
        Me.rate.Location = New System.Drawing.Point(243, 88)
        Me.rate.Name = "rate"
        Me.rate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rate.Size = New System.Drawing.Size(129, 38)
        Me.rate.TabIndex = 8
        Me.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.combo_Subject.Items.AddRange(New Object() {"Seçiniz...", "Dünya Klasikleri", "Aşk", "Psikoloji", "Roman", "Rus Romanı", "İngiliz Romanı", "Gençlik", "Din", "Tarih", "Siyaset-Politika", "Kişisel Gelişim", "Çocuk", "Macera-Aksiyon", "Şiir", "Felsefe-Düşünce", "Korku-Gerilim", "Polisiye", "Bilim Kurgu-Fantastik", "Hikaye", "Edebiyat", "Sosyoloji", "Biyografi", "Araştırma", "Deneme-İnceleme", "Spiritüalizm", "Ekonomi-İş Dünyası", "Eğlence-Mizah", "Manga", "Masal", "Anı-Mektup-Günlük", "Sağlık-Tıp", "İnsan ve Toplum", "Bilim-Teknoloji-Mühendislik", "Eğitim", "Türk Klasikleri", "Tiyatro", "Çizgi Roman", "Tasavvuf-Mezhepler-Tarikatlar", "Bilgisayar-İnternet", "Hukuk", "Sanat", "Spor", "Gezi", "Kadın-Erkek", "Anlatı", "Dergi", "Hobi", "Sinema", "Yemek", "Söyleşi-Röportaj", "Özlü Sözler", "Ders Kitapları", "Antoloji", "Astroloji", "Müzik", "Halk Edebiyatı", "Senaryo", "İletişim", "Moda", "Kültür", "Sözlük-Kılavuz-Ansiklopedi"})
        Me.combo_Subject.Location = New System.Drawing.Point(115, 49)
        Me.combo_Subject.Name = "combo_Subject"
        Me.combo_Subject.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.combo_Subject.OnHoverItemForeColor = System.Drawing.Color.White
        Me.combo_Subject.Size = New System.Drawing.Size(257, 30)
        Me.combo_Subject.TabIndex = 7
        '
        'text_ISBN
        '
        Me.text_ISBN.Animated = true
        Me.text_ISBN.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_ISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_ISBN.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_ISBN.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_ISBN.LineColor = System.Drawing.Color.Aqua
        Me.text_ISBN.Location = New System.Drawing.Point(115, 135)
        Me.text_ISBN.Name = "text_ISBN"
        Me.text_ISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_ISBN.Size = New System.Drawing.Size(257, 38)
        Me.text_ISBN.TabIndex = 4
        Me.text_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = true
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel5.Location = New System.Drawing.Point(17, 144)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(56, 25)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "ISBN:"
        '
        'text_Release
        '
        Me.text_Release.Animated = true
        Me.text_Release.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.text_Release.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_Release.FocusedLineColor = System.Drawing.Color.Indigo
        Me.text_Release.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.text_Release.LineColor = System.Drawing.Color.Aqua
        Me.text_Release.Location = New System.Drawing.Point(115, 88)
        Me.text_Release.Name = "text_Release"
        Me.text_Release.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_Release.Size = New System.Drawing.Size(122, 38)
        Me.text_Release.TabIndex = 2
        Me.text_Release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = true
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel6.Location = New System.Drawing.Point(0, 95)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(113, 19)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "Yayın Yılı/Puan:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = true
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 14!)
        Me.GunaLabel7.Location = New System.Drawing.Point(17, 49)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(60, 25)
        Me.GunaLabel7.TabIndex = 1
        Me.GunaLabel7.Text = "Konu:"
        '
        'elipseBookName
        '
        Me.elipseBookName.Radius = 5
        Me.elipseBookName.TargetControl = Me.text_bookName
        '
        'elipseISBN
        '
        Me.elipseISBN.Radius = 5
        Me.elipseISBN.TargetControl = Me.text_ISBN
        '
        'elipsePublisher
        '
        Me.elipsePublisher.Radius = 5
        Me.elipsePublisher.TargetControl = Me.text_Publisher
        '
        'elipseRelease
        '
        Me.elipseRelease.Radius = 5
        Me.elipseRelease.TargetControl = Me.text_Release
        '
        'GunaElipse6
        '
        Me.GunaElipse6.TargetControl = Me
        '
        'group_bot
        '
        Me.group_bot.BackColor = System.Drawing.Color.Transparent
        Me.group_bot.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.group_bot.BorderColor = System.Drawing.Color.Gainsboro
        Me.group_bot.Controls.Add(Me.GunaAdvenceButton1)
        Me.group_bot.Controls.Add(Me.LibBo_empty)
        Me.group_bot.Controls.Add(Me.button_bot)
        Me.group_bot.Controls.Add(Me.GunaLabel9)
        Me.group_bot.Controls.Add(Me.libbo_isbn)
        Me.group_bot.LineColor = System.Drawing.Color.Indigo
        Me.group_bot.Location = New System.Drawing.Point(412, 280)
        Me.group_bot.Name = "group_bot"
        Me.group_bot.Radius = 5
        Me.group_bot.Size = New System.Drawing.Size(333, 188)
        Me.group_bot.TabIndex = 8
        Me.group_bot.Text = "Kitap verilerini otomatik olarak al"
        Me.group_bot.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Animated = true
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 3!
        Me.GunaAdvenceButton1.AnimationSpeed = 3!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"),System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Aqua
        Me.GunaAdvenceButton1.Image = Global.HBR_Library_System.My.Resources.Resources.help_gradient_32
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(226, 3)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 3
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(87, 23)
        Me.GunaAdvenceButton1.TabIndex = 82
        Me.GunaAdvenceButton1.Text = "Yardım"
        '
        'LibBo_empty
        '
        Me.LibBo_empty.AutoSize = true
        Me.LibBo_empty.Font = New System.Drawing.Font("Segoe UI", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.LibBo_empty.ForeColor = System.Drawing.Color.Crimson
        Me.LibBo_empty.Location = New System.Drawing.Point(110, 68)
        Me.LibBo_empty.Name = "LibBo_empty"
        Me.LibBo_empty.Size = New System.Drawing.Size(123, 19)
        Me.LibBo_empty.TabIndex = 84
        Me.LibBo_empty.Text = "Veri Bulunamadı!"
        Me.LibBo_empty.Visible = false
        '
        'button_bot
        '
        Me.button_bot.Animated = true
        Me.button_bot.AnimationHoverSpeed = 3!
        Me.button_bot.AnimationSpeed = 3!
        Me.button_bot.BackColor = System.Drawing.Color.Transparent
        Me.button_bot.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.button_bot.BorderColor = System.Drawing.Color.Black
        Me.button_bot.CheckedBaseColor = System.Drawing.Color.Gray
        Me.button_bot.CheckedBorderColor = System.Drawing.Color.Black
        Me.button_bot.CheckedForeColor = System.Drawing.Color.White
        Me.button_bot.CheckedImage = CType(resources.GetObject("button_bot.CheckedImage"),System.Drawing.Image)
        Me.button_bot.CheckedLineColor = System.Drawing.Color.DimGray
        Me.button_bot.FocusedColor = System.Drawing.Color.Empty
        Me.button_bot.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.button_bot.ForeColor = System.Drawing.Color.Aqua
        Me.button_bot.Image = Global.HBR_Library_System.My.Resources.Resources.downcloud_gradient_32
        Me.button_bot.ImageSize = New System.Drawing.Size(32, 32)
        Me.button_bot.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.button_bot.Location = New System.Drawing.Point(84, 145)
        Me.button_bot.Name = "button_bot"
        Me.button_bot.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.button_bot.OnHoverBorderColor = System.Drawing.Color.Black
        Me.button_bot.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.button_bot.OnHoverImage = Nothing
        Me.button_bot.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.button_bot.OnPressedColor = System.Drawing.Color.Black
        Me.button_bot.Radius = 5
        Me.button_bot.Size = New System.Drawing.Size(187, 38)
        Me.button_bot.TabIndex = 82
        Me.button_bot.Text = "Libbo ile Doldur"
        Me.button_bot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.button_bot.TextOffsetX = 12
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = true
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.GunaLabel9.Location = New System.Drawing.Point(43, 37)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(257, 30)
        Me.GunaLabel9.TabIndex = 6
        Me.GunaLabel9.Text = "Kitap verilerini uzak sunucudan otomatik olarak"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" almak için lütfen ISBN Kodunu g"& _ 
    "iriniz."
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'libbo_isbn
        '
        Me.libbo_isbn.Animated = true
        Me.libbo_isbn.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(9,Byte),Integer), CType(CType(46,Byte),Integer))
        Me.libbo_isbn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.libbo_isbn.FocusedLineColor = System.Drawing.Color.Indigo
        Me.libbo_isbn.Font = New System.Drawing.Font("Segoe UI", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.libbo_isbn.LineColor = System.Drawing.Color.Aqua
        Me.libbo_isbn.Location = New System.Drawing.Point(43, 91)
        Me.libbo_isbn.MaxLength = 15
        Me.libbo_isbn.Name = "libbo_isbn"
        Me.libbo_isbn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.libbo_isbn.Size = New System.Drawing.Size(257, 47)
        Me.libbo_isbn.TabIndex = 4
        Me.libbo_isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LibBoEmpty_timer
        '
        Me.LibBoEmpty_timer.Interval = 7500
        '
        'elipse_isbn
        '
        Me.elipse_isbn.Radius = 6
        Me.elipse_isbn.TargetControl = Me.libbo_isbn
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.btn_pbType)
        Me.GunaGroupBox1.Controls.Add(Me.book_poster)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Indigo
        Me.GunaGroupBox1.Location = New System.Drawing.Point(18, 55)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Radius = 5
        Me.GunaGroupBox1.Size = New System.Drawing.Size(207, 208)
        Me.GunaGroupBox1.TabIndex = 82
        Me.GunaGroupBox1.Text = "Kitap Kapağı"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_pbType
        '
        Me.btn_pbType.Animated = true
        Me.btn_pbType.AnimationHoverSpeed = 3!
        Me.btn_pbType.AnimationSpeed = 3!
        Me.btn_pbType.BackColor = System.Drawing.Color.Transparent
        Me.btn_pbType.BaseColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(18,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.btn_pbType.BorderColor = System.Drawing.Color.Black
        Me.btn_pbType.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_pbType.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_pbType.CheckedForeColor = System.Drawing.Color.White
        Me.btn_pbType.CheckedImage = CType(resources.GetObject("btn_pbType.CheckedImage"),System.Drawing.Image)
        Me.btn_pbType.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_pbType.FocusedColor = System.Drawing.Color.Empty
        Me.btn_pbType.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.btn_pbType.ForeColor = System.Drawing.Color.Aqua
        Me.btn_pbType.Image = Global.HBR_Library_System.My.Resources.Resources.fit_to_width_64px
        Me.btn_pbType.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_pbType.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_pbType.Location = New System.Drawing.Point(99, 5)
        Me.btn_pbType.Name = "btn_pbType"
        Me.btn_pbType.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btn_pbType.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_pbType.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btn_pbType.OnHoverImage = Nothing
        Me.btn_pbType.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btn_pbType.OnPressedColor = System.Drawing.Color.Black
        Me.btn_pbType.Radius = 3
        Me.btn_pbType.Size = New System.Drawing.Size(103, 23)
        Me.btn_pbType.TabIndex = 82
        Me.btn_pbType.Text = "Sığdır"
        '
        'book_poster
        '
        Me.book_poster.BaseColor = System.Drawing.Color.White
        Me.book_poster.Image = Global.HBR_Library_System.My.Resources.Resources.HBR
        Me.book_poster.Location = New System.Drawing.Point(4, 37)
        Me.book_poster.Name = "book_poster"
        Me.book_poster.Size = New System.Drawing.Size(200, 163)
        Me.book_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.book_poster.TabIndex = 0
        Me.book_poster.TabStop = false
        '
        'dataUpdater
        '
        Me.dataUpdater.Enabled = true
        Me.dataUpdater.Interval = 1000
        '
        'libbo_basic
        '
        Me.libbo_basic.BaseColor = System.Drawing.SystemColors.Control
        Me.libbo_basic.CheckedOffColor = System.Drawing.Color.Gray
        Me.libbo_basic.CheckedOnColor = System.Drawing.Color.Indigo
        Me.libbo_basic.FillColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.libbo_basic.Font = New System.Drawing.Font("Montserrat", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.libbo_basic.Location = New System.Drawing.Point(22, 497)
        Me.libbo_basic.Name = "libbo_basic"
        Me.libbo_basic.Size = New System.Drawing.Size(125, 20)
        Me.libbo_basic.TabIndex = 87
        Me.libbo_basic.Text = "Temel Bilgiler"
        '
        'libbo_advanced
        '
        Me.libbo_advanced.BaseColor = System.Drawing.SystemColors.Control
        Me.libbo_advanced.Checked = true
        Me.libbo_advanced.CheckedOffColor = System.Drawing.Color.Gray
        Me.libbo_advanced.CheckedOnColor = System.Drawing.Color.Indigo
        Me.libbo_advanced.FillColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.libbo_advanced.Font = New System.Drawing.Font("Montserrat", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.libbo_advanced.Location = New System.Drawing.Point(153, 497)
        Me.libbo_advanced.Name = "libbo_advanced"
        Me.libbo_advanced.Size = New System.Drawing.Size(140, 20)
        Me.libbo_advanced.TabIndex = 88
        Me.libbo_advanced.Text = "Gelişmiş Bilgiler"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = true
        Me.GunaLabel8.Font = New System.Drawing.Font("Montserrat", 11!)
        Me.GunaLabel8.Location = New System.Drawing.Point(21, 471)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(134, 21)
        Me.GunaLabel8.TabIndex = 8
        Me.GunaLabel8.Text = "Libbo Veri Modu:"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_SLIDE
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'addedTimer
        '
        Me.addedTimer.Interval = 5000
        '
        'btnINSERT
        '
        Me.btnINSERT.Animated = true
        Me.btnINSERT.AnimationHoverSpeed = 5!
        Me.btnINSERT.AnimationSpeed = 5!
        Me.btnINSERT.BackColor = System.Drawing.Color.Transparent
        Me.btnINSERT.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.btnINSERT.BorderColor = System.Drawing.Color.Black
        Me.btnINSERT.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnINSERT.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnINSERT.CheckedForeColor = System.Drawing.Color.White
        Me.btnINSERT.CheckedImage = CType(resources.GetObject("btnINSERT.CheckedImage"),System.Drawing.Image)
        Me.btnINSERT.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnINSERT.FocusedColor = System.Drawing.Color.Empty
        Me.btnINSERT.Font = New System.Drawing.Font("Montserrat SemiBold", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btnINSERT.ForeColor = System.Drawing.Color.Aqua
        Me.btnINSERT.Image = Global.HBR_Library_System.My.Resources.Resources.forward_96px
        Me.btnINSERT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnINSERT.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnINSERT.LineBottom = 3
        Me.btnINSERT.LineColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.btnINSERT.Location = New System.Drawing.Point(325, 474)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnINSERT.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnINSERT.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnINSERT.OnHoverImage = Nothing
        Me.btnINSERT.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnINSERT.OnPressedColor = System.Drawing.Color.Black
        Me.btnINSERT.Radius = 5
        Me.btnINSERT.Size = New System.Drawing.Size(167, 50)
        Me.btnINSERT.TabIndex = 85
        Me.btnINSERT.Text = "Ekle"
        Me.btnINSERT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colorMASTER
        '
        Me.colorMASTER.Interval = 300
        '
        'colorMASTER_Stopper
        '
        Me.colorMASTER_Stopper.Interval = 5000
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 3
        Me.GunaElipse1.TargetControl = Me.rate
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.libbo_advanced)
        Me.Controls.Add(Me.libbo_basic)
        Me.Controls.Add(Me.btnINSERT)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.group_bot)
        Me.Controls.Add(Me.group_extra)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.group_information)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "Add_Book"
        Me.Size = New System.Drawing.Size(764, 530)
        Me.group_information.ResumeLayout(false)
        Me.group_information.PerformLayout
        Me.group_extra.ResumeLayout(false)
        Me.group_extra.PerformLayout
        Me.group_bot.ResumeLayout(false)
        Me.group_bot.PerformLayout
        Me.GunaGroupBox1.ResumeLayout(false)
        CType(Me.book_poster,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents text_bookName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents elipseAuthor As Guna.UI.WinForms.GunaElipse
    Friend WithEvents group_information As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents group_extra As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents text_ISBN As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Release As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Publisher As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents text_Author As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elipseBookName As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipseISBN As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipsePublisher As Guna.UI.WinForms.GunaElipse
    Friend WithEvents elipseRelease As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents combo_Subject As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_Clear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents group_bot As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents libbo_isbn As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents button_bot As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents LibBo_empty As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LibBoEmpty_timer As Timer
    Friend WithEvents elipse_isbn As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents book_poster As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btn_pbType As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents dataUpdater As Timer
    Friend WithEvents btnINSERT As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents libbo_advanced As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents libbo_basic As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents addedTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents colorMASTER As Timer
    Friend WithEvents colorMASTER_Stopper As Timer
    Friend WithEvents rate As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
