Public Class Form2

    Dim collapsed As Boolean = True
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Size = Panel3.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If collapsed Then
            ' Panel3.Image =
            Panel3.Height += 10
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Dashboard.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class