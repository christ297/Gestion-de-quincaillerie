Imports Gestion_de_quincaillerie.ConnexionToDb
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Data


Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String = "SELECT * FROM client"
        Dim connect As New connexion_db()

        Dim conn As MySqlConnection = connect.OpenConnection()

        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dataSet As New DataSet()
        adapter.Fill(dataSet, "client")
        Dim dataTable As DataTable = dataSet.Tables("client")


        Dim localReport = ReportViewer1.LocalReport
        Dim dataSource As New ReportDataSource("DataSet1", dataTable)
        localReport.DataSources.Add(dataSource)
        Dim reportBytes As Byte() = localReport.Render("PDF")

        Dim savePath As String = "C:\Users\KELI\Desktop\Rapport.pdf"
        System.IO.File.WriteAllBytes(savePath, reportBytes)

        MessageBox.Show("Rapport généré avec succès : " & savePath)

    End Sub
End Class