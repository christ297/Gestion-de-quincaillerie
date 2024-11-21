Imports MySql.Data.MySqlClient

Namespace ConnexionToDb
    Public Class connexion_db
        Private connectionInfo As String = "server=localhost;user=root;password=christ;database=gestion_quincaillerie"

        Public Function OpenConnection() As MySqlConnection
            Dim conn As New MySqlConnection(connectionInfo)
            Try
                conn.Open()
                Debug.WriteLine("Connexion réussie")
                Return conn
            Catch ex As MySqlException
                Console.WriteLine("Erreur de connexion : " & ex.Message)
                Return Nothing
            End Try
        End Function
        ' Crée un DataSet pour stocker les données Dim dataSet As New DataSet() ' Remplit le DataSet avec les données de la table adapter.Fill(dataSet, "YourTable") ' Associe le DataGridView au DataSet DataGridView1.DataSource = dataSet.Tables("YourTable")
        Public Sub CloseConnection(ByVal conn As MySqlConnection)
            Try
                If conn IsNot Nothing Then
                    conn.Close()
                    MsgBox("Connexion fermée")
                End If
            Catch ex As MySqlException
                Console.WriteLine("Erreur lors de la fermeture de la connexion : " & ex.Message)
            End Try
        End Sub
    End Class

End Namespace
