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
        Panel1 = New Panel()
        Label9 = New Label()
        cmotdepasse = New TextBox()
        motdepasse = New TextBox()
        email = New TextBox()
        tel = New TextBox()
        cni = New TextBox()
        prenom = New TextBox()
        nom = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        Button2 = New Button()
        Label12 = New Label()
        Label13 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkBlue
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(cmotdepasse)
        Panel1.Controls.Add(motdepasse)
        Panel1.Controls.Add(email)
        Panel1.Controls.Add(tel)
        Panel1.Controls.Add(cni)
        Panel1.Controls.Add(prenom)
        Panel1.Controls.Add(nom)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(470, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(396, 643)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Cornsilk
        Label9.Location = New Point(34, 508)
        Label9.Name = "Label9"
        Label9.Size = New Size(254, 25)
        Label9.TabIndex = 15
        Label9.Text = "Confirmation de mot de passe"
        ' 
        ' cmotdepasse
        ' 
        cmotdepasse.Location = New Point(35, 536)
        cmotdepasse.Name = "cmotdepasse"
        cmotdepasse.Size = New Size(309, 31)
        cmotdepasse.TabIndex = 14
        ' 
        ' motdepasse
        ' 
        motdepasse.Location = New Point(35, 461)
        motdepasse.Name = "motdepasse"
        motdepasse.Size = New Size(309, 31)
        motdepasse.TabIndex = 13
        ' 
        ' email
        ' 
        email.Location = New Point(35, 385)
        email.Name = "email"
        email.Size = New Size(309, 31)
        email.TabIndex = 12
        ' 
        ' tel
        ' 
        tel.Location = New Point(35, 303)
        tel.Name = "tel"
        tel.Size = New Size(309, 31)
        tel.TabIndex = 11
        ' 
        ' cni
        ' 
        cni.Location = New Point(35, 229)
        cni.Name = "cni"
        cni.Size = New Size(309, 31)
        cni.TabIndex = 10
        ' 
        ' prenom
        ' 
        prenom.Location = New Point(35, 145)
        prenom.Name = "prenom"
        prenom.Size = New Size(309, 31)
        prenom.TabIndex = 9
        ' 
        ' nom
        ' 
        nom.Location = New Point(35, 70)
        nom.Name = "nom"
        nom.Size = New Size(309, 31)
        nom.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Desktop
        Button1.ForeColor = SystemColors.Window
        Button1.Location = New Point(34, 589)
        Button1.Name = "Button1"
        Button1.Size = New Size(309, 34)
        Button1.TabIndex = 7
        Button1.Text = "Inscription"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Cornsilk
        Label7.Location = New Point(35, 433)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 25)
        Label7.TabIndex = 4
        Label7.Text = "Mot de passe"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Cornsilk
        Label6.Location = New Point(35, 357)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 4
        Label6.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Cornsilk
        Label5.Location = New Point(34, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 25)
        Label5.TabIndex = 6
        Label5.Text = "Tel"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Cornsilk
        Label4.Location = New Point(34, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 25)
        Label4.TabIndex = 5
        Label4.Text = "CNI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Cornsilk
        Label3.Location = New Point(23, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 4
        Label3.Text = "Prenom"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Cornsilk
        Label1.Location = New Point(23, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 25)
        Label1.TabIndex = 3
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Stencil", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(505, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 24)
        Label2.TabIndex = 2
        Label2.Text = "Inscription"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkBlue
        Panel2.Controls.Add(TextBox11)
        Panel2.Controls.Add(TextBox12)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label13)
        Panel2.Location = New Point(12, 119)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(396, 383)
        Panel2.TabIndex = 3
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(35, 216)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(309, 31)
        TextBox11.TabIndex = 9
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(35, 111)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(309, 31)
        TextBox12.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Desktop
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(35, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(309, 34)
        Button2.TabIndex = 7
        Button2.Text = "Connexion"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = Color.Cornsilk
        Label12.Location = New Point(35, 170)
        Label12.Name = "Label12"
        Label12.Size = New Size(120, 25)
        Label12.TabIndex = 4
        Label12.Text = "Mot de passe"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.Cornsilk
        Label13.Location = New Point(35, 58)
        Label13.Name = "Label13"
        Label13.Size = New Size(54, 25)
        Label13.TabIndex = 3
        Label13.Text = "Email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Stencil", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DeepSkyBlue
        Label8.Location = New Point(47, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 24)
        Label8.TabIndex = 4
        Label8.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(910, 699)
        Controls.Add(Label8)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents prenom As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents tel As TextBox
    Friend WithEvents cni As TextBox
    Friend WithEvents motdepasse As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmotdepasse As TextBox

End Class
