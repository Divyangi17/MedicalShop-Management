Public Class Form1
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Products.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SellToolStripMenuItem.Click
        Sell.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class
