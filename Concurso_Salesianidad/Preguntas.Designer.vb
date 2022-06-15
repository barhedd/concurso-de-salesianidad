<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preguntas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preguntas))
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbRespuesta4 = New System.Windows.Forms.RadioButton()
        Me.rdbRespuesta3 = New System.Windows.Forms.RadioButton()
        Me.rdbRespuesta2 = New System.Windows.Forms.RadioButton()
        Me.rdbRespuesta1 = New System.Windows.Forms.RadioButton()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblJugador4 = New System.Windows.Forms.Label()
        Me.lblJugador3 = New System.Windows.Forms.Label()
        Me.lblJugador2 = New System.Windows.Forms.Label()
        Me.lblJugador1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdbTeam1 = New System.Windows.Forms.RadioButton()
        Me.rdbTeam2 = New System.Windows.Forms.RadioButton()
        Me.rdbTeam4 = New System.Windows.Forms.RadioButton()
        Me.picSalir = New System.Windows.Forms.PictureBox()
        Me.rdbTeam3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTemporizador = New System.Windows.Forms.Label()
        Me.Tim1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPregunta
        '
        Me.txtPregunta.BackColor = System.Drawing.Color.LightGray
        Me.txtPregunta.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregunta.Location = New System.Drawing.Point(96, 265)
        Me.txtPregunta.Multiline = True
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.ReadOnly = True
        Me.txtPregunta.Size = New System.Drawing.Size(1106, 101)
        Me.txtPregunta.TabIndex = 95
        Me.txtPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTitulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTitulo.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTitulo.Location = New System.Drawing.Point(365, 41)
        Me.txtTitulo.Multiline = True
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(621, 57)
        Me.txtTitulo.TabIndex = 86
        Me.txtTitulo.Text = "Concurso de Salesianidad"
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Berlin Sans FB", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(530, 119)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(285, 71)
        Me.lblResultado.TabIndex = 93
        Me.lblResultado.Text = "¡Correcto!"
        Me.lblResultado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rdbRespuesta4)
        Me.GroupBox1.Controls.Add(Me.rdbRespuesta3)
        Me.GroupBox1.Controls.Add(Me.rdbRespuesta2)
        Me.GroupBox1.Controls.Add(Me.rdbRespuesta1)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1158, 208)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Respuestas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(573, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 32)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "d)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 32)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "c)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(573, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 32)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "b)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "a)"
        '
        'rdbRespuesta4
        '
        Me.rdbRespuesta4.AutoSize = True
        Me.rdbRespuesta4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbRespuesta4.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRespuesta4.Location = New System.Drawing.Point(619, 125)
        Me.rdbRespuesta4.Name = "rdbRespuesta4"
        Me.rdbRespuesta4.Size = New System.Drawing.Size(188, 34)
        Me.rdbRespuesta4.TabIndex = 3
        Me.rdbRespuesta4.TabStop = True
        Me.rdbRespuesta4.Text = "RadioButton4"
        Me.rdbRespuesta4.UseVisualStyleBackColor = True
        '
        'rdbRespuesta3
        '
        Me.rdbRespuesta3.AutoSize = True
        Me.rdbRespuesta3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbRespuesta3.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRespuesta3.Location = New System.Drawing.Point(66, 126)
        Me.rdbRespuesta3.Name = "rdbRespuesta3"
        Me.rdbRespuesta3.Size = New System.Drawing.Size(187, 34)
        Me.rdbRespuesta3.TabIndex = 2
        Me.rdbRespuesta3.TabStop = True
        Me.rdbRespuesta3.Text = "RadioButton3"
        Me.rdbRespuesta3.UseVisualStyleBackColor = True
        '
        'rdbRespuesta2
        '
        Me.rdbRespuesta2.AutoSize = True
        Me.rdbRespuesta2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbRespuesta2.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRespuesta2.Location = New System.Drawing.Point(620, 49)
        Me.rdbRespuesta2.Name = "rdbRespuesta2"
        Me.rdbRespuesta2.Size = New System.Drawing.Size(187, 34)
        Me.rdbRespuesta2.TabIndex = 1
        Me.rdbRespuesta2.TabStop = True
        Me.rdbRespuesta2.Text = "RadioButton2"
        Me.rdbRespuesta2.UseVisualStyleBackColor = True
        '
        'rdbRespuesta1
        '
        Me.rdbRespuesta1.AutoSize = True
        Me.rdbRespuesta1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbRespuesta1.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRespuesta1.Location = New System.Drawing.Point(66, 50)
        Me.rdbRespuesta1.Name = "rdbRespuesta1"
        Me.rdbRespuesta1.Size = New System.Drawing.Size(182, 34)
        Me.rdbRespuesta1.TabIndex = 0
        Me.rdbRespuesta1.TabStop = True
        Me.rdbRespuesta1.Text = "RadioButton1"
        Me.rdbRespuesta1.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Gold
        Me.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSiguiente.Location = New System.Drawing.Point(570, 626)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(166, 70)
        Me.btnSiguiente.TabIndex = 120
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        Me.btnSiguiente.Visible = False
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.Gold
        Me.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnTerminar.Location = New System.Drawing.Point(1150, 642)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(138, 66)
        Me.btnTerminar.TabIndex = 121
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbTeam3)
        Me.GroupBox2.Controls.Add(Me.rdbTeam4)
        Me.GroupBox2.Controls.Add(Me.rdbTeam2)
        Me.GroupBox2.Controls.Add(Me.rdbTeam1)
        Me.GroupBox2.Controls.Add(Me.lblJugador4)
        Me.GroupBox2.Controls.Add(Me.lblJugador3)
        Me.GroupBox2.Controls.Add(Me.lblJugador2)
        Me.GroupBox2.Controls.Add(Me.lblJugador1)
        Me.GroupBox2.Location = New System.Drawing.Point(103, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 210)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'lblJugador4
        '
        Me.lblJugador4.AutoSize = True
        Me.lblJugador4.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador4.ForeColor = System.Drawing.Color.Red
        Me.lblJugador4.Location = New System.Drawing.Point(183, 158)
        Me.lblJugador4.Name = "lblJugador4"
        Me.lblJugador4.Size = New System.Drawing.Size(38, 38)
        Me.lblJugador4.TabIndex = 78
        Me.lblJugador4.Text = "0"
        Me.lblJugador4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJugador4.Visible = False
        '
        'lblJugador3
        '
        Me.lblJugador3.AutoSize = True
        Me.lblJugador3.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador3.ForeColor = System.Drawing.Color.Red
        Me.lblJugador3.Location = New System.Drawing.Point(183, 114)
        Me.lblJugador3.Name = "lblJugador3"
        Me.lblJugador3.Size = New System.Drawing.Size(38, 38)
        Me.lblJugador3.TabIndex = 76
        Me.lblJugador3.Text = "0"
        Me.lblJugador3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJugador3.Visible = False
        '
        'lblJugador2
        '
        Me.lblJugador2.AutoSize = True
        Me.lblJugador2.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador2.ForeColor = System.Drawing.Color.Red
        Me.lblJugador2.Location = New System.Drawing.Point(183, 65)
        Me.lblJugador2.Name = "lblJugador2"
        Me.lblJugador2.Size = New System.Drawing.Size(38, 38)
        Me.lblJugador2.TabIndex = 74
        Me.lblJugador2.Text = "0"
        Me.lblJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJugador2.Visible = False
        '
        'lblJugador1
        '
        Me.lblJugador1.AutoSize = True
        Me.lblJugador1.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador1.ForeColor = System.Drawing.Color.Red
        Me.lblJugador1.Location = New System.Drawing.Point(183, 16)
        Me.lblJugador1.Name = "lblJugador1"
        Me.lblJugador1.Size = New System.Drawing.Size(38, 38)
        Me.lblJugador1.TabIndex = 63
        Me.lblJugador1.Text = "0"
        Me.lblJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJugador1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Concurso_Salesianidad.My.Resources.Resources.DBpensativo
        Me.PictureBox1.Location = New System.Drawing.Point(1015, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'rdbTeam1
        '
        Me.rdbTeam1.AutoSize = True
        Me.rdbTeam1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbTeam1.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTeam1.Location = New System.Drawing.Point(9, 20)
        Me.rdbTeam1.Name = "rdbTeam1"
        Me.rdbTeam1.Size = New System.Drawing.Size(129, 34)
        Me.rdbTeam1.TabIndex = 79
        Me.rdbTeam1.TabStop = True
        Me.rdbTeam1.Text = "Jugador1"
        Me.rdbTeam1.UseVisualStyleBackColor = True
        Me.rdbTeam1.Visible = False
        '
        'rdbTeam2
        '
        Me.rdbTeam2.AutoSize = True
        Me.rdbTeam2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbTeam2.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTeam2.Location = New System.Drawing.Point(9, 69)
        Me.rdbTeam2.Name = "rdbTeam2"
        Me.rdbTeam2.Size = New System.Drawing.Size(134, 34)
        Me.rdbTeam2.TabIndex = 80
        Me.rdbTeam2.TabStop = True
        Me.rdbTeam2.Text = "Jugador2"
        Me.rdbTeam2.UseVisualStyleBackColor = True
        Me.rdbTeam2.Visible = False
        '
        'rdbTeam4
        '
        Me.rdbTeam4.AutoSize = True
        Me.rdbTeam4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbTeam4.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTeam4.Location = New System.Drawing.Point(9, 162)
        Me.rdbTeam4.Name = "rdbTeam4"
        Me.rdbTeam4.Size = New System.Drawing.Size(135, 34)
        Me.rdbTeam4.TabIndex = 82
        Me.rdbTeam4.TabStop = True
        Me.rdbTeam4.Text = "Jugador4"
        Me.rdbTeam4.UseVisualStyleBackColor = True
        Me.rdbTeam4.Visible = False
        '
        'picSalir
        '
        Me.picSalir.BackgroundImage = CType(resources.GetObject("picSalir.BackgroundImage"), System.Drawing.Image)
        Me.picSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSalir.Location = New System.Drawing.Point(1235, 3)
        Me.picSalir.Name = "picSalir"
        Me.picSalir.Size = New System.Drawing.Size(62, 54)
        Me.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSalir.TabIndex = 131
        Me.picSalir.TabStop = False
        '
        'rdbTeam3
        '
        Me.rdbTeam3.AutoSize = True
        Me.rdbTeam3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbTeam3.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTeam3.Location = New System.Drawing.Point(9, 118)
        Me.rdbTeam3.Name = "rdbTeam3"
        Me.rdbTeam3.Size = New System.Drawing.Size(134, 34)
        Me.rdbTeam3.TabIndex = 83
        Me.rdbTeam3.TabStop = True
        Me.rdbTeam3.Text = "Jugador3"
        Me.rdbTeam3.UseVisualStyleBackColor = True
        Me.rdbTeam3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(506, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 54)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Tiempo restante:"
        '
        'lblTemporizador
        '
        Me.lblTemporizador.AutoSize = True
        Me.lblTemporizador.Font = New System.Drawing.Font("Berlin Sans FB", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemporizador.Location = New System.Drawing.Point(550, 172)
        Me.lblTemporizador.Name = "lblTemporizador"
        Me.lblTemporizador.Size = New System.Drawing.Size(250, 54)
        Me.lblTemporizador.TabIndex = 133
        Me.lblTemporizador.Text = "15 segundos"
        '
        'Tim1
        '
        Me.Tim1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(807, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 31)
        Me.Button1.TabIndex = 134
        Me.Button1.Text = "Tiempo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1300, 720)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTemporizador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.txtPregunta)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Preguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPregunta As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rdbRespuesta4 As RadioButton
    Friend WithEvents rdbRespuesta3 As RadioButton
    Friend WithEvents rdbRespuesta2 As RadioButton
    Friend WithEvents rdbRespuesta1 As RadioButton
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnTerminar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblJugador4 As Label
    Friend WithEvents lblJugador3 As Label
    Friend WithEvents lblJugador2 As Label
    Friend WithEvents lblJugador1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rdbTeam4 As RadioButton
    Friend WithEvents rdbTeam2 As RadioButton
    Friend WithEvents rdbTeam1 As RadioButton
    Friend WithEvents picSalir As PictureBox
    Friend WithEvents rdbTeam3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTemporizador As Label
    Friend WithEvents Tim1 As Timer
    Friend WithEvents Button1 As Button
End Class
