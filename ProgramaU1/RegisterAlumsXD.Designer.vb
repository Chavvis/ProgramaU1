<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterAlumsXD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbInscripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dtpFechaNa = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIns = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtImgBus = New System.Windows.Forms.Button()
        Me.txtNuevaRuta = New System.Windows.Forms.TextBox()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdmDocente = New System.Windows.Forms.RadioButton()
        Me.rdAlumno = New System.Windows.Forms.RadioButton()
        Me.lbCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnCedBus = New System.Windows.Forms.Button()
        Me.txtRutaNCed = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(138, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(123, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(605, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(523, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 43)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'lbInscripcion
        '
        Me.lbInscripcion.AutoSize = True
        Me.lbInscripcion.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbInscripcion.Location = New System.Drawing.Point(499, 326)
        Me.lbInscripcion.Name = "lbInscripcion"
        Me.lbInscripcion.Size = New System.Drawing.Size(259, 43)
        Me.lbInscripcion.TabIndex = 4
        Me.lbInscripcion.Text = "Fecha de Inscripcion:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(12, 126)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(368, 47)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Text = "EDWIN"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtDireccion.Location = New System.Drawing.Point(12, 517)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(368, 47)
        Me.txtDireccion.TabIndex = 7
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtTelefono.Location = New System.Drawing.Point(469, 126)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(368, 47)
        Me.txtTelefono.TabIndex = 8
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(940, 562)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(121, 57)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'dtpFechaNa
        '
        Me.dtpFechaNa.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaNa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNa.Location = New System.Drawing.Point(542, 248)
        Me.dtpFechaNa.Name = "dtpFechaNa"
        Me.dtpFechaNa.Size = New System.Drawing.Size(214, 47)
        Me.dtpFechaNa.TabIndex = 13
        '
        'dtpFechaIns
        '
        Me.dtpFechaIns.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaIns.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIns.Location = New System.Drawing.Point(542, 373)
        Me.dtpFechaIns.Name = "dtpFechaIns"
        Me.dtpFechaIns.Size = New System.Drawing.Size(214, 47)
        Me.dtpFechaIns.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(469, 468)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 38)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(146, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 43)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Imagen:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(12, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(368, 47)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImgBus
        '
        Me.txtImgBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtImgBus.Location = New System.Drawing.Point(386, 254)
        Me.txtImgBus.Name = "txtImgBus"
        Me.txtImgBus.Size = New System.Drawing.Size(45, 34)
        Me.txtImgBus.TabIndex = 18
        Me.txtImgBus.Text = "..."
        Me.txtImgBus.UseVisualStyleBackColor = True
        '
        'txtNuevaRuta
        '
        Me.txtNuevaRuta.Location = New System.Drawing.Point(302, 222)
        Me.txtNuevaRuta.Name = "txtNuevaRuta"
        Me.txtNuevaRuta.Size = New System.Drawing.Size(35, 20)
        Me.txtNuevaRuta.TabIndex = 19
        Me.txtNuevaRuta.Visible = False
        '
        'txtCarrera
        '
        Me.txtCarrera.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtCarrera.Location = New System.Drawing.Point(12, 373)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.Size = New System.Drawing.Size(368, 47)
        Me.txtCarrera.TabIndex = 20
        Me.txtCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(138, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 43)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Carrera:"
        '
        'rdmDocente
        '
        Me.rdmDocente.AutoSize = True
        Me.rdmDocente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdmDocente.Location = New System.Drawing.Point(604, 12)
        Me.rdmDocente.Name = "rdmDocente"
        Me.rdmDocente.Size = New System.Drawing.Size(106, 28)
        Me.rdmDocente.TabIndex = 22
        Me.rdmDocente.Text = "Docente"
        Me.rdmDocente.UseVisualStyleBackColor = True
        '
        'rdAlumno
        '
        Me.rdAlumno.AutoSize = True
        Me.rdAlumno.Checked = True
        Me.rdAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAlumno.Location = New System.Drawing.Point(457, 12)
        Me.rdAlumno.Name = "rdAlumno"
        Me.rdAlumno.Size = New System.Drawing.Size(100, 28)
        Me.rdAlumno.TabIndex = 23
        Me.rdAlumno.TabStop = True
        Me.rdAlumno.Text = "Alumno"
        Me.rdAlumno.UseVisualStyleBackColor = True
        '
        'lbCedula
        '
        Me.lbCedula.AutoSize = True
        Me.lbCedula.BackColor = System.Drawing.Color.Transparent
        Me.lbCedula.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbCedula.Location = New System.Drawing.Point(596, 326)
        Me.lbCedula.Name = "lbCedula"
        Me.lbCedula.Size = New System.Drawing.Size(104, 43)
        Me.lbCedula.TabIndex = 24
        Me.lbCedula.Text = "Cedula:"
        Me.lbCedula.Visible = False
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtCedula.Location = New System.Drawing.Point(469, 373)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(368, 47)
        Me.txtCedula.TabIndex = 25
        Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCedula.Visible = False
        '
        'btnCedBus
        '
        Me.btnCedBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCedBus.Location = New System.Drawing.Point(843, 380)
        Me.btnCedBus.Name = "btnCedBus"
        Me.btnCedBus.Size = New System.Drawing.Size(45, 34)
        Me.btnCedBus.TabIndex = 27
        Me.btnCedBus.Text = "..."
        Me.btnCedBus.UseVisualStyleBackColor = True
        '
        'txtRutaNCed
        '
        Me.txtRutaNCed.Location = New System.Drawing.Point(764, 337)
        Me.txtRutaNCed.Name = "txtRutaNCed"
        Me.txtRutaNCed.Size = New System.Drawing.Size(35, 20)
        Me.txtRutaNCed.TabIndex = 28
        Me.txtRutaNCed.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.ProgramaU1.My.Resources.Resources.UsuaLogo
        Me.PictureBox1.Location = New System.Drawing.Point(853, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'RegisterAlumsXD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 631)
        Me.Controls.Add(Me.txtRutaNCed)
        Me.Controls.Add(Me.btnCedBus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lbCedula)
        Me.Controls.Add(Me.rdAlumno)
        Me.Controls.Add(Me.rdmDocente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCarrera)
        Me.Controls.Add(Me.txtNuevaRuta)
        Me.Controls.Add(Me.txtImgBus)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dtpFechaIns)
        Me.Controls.Add(Me.dtpFechaNa)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbInscripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterAlumsXD"
        Me.Text = "RegisterAlumsXD"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbInscripcion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dtpFechaNa As DateTimePicker
    Friend WithEvents dtpFechaIns As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtImgBus As Button
    Friend WithEvents txtNuevaRuta As TextBox
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rdmDocente As RadioButton
    Friend WithEvents rdAlumno As RadioButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCedBus As Button
    Friend WithEvents txtRutaNCed As TextBox
End Class
