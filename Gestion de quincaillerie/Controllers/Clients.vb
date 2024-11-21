Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient

Public Class Clients
    Dim connect As New connexion_db()

    ' Méthode pour insérer un produit
    Public Sub InsertClient(nomclient As String, prenomsClient As String, numClient As String, photo As String)
        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        ' Requête d'insertion SQL
        Dim query As String = "INSERT INTO client (nomClient,prenomsClient, numClient,photo) VALUES (@nom, @prenoms, @telephone,@photo)"

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@nom", nomclient)
                command.Parameters.AddWithValue("@prenoms", prenomsClient)
                command.Parameters.AddWithValue("@telephone", numClient)
                command.Parameters.AddWithValue("@photo", photo)



                ' Exécuter la commande
                command.ExecuteNonQuery()

                ' Message de confirmation
                MsgBox("Client ajouté avec succès !")
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de l'ajout : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Public Sub UpdateProduct(idClient As Integer, nomClient As String, prenomsClient As String, numClient As String, photo As String)
        ' Requête SQL pour mettre à jour un produit
        Dim query As String = "UPDATE client SET nomClient = @nom, prenomsClient = @prenoms, numClient = @telephone, photo = @photo WHERE idClient = @id"

        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@id", idClient)
                command.Parameters.AddWithValue("@nom", nomClient)
                command.Parameters.AddWithValue("@prenoms", prenomsClient)
                command.Parameters.AddWithValue("@telephone", numClient)
                command.Parameters.AddWithValue("@photo", photo)


                ' Exécuter la commande
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Vérifier si la mise à jour a été effectuée
                If rowsAffected > 0 Then
                    MsgBox("client mis à jour avec succès !")
                Else
                    MsgBox("Erreur : Aucun clieent trouvé avec cet ID.")
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


    Public Sub DeleteClient(idClient As Integer)
        ' Requête SQL pour supprimer un produit
        Dim query As String = "DELETE FROM client WHERE idClient = @idClient"

        Dim connection As MySqlConnection = connect.OpenConnection()

        Try
            Using command As New MySqlCommand(query, connection)
                ' Ajouter le paramètre pour sécuriser la requête
                command.Parameters.AddWithValue("@idClient", idClient)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Vérifier si la suppression a été effectuée
                If rowsAffected > 0 Then
                    MsgBox("client supprimé avec succès !")
                Else
                    MsgBox("Erreur : Aucun client trouvé avec cet ID.")
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

    Public Sub LoadClientsTables(DataTableview As DataGridView)
        Try
            Dim connection As MySqlConnection = connect.OpenConnection()
            Dim query As String = "SELECT * FROM client"
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
    Public Function countClient()
        Dim query As String = "SELECT COUNT(*) FROM client"
        Dim count As Integer = 0
        Try
            ' Ouvrir la connexion
            Dim connection As MySqlConnection = connect.OpenConnection()

            ' Création d'une commande SQL
            Using command As New MySqlCommand(query, connection)
                ' Exécution de la commande et récupération du résultat
                count = Convert.ToInt32(command.ExecuteScalar())
                Console.WriteLine($"Nombre de client dans la table : {count}")
            End Using

        Catch ex As Exception
            ' Gestion des erreurs
            Console.WriteLine("Erreur : " & ex.Message)
        End Try

        Return count

    End Function
End Class
