Imports System.Diagnostics.Eventing.Reader

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        connecter = New Button()
        PictureBox1 = New PictureBox()
        email = New TextBox()
        password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' connecter
        ' 
        connecter.BackColor = SystemColors.MenuHighlight
        connecter.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        connecter.ForeColor = SystemColors.ButtonHighlight
        connecter.Location = New Point(1143, 506)
        connecter.Name = "connecter"
        connecter.Size = New Size(255, 51)
        connecter.TabIndex = 0
        connecter.Text = "Se conneccter"
        connecter.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(11, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(634, 718)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' email
        ' 
        email.Location = New Point(1114, 241)
        email.Name = "email"
        email.Size = New Size(354, 31)
        email.TabIndex = 2
        ' 
        ' password
        ' 
        password.Location = New Point(1114, 359)
        password.Name = "password"
        password.Size = New Size(354, 31)
        password.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1011, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 26)
        Label1.TabIndex = 4
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Typewriter", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(885, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 26)
        Label2.TabIndex = 5
        Label2.Text = "Mot de passe"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Typewriter", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1046, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(422, 32)
        Label3.TabIndex = 6
        Label3.Text = "Connexion Administrateur"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(connecter)
        Panel1.Controls.Add(email)
        Panel1.Controls.Add(password)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1920, 1056)
        Panel1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1020)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Gestion de quinaillerie"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents connecter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel

End Class
