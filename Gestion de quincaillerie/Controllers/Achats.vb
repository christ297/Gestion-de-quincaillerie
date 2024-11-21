Imports System.Net.Sockets
Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class Achats

    Dim connect As New connexion_db()

    ' Méthode pour ajouter un achat achat
    Public Sub Ajouter(libelle As String, prix As Decimal, quantite As Integer)
        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        ' Requête d'insertion SQL
        Dim query As String = "INSERT INTO Achat (libelleProduit,quantiteProduit, prixProduit) VALUES (@libelle, @quantite, @prix)"
        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@libelle", libelle)
                command.Parameters.AddWithValue("@quantite", quantite)
                command.Parameters.AddWithValue("@prix", prix)

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


    ' Méthode pour charger les produits
    Public Function ChargerProduits() As Dictionary(Of Integer, String)
        Dim produits As New Dictionary(Of Integer, String)()
        Dim query As String = "SELECT idProduit, libelleProduit FROM Produit"

        Try
            Using connection As MySqlConnection = connect.OpenConnection()
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim idProduit As Integer = Convert.ToInt32(reader("idProduit"))
                            Dim libelleProduit As String = reader("libelleProduit").ToString()
                            produits.Add(idProduit, libelleProduit)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors du chargement des produits : " & ex.Message)
        End Try

        Return produits
    End Function

    Public Function ChargerClients() As Dictionary(Of Integer, String)
        Dim clients As New Dictionary(Of Integer, String)()
        Dim query As String = "SELECT idClient, nomClient FROM client"

        Try
            Using connection As MySqlConnection = connect.OpenConnection()
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim idClient As Integer = Convert.ToInt32(reader("idClient"))
                            Dim nomClient As String = reader("nomClient").ToString()
                            clients.Add(idClient, nomClient)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors du chargement des produits : " & ex.Message)
        End Try

        Return clients
    End Function




    Public Function InsertAchat(quantite As Integer, idClient As Integer, idProduit As Integer)
        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        ' Requête d'insertion SQL
        Dim query As String = "INSERT INTO achat (quantiteAchat,refClient,refProduit) VALUES (@quantite,@idClient,@idProduit)"
        Dim queryConstraint = "SELECT quantiteProduit from produit where refProduit=@idProduit"
        'If quantite - queryConstraint > 0 Then

        'End If

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@quantite", quantite)
                command.Parameters.AddWithValue("@idClient", idClient)
                command.Parameters.AddWithValue("@idProduit", idProduit)


                command.ExecuteNonQuery()

                ' Message de confirmation
                MsgBox("Achat effectué avec succès !")
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de l'insertion : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function

    Public Function UpdateAchat(id As Integer, quantite As Integer, refClient As Integer, refProduit As Integer) As Boolean
        Dim query As String = "UPDATE achat SET quantiteAchat = @quantite,refClient=@idClient,refProduit=@idProduit WHERE idAchat = @id"

        Try
            ' Obtenir la connexion MySQL
            Using connection As MySqlConnection = connect.OpenConnection()
                ' Créer la commande MySQL
                Using command As New MySqlCommand(query, connection)
                    ' Ajouter les paramètres pour sécuriser la requête
                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@quantite", quantite)
                    command.Parameters.AddWithValue("@idClient", refClient)
                    command.Parameters.AddWithValue("@idProduit", refProduit)


                    ' Exécution de la commande
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Retourner True si une ligne a été modifiée
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de la modification : " & ex.Message)
            Return False
        End Try
    End Function

    Public Function DeleteAchat(id As Integer) As Boolean
        Dim query As String = "DELETE FROM achat WHERE idAchat = @id"

        Try
            ' Obtenir la connexion MySQL
            Using connection As MySqlConnection = connect.OpenConnection()
                ' Créer la commande MySQL
                Using command As New MySqlCommand(query, connection)
                    ' Ajouter le paramètre pour sécuriser la requête
                    command.Parameters.AddWithValue("@id", id)

                    ' Exécution de la commande
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Retourner True si une ligne a été supprimée
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erreur lors de la suppression : " & ex.Message)
            Return False
        End Try
    End Function


    Public Function countAchats()
        Dim query As String = "SELECT COUNT(*) FROM achat"
        Dim count As Integer = 0
        Try
            ' Ouvrir la connexion
            Dim connection As MySqlConnection = connect.OpenConnection()

            ' Création d'une commande SQL
            Using command As New MySqlCommand(query, connection)
                ' Exécution de la commande et récupération du résultat
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using

        Catch ex As Exception
            ' Gestion des erreurs
            Console.WriteLine("Erreur : " & ex.Message)
        End Try

        Return count

    End Function

    Public Sub LoadAchatsTables(DataTableview As DataGridView)
        Try
            Dim connection As MySqlConnection = connect.OpenConnection()
            Dim query As String = "SELECT * FROM achat"
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

End Class

