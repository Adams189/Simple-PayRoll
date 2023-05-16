Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click, ACTIONSToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click, ACTIONSToolStripMenuItem.Click


        nameTextBox.Clear()
        deptTextBox.Clear()
        hoursTextBox.Clear()
        payRateTextBox.Clear()
        grossPayTextBox.Clear()
        taxTextBox.Clear()
        deductionTextBox.Clear()
        netPayTextBox.Clear()
        healthCheckBox.Checked = False
        lifeCheckBox.Checked = False
        carCheckBox.Checked = False
        ssnitRadioButton.Checked = False
        privateRadioButton.Checked = False
        noPensionRadioButton.Checked = False




    End Sub

    Private Sub computeButton_Click(sender As Object, e As EventArgs) Handles computeButton.Click, ComputeToolStripMenuItem.Click
        Dim iHours, iRate, iGross As Integer
        Const taxRate1 As Decimal = 0.05
        Const taxRate2 As Decimal = 0.1
        Dim DecTaxx As Decimal
        Const iHealth As Integer = 100
        Const iLife As Integer = 50
        Const iCar As Integer = 20
        Dim iTotalDeduction As Integer
        Const DecSsnit As Decimal = 0.05
        Const DecPrivate As Decimal = 0.1
        Dim DecNetPay As Decimal



        iHours = Integer.Parse(hoursTextBox.Text, Globalization.NumberStyles.Integer)
        iRate = Integer.Parse(payRateTextBox.Text, Globalization.NumberStyles.Integer)

        If iHours <= 100 Then iGross = iHours * iRate Else iGross = (iHours * 100) + (iHours - 100) * (iRate * 2)

        grossPayTextBox.Text = iGross.ToString

        If iGross <= 1000 Then DecTaxx = iGross * taxRate1 Else DecTaxx = iGross * taxRate2

        taxTextBox.Text = DecTaxx.ToString

        If lifeCheckBox.Checked Then iTotalDeduction += iLife
        If healthCheckBox.Checked Then iTotalDeduction += iHealth
        If carCheckBox.Checked Then iTotalDeduction += iCar



        If ssnitRadioButton.Checked Then
            iTotalDeduction += DecSsnit * iGross
        Else
            If privateRadioButton.Checked Then
                iTotalDeduction += DecPrivate * iGross
            Else

            End If
        End If
        deductionTextBox.Text = iTotalDeduction.ToString

        DecNetPay = iGross - (DecTaxx + iTotalDeduction)

        netPayTextBox.Text = DecNetPay.ToString



    End Sub

    Private Sub ComputeToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComputeToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click

        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color


    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font

    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        Dim MessageString As String = "This Program was develoed by Mahama Adams, An Intelligent and Brilliant BIT Student in KNUST" & ControlChars.NewLine & "Today's Date/Time: " & Date.Now.ToString
        Dim TittleString As String = "About the PAyroll Application"

        'Display Output
        MessageBox.Show(MessageString, TittleString, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Private Sub nameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles nameTextBox.Validating
        If nameTextBox.Text = String.Empty Then
            e.Cancel = True
            ErrorProvider1.SetError(nameTextBox, "Please Name is Required")
        End If
        ErrorProvider1.SetError(nameTextBox, "")
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged

    End Sub
End Class
