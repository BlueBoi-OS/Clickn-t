Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Form5.Show()
            Me.Hide()
        Else
            MessageBox.Show("Agreement not checked", "Program Closing")
        End If
    End Sub
End Class