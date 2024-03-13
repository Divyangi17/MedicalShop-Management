Imports System.Data.OleDb

Public Class Login
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Dim loginsuccess As Boolean
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As New String("Data Source=localhost;" +
                                             "password=dev4; User id=dev; " +
                                             "Provider=ORAOLEDB.Oracle")
        connection = New OleDbConnection(connection_string)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ds = New DataSet

            Dim qry As New String("Select PWD from TBL_USER WHERE ID='" & TextBox1.Text & "'")
            Dim adp As New OleDbDataAdapter(qry, connection)
            adp.Fill(ds)

            If TextBox2.Text = ds.Tables(0).Rows(0)("PWD") Then
                loginsuccess = True
                Form1.Show()
                Me.Hide()
            Else
                loginsuccess = False
            End If
        Catch ex As Exception

        End Try




    End Sub



    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
End Class