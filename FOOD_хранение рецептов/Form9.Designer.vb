<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        GroupBox1 = New GroupBox()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        GroupBox2 = New GroupBox()
        Label29 = New Label()
        PictureBox3 = New PictureBox()
        GroupBox3 = New GroupBox()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Button4 = New Button()
        Label28 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.летний_завтрак
        PictureBox1.Location = New Point(-2, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(528, 220)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.ForeColor = Color.Tomato
        Button1.Image = My.Resources.Resources.free_icon_back_10257582
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(-2, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 44)
        Button1.TabIndex = 1
        Button1.Text = "Поиск"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-2, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 32)
        Label1.TabIndex = 2
        Label1.Text = "Летний завтрак"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonFace
        Button2.BackgroundImage = My.Resources.Resources.избранные
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Location = New Point(426, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 44)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonFace
        Button3.BackgroundImage = My.Resources.Resources.поделиться
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(482, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(44, 44)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8F)
        Label2.Location = New Point(-2, 314)
        Label2.Name = "Label2"
        Label2.Size = New Size(447, 168)
        Label2.TabIndex = 5
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(407, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 28)
        Label3.TabIndex = 11
        Label3.Text = "10 минут"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label4.ImageAlign = ContentAlignment.MiddleLeft
        Label4.Location = New Point(45, 567)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 28)
        Label4.TabIndex = 12
        Label4.Text = "Продукты"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 648)
        Label5.Name = "Label5"
        Label5.Size = New Size(206, 25)
        Label5.TabIndex = 13
        Label5.Text = "Для основного блюда "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.free_icon_groceries_6805578
        PictureBox2.Location = New Point(12, 567)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 32)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 612)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 25)
        Label6.TabIndex = 15
        Label6.Text = "Порция"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 691)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 25)
        Label7.TabIndex = 16
        Label7.Text = "Тостовый хлеб"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 720)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 25)
        Label8.TabIndex = 17
        Label8.Text = "Авокадо"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 745)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 25)
        Label9.TabIndex = 18
        Label9.Text = "Куриное яйцо"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 776)
        Label10.Name = "Label10"
        Label10.Size = New Size(158, 25)
        Label10.TabIndex = 19
        Label10.Text = "Сливочное масло"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 801)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 25)
        Label11.TabIndex = 20
        Label11.Text = "Соль"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(7, 837)
        Label12.Name = "Label12"
        Label12.Size = New Size(211, 25)
        Label12.TabIndex = 21
        Label12.Text = "Черный перец молотый"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(381, 691)
        Label13.Name = "Label13"
        Label13.Size = New Size(145, 25)
        Label13.TabIndex = 22
        Label13.Text = "1 ломтик = 40 г "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(383, 716)
        Label14.Name = "Label14"
        Label14.Size = New Size(130, 25)
        Label14.TabIndex = 23
        Label14.Text = "0,5 шт. = 110 г"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(383, 745)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 25)
        Label15.TabIndex = 24
        Label15.Text = "1 шт. = 60 г"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(383, 776)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 25)
        Label16.TabIndex = 25
        Label16.Text = "1 ч.л. = 8 г"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(381, 801)
        Label17.Name = "Label17"
        Label17.Size = New Size(141, 25)
        Label17.TabIndex = 26
        Label17.Text = "1 щепотка = 1 г"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(383, 837)
        Label18.Name = "Label18"
        Label18.Size = New Size(141, 25)
        Label18.TabIndex = 27
        Label18.Text = "1 щепотка = 1 г"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(12, 882)
        Label19.Name = "Label19"
        Label19.Size = New Size(112, 25)
        Label19.TabIndex = 28
        Label19.Text = "Для подачи"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(12, 923)
        Label20.Name = "Label20"
        Label20.Size = New Size(137, 25)
        Label20.TabIndex = 29
        Label20.Text = "Свежая зелень "
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(12, 948)
        Label21.Name = "Label21"
        Label21.Size = New Size(59, 25)
        Label21.TabIndex = 30
        Label21.Text = "Кофе "
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(427, 923)
        Label22.Name = "Label22"
        Label22.Size = New Size(86, 25)
        Label22.TabIndex = 31
        Label22.Text = "По вкусу"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(427, 948)
        Label23.Name = "Label23"
        Label23.Size = New Size(86, 25)
        Label23.TabIndex = 32
        Label23.Text = "По вкусу"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button16)
        GroupBox1.Controls.Add(Button15)
        GroupBox1.Controls.Add(Button14)
        GroupBox1.Controls.Add(Button13)
        GroupBox1.Location = New Point(7, 1153)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(506, 68)
        GroupBox1.TabIndex = 33
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label29)
        GroupBox2.Controls.Add(PictureBox3)
        GroupBox2.Location = New Point(7, 485)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(495, 74)
        GroupBox2.TabIndex = 34
        GroupBox2.TabStop = False
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(191, 30)
        Label29.Name = "Label29"
        Label29.Size = New Size(132, 25)
        Label29.TabIndex = 36
        Label29.Text = "Автор: ..............."
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.пользователь
        PictureBox3.Location = New Point(112, 18)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 35
        PictureBox3.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label27)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(Label28)
        GroupBox3.Location = New Point(7, 976)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(506, 190)
        GroupBox3.TabIndex = 35
        GroupBox3.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 8F)
        Label27.Location = New Point(337, 63)
        Label27.Name = "Label27"
        Label27.Size = New Size(76, 21)
        Label27.TabIndex = 42
        Label27.Text = "10 минут"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 8F)
        Label26.Location = New Point(15, 63)
        Label26.Name = "Label26"
        Label26.Size = New Size(76, 21)
        Label26.TabIndex = 37
        Label26.Text = "10 минут"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(337, 27)
        Label25.Name = "Label25"
        Label25.Size = New Size(145, 25)
        Label25.TabIndex = 40
        Label25.Text = "Время на кухне"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(15, 27)
        Label24.Name = "Label24"
        Label24.Size = New Size(176, 25)
        Label24.TabIndex = 38
        Label24.Text = "Будет готово через"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button4.Image = My.Resources.Resources.free_icon_play_button_117999
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(137, 136)
        Button4.Name = "Button4"
        Button4.Size = New Size(264, 48)
        Button4.TabIndex = 41
        Button4.Text = "Начать готовить"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(15, 108)
        Label28.Name = "Label28"
        Label28.Size = New Size(240, 25)
        Label28.TabIndex = 39
        Label28.Text = "В режиме готовки удобнее!"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(525, 682)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form9"
        Text = "Form9"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label28 As Label
End Class
