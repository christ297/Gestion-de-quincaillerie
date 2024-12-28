Imports Mysqlx.XDevAPI

Public Class Form3
    Private filePath As String
    Private idClient As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As New Clients()
        client.LoadClientsTables(DataGridViewClient)
    End Sub

    Private Sub btnCharger_Click(sender As Object, e As EventArgs) Handles btnCharger.Click
        ' Créer une instance de OpenFileDialog
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Sélectionner une image"
        ofd.Filter = "Fichiers d'image|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        ' Afficher la boîte de dialogue et vérifier si l'utilisateur a sélectionné un fichier
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                filePath = ofd.FileName
                ' Charger l'image sélectionnée dans le PictureBox
                pbxImage.Image = Image.FromFile(ofd.FileName)
            Catch ex As Exception
                MessageBox.Show("Erreur lors du chargement de l'image : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim client As New Clients()
        client.InsertClient(nomClient.Text, prenomsClient.Text, numClient.Text, filePath)
        client.LoadClientsTables(DataGridViewClient)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim client As New Clients()
        client.UpdateProduct(idClient, nomClient.Text, prenomsClient.Text, numClient.Text, filePath)
        client.LoadClientsTables(DataGridViewClient)
    End Sub

    Private Sub DataGridViewClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClient.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewClient.Rows(e.RowIndex)
            idClient = Convert.ToInt32(selectedRow.Cells("idClient").Value)
            nomClient.Text = selectedRow.Cells("nomClient").Value
            prenomsClient.Text = selectedRow.Cells("prenomsClient").Value
            numClient.Text = selectedRow.Cells("numClient").Value
            filePath = selectedRow.Cells("photo").Value
            pbxImage.Image = Image.FromFile(filePath)

            MsgBox("ID sélectionné : " & idClient)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim client As New Clients()
        client.DeleteClient(idClient)
        client.LoadClientsTables(DataGridViewClient)

    End Sub
End Class