Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim home As New Home(Panel2, Form3)
        home.open1()

        ' Créer une instance de Form3
        'Dim form3 As New Form3()

        ' Configurer Form3 pour qu'il s'affiche sans bordure et qu'il soit non top-level
        'Form3.TopLevel = False
        'Form3.FormBorderStyle = FormBorderStyle.None
        ' Form3.Dock = DockStyle.Fill ' Pour que Form3 remplisse entièrement Panel2

        ' Effacer uniquement les contrôles de Panel2, pas ceux de Form1
        ' Panel2.Controls.Clear()

        ' Ajouter Form3 au Panel2 de Form1
        ' Panel2.Controls.Add(form3)
        ' Form3.Show()


    End Sub
End Class