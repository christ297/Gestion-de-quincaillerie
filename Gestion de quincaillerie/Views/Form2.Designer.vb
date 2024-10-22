<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Button2 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Dashboard = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel8 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Panel5 = New Panel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1370, 1022)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.BackColor = Color.Black
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(Button8)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 298)
        Panel4.MaximumSize = New Size(250, 298)
        Panel4.MinimumSize = New Size(250, 65)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 298)
        Panel4.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(0, 80)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 39)
        Button2.TabIndex = 3
        Button2.Text = "Catégories"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DimGray
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = SystemColors.ControlLightLight
        Button6.Location = New Point(0, 145)
        Button6.Name = "Button6"
        Button6.Size = New Size(250, 39)
        Button6.TabIndex = 2
        Button6.Text = "Produits"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DimGray
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = SystemColors.ControlLightLight
        Button7.Location = New Point(0, 213)
        Button7.Name = "Button7"
        Button7.Size = New Size(250, 39)
        Button7.TabIndex = 1
        Button7.Text = "Achats"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Image = My.Resources.Resources.left_arrow1
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(3, 3)
        Button8.Name = "Button8"
        Button8.Size = New Size(244, 52)
        Button8.TabIndex = 0
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Dashboard)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.MaximumSize = New Size(250, 298)
        Panel3.MinimumSize = New Size(250, 65)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 298)
        Panel3.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DimGray
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(0, 80)
        Button5.Name = "Button5"
        Button5.Size = New Size(250, 39)
        Button5.TabIndex = 3
        Button5.Text = "Catégories"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DimGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(0, 145)
        Button4.Name = "Button4"
        Button4.Size = New Size(250, 39)
        Button4.TabIndex = 2
        Button4.Text = "Produits"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DimGray
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(0, 213)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 39)
        Button3.TabIndex = 1
        Button3.Text = "Achats"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        Dashboard.BackColor = Color.Black
        Dashboard.FlatAppearance.BorderSize = 0
        Dashboard.FlatStyle = FlatStyle.Flat
        Dashboard.ForeColor = SystemColors.ControlLightLight
        Dashboard.Image = My.Resources.Resources.left_arrow1
        Dashboard.ImageAlign = ContentAlignment.MiddleLeft
        Dashboard.Location = New Point(3, 3)
        Dashboard.Name = "Dashboard"
        Dashboard.Size = New Size(244, 52)
        Dashboard.TabIndex = 0
        Dashboard.Text = "Dashboard"
        Dashboard.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 567)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 29)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(259, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1663, 1025)
        Panel2.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(1333, 94)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(316, 128)
        Panel8.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(912, 94)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(316, 128)
        Panel7.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(507, 94)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(316, 128)
        Panel6.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(85, 94)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(316, 128)
        Panel5.TabIndex = 1
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 15
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1020)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Dashboard As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
End Class
