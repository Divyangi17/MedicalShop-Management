Imports System.Data.OleDb

Public Class Sell
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection_string As New String("Data Source=localhost;" +
                                             "password=dev4; User id=dev; " +
                                             "Provider=ORAOLEDB.Oracle")
        connection = New OleDbConnection(connection_string)

        fillProducts()
        addColumnsToDG2()
    End Sub

    Private Sub addColumnsToDG2()
        DataGridView1.Columns.Add("Id", "Id")
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("Qty", "Qty")
    End Sub

    Private Sub fillProducts()
        ds = New DataSet
        Dim dataAdapter As New OleDbDataAdapter _
                    ("Select * from TBL_PRODUCT", connection)
        dataAdapter.Fill(ds, "product")

        Dim primaryKeyColumns() As DataColumn = {ds.Tables("product").Columns("PRODUCT_ID")}
        ds.Tables("product").PrimaryKey = primaryKeyColumns

        ComboBox1.DataSource = ds.Tables("product")
        ComboBox1.DisplayMember = "PRODUCT_NAME"
        ComboBox1.ValueMember = "PRODUCT_ID"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertDataIntoDataGridView(ComboBox1.SelectedItem.item(0), ComboBox1.SelectedItem.item(1), TextBox3.Text)
    End Sub
    Private Sub InsertDataIntoDataGridView(ByVal product_id As String, ByVal product_name As String, ByVal quantity As String)

        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(DataGridView1)
        newRow.Cells(0).Value = product_id
        newRow.Cells(1).Value = product_name
        newRow.Cells(2).Value = quantity
        DataGridView1.Rows.Add(newRow)

        Dim dr As DataRow = ds.Tables("product").Rows.Find(product_id)
        'MsgBox(dr("PRODUCT_PRICE"))
        txt_total_amt.Text = (CInt(txt_total_amt.Text) + (dr("PRODUCT_PRICE") * CInt(TextBox3.Text))).ToString
    End Sub

End Class