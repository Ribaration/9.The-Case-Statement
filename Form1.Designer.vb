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
        Button1 = New Button()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 21)
        Label1.TabIndex = 0
        Label1.Text = "Enter the Grade letter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(87, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 30)
        Label2.TabIndex = 1
        Label2.Text = "Results"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(78, 236)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 69)
        Button1.TabIndex = 2
        Button1.Text = "Compute!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(245, 136)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 23)
        TextBox2.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"A", "A-", "B", "C", "D"})
        ComboBox1.Location = New Point(245, 74)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(104, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(686, 450)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Grade Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox

End Class
