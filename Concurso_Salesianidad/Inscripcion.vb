Public Class Inscripcion
    Dim contadora1 As Byte = 0
    Dim contadora2 As Byte = 0
    Dim contadora3 As Byte = 0
    Dim contadora4 As Byte = 0
    Dim contadora5 As Byte = 0
    Dim contadora6 As Byte = 0
    Dim contadora7 As Byte = 0
    Dim contadora8 As Byte = 0
    Dim contadora9 As Byte = 0
    Dim contadora10 As Byte = 0
    Dim control As Byte = 0
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (IsNumeric(e.KeyChar)) Or e.KeyChar = (Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Inscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picFormar_Click(sender As Object, e As EventArgs)
        Me.Close()
        contadora1 = 0
        contadora2 = 0
        contadora3 = 0
        contadora4 = 0
        contadora5 = 0
        contadora6 = 0
        contadora7 = 0
        contadora8 = 0
        contadora9 = 0
        contadora10 = 0
        colegios = 0
        'SeleccionRandom.Show()
    End Sub

    Private Sub picDonBosco_Click(sender As Object, e As EventArgs) Handles picDonBosco.Click
        contadora1 += 1
        If contadora1 Mod 2 <> 0 Then
            picDonBosco.BackgroundImage = Nothing
            picDonBosco.Image = Nothing
            picDonBosco.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then
                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "Don Bosco"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "Don Bosco"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora1 Mod 2 = 0 Then
            picDonBosco.BackgroundImage = Nothing
            picDonBosco.Image = Nothing
            picDonBosco.Image = My.Resources.ATLETA_DE_DIOS
            colegios -= 1
        End If

        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select

    End Sub

    Private Sub picRical_Click(sender As Object, e As EventArgs) Handles picRical.Click
        contadora2 += 1
        If contadora2 Mod 2 <> 0 Then
            picRical.BackgroundImage = Nothing
            picRical.Image = Nothing
            picRical.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count > 1 Then
                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "Ricaldone"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "Ricaldone"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora2 Mod 2 = 0 Then
            picRical.BackgroundImage = Nothing
            picRical.Image = Nothing
            picRical.Image = My.Resources.ricaldone
            colegios -= 1
        End If


        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select
    End Sub

    Private Sub picCMA_Click(sender As Object, e As EventArgs) Handles picCMA.Click
        contadora3 += 1
        If contadora3 Mod 2 <> 0 Then
            picCMA.BackgroundImage = Nothing
            picCMA.Image = Nothing
            picCMA.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then

                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "CMA"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "CMA"

                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora3 Mod 2 = 0 Then
            picCMA.BackgroundImage = Nothing
            picCMA.Image = Nothing
            picCMA.Image = My.Resources.Logo
            colegios -= 1
        End If


        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select

    End Sub

    Private Sub picESMA_Click(sender As Object, e As EventArgs) Handles picESMA.Click
        contadora4 += 1
        If contadora4 Mod 2 <> 0 Then
            picESMA.BackgroundImage = Nothing
            picESMA.Image = Nothing
            picESMA.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then

                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "ESMA"

                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "ESMA"

                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora4 Mod 2 = 0 Then
            picESMA.BackgroundImage = Nothing
            picESMA.Image = Nothing
            picESMA.Image = My.Resources.Logo
            colegios -= 1
        End If

        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select
    End Sub

    Private Sub picSanJose_Click(sender As Object, e As EventArgs) Handles picSanJose.Click
        contadora5 += 1
        If contadora5 Mod 2 <> 0 Then
            picSanJose.BackgroundImage = Nothing
            picSanJose.Image = Nothing
            picSanJose.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then
                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "San José"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "San José"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora5 Mod 2 = 0 Then
            picSanJose.BackgroundImage = Nothing
            picSanJose.Image = Nothing
            picSanJose.Image = My.Resources.sanjose1
            colegios -= 1
        End If


        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select

    End Sub

    Private Sub picMazzarello_Click(sender As Object, e As EventArgs) Handles picMazzarello.Click
        contadora6 += 1
        If contadora6 Mod 2 <> 0 Then
            picMazzarello.BackgroundImage = Nothing
            picMazzarello.Image = Nothing
            picMazzarello.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then
                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "Mazzarello"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "Mazzarello"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora6 Mod 2 = 0 Then
            picMazzarello.BackgroundImage = Nothing
            picMazzarello.Image = Nothing
            picMazzarello.Image = My.Resources.mazzarello1
            colegios -= 1
        End If


        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select

    End Sub

    Private Sub picSantaInes_Click(sender As Object, e As EventArgs) Handles picSantaInes.Click
        contadora7 += 1
        If contadora7 Mod 2 <> 0 Then
            picSantaInes.BackgroundImage = Nothing
            picSantaInes.Image = Nothing
            picSantaInes.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then

                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "Santa Inés"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "Santa Inés"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora7 Mod 2 = 0 Then
            picSantaInes.BackgroundImage = Nothing
            picSantaInes.Image = Nothing
            picSantaInes.Image = My.Resources.santa_ines1
            colegios -= 1
        End If


        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select
    End Sub

    Private Sub picChaleco_Click(sender As Object, e As EventArgs) Handles picChaleco.Click
        contadora8 += 1
        If contadora8 Mod 2 <> 0 Then
            picChaleco.BackgroundImage = Nothing
            picChaleco.Image = Nothing
            picChaleco.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then

                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "Santa Cecilia"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "Santa Cecilia"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora8 Mod 2 = 0 Then
            picChaleco.BackgroundImage = Nothing
            picChaleco.Image = Nothing
            picChaleco.Image = My.Resources.escudo_amarillo1
            colegios -= 1
        End If

        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select
    End Sub

    Private Sub picSavio_Click(sender As Object, e As EventArgs) Handles picSavio.Click
        contadora9 += 1
        If contadora9 Mod 2 <> 0 Then
            picSavio.BackgroundImage = Nothing
            picSavio.Image = Nothing
            picSavio.Image = My.Resources.success
            colegios += 1
            If colegiosINSCRITOS.Count <> 1 Then

                colegiosINSCRITOS(UBound(colegiosINSCRITOS)) = "D. Savio"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            ElseIf colegiosINSCRITOS.Count = 1 Then
                colegiosINSCRITOS(0) = "D. Savio"
                ReDim Preserve colegiosINSCRITOS(UBound(colegiosINSCRITOS) + 1)
            End If
        End If

        If contadora9 Mod 2 = 0 Then
            picSavio.BackgroundImage = Nothing
            picSavio.Image = Nothing
            picSavio.Image = My.Resources.domingo1
            colegios -= 1
        End If

        Select Case colegios
            Case 0 To 1
                picComenzar.Visible = False
                Label17.Visible = False
            Case 2 To 10
                picComenzar.Visible = True
                Label17.Visible = True
        End Select

    End Sub

    Private Sub picJugar_Click(sender As Object, e As EventArgs)
        Me.Close()
        Preguntas.Show()
        contadora1 = 0
        contadora2 = 0
        contadora3 = 0
        contadora4 = 0
        contadora5 = 0
        contadora6 = 0
        contadora7 = 0
        contadora8 = 0
        contadora9 = 0
        contadora10 = 0
        colegios = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picComenzar.Click
        Me.Close()
        Preguntas.Show()
    End Sub

    Private Sub picSalir_Click(sender As Object, e As EventArgs) Handles picSalir.Click
        Me.Close()
        Inicio.Close()
    End Sub
End Class