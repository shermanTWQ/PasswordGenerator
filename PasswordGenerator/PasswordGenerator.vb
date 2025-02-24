Public Class PasswordGenerator
    'Password Generator 1.0
    'Provided for non-commercial use. Please refer to Github Repo for more information. 
    'Contact: Sherman_tan@outlook.com
    '(C) Tan Wei Qiang Sherman.
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim intRnd As Integer
        Dim intStep As Integer = Nothing
        Dim strname As String
        Dim intlength As Integer
        Dim strinputstring As String = ""
        Dim Numbers As String = "12345678901234567890"
        Dim Lower As String = "abcdefghijklmnopqrstuvwxyzyz"
        Dim Upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZYZ"
        Dim intnamelength As Integer = 1

        If chkUpper.Checked Then strinputstring &= Lower
        If chkLower.Checked Then strinputstring &= Numbers
        If chkNumbers.Checked Then strinputstring &= Upper

        intlength = Len(strinputstring)
        Integer.TryParse(txtNumber.Text, intnamelength)

        Randomize()
        strname = ""

        For inStep = 1 To intnamelength
            intRnd = Int(Rnd() * intlength) + 1
            strname = strname & Mid(strinputstring, intRnd, 1)
        Next
        txtOutput.Text = strname
    End Sub

    Private Sub chkUpper_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpper.CheckedChanged

    End Sub
End Class
