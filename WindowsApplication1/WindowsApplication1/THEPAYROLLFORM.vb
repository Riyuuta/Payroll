Public Class THEPAYROLLFORM
    Dim sss, philhealth, pagibig, netpay, hol, ot As Single
    Dim pesos_total, pesos_gross, pesos_contrib As Single



    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub THEPAYROLLFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load













        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.FromArgb(39, 174, 96)

        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.FromArgb(39, 174, 96)

        Button3.FlatStyle = FlatStyle.Flat
        Button3.BackColor = Color.FromArgb(39, 174, 96)

        Button4.FlatStyle = FlatStyle.Flat
        Button4.BackColor = Color.FromArgb(39, 174, 96)










        Try
            Label11.Text = CREATE_ACCOUNT.TextBox1.Text
            Label12.Text = CREATE_ACCOUNT.TextBox5.Text + " " + CREATE_ACCOUNT.TextBox6.Text + " " + CREATE_ACCOUNT.TextBox4.Text








        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rateperhour = 56.29
        Dim daysofwork = TextBox1.Text
        Dim overtime = TextBox2.Text
        Dim holiday = TextBox3.Text
        Dim rateperday = 490

        Try 'FOR NORMAL SALARY'

            Label17.Text = daysofwork

            pesos_total = rateperday * daysofwork
            Label18.Text = pesos_total.ToString("0,0")

            pesos_gross = Label18.Text
            Label24.Text = pesos_gross.ToString("0,0")

            sss = pesos_gross * 0.11 'SSS'
            pagibig = pesos_gross / 40 'PAGIBIG'
            philhealth = pesos_gross * 0.04 'PHILHEALTH'

            Label30.Text = sss.ToString("0,0")
            Label31.Text = pagibig.ToString("0,0")
            Label32.Text = philhealth.ToString("0,0")

            pesos_contrib = sss + pagibig + philhealth

            Label33.Text = pesos_contrib.ToString("0,0")

            netpay = pesos_contrib - pesos_gross
            Label34.Text = netpay.ToString("0,0")

            If CheckBox1.Checked = True Then
                'FOR OVERTIME'
                Label17.Text = daysofwork
                ot = rateperhour * overtime
                Label23.Text = ot.ToString("0,0")

                pesos_total = rateperday + daysofwork + ot
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + ot
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + ot
                Label24.Text = pesos_gross.ToString("0,)")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                Label30.Text = sss.ToString("0,0")
                Label31.Text = pagibig.ToString("0,0")
                Label32.Text = philhealth.ToString("0,0")

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = netpay.ToString("0,0")

            ElseIf ComboBox1.Text = "January" Then
                'FOR HOLIDAY UPTO END'
                Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH"

                If TextBox3.Text > 1 Then
                    MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS")

                    Label17.Text = daysofwork

                    pesos_total = rateperhour * daysofwork
                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = Label18.Text
                    Label24.Text = pesos_gross.ToString("0,0")
                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_contrib - pesos_gross
                    Label34.Text = netpay.ToString("0,0")
                    Return


                End If

                hol = 490 * holiday
                Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                Label18.Text = daysofwork

                pesos_total = rateperday * daysofwork + hol
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + hol
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = netpay.ToString("0,0")

            ElseIf ComboBox1.Text = "February" Then
                Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH."
                If TextBox3.Text > 2 Then
                    MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                    Label17.Text = daysofwork
                    pesos_total = rateperday * daysofwork

                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = Label18.Text
                    Label24.Text = pesos_gross.ToString("0,0")
                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_contrib - pesos_gross
                    Label34.Text = netpay.ToString("0,0")


                End If

                hol = 490 * holiday
                Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                Label18.Text = daysofwork

                pesos_total = rateperday * daysofwork + hol
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + hol
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = netpay.ToString("0,0")

            ElseIf ComboBox1.Text = "March" Then

                Label10.Text = "THERE IS 3 HOLIDAY ON THIS MONTH."

                If TextBox3.Text > 3 Then
                    MsgBox("THERE IS 3 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                    Label17.Text = daysofwork
                    pesos_total = rateperday * daysofwork

                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = Label18.Text
                    Label24.Text = pesos_gross.ToString("0,0")
                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_contrib - pesos_gross
                    Label34.Text = netpay.ToString("0,0")
                    Return

                End If

                hol = 490 * holiday
                Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                Label18.Text = daysofwork

                pesos_total = rateperday * daysofwork + hol
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + hol
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = netpay.ToString("0,0")

            ElseIf ComboBox1.Text = "April" Then
                Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."

                If TextBox3.Text > 1 Then
                    MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                    Label17.Text = daysofwork
                    pesos_total = rateperday * daysofwork

                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = Label18.Text
                    Label24.Text = pesos_gross.ToString("0,0")
                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_contrib - pesos_gross
                    Label34.Text = netpay.ToString("0,0")
                    Return


                End If

                hol = 490 * holiday
                Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                Label18.Text = daysofwork

                pesos_total = rateperday * daysofwork + hol
                Label18.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + hol
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = netpay.ToString("0,0")

            ElseIf ComboBox1.Text = "May" Then
                Label10.Text = ("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                Label18.Text = daysofwork

                pesos_total = rateperday * daysofwork
                Label18.Text = pesos_total

                pesos_gross = Label18.Text
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                Label30.Text = sss.ToString("0,0")
                Label31.Text = pagibig.ToString("0,0")
                Label32.Text = philhealth.ToString("0,0")

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_total - pesos_contrib
                Label34.Text = netpay.ToString("0,0")
                Return

                hol = 490 * holiday
                Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                Label17.Text = daysofwork
                pesos_total = rateperday * daysofwork + hol
                Label8.Text = pesos_total.ToString("0,0")

                pesos_gross = pesos_total + hol
                Label24.Text = pesos_gross.ToString("0,0")

                sss = pesos_gross * 0.11 'SSS'
                pagibig = pesos_gross / 40 'PAGIBIG'
                philhealth = pesos_gross * 0.04 'PHILHEALTH'

                pesos_contrib = sss + pagibig + philhealth

                Label33.Text = pesos_contrib.ToString("0,0")

                netpay = pesos_gross - pesos_contrib
                Label34.Text = pesos_contrib.ToString("0,0")

            ElseIf ComboBox1.Text = "May" Then
                Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."

                If TextBox3.Text > 1 Then
                    MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                    Label18.Text = daysofwork

                    pesos_total = rateperday * daysofwork
                    Label18.Text = pesos_total

                    pesos_gross = Label18.Text
                    Label24.Text = pesos_gross.ToString("0,0")

                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_total - pesos_contrib
                    Label34.Text = netpay.ToString("0,0")
                    Return

                    hol = 490 * holiday
                    Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                    Label17.Text = daysofwork
                    pesos_total = rateperday * daysofwork + hol
                    Label8.Text = pesos_total.ToString("0,0")

                    pesos_gross = pesos_total + hol
                    Label24.Text = pesos_gross.ToString("0,0")

                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    pesos_contrib = sss + pagibig + philhealth

                    Label33.Text = pesos_contrib.ToString("0,0")

                    netpay = pesos_gross - pesos_contrib
                    Label34.Text = pesos_contrib.ToString("0,0")

                ElseIf ComboBox1.Text = "June" Then
                    Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."

                    If TextBox3.Text > 1 Then
                        MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")

                        Label18.Text = daysofwork

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total

                        pesos_gross = Label18.Text
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")
                        Return

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                        Label17.Text = daysofwork
                        pesos_total = rateperday * daysofwork + hol
                        Label8.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = pesos_contrib.ToString("0,0")

                    ElseIf ComboBox1.Text = "July" Then
                        Label10.Text = ("THERE IS NO HOLIDAY ON THIS MONTH.")

                        Label17.Text = daysofwork

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = Label18.Text
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf ComboBox1.Text = "August" Then
                        Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH."

                        If TextBox3.Text > 2 Then
                            MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")
                            Label18.Text = daysofwork

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total

                            pesos_gross = Label18.Text
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return

                        End If

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                        Label18.Text = daysofwork

                        pesos_total = rateperday * daysofwork + hol
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                    ElseIf ComboBox1.Text = "September" Then
                        Label10.Text = "THERE IS NO HOLIDAY ON THIS MONTH."

                        Label17.Text = daysofwork

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = Label18.Text
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf ComboBox1.Text = "October" Then
                        Label22.Text = "THERE IS NO HOLIDAY ON THIS MONTH."

                        Label17.Text = daysofwork

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = Label18.Text
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf ComboBox1.Text = "November" Then
                        Label10.Text = "THERE IS 2 HOLIDAY ONTHIS MONTH."

                        If TextBox3.Text > 2 Then
                            MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")
                            Label18.Text = daysofwork

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total

                            pesos_gross = Label18.Text
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                        Label18.Text = daysofwork

                        pesos_total = rateperday * daysofwork + hol
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                    ElseIf ComboBox1.Text = "December" Then
                        Label10.Text = ("THERE IS 2 HOLIDAY ON THIS MONTH.")

                        If TextBox3.Text > 2 Then
                            MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED W/O HOLIDAY BONUS.")
                            Label18.Text = daysofwork

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total

                            pesos_gross = Label18.Text
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") 'HOLIDAY'

                        Label18.Text = daysofwork

                        pesos_total = rateperday * daysofwork + hol
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")
                        'END WE HOLIDAY W/O OVERTIME'




                    End If
                    If CheckBox1.Checked = True AndAlso ComboBox1.Text = "January" Then
                        Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."

                        If TextBox3.Text > 1 Then
                            MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")

                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return

                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "February" Then
                        Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH."

                        If TextBox3.Text > 2 Then
                            MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return

                        End If

                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "March" Then
                        Label10.Text = "THERE IS 3 HOLIDAY ON THIS MONTH."
                        If TextBox3.Text > 3 Then
                            MsgBox("THERE IS 3 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVER BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return

                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "April" Then
                        Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."
                        If TextBox3.Text > 1 Then
                            MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "May" Then
                        Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH"
                        If TextBox3.Text > 1 Then
                            MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "June" Then
                        Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."
                        If TextBox3.Text > 1 Then
                            MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "July" Then
                        Label10.Text = "THERE IS 1 HOLIDAY ON THIS MONTH."

                        If TextBox3.Text > 1 Then
                            MsgBox("THERE IS 1 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "August" Then
                        Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH"
                        If TextBox3.Text > 2 Then
                            MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return
                        End If
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        hol = 490 * holiday
                        Label22.Text = hol.ToString("0,0") * holiday

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot + hol
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "SEPTEMBER" Then
                        Label10.Text = "THERE IS NO HOLIDAY ON THIS MONTH"
                        If TextBox3.Text > "" Then
                            MsgBox("THERE IS NO HOLIDAY IN THIS MONTH. IT CALCULATED WITH OVERTIME.")
                            Label17.Text = daysofwork

                            ot = rateperhour * overtime
                            Label23.Text = ot.ToString("0,0")

                            pesos_total = rateperday * daysofwork
                            Label18.Text = pesos_total.ToString("0,0")

                            pesos_gross = pesos_total + ot
                            Label24.Text = pesos_gross.ToString("0,0")

                            sss = pesos_gross * 0.11 'SSS'
                            pagibig = pesos_gross / 40 'PAGIBIG'
                            philhealth = pesos_gross * 0.04 'PHILHEALTH'

                            Label30.Text = sss.ToString("0,0")
                            Label31.Text = pagibig.ToString("0,0")
                            Label32.Text = philhealth.ToString("0,0")

                            pesos_contrib = sss + pagibig + philhealth

                            Label33.Text = pesos_contrib.ToString("0,0")

                            netpay = pesos_total - pesos_contrib
                            Label34.Text = netpay.ToString("0,0")
                            Return



                        End If
                        Label17.Text = daysofwork
                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")
                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        netpay = pesos_gross - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")

                    ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "October" Then
                        Label10.Text = "THERE IS NO HOLIDAY ON THIS MONTH"
                        If TextBox3.Text > "" Then

                        End If
                        MsgBox("THERE IS NO HOLIDAY IN THIS MONTH. IT CALCULATED WITH OVERTIME.")
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")
                        Return

                    End If
                    Label17.Text = daysofwork
                    ot = rateperhour * overtime
                    Label23.Text = ot.ToString("0,0")
                    pesos_total = rateperday * daysofwork
                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = pesos_total + ot
                    Label24.Text = pesos_gross.ToString("0,0")

                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    netpay = pesos_gross - pesos_contrib
                    Label34.Text = netpay.ToString("0,0")

                ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "November" Then
                    Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH."
                    If TextBox3.Text > 2 Then
                        MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS.")
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")
                        Return

                    End If
                    Label17.Text = daysofwork

                    ot = rateperhour * overtime
                    Label23.Text = ot.ToString("0,0")

                    hol = 490 * holiday
                    Label22.Text = hol.ToString("0,0") * holiday

                    pesos_total = rateperday * daysofwork
                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = pesos_total + ot + hol
                    Label24.Text = pesos_gross.ToString("0,0")

                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    netpay = pesos_gross - pesos_contrib
                    Label34.Text = netpay.ToString("0,0")

                ElseIf CheckBox1.Checked = True AndAlso ComboBox1.Text = "December" Then
                    Label10.Text = "THERE IS 2 HOLIDAY ON THIS MONTH"
                    If TextBox3.Text > 2 Then
                        MsgBox("THERE IS 2 HOLIDAY ON THIS MONTH. IT CALCULATED WITH OVERTIME BUT W/O HOLIDAY BONUS")
                        Label17.Text = daysofwork

                        ot = rateperhour * overtime
                        Label23.Text = ot.ToString("0,0")

                        pesos_total = rateperday * daysofwork
                        Label18.Text = pesos_total.ToString("0,0")

                        pesos_gross = pesos_total + ot
                        Label24.Text = pesos_gross.ToString("0,0")

                        sss = pesos_gross * 0.11 'SSS'
                        pagibig = pesos_gross / 40 'PAGIBIG'
                        philhealth = pesos_gross * 0.04 'PHILHEALTH'

                        Label30.Text = sss.ToString("0,0")
                        Label31.Text = pagibig.ToString("0,0")
                        Label32.Text = philhealth.ToString("0,0")

                        pesos_contrib = sss + pagibig + philhealth

                        Label33.Text = pesos_contrib.ToString("0,0")

                        netpay = pesos_total - pesos_contrib
                        Label34.Text = netpay.ToString("0,0")
                        Return

                    End If
                    Label17.Text = daysofwork

                    ot = rateperhour * overtime
                    Label23.Text = ot.ToString("0,0")

                    hol = 490 * holiday
                    Label22.Text = hol.ToString("0,0") * holiday

                    pesos_total = rateperday * daysofwork
                    Label18.Text = pesos_total.ToString("0,0")

                    pesos_gross = pesos_total + ot + hol
                    Label24.Text = pesos_gross.ToString("0,0")

                    sss = pesos_gross * 0.11 'SSS'
                    pagibig = pesos_gross / 40 'PAGIBIG'
                    philhealth = pesos_gross * 0.04 'PHILHEALTH'

                    Label30.Text = sss.ToString("0,0")
                    Label31.Text = pagibig.ToString("0,0")
                    Label32.Text = philhealth.ToString("0,0")

                    pesos_contrib = sss + pagibig + philhealth

                    netpay = pesos_gross - pesos_contrib
                    Label34.Text = netpay.ToString("0,0")


                End If





            End If










        Catch ex As Exception

        End Try






















    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        Label24.Text = ""
        Label30.Text = ""
        Label31.Text = ""
        Label32.Text = ""
        Label33.Text = ""
        Label34.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        printForm.Show()



    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label35_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class