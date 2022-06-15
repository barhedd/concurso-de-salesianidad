Public Class Inicio
    Private Sub picSalir_Click(sender As Object, e As EventArgs) Handles picSalir.Click
        Me.Close()
    End Sub

    Private Sub picInscribir_Click(sender As Object, e As EventArgs) Handles picInscribir.Click
        Me.Hide()
        Inscripcion.Show()
    End Sub
End Class