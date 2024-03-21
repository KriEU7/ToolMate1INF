Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Area.Checked Then
            MessageBox.Show(TextBox1.Text * TextBox1.Text, "Risultato")
            TextBox1.Text = ""
        End If
        If Perimetro.Checked Then
            MessageBox.Show(TextBox1.Text * 4, "Risultato")
            TextBox1.Text = ""
        End If
    End Sub
End Class
