'Niks Converter Program
'By Nikolas Karinja
'12/2/22

Imports System.ComponentModel

Public Class frmConversion

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim shoGal, shoFar, shoMiles, shoFeet As Short
        Dim sglLit, sglCel, sglKil, sglMtrs As Single

        'Trap for Errors

        Try

            'Get Values

            shoGal = CShort(txtGal.Text)
            shoFar = CShort(txtFar.Text)
            shoFeet = CShort(txtFeet.Text)
            shoMiles = CShort(txtMiles.Text)

            'Conversions

            'Gallons to Liters
            sglLit = shoGal * 3.785

            'Feet to meters
            sglMtrs = shoFeet * 0.3

            'Farenheit to Celsius
            sglCel = (shoFar - 32) * 5 / 9

            'Miles to Kilometers
            sglKil = shoMiles * 1.61

            'Display Results

            lblCel.Text = sglCel.ToString("0.0")
            lblKilo.Text = sglKil.ToString("0.0")
            lblMeters.Text = sglMtrs.ToString("0.0")
            lblLiters.Text = sglLit.ToString("0.0")

        Catch ex As Exception

            'Error Occurred

            MessageBox.Show("Please enter numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGal.Focus()

        End Try

    End Sub

    Private Sub txtGal_GotFocus(sender As Object, e As EventArgs) Handles txtGal.GotFocus

        'Select text when the Gallons textbox receives the focus
        txtGal.SelectAll()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Reset textboxes
        txtGal.Text = "0"
        txtFeet.Text = "0"
        txtFar.Text = "0"
        txtMiles.Text = "0"

        'Clear the labels
        lblCel.Text = ""
        lblKilo.Text = ""
        lblLiters.Text = ""
        lblMeters.Text = ""

        'Return the focus
        txtGal.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close and dispose of the form
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Conversion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'Prompt user, end program
        If MessageBox.Show("Exit Program?", "Converter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If

    End Sub

End Class
