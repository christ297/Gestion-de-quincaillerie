﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label5 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        label = New Label()
        numClient = New TextBox()
        nomClient = New TextBox()
        DataGridViewClient = New DataGridView()
        PictureBox1 = New PictureBox()
        search = New TextBox()
        Label1 = New Label()
        prenomsClient = New TextBox()
        pbxImage = New PictureBox()
        btnCharger = New Button()
        CType(DataGridViewClient, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F)
        Label5.Location = New Point(35, 580)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 31)
        Label5.TabIndex = 29
        Label5.Text = "Numéro Client"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 13.8F)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(475, 709)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 48)
        Button3.TabIndex = 27
        Button3.Text = "Supprimer"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrange
        Button2.Font = New Font("Segoe UI", 13.8F)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(251, 709)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 48)
        Button2.TabIndex = 26
        Button2.Text = "Modifier"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 13.8F)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(35, 709)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 48)
        Button1.TabIndex = 25
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F)
        Label4.Location = New Point(35, 371)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 31)
        Label4.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 491)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 31)
        Label3.TabIndex = 23
        Label3.Text = "Prénoms"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(35, 403)
        label.Name = "label"
        label.Size = New Size(64, 31)
        label.TabIndex = 22
        label.Text = "Nom"
        ' 
        ' numClient
        ' 
        numClient.Font = New Font("Segoe UI", 12F)
        numClient.Location = New Point(302, 580)
        numClient.Name = "numClient"
        numClient.PlaceholderText = "Entrer votre téléphone"
        numClient.Size = New Size(277, 34)
        numClient.TabIndex = 21
        ' 
        ' nomClient
        ' 
        nomClient.Font = New Font("Segoe UI", 12F)
        nomClient.Location = New Point(302, 399)
        nomClient.Name = "nomClient"
        nomClient.PlaceholderText = "Entrer votre nom"
        nomClient.Size = New Size(277, 34)
        nomClient.TabIndex = 20
        ' 
        ' DataGridViewClient
        ' 
        DataGridViewClient.AllowUserToAddRows = False
        DataGridViewClient.AllowUserToDeleteRows = False
        DataGridViewClient.AllowUserToResizeColumns = False
        DataGridViewClient.AllowUserToResizeRows = False
        DataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewClient.ColumnHeadersHeight = 29
        DataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewClient.Location = New Point(677, 204)
        DataGridViewClient.Name = "DataGridViewClient"
        DataGridViewClient.ReadOnly = True
        DataGridViewClient.RowHeadersVisible = False
        DataGridViewClient.RowHeadersWidth = 280
        DataGridViewClient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewClient.ShowCellErrors = False
        DataGridViewClient.ShowEditingIcon = False
        DataGridViewClient.ShowRowErrors = False
        DataGridViewClient.Size = New Size(569, 487)
        DataGridViewClient.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(1177, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 32)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' search
        ' 
        search.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        search.Location = New Point(420, 26)
        search.Name = "search"
        search.Size = New Size(650, 34)
        search.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-67, -24)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 16
        Label1.Text = "Produits"
        ' 
        ' prenomsClient
        ' 
        prenomsClient.Font = New Font("Segoe UI", 12F)
        prenomsClient.Location = New Point(302, 487)
        prenomsClient.Name = "prenomsClient"
        prenomsClient.PlaceholderText = "Entrer votre prenoms"
        prenomsClient.Size = New Size(277, 34)
        prenomsClient.TabIndex = 31
        ' 
        ' pbxImage
        ' 
        pbxImage.BorderStyle = BorderStyle.FixedSingle
        pbxImage.Location = New Point(11, 109)
        pbxImage.Name = "pbxImage"
        pbxImage.Size = New Size(157, 171)
        pbxImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbxImage.TabIndex = 32
        pbxImage.TabStop = False
        ' 
        ' btnCharger
        ' 
        btnCharger.BackColor = Color.DodgerBlue
        btnCharger.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCharger.ForeColor = SystemColors.ControlLightLight
        btnCharger.Location = New Point(11, 305)
        btnCharger.Name = "btnCharger"
        btnCharger.Size = New Size(158, 40)
        btnCharger.TabIndex = 33
        btnCharger.Text = "Charger Image"
        btnCharger.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1497, 845)
        Controls.Add(btnCharger)
        Controls.Add(pbxImage)
        Controls.Add(prenomsClient)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(label)
        Controls.Add(numClient)
        Controls.Add(nomClient)
        Controls.Add(DataGridViewClient)
        Controls.Add(PictureBox1)
        Controls.Add(search)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridViewClient, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents numClient As TextBox
    Friend WithEvents nomClient As TextBox
    Friend WithEvents DataGridViewClient As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents prenomsClient As TextBox
    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents btnCharger As Button
End Class
