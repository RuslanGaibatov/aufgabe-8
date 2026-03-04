Public Class Form1

    Private Sub btnQuadrat_Click(sender As Object, e As EventArgs) Handles btnQuadrat.Click
        lblQuadrat.Text = ""
        Dim unten As Double = CDbl(txtUnten.Text)
        Dim q As New CQuadrat(unten)
        Dim flaeche As Double = q.BerechneFlaeche(unten)
        lblQuadrat.Text = "Die Quadratfläche beträgt " & flaeche & " cm²"
        txtUnten.Focus()
    End Sub

    Private Sub btnVolumen_Click(sender As Object, e As EventArgs) Handles btnVolumen.Click
        lblVolumen.Text = ""
        Dim unten As Double = CDbl(txtUnten.Text)
        Dim oben As Double = CDbl(txtOben.Text)
        Dim hoehe As Double = CDbl(txtHoehe.Text)
        Dim p As New CPyramidenstumpf(unten, oben, hoehe)
        Dim volumen As Double = p.BerechneVolumen()
        lblVolumen.Text = "Das Pyramidenstumpfvolumen beträgt " & volumen & " cm³"
        txtUnten.Focus()
    End Sub

    Private Sub btnLeeren_Click(sender As Object, e As EventArgs) Handles btnLeeren.Click
        txtUnten.Clear()
        txtOben.Clear()
        txtHoehe.Clear()
        lblQuadrat.Text = ""
        lblVolumen.Text = ""
        txtUnten.Focus()
    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        Me.Close()
    End Sub

End Class
