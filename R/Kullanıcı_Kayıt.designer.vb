<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kullanıcı_Kayıt
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    Private Const V1 As String = ""

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent(v As Guna.UI.WinForms.GunaTextBox)
        Me.SuspendLayout
        '
        'Kullanıcı_Kayıt
        '
        Me.ClientSize = New System.Drawing.Size(361, 261)
        Me.Name = "Kullanıcı_Kayıt"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents giris_yap As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents header_kapat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents header_icon As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents wc1 As Timer
    Friend WithEvents wc2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Header As FormSkin
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents block As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nulltime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents verify_box As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents error_desc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents block_box As PictureBox
    Friend WithEvents gb_verify As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents n4 As Label
    Friend WithEvents n3 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents n1 As Label
    Friend WithEvents kod4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents kod1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FormSkin2 As FormSkin
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradientButton3 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents level_high As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents level_standart As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents register As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents piyon As TextBox
End Class
