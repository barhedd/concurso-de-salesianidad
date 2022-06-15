Public Class Resultados
    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = colegiosINSCRITOS(0)
        Label2.Text = colegiosINSCRITOS(1)
        If colegiosINSCRITOS.Count > 2 Then
            Label3.Text = colegiosINSCRITOS(2)
        ElseIf colegiosINSCRITOS.Count <= 2 Then
            Label3.Visible = False
            lblPuntaje3.Visible = False
        End If
        If colegiosINSCRITOS.Count > 3 Then
            Label4.Text = colegiosINSCRITOS(3)
        ElseIf colegiosINSCRITOS.Count <= 3 Then
            Label4.Visible = False
            lblPuntaje4.Visible = False
        End If

        'Asignación de puntos al jugador 1
        If equipo1 = 1 Then
            lblPuntaje1.Text = equipo1 & " punto"
        ElseIf equipo1 <> 1 Then
            lblPuntaje1.Text = equipo1 & " puntos"
        End If

        'Asignación de puntos al jugador 
        If equipo2 = 1 Then
            lblPuntaje2.Text = equipo2 & " punto"
        ElseIf equipo2 <> 1 Then
            lblPuntaje2.Text = equipo2 & " puntos"
        End If

        'Asignación de puntos al jugador 3
        If equipo3 = 1 Then
            lblPuntaje3.Text = equipo3 & " punto"
        ElseIf equipo3 <> 1 Then
            lblPuntaje3.Text = equipo3 & " puntos"
        End If

        'Asignación de puntos al jugador 4
        If equipo4 = 1 Then
            lblPuntaje4.Text = equipo4 & " punto"
        ElseIf equipo4 <> 1 Then
            lblPuntaje4.Text = equipo4 & " puntos"
        End If
    End Sub

    Private Sub picComenzar_Click(sender As Object, e As EventArgs) Handles picComenzar.Click
        colegiosINSCRITOS = Nothing
        ReDim colegiosINSCRITOS(0)
        Me.Close()
        Inscripcion.Show()
    End Sub

    Private Sub picSalir_Click(sender As Object, e As EventArgs) Handles picSalir.Click
        Me.Close()
        Inicio.Close()
    End Sub
End Class