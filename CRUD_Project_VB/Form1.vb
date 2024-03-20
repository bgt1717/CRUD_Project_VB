Imports System.Data.SqlClient


Public Class Form1
    Dim con As New SqlConnection("Data Source=(localdb)\Local;Initial Catalog=ProgrammingDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer = Textproductid.Text
        Dim iname As String = Textitemname.Text
        Dim design As String = Textdesign.Text
        Dim color As String = Combocolor.Text
        Dim insertdate As DateTime = DateTimePickerinsert.Text
        Dim wtype As String = ""
        If Radioallowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "Not Allowed"
        End If

        con.Open()
        Dim command As New SqlCommand("Insert into Product_Setup_Tab values('" & pid & "','" & iname & "','" & design & "','" & color & "','" & insertdate & "','" & wtype & "',)", con)
        command.ExecuteNonQuery()
        MessageBox.Show("Submission Successful")
    End Sub
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Product_Setup_Tab")
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        DataGridView1.DataSource = dt
    End Sub
End Class
