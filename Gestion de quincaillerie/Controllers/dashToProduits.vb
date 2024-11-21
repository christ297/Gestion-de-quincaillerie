Public Class dashToProduits

    Private mainPanel As New Panel
    Private mainForm As New Form

    Public Sub New(panel As Panel, form As Form)
        ' Initialisation de la propriété mainPanel avec le paramètre reçu
        Me.mainPanel = panel
        Me.mainForm = form
    End Sub
    Public Sub open1()

        ' Configurer Form3 pour qu'il s'affiche sans bordure et qu'il soit non top-level
        mainForm.TopLevel = False
        mainForm.FormBorderStyle = FormBorderStyle.None
        mainForm.Dock = DockStyle.Fill ' Pour que Form3 remplisse entièrement Panel2

        ' Effacer uniquement les contrôles de Panel2, pas ceux de Form1
        mainPanel.Controls.Clear()
        ' Ajouter Form3 au Panel2 de Form1
        mainPanel.Controls.Add(Form4)
        mainForm.Show()
    End Sub
End Class
