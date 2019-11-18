Public Class CREATE_ACCOUNT

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Loginform.Show()
        Me.Close()

        








    End Sub

    Private Sub CREATE_ACCOUNT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.SendToBack()

        Button3.FlatStyle = FlatStyle.Flat
        Button3.BackColor = Color.FromArgb(39, 174, 96)

        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.FromArgb(39, 174, 96)



        TextBox1.BackColor = Color.Gray
        TextBox2.BackColor = Color.Gray
        TextBox3.BackColor = Color.Gray
        TextBox4.BackColor = Color.Gray
        TextBox5.BackColor = Color.Gray
        TextBox6.BackColor = Color.Gray

        TextBox1.ForeColor = Color.Yellow
        TextBox2.ForeColor = Color.Yellow
        TextBox3.ForeColor = Color.Yellow
        TextBox4.ForeColor = Color.Yellow
        TextBox5.ForeColor = Color.Yellow
        TextBox6.ForeColor = Color.Yellow











    End Sub


    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'THIS BUTTON HAS TEMPORARY DATABASE FOR INFORMATION OF THE CLIENT

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then
            MsgBox("PLEASE FILL UP THE FORM")
            Return
        End If

        Try
            label1.Text = TextBox1.Text
            Label2.Text = TextBox2.Text
            Label3.Text = TextBox3.Text
            Label4.Text = TextBox4.Text
            Label5.Text = TextBox5.Text
            Label6.Text = TextBox6.Text

            If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Then

                MsgBox("PLEASE COMLETE UP THE FORM")

                Return

            End If

            Loginform.Show()
            Me.Hide()


        Catch ex As Exception

        End Try
      

            
    End Sub
End Class