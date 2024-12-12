<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(173, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 41)
        Label1.TabIndex = 0
        Label1.Text = "Регистрация"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(167, 105)
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
        Label3.Location = New Point(188, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 32)
        Label3.TabIndex = 2
        Label3.Text = "Введите Имя:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(163, 379)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 32)
        Label4.TabIndex = 3
        Label4.Text = "Введите пароль:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(99, 179)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(353, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(99, 294)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(353, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(99, 423)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(353, 31)
        TextBox3.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(154, 527)
        Button1.Name = "Button1"
        Button1.Size = New Size(207, 34)
        Button1.TabIndex = 7
        Button1.Text = "Зарегистрироваться"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        BackgroundImage = My.Resources.Resources.регистрацияя
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(525, 682)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
