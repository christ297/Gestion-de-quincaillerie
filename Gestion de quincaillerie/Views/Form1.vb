Public Class Form1

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connection As New Connection(Panel1, Me)
        connection.openForm2()
        ' Nettoyer tous les contrôles de Form1 avant de charger Form2
        ' Me.Controls.Clear()
        ' Me.Controls.Add(Panel1)

        ' Créer une instance de Form2
        'Dim form2 As New Form2()
        ' Configurer Form2 pour qu'il s'affiche dans le Panel
        ' Form2.TopLevel = False
        ' Form2.FormBorderStyle = FormBorderStyle.None
        ' Form2.Dock = DockStyle.Fill

        ' Ajouter Form2 au Panel1 de Form1
        'Panel1.Controls.Add(form2)
        ' Form2.Show()
    End Sub
End Class
