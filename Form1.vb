Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnValidate_Click(sender As System.Object, e As System.EventArgs) Handles btnValidate.Click
        Dim regex As Regex = New Regex("(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$")

        'Verify whether date entered in dd/MM/yyyy format.
        Dim isValid As Boolean = regex.IsMatch(txtDate.Text.Trim)

        'Verify whether entered date is Valid date.
        Dim dt As DateTime
        isValid = DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", New CultureInfo("en-GB"), DateTimeStyles.None, dt)
        If Not isValid Then
            MessageBox.Show("Invalid Date.")
        End If
    End Sub
End Class
