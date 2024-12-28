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
        outils = New Button()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        dashboard = New Button()
        Panel2 = New Panel()
        Button8 = New Button()
        Panel8 = New Panel()
        nombreClients = New Label()
        countClient = New Label()
        Panel7 = New Panel()
        Label3 = New Label()
        countp = New Label()
        Panel6 = New Panel()
        Label4 = New Label()
        restantStock = New Label()
        Panel5 = New Panel()
        Label2 = New Label()
        countA = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(3, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1199, 766)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(outils)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 224)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.MaximumSize = New Size(219, 224)
        Panel4.MinimumSize = New Size(219, 49)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(219, 224)
        Panel4.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(0, 60)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(219, 29)
        Button2.TabIndex = 3
        Button2.Text = "Tableau de bord"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DimGray
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = SystemColors.ControlLightLight
        Button6.Location = New Point(0, 109)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(219, 29)
        Button6.TabIndex = 2
        Button6.Text = "Factures"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DimGray
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = SystemColors.ControlLightLight
        Button7.Location = New Point(0, 184)
        Button7.Margin = New Padding(3, 2, 3, 2)
        Button7.Name = "Button7"
        Button7.Size = New Size(219, 29)
        Button7.TabIndex = 1
        Button7.Text = "Se Déconnecter"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' outils
        ' 
        outils.FlatAppearance.BorderSize = 0
        outils.FlatStyle = FlatStyle.Flat
        outils.ForeColor = SystemColors.ControlLightLight
        outils.ImageAlign = ContentAlignment.MiddleLeft
        outils.Location = New Point(3, 2)
        outils.Margin = New Padding(3, 2, 3, 2)
        outils.Name = "outils"
        outils.Size = New Size(214, 39)
        outils.TabIndex = 0
        outils.Text = "Outils"
        outils.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(dashboard)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.MaximumSize = New Size(219, 224)
        Panel3.MinimumSize = New Size(219, 49)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 224)
        Panel3.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DimGray
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(0, 60)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(219, 29)
        Button5.TabIndex = 3
        Button5.Text = "Clients"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DimGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(0, 109)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(219, 29)
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
        Button3.Location = New Point(0, 159)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(219, 29)
        Button3.TabIndex = 1
        Button3.Text = "Achats"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' dashboard
        ' 
        dashboard.BackColor = Color.Black
        dashboard.FlatAppearance.BorderSize = 0
        dashboard.FlatStyle = FlatStyle.Flat
        dashboard.ForeColor = SystemColors.ControlLightLight
        dashboard.ImageAlign = ContentAlignment.MiddleLeft
        dashboard.Location = New Point(3, 2)
        dashboard.Margin = New Padding(3, 2, 3, 2)
        dashboard.Name = "dashboard"
        dashboard.Size = New Size(214, 39)
        dashboard.TabIndex = 0
        dashboard.Text = "Menu"
        dashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Location = New Point(227, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1465, 766)
        Panel2.TabIndex = 1
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(92, 299)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 23)
        Button8.TabIndex = 4
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Brown
        Panel8.Controls.Add(nombreClients)
        Panel8.Controls.Add(countClient)
        Panel8.Location = New Point(1025, 70)
        Panel8.Margin = New Padding(3, 2, 3, 2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(276, 96)
        Panel8.TabIndex = 3
        ' 
        ' nombreClients
        ' 
        nombreClients.AutoSize = True
        nombreClients.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nombreClients.ForeColor = SystemColors.ButtonHighlight
        nombreClients.Location = New Point(116, 8)
        nombreClients.Name = "nombreClients"
        nombreClients.Size = New Size(69, 25)
        nombreClients.TabIndex = 1
        nombreClients.Text = "Clients"
        ' 
        ' countClient
        ' 
        countClient.AutoSize = True
        countClient.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        countClient.ForeColor = SystemColors.ButtonHighlight
        countClient.Location = New Point(139, 39)
        countClient.Name = "countClient"
        countClient.Size = New Size(27, 30)
        countClient.TabIndex = 0
        countClient.Text = "C"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Khaki
        Panel7.Controls.Add(Label3)
        Panel7.Controls.Add(countp)
        Panel7.Location = New Point(698, 70)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(276, 96)
        Panel7.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(24, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 25)
        Label3.TabIndex = 1
        Label3.Text = " Produits Approvisionnés"
        ' 
        ' countp
        ' 
        countp.AutoSize = True
        countp.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        countp.ForeColor = SystemColors.ButtonHighlight
        countp.Location = New Point(133, 38)
        countp.Name = "countp"
        countp.Size = New Size(24, 30)
        countp.TabIndex = 0
        countp.Text = "L"
        countp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Highlight
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(restantStock)
        Panel6.Location = New Point(372, 70)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(276, 96)
        Panel6.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(53, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 25)
        Label4.TabIndex = 4
        Label4.Text = "Produits En Stocks"
        ' 
        ' restantStock
        ' 
        restantStock.AutoSize = True
        restantStock.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        restantStock.ForeColor = SystemColors.ButtonHighlight
        restantStock.Location = New Point(118, 39)
        restantStock.Name = "restantStock"
        restantStock.Size = New Size(24, 30)
        restantStock.TabIndex = 0
        restantStock.Text = "L"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Green
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(countA)
        Panel5.Location = New Point(33, 70)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(276, 96)
        Panel5.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(49, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 25)
        Label2.TabIndex = 1
        Label2.Text = "Produits Achetés"
        ' 
        ' countA
        ' 
        countA.AutoSize = True
        countA.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        countA.ForeColor = SystemColors.ButtonHighlight
        countA.Location = New Point(119, 39)
        countA.Name = "countA"
        countA.Size = New Size(24, 30)
        countA.TabIndex = 0
        countA.Text = "L"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 15
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 8
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 634)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dashboard As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents outils As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents countp As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents countA As Label
    Friend WithEvents restantStock As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nombreClients As Label
    Friend WithEvents countClient As Label
    Friend WithEvents Button8 As Button
End Class
