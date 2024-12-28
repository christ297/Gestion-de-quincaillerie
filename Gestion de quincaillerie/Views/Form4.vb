Public Class Form4
    Public idProduit As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles label.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduit.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewProduit.Rows(e.RowIndex)
            idProduit = Convert.ToInt32(selectedRow.Cells("idProduit").Value)
            libelleProduit.Text = selectedRow.Cells("libelleProduit").Value
            typeProduit.Text = selectedRow.Cells("categorieProduit").Value
            prixProduit.Text = Convert.ToInt32(selectedRow.Cells("prixProduit").Value)
            quantiteProduit.Text = Convert.ToInt32(selectedRow.Cells("quantiteProduit").Value)
            MsgBox("ID sélectionné : " & idProduit)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As New products()
        insert.InsertProduct(libelleProduit.Text, Int(prixProduit.Text), Int(quantiteProduit.Text), typeProduit.Text)
        insert.LoadProduitsTables(DataGridViewProduit)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim produit As New products()
        produit.LoadProduitsTables(DataGridViewProduit)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim produit As New products()
        produit.UpdateProduct(idProduit, libelleProduit.Text, prixProduit.Text, quantiteProduit.Text, typeProduit.Text)
        produit.LoadProduitsTables(DataGridViewProduit)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim produit As New products()
        produit.DeleteProduct(idProduit)
        produit.LoadProduitsTables(DataGridViewProduit)

    End Sub
End Class