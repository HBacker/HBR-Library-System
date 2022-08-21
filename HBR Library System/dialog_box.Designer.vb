<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialog_box
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dialog_box))
        Me.FormSkin1 = New HBR_Library_System.FormSkin()
        Me.title = New Guna.UI.WinForms.GunaLabel()
        Me.message = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnHelp = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnOK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.colorMASTER = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout
        Me.SuspendLayout
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(73,Byte),Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(60,Byte),Integer))
        Me.FormSkin1.Controls.Add(Me.title)
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35,Byte),Integer), CType(CType(168,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(151,Byte),Integer))
        Me.FormSkin1.HeaderMaximize = false
        Me.FormSkin1.Location = New System.Drawing.Point(-11, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(565, 48)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "FormSkin1"
        '
        'title
        '
        Me.title.AutoSize = true
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Montserrat", 20!, System.Drawing.FontStyle.Bold)
        Me.title.Location = New System.Drawing.Point(227, 5)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(96, 37)
        Me.title.TabIndex = 0
        Me.title.Text = "$Title"
        '
        'message
        '
        Me.message.AutoSize = true
        Me.message.BackColor = System.Drawing.Color.Transparent
        Me.message.Font = New System.Drawing.Font("Montserrat", 20!, System.Drawing.FontStyle.Bold)
        Me.message.Location = New System.Drawing.Point(189, 139)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(158, 37)
        Me.message.TabIndex = 1
        Me.message.Text = "$Message"
        Me.message.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'btnHelp
        '
        Me.btnHelp.Animated = true
        Me.btnHelp.AnimationHoverSpeed = 3!
        Me.btnHelp.AnimationSpeed = 3!
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.btnHelp.BorderColor = System.Drawing.Color.Black
        Me.btnHelp.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHelp.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHelp.CheckedForeColor = System.Drawing.Color.White
        Me.btnHelp.CheckedImage = CType(resources.GetObject("btnHelp.CheckedImage"),System.Drawing.Image)
        Me.btnHelp.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHelp.Enabled = false
        Me.btnHelp.FocusedColor = System.Drawing.Color.Empty
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 12!)
        Me.btnHelp.ForeColor = System.Drawing.Color.Aqua
        Me.btnHelp.Image = Global.HBR_Library_System.My.Resources.Resources.help_gradient_32
        Me.btnHelp.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnHelp.LineBottom = 1
        Me.btnHelp.LineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnHelp.LineLeft = 1
        Me.btnHelp.LineRight = 1
        Me.btnHelp.LineTop = 1
        Me.btnHelp.Location = New System.Drawing.Point(212, 282)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnHelp.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHelp.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnHelp.OnHoverImage = Nothing
        Me.btnHelp.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnHelp.OnPressedColor = System.Drawing.Color.Black
        Me.btnHelp.Radius = 2
        Me.btnHelp.Size = New System.Drawing.Size(135, 38)
        Me.btnHelp.TabIndex = 86
        Me.btnHelp.Text = "Yardım"
        Me.btnHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnHelp.TextOffsetX = 18
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
        Me.btnOK.Location = New System.Drawing.Point(355, 276)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        Me.btnOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOK.OnHoverForeColor = System.Drawing.Color.Indigo
        Me.btnOK.OnHoverImage = Nothing
        Me.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(170,Byte),Integer))
        Me.btnOK.OnPressedColor = System.Drawing.Color.Black
        Me.btnOK.Radius = 5
        Me.btnOK.Size = New System.Drawing.Size(167, 50)
        Me.btnOK.TabIndex = 87
        Me.btnOK.Text = "Tamam"
        Me.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnOK.TextOffsetX = 6
        '
        'colorMASTER
        '
        Me.colorMASTER.Interval = 500
        '
        'dialog_box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(545, 340)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.FormSkin1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "dialog_box"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog Mesajı / HBR Library System"
        Me.TopMost = true
        Me.FormSkin1.ResumeLayout(false)
        Me.FormSkin1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents message As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnHelp As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents colorMASTER As Timer
End Class
