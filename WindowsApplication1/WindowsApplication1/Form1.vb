Public Class Loginform

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.SendToBack()



        TextBox1.BackColor = Color.Gray
        TextBox2.BackColor = Color.Gray

        TextBox1.ForeColor = Color.Yellow
        TextBox2.ForeColor = Color.Yellow

        Button3.FlatStyle = FlatStyle.Flat
        Button3.BackColor = Color.FromArgb(39, 174, 96)

        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.FromArgb(39, 174, 96)

        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.FromArgb(39, 174, 96)



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then

            MsgBox("Can't Login, PLEASE INPUT YOUR USERNAME AND PASSWORD")
            Return

        End If

        If CREATE_ACCOUNT.TextBox1.Text = Me.TextBox1.Text Then
            CREATE_ACCOUNT.TextBox2.Text = Me.TextBox2.Text
            MsgBox("SUCCESSFULLY LOGIN")

            'ANOTHER FORM WILL SHOW.

        ElseIf Me.TextBox1.Text.ToUpper = "USR" And Me.TextBox2.Text.ToUpper = "PSS" Then
            MsgBox("SUCCESSFULLY LOGIN")
        Else
            MsgBox("WRONG USERNAME OR PASSWORD")
            Return


        End If
        Me.Hide()
        LoadingScreen1.Show()

        







    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        CREATE_ACCOUNT.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CREATE_ACCOUNT.Close()
        LoadingScreen1.Close()
        Me.Close()
        End

    End Sub
End Class
