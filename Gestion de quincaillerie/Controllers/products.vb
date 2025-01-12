Imports System.Net
Imports System.Net.Mail
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

    Public Sub LoadProduitsTables(DataTableview As DataGridView, Optional searchKeyword As String = "")
        Try
            ' Obtenir la connexion à la base de données
            Dim connection As MySqlConnection = connect.OpenConnection()

            ' Construire la requête SQL avec une clause WHERE pour la recherche
            Dim query As String = "SELECT * FROM produit"
            If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                query &= " WHERE libelleProduit LIKE @search OR quantiteProduit LIKE @search OR prixProduit LIKE @search"
            End If

            ' Créer et paramétrer la commande
            Dim command As New MySqlCommand(query, connection)
            If Not String.IsNullOrWhiteSpace(searchKeyword) Then
                command.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")
            End If

            ' Exécuter la commande et remplir le DataTable
            Dim data As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable
            data.Fill(dataTable)

            ' Lier les données au DataGridView
            DataTableview.DataSource = dataTable

            ' Définir les en-têtes des colonnes si nécessaire
            'DataTableview.Columns(0).HeaderText = "Libelle"
            'DataTableview.Columns(1).HeaderText = "Quantite"
            'DataTableview.Columns(2).HeaderText = "Prix"

        Catch ex As Exception
            ' Afficher un message en cas d'erreur
            MessageBox.Show("Erreur lors du chargement des données : " & ex.Message)
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

    Public Sub UpdateSeuil(seuilStocks As Integer)
        ' Requête SQL pour mettre à jour un produit
        Dim query As String = "UPDATE seuil SET seuil = @nouv"

        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()

        Try
            ' Créer la commande MySQL
            Using command As New MySqlCommand(query, connection)
                ' Ajouter les paramètres pour sécuriser la requête
                command.Parameters.AddWithValue("@nouv", seuilStocks)


                ' Exécuter la commande
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Vérifier si la mise à jour a été effectuée
                If rowsAffected > 0 Then
                    MsgBox("Seuil mis à jour avec succès !")
                Else
                    MsgBox("Erreur")
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

    Public Sub VoirSeuil(seuil As Label)
        Try
            Dim connection As MySqlConnection = connect.OpenConnection()
            Dim query As String = "SELECT seuil FROM seuil"
            Dim command As New MySqlCommand(query, connection)
            seuil.Text = command.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Function sendMailAlerte()
        Try
            ' Configurer le message
            Dim mail As New MailMessage()
            mail.From = New MailAddress("christlearn834@gmail.com") ' Adresse de l'expéditeur
            mail.To.Add("hisciences331@gmail.com")          ' Adresse du destinataire
            mail.Subject = "Alerte : Problème détecté"
            mail.Body = "Bonjour, une alerte a été détectée concernant l'adresse XYZ. Merci de vérifier rapidement."

            ' Configurer le client SMTP
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.Credentials = New NetworkCredential("christlearn834@gmail.com", "dowq qilc pwcr esun") ' Authentification
            smtp.EnableSsl = True

            ' Envoyer l'e-mail
            smtp.Send(mail)
            MessageBox.Show("L'e-mail a été envoyé avec succès.")
        Catch ex As Exception
            Console.WriteLine("Erreur lors de l'envoi : " & ex.Message)
        End Try
    End Function


    Public Sub DeleteAll()
        ' Requête SQL pour supprimer un produit
        Dim query1 As String = "DELETE FROM produit"
        Dim query2 As String = "DELETE FROM achat"
        Dim query3 As String = "DELETE FROM client"


        ' Obtenir la connexion MySQL
        Dim connection As MySqlConnection = connect.OpenConnection()
        Dim rowsAffected1 As Integer = 0
        Dim rowsAffected2 As Integer = 0
        Dim rowsAffected3 As Integer = 0

        Try
            ' Créer la commande MySQL
            Using command1 As New MySqlCommand(query1, connection)
                rowsAffected1 = command1.ExecuteNonQuery()

            End Using
            Using command2 As New MySqlCommand(query2, connection)
                rowsAffected2 = command2.ExecuteNonQuery()

            End Using
            Using command3 As New MySqlCommand(query3, connection)
                rowsAffected3 = command3.ExecuteNonQuery()
            End Using

            If MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser le logiciel ? Cette action est irréversible.",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ' Si l'utilisateur confirme, procédez avec l'action
                If rowsAffected1 > 0 And rowsAffected2 > 0 And rowsAffected3 > 0 Then
                    MsgBox("Logiciel réinitialisé avec succès !", MessageBoxIcon.Information)
                End If
            Else
                ' Si l'utilisateur annule, affichez un message ou ne faites rien
                MsgBox("Réinitialisation annulée.", MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox("Erreur lors de la réinitialisation : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

End Class
