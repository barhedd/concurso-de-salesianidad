<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.picSalir = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picInscribir = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.picSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInscribir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSalir
        '
        Me.picSalir.BackColor = System.Drawing.Color.DarkBlue
        Me.picSalir.BackgroundImage = CType(resources.GetObject("picSalir.BackgroundImage"), System.Drawing.Image)
        Me.picSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSalir.Location = New System.Drawing.Point(1226, 656)
        Me.picSalir.Name = "picSalir"
        Me.picSalir.Size = New System.Drawing.Size(68, 56)
        Me.picSalir.TabIndex = 48
        Me.picSalir.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 47.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(441, 542)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 69)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Inscribir equipos"
        '
        'picInscribir
        '
        Me.picInscribir.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.picInscribir.BackgroundImage = CType(resources.GetObject("picInscribir.BackgroundImage"), System.Drawing.Image)
        Me.picInscribir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picInscribir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picInscribir.Location = New System.Drawing.Point(535, 318)
        Me.picInscribir.Name = "picInscribir"
        Me.picInscribir.Size = New System.Drawing.Size(237, 199)
        Me.picInscribir.TabIndex = 46
        Me.picInscribir.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(792, 79)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Concurso de Salesianidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(920, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 335)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Location = New System.Drawing.Point(12, 246)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(397, 335)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox3.Location = New System.Drawing.Point(99, 167)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1124, 83)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1300, 720)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picInscribir)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.picSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInscribir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSalir As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picInscribir As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
