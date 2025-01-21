<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        libelleProductBox = New ComboBox()
        quantiteAchat = New NumericUpDown()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        AchatsTableview = New DataGridView()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        nomClientBox = New ComboBox()
        Label4 = New Label()
        CType(quantiteAchat, ComponentModel.ISupportInitialize).BeginInit()
        CType(AchatsTableview, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' libelleProductBox
        ' 
        libelleProductBox.Font = New Font("Segoe UI", 12F)
        libelleProductBox.FormattingEnabled = True
        libelleProductBox.Location = New Point(245, 176)
        libelleProductBox.Margin = New Padding(4)
        libelleProductBox.Name = "libelleProductBox"
        libelleProductBox.Size = New Size(382, 36)
        libelleProductBox.TabIndex = 30
        ' 
        ' quantiteAchat
        ' 
        quantiteAchat.Font = New Font("Segoe UI", 12F)
        quantiteAchat.Location = New Point(245, 456)
        quantiteAchat.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        quantiteAchat.Name = "quantiteAchat"
        quantiteAchat.Size = New Size(382, 34)
        quantiteAchat.TabIndex = 28
        quantiteAchat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 13.8F)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(556, 627)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(204, 49)
        Button3.TabIndex = 27
        Button3.Text = "Supprimer"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrange
        Button2.Font = New Font("Segoe UI", 13.8F)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(295, 627)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(212, 49)
        Button2.TabIndex = 26
        Button2.Text = "Modifier"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Segoe UI", 13.8F)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(45, 627)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(212, 49)
        Button1.TabIndex = 25
        Button1.Text = "Ajouter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 456)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 31)
        Label3.TabIndex = 23
        Label3.Text = "Quantité"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 176)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 31)
        Label2.TabIndex = 22
        Label2.Text = "Libellé produit"
        ' 
        ' AchatsTableview
        ' 
        AchatsTableview.AllowUserToAddRows = False
        AchatsTableview.AllowUserToDeleteRows = False
        AchatsTableview.AllowUserToResizeColumns = False
        AchatsTableview.AllowUserToResizeRows = False
        AchatsTableview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AchatsTableview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        AchatsTableview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AchatsTableview.EnableHeadersVisualStyles = False
        AchatsTableview.Location = New Point(791, 139)
        AchatsTableview.Margin = New Padding(4)
        AchatsTableview.MultiSelect = False
        AchatsTableview.Name = "AchatsTableview"
        AchatsTableview.ReadOnly = True
        AchatsTableview.RowHeadersVisible = False
        AchatsTableview.RowHeadersWidth = 280
        AchatsTableview.ShowCellErrors = False
        AchatsTableview.ShowCellToolTips = False
        AchatsTableview.ShowEditingIcon = False
        AchatsTableview.ShowRowErrors = False
        AchatsTableview.Size = New Size(646, 433)
        AchatsTableview.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(1551, 46)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 45)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 34)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 28)
        Label1.TabIndex = 16
        Label1.Text = "Achats"
        ' 
        ' nomClientBox
        ' 
        nomClientBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nomClientBox.FormattingEnabled = True
        nomClientBox.ItemHeight = 28
        nomClientBox.Location = New Point(245, 318)
        nomClientBox.Margin = New Padding(4)
        nomClientBox.Name = "nomClientBox"
        nomClientBox.Size = New Size(382, 36)
        nomClientBox.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 318)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 31)
        Label4.TabIndex = 32
        Label4.Text = "Client"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1540, 845)
        Controls.Add(Label4)
        Controls.Add(nomClientBox)
        Controls.Add(libelleProductBox)
        Controls.Add(quantiteAchat)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(AchatsTableview)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form5"
        Text = "Form5"
        CType(quantiteAchat, ComponentModel.ISupportInitialize).EndInit()
        CType(AchatsTableview, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents libelleProductBox As ComboBox
    Friend WithEvents quantiteAchat As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AchatsTableview As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nomClientBox As ComboBox
    Friend WithEvents Label4 As Label
End Class
