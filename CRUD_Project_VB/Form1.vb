Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=(localdb)\Local;Initial Catalog=ProgrammingDB;Integrated Security=True;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer
        If Integer.TryParse(Textproductid.Text, pid) Then
            Dim iname = Textitemname.Text
            Dim design = Textdesign.Text
            Dim color = Combocolor.Text
            Dim insertdate = DateTimePickerinsert.Value
            Dim wtype = If(Radioallowed.Checked, "Allowed", "Not Allowed")

            con.Open()
            Dim command As New SqlCommand("INSERT INTO Product_Setup_Tab VALUES(@pid, @iname, @design, @color, @insertdate, @wtype)", con)
            command.Parameters.AddWithValue("@pid", pid)
            command.Parameters.AddWithValue("@iname", iname)
            command.Parameters.AddWithValue("@design", design)
            command.Parameters.AddWithValue("@color", color)
            command.Parameters.AddWithValue("@insertdate", insertdate)
            command.Parameters.AddWithValue("@wtype", wtype)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Submission Successful")
            LoadDataInGrid()
        Else
            MessageBox.Show("Please enter a valid integer value for Product ID.")
        End If
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("SELECT * FROM Product_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pid As Integer
        If Integer.TryParse(Textproductid.Text, pid) Then
            Dim iname = Textitemname.Text
            Dim design = Textdesign.Text
            Dim color = Combocolor.Text
            Dim insertdate = DateTimePickerinsert.Value
            Dim wtype = If(Radioallowed.Checked, "Allowed", "Not Allowed")

            con.Open()
            Dim command As New SqlCommand("UPDATE Product_Setup_Tab SET ItemName = @iname, Design = @design, Color = @color, ItemDate = @insertdate, WarrantyType = @wtype WHERE Product_ID = @pid", con)
            command.Parameters.AddWithValue("@pid", pid)
            command.Parameters.AddWithValue("@iname", iname)
            command.Parameters.AddWithValue("@design", design)
            command.Parameters.AddWithValue("@color", color)
            command.Parameters.AddWithValue("@insertdate", insertdate)
            command.Parameters.AddWithValue("@wtype", wtype)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Updated")
            LoadDataInGrid()
        Else
            MessageBox.Show("Please enter a valid integer value for Product ID.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pid As Integer
        If Integer.TryParse(Textproductid.Text, pid) Then
            con.Open()
            Dim command As New SqlCommand("DELETE FROM Product_Setup_Tab WHERE Product_ID = @pid", con)
            command.Parameters.AddWithValue("@pid", pid)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            con.Close()
            LoadDataInGrid()
        Else
            MessageBox.Show("Please enter a valid integer value for Product ID.")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
