Public Class frmDollarToPesoConverter
    Private Sub btncvrt_Click(sender As Object, e As EventArgs) Handles btncvrt.Click
        Dim peso As Double

        peso = txtdl.Text * 51.5
        txtps.Text = peso
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtps.Clear()
        txtdl.Clear()

    End Sub
End Class