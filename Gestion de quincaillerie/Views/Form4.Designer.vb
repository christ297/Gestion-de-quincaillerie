﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        searchBox = New TextBox()
        PictureBox1 = New PictureBox()
        DataGridViewProduit = New DataGridView()
        libelleProduit = New TextBox()
        prixProduit = New TextBox()
        label = New Label()
        Label3 = New Label()
        Label4 = New Label()
        add = New Button()
        update = New Button()
        delete = New Button()
        quantiteProduit = New NumericUpDown()
        Label5 = New Label()
        typeProduit = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewProduit, ComponentModel.ISupportInitialize).BeginInit()
        CType(quantiteProduit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 0
        Label1.Text = "Produits"
        ' 
        ' searchBox
        ' 
        searchBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(427, 17)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(650, 34)
        searchBox.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(1099, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 32)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' DataGridViewProduit
        ' 
        DataGridViewProduit.AllowUserToAddRows = False
        DataGridViewProduit.AllowUserToDeleteRows = False
        DataGridViewProduit.AllowUserToResizeColumns = False
        DataGridViewProduit.AllowUserToResizeRows = False
        DataGridViewProduit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewProduit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProduit.Location = New Point(683, 136)
        DataGridViewProduit.Name = "DataGridViewProduit"
        DataGridViewProduit.ReadOnly = True
        DataGridViewProduit.RowHeadersVisible = False
        DataGridViewProduit.RowHeadersWidth = 280
        DataGridViewProduit.ShowCellErrors = False
        DataGridViewProduit.ShowCellToolTips = False
        DataGridViewProduit.ShowEditingIcon = False
        DataGridViewProduit.ShowRowErrors = False
        DataGridViewProduit.Size = New Size(577, 456)
        DataGridViewProduit.TabIndex = 3
        ' 
        ' libelleProduit
        ' 
        libelleProduit.Font = New Font("Segoe UI", 12F)
        libelleProduit.Location = New Point(314, 159)
        libelleProduit.Name = "libelleProduit"
        libelleProduit.PlaceholderText = "Entrer le libellé du profuit"
        libelleProduit.Size = New Size(277, 34)
        libelleProduit.TabIndex = 4
        ' 
        ' prixProduit
        ' 
        prixProduit.Font = New Font("Segoe UI", 12F)
        prixProduit.Location = New Point(314, 449)
        prixProduit.Name = "prixProduit"
        prixProduit.PlaceholderText = "Entrer le prix du produit"
        prixProduit.Size = New Size(277, 34)
        prixProduit.TabIndex = 6
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(75, 159)
        label.Name = "label"
        label.Size = New Size(163, 31)
        label.TabIndex = 7
        label.Text = "Libellé produit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 31)
        Label3.TabIndex = 8
        Label3.Text = "Quantité"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F)
        Label4.Location = New Point(75, 452)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 31)
        Label4.TabIndex = 9
        Label4.Text = "Prix"
        ' 
        ' add
        ' 
        add.BackColor = Color.Green
        add.Font = New Font("Segoe UI", 13.8F)
        add.ForeColor = SystemColors.ButtonHighlight
        add.Location = New Point(48, 604)
        add.Name = "add"
        add.Size = New Size(155, 48)
        add.TabIndex = 10
        add.Text = "Ajouter"
        add.UseVisualStyleBackColor = False
        ' 
        ' update
        ' 
        update.BackColor = Color.Orange
        update.Font = New Font("Segoe UI", 13.8F)
        update.ForeColor = SystemColors.ButtonHighlight
        update.Location = New Point(261, 604)
        update.Name = "update"
        update.Size = New Size(154, 48)
        update.TabIndex = 11
        update.Text = "Modifier"
        update.UseVisualStyleBackColor = False
        ' 
        ' delete
        ' 
        delete.BackColor = Color.Red
        delete.Font = New Font("Segoe UI", 13.8F)
        delete.ForeColor = SystemColors.ButtonHighlight
        delete.Location = New Point(473, 604)
        delete.Name = "delete"
        delete.Size = New Size(149, 48)
        delete.TabIndex = 12
        delete.Text = "Supprimer"
        delete.UseVisualStyleBackColor = False
        ' 
        ' quantiteProduit
        ' 
        quantiteProduit.Font = New Font("Segoe UI", 12F)
        quantiteProduit.Location = New Point(317, 253)
        quantiteProduit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        quantiteProduit.Name = "quantiteProduit"
        quantiteProduit.Size = New Size(277, 34)
        quantiteProduit.TabIndex = 13
        quantiteProduit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F)
        Label5.Location = New Point(75, 357)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 31)
        Label5.TabIndex = 14
        Label5.Text = "Type Produit"
        ' 
        ' typeProduit
        ' 
        typeProduit.Font = New Font("Segoe UI", 12F)
        typeProduit.FormattingEnabled = True
        typeProduit.Location = New Point(315, 357)
        typeProduit.Name = "typeProduit"
        typeProduit.Size = New Size(279, 36)
        typeProduit.TabIndex = 15
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1435, 691)
        Controls.Add(typeProduit)
        Controls.Add(Label5)
        Controls.Add(quantiteProduit)
        Controls.Add(delete)
        Controls.Add(update)
        Controls.Add(add)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(label)
        Controls.Add(prixProduit)
        Controls.Add(libelleProduit)
        Controls.Add(DataGridViewProduit)
        Controls.Add(PictureBox1)
        Controls.Add(searchBox)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewProduit, ComponentModel.ISupportInitialize).EndInit()
        CType(quantiteProduit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewProduit As DataGridView
    Friend WithEvents libelleProduit As TextBox
    Friend WithEvents prixProduit As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents quantiteProduit As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents typeProduit As ComboBox
    Friend WithEvents add As Button
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
End Class
