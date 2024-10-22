Public Class Connection
    Private mainPanel As New Panel
    Private mainForm As New Form

    Public Sub New(panel As Panel, form As Form)
        ' Initialisation de la propriété mainPanel avec le paramètre reçu
        Me.mainPanel = panel
        Me.mainForm = form
    End Sub
    Public Sub openForm2()
        ' Nettoyer tous les contrôles de Form1 avant de charger Form2
        mainPanel.Controls.Clear()
        mainForm.Controls.Clear()
        mainForm.Controls.Add(mainPanel)

        ' Créer une instance de Form2
        Dim form2 As New Form2()
        ' Configurer Form2 pour qu'il s'affiche dans le Panel
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill

        ' Ajouter Form2 au Panel1 de Form1
        mainPanel.Controls.Add(form2)
        form2.Show()
    End Sub

End Class
