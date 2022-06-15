Imports System.IO
Imports System.Text

Public Class Preguntas
    Dim c As Integer, linea As String
    Dim preguntas(100, 5) As String
    Dim pregunta As Byte = 1
    Dim tiempo As Integer = 15

    Private Sub Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbTeam1.Visible = True
        rdbTeam1.Text = colegiosINSCRITOS(0)
        lblJugador1.Visible = True

        rdbTeam2.Visible = True
        rdbTeam2.Text = colegiosINSCRITOS(1)
        lblJugador2.Visible = True


        If colegiosINSCRITOS.Count = 2 Then
            rdbTeam3.Visible = False
        Else
            rdbTeam3.Visible = True
            rdbTeam3.Text = colegiosINSCRITOS(2)
            lblJugador3.Visible = True
        End If

        If colegiosINSCRITOS.Count = 3 Then
            rdbTeam4.Visible = False
        Else
            rdbTeam4.Visible = True
            rdbTeam4.Text = colegiosINSCRITOS(3)
            lblJugador4.Visible = True
        End If
        Try
            'Abrimos el archivo usando StreamReader
            Using sr As New StreamReader("Cj_DB.txt", Encoding.Default)
                'leemos cada línea del archivo usando una repetitiva
                Do
                    'Se almacena en linea la linea actual en el archivo
                    linea = sr.ReadLine()
                    'Se verifica que la línea no este vacia 
                    If Not linea Is Nothing Then
                        'Se fragmenta la línea por el delimitador, para extraer los campos
                        Dim vector() As String = Split(linea, "|")
                        preguntas(c, 0) = vector(0)
                        preguntas(c, 1) = vector(1)
                        preguntas(c, 2) = vector(2)
                        preguntas(c, 3) = vector(3)
                        preguntas(c, 4) = vector(4)
                        preguntas(c, 5) = vector(5)
                        c += 1
                    End If
                    'se repite hasta q la línea leída sea vacio, es decir
                    'cuando se hayan leido todas las líneas del archivo
                Loop Until linea Is Nothing
            End Using
        Catch ex As Exception
            'Si se da un error se muestra el mensaje
            MsgBox("El archivo no existe " & ex.Message)
        End Try

        'Generamos un número aleatorio para mostrar una pregunta en orden aleatorio
        i = aleatorio.Next(0, 59)

        'Llenamos el espacio correspondiente de la pregunta (txtPregunta) con los datos de la matriz
        txtPregunta.Text = preguntas(i, 0)

        'Llenamos el espacio correspondiente de las opciones de respuesta (RadioButton) con los datos de la matriz
        rdbRespuesta1.Text = preguntas(i, 1)
        rdbRespuesta2.Text = preguntas(i, 2)
        rdbRespuesta3.Text = preguntas(i, 3)
        rdbRespuesta4.Text = preguntas(i, 4)
    End Sub

    'Botón que nos lleva al formulario de inicio (sirve para abandonar el juego en cualquier momento)
    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        colegiosINSCRITOS = Nothing
        ReDim colegiosINSCRITOS(0)
        equipo1 = 0
        equipo2 = 0
        equipo3 = 0
        equipo4 = 0
        Me.Close() 'Cerramos el formulario 
        Inicio.Show() 'Abrimos el formulario de Inicio
    End Sub


    'Modificamos el color del texto de los RadioButton de respuesta acorde a la selección del usuario
    'Si el usuario selecciona la respuesta 1, el texto de la respuesta (item) cambia a color naranja y los demás no cambian
    Private Sub rdbRespuesta1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRespuesta1.CheckedChanged
        Tim1.Stop()
        Label1.Visible = False
        lblTemporizador.Visible = False
        lblTemporizador.Text = "15 segundos"

        If rdbTeam1.Checked = True Then
            'Si el rdbRespuesta1 (ITEM A) contiene la respuesta correcta, su texto cambia a color verde
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text = preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo1 += 1
                lblJugador1.Text = equipo1
            End If

            'Si el rdbRespuesta1 (ITEM A) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text <> preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo1 += 0
                lblJugador1.Text = equipo1
            End If
        End If

        If rdbTeam2.Checked = True Then
            'Si el rdbRespuesta1 (ITEM A) contiene la respuesta correcta, su texto cambia a color verde
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text = preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo2 += 1
                lblJugador2.Text = equipo2
            End If

            'Si el rdbRespuesta1 (ITEM A) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text <> preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo2 += 0
                lblJugador2.Text = equipo2
            End If
        End If

        If rdbTeam3.Checked = True Then
            'Si el rdbRespuesta1 (ITEM A) contiene la respuesta correcta, su texto cambia a color verde
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text = preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo3 += 1
                lblJugador3.Text = equipo3
            End If

            'Si el rdbRespuesta1 (ITEM A) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text <> preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo3 += 0
                lblJugador3.Text = equipo3
            End If
        End If

        If rdbTeam4.Checked = True Then
            'Si el rdbRespuesta1 (ITEM A) contiene la respuesta correcta, su texto cambia a color verde
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text = preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo4 += 1
                lblJugador4.Text = equipo4
            End If

            'Si el rdbRespuesta1 (ITEM A) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta1.Checked = True AndAlso rdbRespuesta1.Text <> preguntas(i, 5) Then
                rdbRespuesta1.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo4 += 0
                lblJugador4.Text = equipo4
            End If
        End If

        'Cambio de color de las RESPUESTAS
        rdbRespuesta2.ForeColor = Color.Black
        rdbRespuesta3.ForeColor = Color.Black
        rdbRespuesta4.ForeColor = Color.Black

        'Activamos el botón "Siguiente"
        btnSiguiente.Enabled = True
        btnSiguiente.Visible = True
    End Sub

    'Si el usuario selecciona la respuesta 2, "rdbRespuesta2" cambia a color naranja y los demás no cambian
    Private Sub rdbRespuesta2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRespuesta2.CheckedChanged
        Tim1.Stop()
        Label1.Visible = False
        lblTemporizador.Visible = False
        lblTemporizador.Text = "15 segundos"

        'Si el rdbRespuesta2 (ITEM B) contiene la respuesta correcta, su texto cambia a color verde
        If rdbTeam1.Checked = True Then
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text = preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo1 += 1
                lblJugador1.Text = equipo1
            End If

            'Si el rdbRespuesta2 (ITEM B) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text <> preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo1 += 0
                lblJugador1.Text = equipo1
            End If
        End If

        If rdbTeam2.Checked = True Then
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text = preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo2 += 1
                lblJugador2.Text = equipo2
            End If

            'Si el rdbRespuesta2 (ITEM B) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text <> preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo2 += 0
                lblJugador2.Text = equipo2
            End If
        End If


        If rdbTeam3.Checked = True Then
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text = preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo3 += 1
                lblJugador3.Text = equipo3
            End If

            'Si el rdbRespuesta2 (ITEM B) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text <> preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo3 += 0
                lblJugador3.Text = equipo3
            End If
        End If


        If rdbTeam4.Checked = True Then
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text = preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo4 += 1
                lblJugador4.Text = equipo4
            End If

            'Si el rdbRespuesta2 (ITEM B) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta2.Checked = True AndAlso rdbRespuesta2.Text <> preguntas(i, 5) Then
                rdbRespuesta2.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo4 += 0
                lblJugador4.Text = equipo4
            End If
        End If

        'Cambio de color de las RESPUESTAS
        rdbRespuesta1.ForeColor = Color.Black
        rdbRespuesta3.ForeColor = Color.Black
        rdbRespuesta4.ForeColor = Color.Black

        'Activamos el botón "Siguiente"
        btnSiguiente.Enabled = True
        btnSiguiente.Visible = True
    End Sub

    'Si el usuario selecciona la respuesta 3, "rdbRespuesta3" cambia a color naranja y los demás no cambian
    Private Sub rdbRespuesta3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRespuesta3.CheckedChanged
        Tim1.Stop()
        Label1.Visible = False
        lblTemporizador.Visible = False
        lblTemporizador.Text = "15 segundos"

        'Si el rdbRespuesta3 (ITEM C) contiene la respuesta correcta, su texto cambia a color verde
        If rdbTeam1.Checked = True Then
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text = preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo1 += 1
                lblJugador1.Text = equipo1
            End If

            'Si el rdbRespuesta3 (ITEM C) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text <> preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo1 += 0
                lblJugador1.Text = equipo1
            End If
        End If

        If rdbTeam2.Checked = True Then
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text = preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo2 += 1
                lblJugador2.Text = equipo2
            End If

            'Si el rdbRespuesta3 (ITEM C) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text <> preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo2 += 0
                lblJugador2.Text = equipo2
            End If
        End If

        If rdbTeam3.Checked = True Then
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text = preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo3 += 1
                lblJugador3.Text = equipo3
            End If

            'Si el rdbRespuesta3 (ITEM C) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text <> preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo3 += 0
                lblJugador3.Text = equipo3
            End If
        End If

        If rdbTeam4.Checked = True Then
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text = preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo4 += 1
                lblJugador4.Text = equipo4
            End If

            'Si el rdbRespuesta3 (ITEM C) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta3.Checked = True AndAlso rdbRespuesta3.Text <> preguntas(i, 5) Then
                rdbRespuesta3.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo4 += 0
                lblJugador4.Text = equipo4
            End If
        End If

        'Cambio de color de las RESPUESTAS
        rdbRespuesta1.ForeColor = Color.Black
        rdbRespuesta2.ForeColor = Color.Black
        rdbRespuesta4.ForeColor = Color.Black

        'Activamos el botón "Siguiente"
        btnSiguiente.Enabled = True
        btnSiguiente.Visible = True
    End Sub


    'Si el usuario selecciona la respuesta 4, "rdbRespuesta3" cambia a color naranja y los demás no cambian
    Private Sub rdbRespuesta4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRespuesta4.CheckedChanged
        Tim1.Stop()
        Label1.Visible = False
        lblTemporizador.Visible = False
        lblTemporizador.Text = "15 segundos"

        'Si el rdbRespuesta4 (ITEM D) contiene la respuesta correcta, su texto cambia a color verde
        If rdbTeam1.Checked = True Then
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text = preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo1 += 1
                lblJugador1.Text = equipo1
            End If

            'Si el rdbRespuesta4 (ITEM D) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text <> preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo1 += 0
                lblJugador1.Text = equipo1
            End If
        End If

        If rdbTeam2.Checked = True Then
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text = preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo2 += 1
                lblJugador2.Text = equipo2
            End If

            'Si el rdbRespuesta4 (ITEM D) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text <> preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo2 += 0
                lblJugador2.Text = equipo2
            End If
        End If

        If rdbTeam3.Checked = True Then
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text = preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo3 += 1
                lblJugador3.Text = equipo3
            End If

            'Si el rdbRespuesta4 (ITEM D) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text <> preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo3 += 0
                lblJugador3.Text = equipo3
            End If
        End If

        If rdbTeam4.Checked = True Then
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text = preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.DarkGreen
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "¡Correcto!"
                lblResultado.ForeColor = Color.DarkGreen
                equipo4 += 1
                lblJugador4.Text = equipo4
            End If

            'Si el rdbRespuesta4 (ITEM D) fue seleccionado por el usuario pero no contiene la respuesta correcta, se cambia el color de la letra a rojo
            If rdbRespuesta4.Checked = True AndAlso rdbRespuesta4.Text <> preguntas(i, 5) Then
                rdbRespuesta4.ForeColor = Color.Red
                'Activamos el label que nos mostrará los mensajes "¡Correcto!" o "Incorrecto"
                lblResultado.Visible = True
                lblResultado.Text = "Incorrecto"
                lblResultado.ForeColor = Color.Red
                equipo4 += 0
                lblJugador4.Text = equipo4
            End If
        End If

        'Cambio de color de las RESPUESTAS
        rdbRespuesta1.ForeColor = Color.Black
        rdbRespuesta2.ForeColor = Color.Black
        rdbRespuesta3.ForeColor = Color.Black

        'Activamos el botón "Siguiente"
        btnSiguiente.Enabled = True
        btnSiguiente.Visible = True
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Me.Close()
        Resultados.Show()
    End Sub

    Private Sub picSalir_Click(sender As Object, e As EventArgs) Handles picSalir.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub rdbTeam1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTeam1.CheckedChanged
        rdbTeam1.ForeColor = Color.DarkGreen
        rdbTeam2.ForeColor = Color.Black
        rdbTeam3.ForeColor = Color.Black
        rdbTeam4.ForeColor = Color.Black

    End Sub

    Private Sub rdbTeam2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTeam2.CheckedChanged
        rdbTeam1.ForeColor = Color.Black
        rdbTeam2.ForeColor = Color.DarkGreen
        rdbTeam3.ForeColor = Color.Black
        rdbTeam4.ForeColor = Color.Black

    End Sub

    Private Sub rdbTeam3_CheckedChanged(sender As Object, e As EventArgs)
        rdbTeam1.ForeColor = Color.Black
        rdbTeam2.ForeColor = Color.Black
        rdbTeam3.ForeColor = Color.DarkGreen
        rdbTeam4.ForeColor = Color.Black

    End Sub

    Private Sub rdbTeam4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTeam4.CheckedChanged
        rdbTeam1.ForeColor = Color.Black
        rdbTeam2.ForeColor = Color.Black
        rdbTeam3.ForeColor = Color.Black
        rdbTeam4.ForeColor = Color.DarkGreen

    End Sub

    Private Sub Tim1_Tick(sender As Object, e As EventArgs) Handles Tim1.Tick
        tiempo -= 1
        lblTemporizador.Text = tiempo & " segundos"
        If tiempo = 1 Then
            lblTemporizador.Text = tiempo & " segundo"
        End If
        If tiempo = 0 Then
            Tim1.Stop()
            Label1.Visible = False
            lblTemporizador.Visible = False
            lblResultado.Visible = True
            lblResultado.Text = "Ups! Tiempo"
            lblResultado.ForeColor = Color.Red
            equipo1 += 0
            equipo2 += 0
            equipo3 += 0
            equipo4 += 0
            btnSiguiente.Enabled = True
            btnSiguiente.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tim1.Start()
        Button1.Visible = False
    End Sub



    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        tiempo = 15

        '  Ocultamos el Label que muestra el resultado de la respuesta
        lblResultado.Visible = False

        'Deseleccionamos todos los RadioButton
        rdbRespuesta1.Checked = False
        rdbRespuesta2.Checked = False
        rdbRespuesta3.Checked = False
        rdbRespuesta4.Checked = False
        rdbTeam1.Checked = False
        rdbTeam2.Checked = False
        rdbTeam3.Checked = False
        rdbTeam4.Checked = False

        'Devolvemos el color negro a todos los RadioButton que contienen las posibles respuestas
        'ITEMS (RadioButton)
        rdbRespuesta1.ForeColor = Color.Black
        rdbRespuesta2.ForeColor = Color.Black
        rdbRespuesta3.ForeColor = Color.Black
        rdbRespuesta4.ForeColor = Color.Black
        rdbTeam1.ForeColor = Color.Black
        rdbTeam2.ForeColor = Color.Black
        rdbTeam3.ForeColor = Color.Black
        rdbTeam4.ForeColor = Color.Black

        If repetidos.Count = 58 Then
            repetidos = Nothing 'Limpiamos el arreglo
            ReDim repetidos(0) 'Lo redimensionamos
        End If

        'Volvemos a llenar todos los campos interactivos con la siguiente preguntas
        ReDim Preserve repetidos(UBound(repetidos) + 1) 'Aumentamos un espacio más al arreglo "repetidos" usando la función UBound
        repetidos(UBound(repetidos)) = i 'Guardamos el número aleatorio en el último espacio del arreglo recién generado
        Do
            'Generamos un número aleatorio para mostrar una pregunta al azar
            i = aleatorio.Next(0, 59)
        Loop Until repetidas(i) = False 'Si el índice de la matriz ya ha salido con anterioridad, generamos otro índice

        'Llenamos el espacio correspondiente de la pregunta (txtPregunta) con los datos de la matriz
        txtPregunta.Text = preguntas(i, 0)

        'Llenamos el espacio correspondiente de las opciones de respuesta (RadioButton) con los datos de la matriz
        rdbRespuesta1.Text = preguntas(i, 1)
        rdbRespuesta2.Text = preguntas(i, 2)
        rdbRespuesta3.Text = preguntas(i, 3)
        rdbRespuesta4.Text = preguntas(i, 4)

        'Sumamos 1 a la contadora de preguntas (Label 4)
        pregunta += 1

        'Volvemos a mostrar todos los RadioButton por si se llegó a usar el 50:50 
        rdbRespuesta1.Visible = True
        rdbRespuesta2.Visible = True
        rdbRespuesta3.Visible = True
        rdbRespuesta4.Visible = True

        'Ocultamos el botón siguiente
        btnSiguiente.Enabled = False
        btnSiguiente.Visible = False

        Button1.Visible = True
        Label1.Visible = True
        lblTemporizador.Visible = True


    End Sub
End Class