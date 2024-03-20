Imports System.Data.SqlClient


Public Class Form1
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
        Dim con As New SqlConnection("Data Source=(localdb)\Local;Initial Catalog=ProgrammingDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
        con.Open()
        Dim command As New SqlCommand("Insert into Product_Setup_Tab values()")
    End Sub
End Class
