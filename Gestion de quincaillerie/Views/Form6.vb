Imports System.Drawing.Printing
Imports System.IO
Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient


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
        Dim yPos As Integer = 100
        Dim xPos As Integer = 50
        Dim lineHeight As Integer = 40
        Dim columnWidth As Integer = 200
        Dim centerX As Integer = e.MarginBounds.Width / 2
        Dim titleFont As New Font("Arial", 24, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 10)
        Dim footerFont As New Font("Arial", 10, FontStyle.Italic)
        Dim headerBrush As New SolidBrush(Color.White)
        Dim dataBrush As New SolidBrush(Color.Black)
        Dim borderPen As New Pen(Color.Blue, 2)
        Dim bgBrush As New SolidBrush(Color.Blue)

        ' Draw the title
        Dim title As String = "FACTURE QUINCAILLERIE"
        Dim titleWidth As Single = e.Graphics.MeasureString(title, titleFont).Width
        e.Graphics.DrawString(title, titleFont, New SolidBrush(Color.DarkBlue), centerX - titleWidth / 2, yPos)
        yPos += 60

        ' Draw table headers
        xPos = 50
        For Each column As DataColumn In dataTable.Columns
            e.Graphics.FillRectangle(bgBrush, xPos, yPos, columnWidth, lineHeight)
            e.Graphics.DrawRectangle(borderPen, xPos, yPos, columnWidth, lineHeight)
            e.Graphics.DrawString(column.ColumnName, headerFont, headerBrush, xPos + 5, yPos + 10)
            xPos += columnWidth
        Next
        yPos += lineHeight

        ' Draw table rows
        For Each row As DataRow In dataTable.Rows
            xPos = 50
            For Each column As DataColumn In dataTable.Columns
                e.Graphics.DrawRectangle(borderPen, xPos, yPos, columnWidth, lineHeight)
                e.Graphics.DrawString(row(column).ToString(), dataFont, dataBrush, xPos + 5, yPos + 10)
                xPos += columnWidth
            Next
            yPos += lineHeight
        Next

        ' Add a logo or an icon (retrieved from DB)
        Dim connect As New connexion_db()
        Dim connection As MySqlConnection = connect.OpenConnection()
        Dim command As New MySqlCommand("SELECT photo FROM client WHERE idClient=@idClient", connection)
        command.Parameters.AddWithValue("@idClient", idClient)

        Dim photoPath As String = CType(command.ExecuteScalar(), String)
        'connection.Close()

        If Not String.IsNullOrEmpty(photoPath) AndAlso IO.File.Exists(photoPath) Then
            Dim toolIcon As New Bitmap(photoPath)
            e.Graphics.DrawImage(toolIcon, e.MarginBounds.Right - 100, 20, 80, 80)
        End If

        ' Draw footer
        Dim footer As String = "Merci pour votre fidélité !"
        Dim footerWidth As Single = e.Graphics.MeasureString(footer, footerFont).Width
        e.Graphics.DrawString(footer, footerFont, New SolidBrush(Color.DarkBlue), centerX - footerWidth / 2, e.MarginBounds.Bottom - 50)
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