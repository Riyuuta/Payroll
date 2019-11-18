Public Class LoadingScreen1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        ProgressBar1.Maximum = (100)
        ProgressBar1.Minimum = 0
        Label2.Text = ProgressBar1.Value & "%)"
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            THEPAYROLLFORM.Show()
            Timer1.Stop()

        End If



    End Sub

    Private Sub LoadingScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SendToBack()
        Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)
        Label3.BackColor = Color.Transparent

        Timer1.Start()
        Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)

        Label1.BackColor = Color.Transparent




    End Sub
End Class