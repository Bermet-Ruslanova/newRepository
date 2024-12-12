<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Script MT Bold", 40F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Olive
        Label1.Location = New Point(132, 447)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 96)
        Label1.TabIndex = 0
        Label1.Text = "FOOD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Vivaldi", 35F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.Olive
        Label2.Location = New Point(97, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 83)
        Label2.TabIndex = 1
        Label2.Text = "Welcome to"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(169, 589)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 34)
        Button1.TabIndex = 2
        Button1.Text = "Зарегистрироваться"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(207, 629)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.No
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 3
        Button2.Text = "Войти"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        BackgroundImage = My.Resources.Resources.рецепты_обложка
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(525, 682)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
