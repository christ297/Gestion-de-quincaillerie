Imports System.Diagnostics.Metrics
Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports QuestPDF.Infrastructure

Public Class Form5
    Public idAchat As Integer
    Public idProduit As Integer
    Public idClient As Integer
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As New Achats()
        dataTable.LoadAchatsTables(AchatsTableview)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertAchat As New Achats()
        idProduit = DirectCast(libelleProductBox.SelectedItem, Object).ID
        idClient = DirectCast(nomClientBox.SelectedItem, Object).ID
        insertAchat.InsertAchat(quantiteAchat.Text, idProduit, idClient)
        Dim dataTable As New Achats()
        dataTable.LoadAchatsTables(AchatsTableview)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim achat As New Achats()
        Dim produits As Dictionary(Of Integer, String) = achat.ChargerProduits()

        libelleProductBox.Items.Clear()
        For Each kvp As KeyValuePair(Of Integer, String) In produits
            libelleProductBox.Items.Add(New With {.ID = kvp.Key, .Libelle = kvp.Value})
        Next

        libelleProductBox.DisplayMember = "Libelle" ' Ce qui est affiché
        libelleProductBox.ValueMember = "ID" ' Ce qui est utilisé
    End Sub




    Private Sub libelleProductBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles libelleProductBox.SelectedIndexChanged

    End Sub

    Private Sub AchatsTableview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AchatsTableview.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = AchatsTableview.Rows(e.RowIndex)
            idAchat = Convert.ToInt32(selectedRow.Cells("idAchat").Value)
            quantiteAchat.Text = selectedRow.Cells("quantiteAchat").Value
            nomClientBox.Text = Convert.ToInt32(selectedRow.Cells("refClient").Value)
            libelleProductBox.Text = selectedRow.Cells("refProduit").Value

            MsgBox("ID sélectionné : " & idAchat)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim achat As New Achats()
        achat.DeleteAchat(idAchat)
        Dim dataTable As New Achats()
        dataTable.LoadAchatsTables(AchatsTableview)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim achat As New Achats()
        achat.UpdateAchat(idAchat, quantiteAchat.Text, idClient, idProduit)
        Dim dataTable As New Achats()
        dataTable.LoadAchatsTables(AchatsTableview)
    End Sub

    Private Sub nomClientBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim achat As New Achats()
        Dim clients As Dictionary(Of Integer, String) = achat.ChargerClients()

        nomClientBox.Items.Clear()
        For Each kvp As KeyValuePair(Of Integer, String) In clients
            nomClientBox.Items.Add(New With {.ID = kvp.Key, .Nom = kvp.Value})
        Next

        nomClientBox.DisplayMember = "Nom" ' Ce qui est affiché
        nomClientBox.ValueMember = "ID" ' Ce qui est utilisé
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class