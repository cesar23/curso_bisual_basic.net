Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Si" Then
            End
        Else
            MessageBox.Show("No")
        End If
    End Sub
End Class
