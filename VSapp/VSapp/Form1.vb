Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged

    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim sumaTotal As Int16


        sumaTotal = Convert.ToInt16(txtNum1.Text) + Convert.ToInt16(txtNum2.Text)
        txtTotal.Text = sumaTotal
        MessageBox.Show(sumaTotal)








    End Sub

    Private Sub txtNum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim mostrarSuma As Int16

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcularFecha.Click
        Dim fechaInicio As Date = dtpFechaInicio.Value.ToShortDateString


        Dim fechaFinal As Date = dtpFechaFinal.Value.ToShortDateString


        Dim diferenciaDias As String = DateDiff(DateInterval.Day, fechaInicio, fechaFinal)

        MessageBox.Show(diferenciaDias)
        Label1.Visible = True
        Label1.Text = "Dieferencia igual a :"
        Label1.Text = Label1.Text + diferenciaDias











    End Sub

    Private Sub DateTime1_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged

    End Sub
End Class
