Public Class Form2
    Dim collapsed As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(800, 800)

        Panel3.Size = Panel3.MinimumSize
        Panel4.Size = Panel4.MinimumSize
        Dim client As New Clients()
        countClient.Text = client.countClient()

        'dashboard informations
        Dim produits As New products()
        Dim counterProduit As Integer = produits.countProduits()
        countp.Text = counterProduit
        produits.VoirSeuil(seuilvue)


        Dim compteAchat As New Achats()
        Dim counterAchat As Integer = compteAchat.countAchats()
        countA.Text = counterAchat

        restantStock.Text = counterProduit - counterAchat

        If Convert.ToInt32(restantStock.Text) <= Convert.ToInt32(seuilvue.Text) Then
            Dim produit As New products()
            produit.sendMailAlerte()
            MessageBox.Show("Seuil minimal atteint.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        MessageBox.Show(Form1.roleUser)
        If Form1.roleUser = "Caissiere" Then
            resetAll.Enabled = False
            seuilMinimal.Enabled = False
            resetAll.BackColor = Color.Gray

        End If

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
        Dim produitView As New dashToProduits(Panel2, New Form4())
        produitView.open1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim achatView As New dashToAchats(Panel2, New Form5())
        achatView.open1()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connection As New Connect(Me, New Form2())
        connection.open1()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim connection As New Connect(Me, New Form1())
        connection.open1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim home As New Home(Panel2, New Form3())
        home.open1()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles countClient.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim home As New Facture(Panel2, New Form6())
        home.open1()
    End Sub

    Private Sub countA_Click(sender As Object, e As EventArgs) Handles countA.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim home As New Facture(Panel2, New Form6())
        home.open1
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles seuilMinimal.Click
        Dim produit As New products()
        produit.UpdateSeuil(seuils.Text)
        produit.VoirSeuil(seuilvue)
    End Sub

    Private Sub resetAll_Click(sender As Object, e As EventArgs) Handles resetAll.Click
        Dim produit As New products()
        produit.DeleteAll()
    End Sub
End Class
