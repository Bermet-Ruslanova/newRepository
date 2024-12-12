<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(195, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 54)
        Label1.TabIndex = 0
        Label1.Text = "Войти"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(173, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 32)
        Label2.TabIndex = 1
        Label2.Text = "Введите e-mail:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(173, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 32)
        Label3.TabIndex = 2
        Label3.Text = "Введите пароль:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(122, 221)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(122, 371)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(281, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(214, 464)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "Войти"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.регистрацияя
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(525, 682)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
