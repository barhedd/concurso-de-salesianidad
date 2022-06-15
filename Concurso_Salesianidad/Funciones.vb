Module Funciones
    Public equipos_cant As Byte
    Public equipos(20) As String

    'VARIABLES PÚBLICAS QUE SE USAN EN MÁS DE UN FORMULARIO
    Public i As Byte 'Variable que controla la pregunta mostrada (es un número porque indica el índice de la matriz)
    Public categoria As String 'Variable que nos permite modificar el color y las preguntas a mostrar en el 
    'Form "Preguntas" según la categoría elegida en el menú
    Public preguntas(100, 5) As String 'Matriz donde se guardan las preguntas
    Public repetidos(0) As Integer 'Arreglo donde se guardan que las preguntas que vayan mostrándose
    Public colegios_repetidos(0) As Integer
    Public colegiosINSCRITOS(0) As String
    Public aleatorio As New Random 'Generación del número Random
    Public j As Byte 'Variable que nos sirve para controlar el índice del arreglo "repetidos"
    Public colegios As Byte = 0

    'Variables de conteos de puntos
    Public equipo1 As Byte = 0
    Public equipo2 As Byte = 0
    Public equipo3 As Byte = 0
    Public equipo4 As Byte = 0


    'FUNCIÓN PARA VALIDAR QUE LAS PREGUNTAS NO SE VUELVAN A REPETIR
    Function repetidas(i As Byte) As Boolean
        Dim total As Byte = repetidos.Length - 1
        For j = 0 To total
            If i = repetidos(j) Then
                Return True
            End If
        Next
        Return False
    End Function

    'FUNCIÓN PARA VALIDAR QUE NINGÚN COLEGIO SE VUELVA A REPETIR
    Function colegiosREPETIDOS(colegios As Byte) As Boolean
        Dim total As Byte = colegios_repetidos.Length - 1
        For k = 0 To total
            If colegios = colegios_repetidos(k) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub mostrar(ByRef picFormar As PictureBox, ByRef lblFormar As Label, ByRef lblIngresa As Label,
                       ByRef lblEquipos As Label, ByRef GroupBox1 As GroupBox, ByRef PictureBox1 As PictureBox)
        picFormar.Visible = True
        lblFormar.Visible = True
        lblIngresa.Visible = False
        lblEquipos.Visible = False
        GroupBox1.Visible = False
        PictureBox1.Left = PictureBox1.Left + 40
    End Sub
End Module
