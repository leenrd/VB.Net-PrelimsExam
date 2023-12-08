Public Class frmGradingApplication
    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtpt.Clear()
        txtqe.Clear()
        txtww.Clear()

    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim ww As Integer
        Dim pt As Integer
        Dim qt As Integer
        Dim Final As Integer

        ww = txtww.Text * 0.2
        pt = txtpt.Text * 0.6
        qt = txtqe.Text * 0.2
        Final = ww + pt + qt

        MsgBox("Written Works: " & ww & vbNewLine & "Performance Task: " & pt & vbNewLine & "Quarterly Exam: " & qt & vbNewLine & vbNewLine & "Final Grade: " & Final,, "RESULTS!")

    End Sub
End Class