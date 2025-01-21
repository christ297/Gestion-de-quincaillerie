<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Button1 = New Button()
        facture = New DataGridView()
        CType(facture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ReportViewer1
        ' 
        ReportViewer1.LocalReport.ReportPath = "C:\Users\KELI\source\repos\Gestion de quincaillerie\Gestion de quincaillerie\Report1.rdlc"
        ReportViewer1.Location = New Point(0, 0)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(396, 246)
        ReportViewer1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.ForeColor = SystemColors.Highlight
        Button1.Location = New Point(538, 534)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(211, 52)
        Button1.TabIndex = 0
        Button1.Text = "Imprimer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' facture
        ' 
        facture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        facture.BackgroundColor = SystemColors.ButtonFace
        facture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        facture.Location = New Point(38, 30)
        facture.Name = "facture"
        facture.ReadOnly = True
        facture.RowHeadersWidth = 51
        facture.Size = New Size(1228, 458)
        facture.TabIndex = 1
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1333, 627)
        Controls.Add(facture)
        Controls.Add(Button1)
        Name = "Form6"
        Text = "Form6"
        CType(facture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents facture As DataGridView
End Class
