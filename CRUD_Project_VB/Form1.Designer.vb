<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Textproductid = New TextBox()
        Textitemname = New TextBox()
        Textdesign = New TextBox()
        Combocolor = New ComboBox()
        DateTimePickerinsert = New DateTimePicker()
        Radioallowed = New RadioButton()
        Radionotallowed = New RadioButton()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Label8 = New Label()
        TextBoxPrice = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(24, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(539, 57)
        Label1.TabIndex = 0
        Label1.Text = "Computer Parts Inventory"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(78, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 1
        Label2.Text = "Product ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(78, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 28)
        Label3.TabIndex = 2
        Label3.Text = "Item Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(78, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 28)
        Label4.TabIndex = 3
        Label4.Text = "Design"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(78, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 28)
        Label5.TabIndex = 4
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(78, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 28)
        Label6.TabIndex = 5
        Label6.Text = "Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(78, 293)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 28)
        Label7.TabIndex = 6
        Label7.Text = "Warranty"
        ' 
        ' Textproductid
        ' 
        Textproductid.Font = New Font("Segoe UI", 10F)
        Textproductid.Location = New Point(197, 90)
        Textproductid.Name = "Textproductid"
        Textproductid.Size = New Size(366, 30)
        Textproductid.TabIndex = 7
        ' 
        ' Textitemname
        ' 
        Textitemname.Font = New Font("Segoe UI", 10F)
        Textitemname.Location = New Point(197, 130)
        Textitemname.Name = "Textitemname"
        Textitemname.Size = New Size(366, 30)
        Textitemname.TabIndex = 8
        ' 
        ' Textdesign
        ' 
        Textdesign.Font = New Font("Segoe UI", 10F)
        Textdesign.Location = New Point(197, 173)
        Textdesign.Name = "Textdesign"
        Textdesign.Size = New Size(366, 30)
        Textdesign.TabIndex = 9
        ' 
        ' Combocolor
        ' 
        Combocolor.Font = New Font("Segoe UI", 10F)
        Combocolor.FormattingEnabled = True
        Combocolor.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Brown"})
        Combocolor.Location = New Point(197, 219)
        Combocolor.Name = "Combocolor"
        Combocolor.Size = New Size(366, 31)
        Combocolor.TabIndex = 10
        ' 
        ' DateTimePickerinsert
        ' 
        DateTimePickerinsert.Font = New Font("Segoe UI", 10F)
        DateTimePickerinsert.Format = DateTimePickerFormat.Short
        DateTimePickerinsert.Location = New Point(197, 256)
        DateTimePickerinsert.Name = "DateTimePickerinsert"
        DateTimePickerinsert.Size = New Size(366, 30)
        DateTimePickerinsert.TabIndex = 11
        ' 
        ' Radioallowed
        ' 
        Radioallowed.AutoSize = True
        Radioallowed.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Radioallowed.ForeColor = SystemColors.ButtonFace
        Radioallowed.Location = New Point(197, 298)
        Radioallowed.Name = "Radioallowed"
        Radioallowed.Size = New Size(97, 27)
        Radioallowed.TabIndex = 12
        Radioallowed.TabStop = True
        Radioallowed.Text = "Allowed"
        Radioallowed.UseVisualStyleBackColor = True
        ' 
        ' Radionotallowed
        ' 
        Radionotallowed.AutoSize = True
        Radionotallowed.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Radionotallowed.ForeColor = SystemColors.ButtonFace
        Radionotallowed.Location = New Point(300, 298)
        Radionotallowed.Name = "Radionotallowed"
        Radionotallowed.Size = New Size(132, 27)
        Radionotallowed.TabIndex = 13
        Radionotallowed.TabStop = True
        Radionotallowed.Text = "Not Allowed"
        Radionotallowed.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(116, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 41)
        Button1.TabIndex = 14
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 425)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1151, 295)
        DataGridView1.TabIndex = 15
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSlateGray
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(284, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 41)
        Button2.TabIndex = 16
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(452, 378)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 41)
        Button3.TabIndex = 17
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(78, 334)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 28)
        Label8.TabIndex = 18
        Label8.Text = "Price"
        ' 
        ' TextBoxPrice
        ' 
        TextBoxPrice.Font = New Font("Segoe UI", 10F)
        TextBoxPrice.Location = New Point(197, 336)
        TextBoxPrice.Name = "TextBoxPrice"
        TextBoxPrice.Size = New Size(366, 30)
        TextBoxPrice.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1175, 732)
        Controls.Add(TextBoxPrice)
        Controls.Add(Label8)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Radionotallowed)
        Controls.Add(Radioallowed)
        Controls.Add(DateTimePickerinsert)
        Controls.Add(Combocolor)
        Controls.Add(Textdesign)
        Controls.Add(Textitemname)
        Controls.Add(Textproductid)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Textproductid As TextBox
    Friend WithEvents Textitemname As TextBox
    Friend WithEvents Textdesign As TextBox
    Friend WithEvents Combocolor As ComboBox
    Friend WithEvents DateTimePickerinsert As DateTimePicker
    Friend WithEvents Radioallowed As RadioButton
    Friend WithEvents Radionotallowed As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPrice As TextBox

End Class
