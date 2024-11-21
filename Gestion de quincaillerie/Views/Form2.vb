Public Class Form2
    Dim collapsed As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Size = Panel3.MinimumSize
        Panel4.Size = Panel4.MinimumSize
        Dim client As New Clients()
        countClient.Text = client.countClient()

        'dashboard informations
        Dim countProduit As New products()
        Dim counterProduit As Integer = countProduit.countProduits()
        countp.Text = counterProduit


        Dim compteAchat As New Achats()
        Dim counterAchat As Integer = compteAchat.countAchats()
        countA.Text = counterAchat

        restantStock.Text = counterProduit - counterAchat

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If collapsed Then
            dashboard.Image = My.Resources.down_arrow
            Panel3.Height += 10
            If Panel3.Size = Panel3.MaximumSize Then
                Timer1.Stop()
                collapsed = False
            End If
        Else
            dashboard.Image = My.Resources.left_arrow1
            Panel3.Height -= 6
            If Panel3.Size = Panel3.MinimumSize Then
                Timer1.Stop()
                collapsed = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        Timer1.Start()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If collapsed Then
            outils.Image = My.Resources.down_arrow
            Panel4.Height += 10
            If Panel4.Size = Panel4.MaximumSize Then
                Timer2.Stop()
                collapsed = False
            End If
        Else
            outils.Image = My.Resources.left_arrow1
            Panel4.Height -= 6
            If Panel4.Size = Panel3.MinimumSize Then
                Timer2.Stop()
                collapsed = True
            End If
        End If
    End Sub

    Private Sub outils_Click(sender As Object, e As EventArgs) Handles outils.Click
        Timer2.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim produitView As New dashToProduits(Panel2, Form4)
        produitView.open1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim achatView As New dashToAchats(Panel2, Form5)
        achatView.open1()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New Connection(Panel1, Me)
        connection.openForm2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim home As New Home(Panel2, Form3)
        home.open1()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles countClient.Click

    End Sub
End Class
