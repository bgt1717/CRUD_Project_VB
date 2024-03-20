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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Alloweda = New RadioButton()
        RadioButton1 = New RadioButton()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(28, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 28)
        Label1.TabIndex = 0
        Label1.Text = "CRUD OPERATIONS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(28, 88)
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
        Label3.Location = New Point(28, 130)
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
        Label4.Location = New Point(28, 173)
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
        Label5.Location = New Point(28, 217)
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
        Label6.Location = New Point(28, 267)
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
        Label7.Location = New Point(28, 309)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 28)
        Label7.TabIndex = 6
        Label7.Text = "Warranty Type"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(197, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(366, 30)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(197, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(366, 30)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10F)
        TextBox3.Location = New Point(197, 173)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(366, 30)
        TextBox3.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Brown"})
        ComboBox1.Location = New Point(197, 219)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(366, 31)
        ComboBox1.TabIndex = 10
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 10F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(197, 267)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(366, 30)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Alloweda
        ' 
        Alloweda.AutoSize = True
        Alloweda.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Alloweda.ForeColor = SystemColors.ButtonFace
        Alloweda.Location = New Point(197, 314)
        Alloweda.Name = "Alloweda"
        Alloweda.Size = New Size(97, 27)
        Alloweda.TabIndex = 12
        Alloweda.TabStop = True
        Alloweda.Text = "Allowed"
        Alloweda.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        RadioButton1.ForeColor = SystemColors.ButtonFace
        RadioButton1.Location = New Point(309, 314)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(132, 27)
        RadioButton1.TabIndex = 13
        RadioButton1.TabStop = True
        RadioButton1.Text = "Not Allowed"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(197, 347)
        Button1.Name = "Button1"
        Button1.Size = New Size(296, 41)
        Button1.TabIndex = 14
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 394)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(979, 240)
        DataGridView1.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1003, 646)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(RadioButton1)
        Controls.Add(Alloweda)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Alloweda As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
