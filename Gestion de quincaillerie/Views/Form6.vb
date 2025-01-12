Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Data
Imports System.Drawing.Printing
Imports Devart.Common


Public Class Form6

    Private idClient As String
    Dim WithEvents PrintDoc As New PrintDocument
    Dim rowIndex As Integer = 0
    Dim printFont As New Font("Arial", 10)
    Dim dataTable As New DataTable()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String = "SELECT 
            client.nomClient,
            client.prenomsClient,
            client.numClient,
            SUM(achat.quantiteAchat * produit.prixProduit) AS totalAchats
        FROM 
            client
        INNER JOIN 
            achat 
            ON achat.refClient = client.idClient
        INNER JOIN 
            produit 
            ON produit.idProduit = achat.refProduit
        WHERE 
            client.idClient = @idclient
        GROUP BY 
            client.nomClient, 
            client.prenomsClient, 
            client.numClient;
        "

        Dim connect As New connexion_db()
        Dim conn As MySqlConnection = connect.OpenConnection()
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)

        ' Ajouter les paramètres pour sécuriser la requête
        cmd.Parameters.AddWithValue("@idclient", idClient)

        ' Remplir le DataTable
        adapter.Fill(DataTable)
        'facture.DataSource = dataTable

        ' Imprimer le document
        PrintDoc.Print()

    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim yPos As Integer = 100 ' Position verticale initiale
        Dim xPos As Integer = 50 ' Position horizontale initiale
        Dim lineHeight As Integer = 30 ' Hauteur des lignes
        Dim columnWidth As Integer = 150 ' Largeur des colonnes
        Dim centerX As Integer = e.MarginBounds.Width / 2 ' Centre horizontal
        Dim titleFont As New Font(printFont.FontFamily, 24, FontStyle.Bold) ' Police pour le titre
        Dim headerFont As New Font(printFont.FontFamily, 12, FontStyle.Bold) ' Police pour les en-têtes
        Dim footerFont As New Font(printFont.FontFamily, 10, FontStyle.Italic) ' Police pour le pied de page
        Dim headerBrush As New SolidBrush(Color.DarkGreen) ' Couleur des en-têtes
        Dim dataBrush As New SolidBrush(Color.Black) ' Couleur des données
        Dim borderPen As New Pen(Color.Black, 1) ' Stylo pour les bordures

        ' Dessiner le titre centré
        Dim title As String = "FACTURE QUINCAILLERIE"
        Dim titleWidth As Single = e.Graphics.MeasureString(title, titleFont).Width
        e.Graphics.DrawString(title, titleFont, headerBrush, centerX - titleWidth / 2, yPos)
        yPos += 50 ' Ajouter un espace après le titre

        ' Dessiner les colonnes avec bordures
        xPos = 50
        For Each column As DataColumn In DataTable.Columns
            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), xPos, yPos, columnWidth, lineHeight) ' Fond gris clair
            e.Graphics.DrawRectangle(borderPen, xPos, yPos, columnWidth, lineHeight) ' Bordures
            e.Graphics.DrawString(column.ColumnName, headerFont, headerBrush, xPos + 5, yPos + 5)
            xPos += columnWidth
        Next
        yPos += lineHeight ' Passer à la ligne suivante

        ' Dessiner les données avec des bordures
        For Each row As DataRow In DataTable.Rows
            xPos = 50 ' Réinitialiser la position horizontale
            For Each column As DataColumn In DataTable.Columns
                e.Graphics.DrawRectangle(borderPen, xPos, yPos, columnWidth, lineHeight) ' Bordures
                e.Graphics.DrawString(row(column).ToString(), printFont, dataBrush, xPos + 5, yPos + 5)
                xPos += columnWidth
            Next
            yPos += lineHeight ' Passer à la ligne suivante
        Next

        ' Dessiner le message de remerciement en bas
        Dim footer As String = "Merci pour votre fidélité !"
        Dim footerWidth As Single = e.Graphics.MeasureString(footer, footerFont).Width
        e.Graphics.DrawString(footer, footerFont, dataBrush, centerX - footerWidth / 2, e.MarginBounds.Bottom - 450)

        ' Ajouter un dessin ou une icône
        Dim toolIcon As New Bitmap("C:\Users\KELI\source\repos\GK\Gestion de quincaillerie\Resources\left-arrow.png") ' Remplace par le chemin d'une icône
        e.Graphics.DrawImage(toolIcon, e.MarginBounds.Right - 100, 20, 80, 80)
    End Sub


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As New connexion_db()
        Dim connection As MySqlConnection = connect.OpenConnection()
        Dim query As String = "SELECT 
            client.nomClient,
            client.prenomsClient,
            client.numClient,
            client.idClient,
            SUM(achat.quantiteAchat * produit.prixProduit) AS totalAchats
        FROM 
            client
        INNER JOIN 
            achat 
            ON achat.refClient = client.idClient
        INNER JOIN 
            produit 
            ON produit.idProduit = achat.refProduit
        GROUP BY 
            client.nomClient, 
            client.prenomsClient, 
            client.numClient;"
        Dim command As New MySqlCommand(query, connection)
        Dim data As New MySqlDataAdapter(command)
        Dim dataTable As New DataTable
        data.Fill(dataTable)
        facture.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles facture.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = facture.Rows(e.RowIndex)
            idClient = Convert.ToInt32(selectedRow.Cells("idClient").Value)


            MsgBox("ID sélectionné : " & idClient)
        End If
    End Sub
End Class