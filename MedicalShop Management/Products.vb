Imports System.Data.OleDb
Imports System.IO
Public Class Products
    Dim connection As OleDbConnection
    Dim ds As DataSet
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        connection = New OleDbConnection("Data Source=localhost; " &
                                         "Password=dev4; User Id=dev; " &
                                         "Provider=OraOLEDB.Oracle")
        fillDataGridView()
    End Sub

    Private Sub fillDataGridView()
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        DataGridView1.RowTemplate.Height = 100

        Dim debugFolderPath As String = AppDomain.CurrentDomain.BaseDirectory
        ds = New DataSet
        Dim adp As New OleDbDataAdapter("Select * from TBL_PRODUCT", connection)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.HeaderText = "Image"
        imageColumn.Name = "ImageColumn"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch ' Stretch the image to fit cell
        DataGridView1.Columns.Add(imageColumn)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim fileName As String = row.Cells(4).Value
                    Dim imagePath As String = Path.Combine(debugFolderPath, fileName)
                    If File.Exists(imagePath) Then
                        Dim image As Image = Image.FromFile(imagePath)
                        row.Cells("ImageColumn").Value = image
                    Else
                        MessageBox.Show($"Image file not found: {fileName}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "C:\" 'Set the directory name  
            OpenFileDialog1.Title = "Open an Image File" 'Set the title name of the OpenDialog Box  
            OpenFileDialog1.Filter = "Image|*.jpg" 'Set the filter to display only image.  
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            'Label2.Text = OpenFileDialog1.FileName 'Path of selected file
            TextBox5.Text = Path.GetFileName(OpenFileDialog1.FileName) 'Path of selected file 
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim debugFolderPath As String = Path.GetDirectoryName(Application.ExecutablePath)
            Dim imagePath As String = Path.Combine(debugFolderPath, TextBox5.Text)
            PictureBox1.Image.Save(imagePath)
            MessageBox.Show("Image saved to project folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No image loaded to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            connection.Open()
            Dim qry As New String("INSERT INTO TBL_PRODUCT" &
            "(PRODUCT_ID, PRODUCT_NAME, PRODUCT_DETAIL, PRODUCT_PRICE, PRODUCT_IMAGE, PRODUCT_QTY) VALUES" &
            "(?,?,?,?,?,?)")
            Dim command As New OleDbCommand(qry, connection)

            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            command.Parameters.AddWithValue("?", TextBox2.Text)
            command.Parameters.AddWithValue("?", TextBox3.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox4.Text))
            command.Parameters.AddWithValue("?", TextBox5.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox6.Text))

            Dim res = command.ExecuteNonQuery()

            If (res >= 1) Then
                'MsgBox("Data inserted")
                fillDataGridView()
            End If


            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim debugFolderPath As String = Path.GetDirectoryName(Application.ExecutablePath)
            Dim imagePath As String = Path.Combine(debugFolderPath, TextBox5.Text)
            PictureBox1.Image.Save(imagePath)
            MessageBox.Show("Image saved to project folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No image loaded to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            connection.Open()
            Dim qry As New String("Update TBL_PRODUCT" &
            "SET PRODUCT_NAME=?, PRODUCT_DETAIL=?, PRODUCT_PRICE=?, PRODUCT_IMAGE=? WHERE PRODUCT_ID=?")
            Dim command As New OleDbCommand(qry, connection)

            command.Parameters.AddWithValue("?", TextBox2.Text)
            command.Parameters.AddWithValue("?", TextBox3.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox4.Text))
            command.Parameters.AddWithValue("?", TextBox5.Text)
            command.Parameters.AddWithValue("?", CInt(TextBox6.Text))
            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))

            Dim res = command.ExecuteNonQuery()

            If (res >= 1) Then
                'MsgBox("Data inserted")
                fillDataGridView()
            End If

            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection.Open()
            Dim qry As New String("DELETE FROM TBL_PRODUCT" &
            " WHERE PRODUCT_ID=?")
            Dim command As New OleDbCommand(qry, connection)

            command.Parameters.AddWithValue("?", CInt(TextBox1.Text))

            Dim res = command.ExecuteNonQuery()

            If (res >= 1) Then
                'MsgBox("Data inserted")
                fillDataGridView()
            End If


            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If TextBox7.Text = row.Cells(1).Value Then
                MsgBox("At row =" & row.Index.ToString)
            End If
        Next

    End Sub
End Class