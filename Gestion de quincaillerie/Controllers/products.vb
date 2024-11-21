Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient

Public Class products
    Dim connect As New connexion_db()

    ' Méthode pour insérer un produit
    Public Sub InsertProduct(libelle As String, prix As Decimal, quantite As Integer, categorie As String)
        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        ' Requête d'insertion SQL
        Dim query As String = "INSERT INTO Produit (libelleProduit,quantiteProduit, prixProduit,categorieProduit) VALUES (@libelle, @quantite, @prix,@categorie)"

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@libelle", libelle)
                command.Parameters.AddWithValue("@quantite", quantite)
                command.Parameters.AddWithValue("@prix", prix)
                command.Parameters.AddWithValue("@categorie", categorie)


                ' Ouvrir la connexion
                'connection.Open()

                ' Exécuter la commande
                command.ExecuteNonQuery()

                ' Message de confirmation
                MsgBox("Produit inséré avec succès !")
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de l'insertion : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Public Sub UpdateProduct(idProduit As Integer, nouveauLibelle As String, nouveauPrix As Decimal, nouvelleQuantite As Integer, nouvelleCategorie As String)
        ' Requête SQL pour mettre à jour un produit
        Dim query As String = "UPDATE Produit SET libelleProduit = @nouveauLibelle, prixProduit = @nouveauPrix, quantiteProduit = @nouvelleQuantite, categorieProduit = @nouvelleCategorie WHERE idProduit = @idProduit"

        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@idProduit", idProduit)
                command.Parameters.AddWithValue("@nouveauLibelle", nouveauLibelle)
                command.Parameters.AddWithValue("@nouveauPrix", nouveauPrix)
                command.Parameters.AddWithValue("@nouvelleQuantite", nouvelleQuantite)
                command.Parameters.AddWithValue("@nouvelleCategorie", nouvelleCategorie)


                ' Exécuter la commande
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Vérifier si la mise à jour a été effectuée
                If rowsAffected > 0 Then
                    MsgBox("Produit mis à jour avec succès !")
                Else
                    MsgBox("Erreur : Aucun produit trouvé avec cet ID.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de la mise à jour : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Public Sub DeleteProduct(idProduit As Integer)
        ' Requête SQL pour supprimer un produit
        Dim query As String = "DELETE FROM Produit WHERE idProduit = @idProduit"

        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter le paramètre pour sécuriser la requête
                command.Parameters.AddWithValue("@idProduit", idProduit)

                ' Exécuter la commande
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Vérifier si la suppression a été effectuée
                If rowsAffected > 0 Then
                    MsgBox("Produit supprimé avec succès !")
                Else
                    MsgBox("Erreur : Aucun produit trouvé avec cet ID.")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de la suppression : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub LoadProduitsTables(DataTableview As DataGridView)
        Try
            Dim connection As MySqlConnection = connect.OpenConnection()
            Dim query As String = "SELECT * FROM produit"
            Dim command As New MySqlCommand(query, connection)
            Dim data As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable
            data.Fill(dataTable)
            DataTableview.DataSource = dataTable

            ' Define column headers
            DataTableview.Columns(0).HeaderText = "Libelle"
            DataTableview.Columns(1).HeaderText = "Quantite"
            DataTableview.Columns(2).HeaderText = "Prix"

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Function countProduits()
        Dim query As String = "SELECT COUNT(*) FROM produit"
        Dim count As Integer = 0
        Try
            ' Ouvrir la connexion
            Dim connection As MySqlConnection = connect.OpenConnection()

            ' Création d'une commande SQL
            Using command As New MySqlCommand(query, connection)
                ' Exécution de la commande et récupération du résultat
                count = Convert.ToInt32(command.ExecuteScalar())
                Console.WriteLine($"Nombre de produits dans la table : {count}")
            End Using

        Catch ex As Exception
            ' Gestion des erreurs
            Console.WriteLine("Erreur : " & ex.Message)
        End Try

        Return count

    End Function
End Class
