Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Dear person seeing this, please don't share the password shown below, instead keep it stored in your head and use clickn't your self!
        If TextBox2.Text = Form5.TextBox2.Text Then


            Form1.Timer2.Enabled = True
            TextBox2.Text = ""
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Password")

            Me.Hide()
            TextBox2.Text = ""
            Form1.Show()
        End If




    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
        If Not TextBox1.Text = "" Then
            TextBox2.Text = TextBox2.Text + TextBox1.Text
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        TextBox2.Text = ""
        Me.Hide()
    End Sub

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(TextBox1, "Input Password.")
        TextBox2.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Process.Start("C:\Windows\System32\taskkill.exe", "/IM taskmgr.exe")
    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class