Public Class frmSalesTaxApplication
    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtaos.Clear()
    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim aos As Integer
        Dim vat As Double = 0.12
        Dim vatval As Double
        Dim gross As Integer

        aos = txtaos.Text
        vatval = aos * vat
        gross = aos + vatval

        MsgBox("Amount of Sales: " & aos & vbNewLine & "Value added tax: " & vatval & vbNewLine & "Total amount of Sales: " & gross, , "Results!!")
    End Sub
End Class
