Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaring Variables
        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
                TextBox2.Text = "High Distinction"

            Case "A-"
                TextBox2.Text = "Distinction"

            Case "C"
                TextBox2.Text = "Credit"

            Case "D"
                TextBox2.Text = "Pass"

            Case "E"
                TextBox2.Text = "fail"

            Case Else
                TextBox2.Text = "Fail"

        End Select

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
