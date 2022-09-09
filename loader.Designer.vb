<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sd
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
        Me.loading = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.loading.SuspendLayout
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'loading
        '
        Me.loading.BackColor = System.Drawing.Color.Transparent
        Me.loading.BaseColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.loading.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.loading.Controls.Add(Me.GunaPictureBox1)
        Me.loading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loading.Font = New System.Drawing.Font("Yu Gothic UI", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.loading.LineBottom = 1
        Me.loading.LineColor = System.Drawing.Color.FromArgb(CType(CType(63,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.loading.LineLeft = 1
        Me.loading.LineRight = 1
        Me.loading.Location = New System.Drawing.Point(0, 0)
        Me.loading.Name = "loading"
        Me.loading.Radius = 5
        Me.loading.Size = New System.Drawing.Size(740, 570)
        Me.loading.TabIndex = 4
        Me.loading.Text = "Yükleniyor..."
        Me.loading.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.HBR_Library_System.My.Resources.Resources.loader_booksFAST
        Me.GunaPictureBox1.Location = New System.Drawing.Point(153, -429)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(425, 1571)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = false
        '
        'loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6,Byte),Integer), CType(CType(16,Byte),Integer), CType(CType(27,Byte),Integer))
        Me.Controls.Add(Me.loading)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4,Byte),Integer), CType(CType(175,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.Name = "loader"
        Me.Size = New System.Drawing.Size(740, 570)
        Me.loading.ResumeLayout(false)
        CType(Me.GunaPictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents loading As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
