Public Class Form1

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connecter.Click
        If Me.email.Text = "christ" And Me.password.Text = "christ" Then

            Dim connection As New Connection(Panel1, Me)
            connection.openForm2()

        Else
            MsgBox("Identifiant Incorrect", +vbExclamation, "Erreur d'authentification")
        End If




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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.UseSystemPasswordChar = False

        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
