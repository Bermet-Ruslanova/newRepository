<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        PictureBox4 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.таймер
        PictureBox1.Location = New Point(10, 235)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 28)
        Label2.TabIndex = 10
        Label2.Text = "30 минут"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 28)
        Label1.TabIndex = 9
        Label1.Text = "Салат ""Цезарь"""
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.цезарь
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(493, 170)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.ErrorImage = Nothing
        PictureBox2.Image = My.Resources.Resources.таймер
        PictureBox2.Location = New Point(10, 539)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(48, 541)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 28)
        Label3.TabIndex = 14
        Label3.Text = "50 минут"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 499)
        Label4.Name = "Label4"
        Label4.Size = New Size(315, 28)
        Label4.TabIndex = 13
        Label4.Text = "Салат с селедкой и картофелем"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.салат_с_селедкой
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Location = New Point(12, 316)
        Button2.Name = "Button2"
        Button2.Size = New Size(493, 170)
        Button2.TabIndex = 12
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.ErrorImage = Nothing
        PictureBox3.Image = My.Resources.Resources.таймер
        PictureBox3.Location = New Point(10, 813)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(34, 30)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(48, 815)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 28)
        Label5.TabIndex = 18
        Label5.Text = "1 час 15 минут"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(10, 773)
        Label6.Name = "Label6"
        Label6.Size = New Size(165, 28)
        Label6.TabIndex = 17
        Label6.Text = "Салат из свеклы"
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.свекла
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(12, 590)
        Button3.Name = "Button3"
        Button3.Size = New Size(493, 170)
        Button3.TabIndex = 16
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.ErrorImage = Nothing
        PictureBox4.Image = My.Resources.Resources.таймер
        PictureBox4.Location = New Point(8, 1087)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(34, 30)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(46, 1089)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 28)
        Label7.TabIndex = 22
        Label7.Text = "15 минут"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(8, 1047)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 28)
        Label8.TabIndex = 21
        Label8.Text = "Салат ""Цветной"""
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = My.Resources.Resources.цветной_салат
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Location = New Point(10, 864)
        Button4.Name = "Button4"
        Button4.Size = New Size(493, 170)
        Button4.TabIndex = 20
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button16)
        GroupBox1.Controls.Add(Button15)
        GroupBox1.Controls.Add(Button14)
        GroupBox1.Controls.Add(Button13)
        GroupBox1.Location = New Point(-1, 1133)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(506, 68)
        GroupBox1.TabIndex = 28
        GroupBox1.TabStop = False
        ' 
        ' Button16
        ' 
        Button16.BackgroundImage = My.Resources.Resources.профиль
        Button16.BackgroundImageLayout = ImageLayout.Zoom
        Button16.ForeColor = SystemColors.Control
        Button16.Location = New Point(369, 19)
        Button16.Name = "Button16"
        Button16.Size = New Size(70, 43)
        Button16.TabIndex = 3
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.BackgroundImage = My.Resources.Resources.избранные
        Button15.BackgroundImageLayout = ImageLayout.Zoom
        Button15.Location = New Point(267, 19)
        Button15.Name = "Button15"
        Button15.Size = New Size(70, 43)
        Button15.TabIndex = 2
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.BackgroundImage = My.Resources.Resources.поиск
        Button14.BackgroundImageLayout = ImageLayout.Zoom
        Button14.Location = New Point(163, 19)
        Button14.Name = "Button14"
        Button14.Size = New Size(70, 43)
        Button14.TabIndex = 1
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.BackgroundImage = My.Resources.Resources.иконка_главная
        Button13.BackgroundImageLayout = ImageLayout.Zoom
        Button13.Location = New Point(60, 19)
        Button13.Name = "Button13"
        Button13.Size = New Size(70, 43)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(525, 682)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox4)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Button4)
        Controls.Add(PictureBox3)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form8"
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
End Class
