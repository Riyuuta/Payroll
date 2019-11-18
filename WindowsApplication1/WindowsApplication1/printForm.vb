Public Class printForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Print Payslip?", "PAYSLIP", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            MessageBox.Show("PRINT SUCCESSFULLY")

        End If



    End Sub

    Private Sub PRINT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.FromArgb(120, 0, 0, 0)
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent

        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White

        GroupBox2.BackColor = Color.FromArgb(120, 0, 0, 0)
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent

        Label5.ForeColor = Color.White
        Label6.ForeColor = Color.White
        Label7.ForeColor = Color.White
        Label8.ForeColor = Color.White
        Label9.ForeColor = Color.White
        Label10.ForeColor = Color.White

        GroupBox3.BackColor = Color.FromArgb(120, 0, 0, 0)
        Label11.BackColor = Color.Transparent
        Label12.BackColor = Color.Transparent
        Label13.BackColor = Color.Transparent
        Label14.BackColor = Color.Transparent
        Label15.BackColor = Color.Transparent
        Label16.BackColor = Color.Transparent

        Label11.ForeColor = Color.White
        Label12.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label14.ForeColor = Color.White
        Label15.ForeColor = Color.White
        Label16.ForeColor = Color.White

        GroupBox4.BackColor = Color.FromArgb(120, 0, 0, 0)
        Label17.BackColor = Color.Transparent
        Label18.BackColor = Color.Transparent
        Label19.BackColor = Color.Transparent
        Label20.BackColor = Color.Transparent
        Label21.BackColor = Color.Transparent
        Label22.BackColor = Color.Transparent
        Label23.BackColor = Color.Transparent
        Label24.BackColor = Color.Transparent
        Label25.BackColor = Color.Transparent
        Label26.BackColor = Color.Transparent

        Label17.ForeColor = Color.White
        Label18.ForeColor = Color.White
        Label19.ForeColor = Color.White
        Label20.ForeColor = Color.White
        Label21.ForeColor = Color.White
        Label22.ForeColor = Color.White
        Label23.ForeColor = Color.White
        Label24.ForeColor = Color.White
        Label25.ForeColor = Color.White
        Label26.ForeColor = Color.White

        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.FromArgb(39, 174, 96)
        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.FromArgb(39, 174, 96)





        Try
            Label3.Text = THEPAYROLLFORM.Label12.Text
            Label4.Text = THEPAYROLLFORM.Label11.Text
            Label9.Text = THEPAYROLLFORM.Label17.Text
            Label10.Text = THEPAYROLLFORM.Label18.Text
            Label14.Text = THEPAYROLLFORM.Label22.Text
            Label15.Text = THEPAYROLLFORM.Label23.Text
            Label16.Text = THEPAYROLLFORM.Label24.Text
            Label22.Text = THEPAYROLLFORM.Label30.Text
            Label23.Text = THEPAYROLLFORM.Label31.Text
            Label24.Text = THEPAYROLLFORM.Label32.Text
            Label25.Text = THEPAYROLLFORM.Label33.Text
            Label26.Text = THEPAYROLLFORM.Label34.Text



        Catch ex As Exception

        End Try

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintPreviewDialog1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub PrintPreviewControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Me.Activated
        If Loginform.TextBox1.Text = "USR" AndAlso Loginform.TextBox2.Text = "PSS" Then
            Me.Label2.Text = "GUEST"
            Me.Label3.Text = "GUEST"

            Label9.Text = THEPAYROLLFORM.Label17.Text
            Label10.Text = THEPAYROLLFORM.Label18.Text
            Label14.Text = THEPAYROLLFORM.Label22.Text
            Label15.Text = THEPAYROLLFORM.Label23.Text
            Label16.Text = THEPAYROLLFORM.Label24.Text
            Label22.Text = THEPAYROLLFORM.Label30.Text
            Label23.Text = THEPAYROLLFORM.Label31.Text
            Label24.Text = THEPAYROLLFORM.Label32.Text
            Label25.Text = THEPAYROLLFORM.Label33.Text
            Label26.Text = THEPAYROLLFORM.Label34.Text
        Else
            Label3.Text = CREATE_ACCOUNT.TextBox4.Text & "," & CREATE_ACCOUNT.TextBox5.Text & "," & CREATE_ACCOUNT.TextBox6.Text
            Label4.Text = CREATE_ACCOUNT.TextBox1.Text

            Label9.Text = THEPAYROLLFORM.Label17.Text
            Label10.Text = THEPAYROLLFORM.Label18.Text
            Label14.Text = THEPAYROLLFORM.Label22.Text
            Label15.Text = THEPAYROLLFORM.Label23.Text
            Label16.Text = THEPAYROLLFORM.Label24.Text
            Label22.Text = THEPAYROLLFORM.Label30.Text
            Label23.Text = THEPAYROLLFORM.Label31.Text
            Label24.Text = THEPAYROLLFORM.Label32.Text
            Label25.Text = THEPAYROLLFORM.Label33.Text
            Label26.Text = THEPAYROLLFORM.Label34.Text




        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        THEPAYROLLFORM.Show()

    End Sub
End Class