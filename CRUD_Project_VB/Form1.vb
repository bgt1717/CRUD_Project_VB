Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=(localdb)\Local;Initial Catalog=ProgrammingDB;Integrated Security=True;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer = Textproductid.Text
        Dim iname As String = Textitemname.Text
        Dim design As String = Textdesign.Text
        Dim color As String = Combocolor.Text
        Dim insertdate As DateTime = DateTimePickerinsert.Value
        Dim wtype As String = If(Radioallowed.Checked, "Allowed", "Not Allowed")

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
End Class

