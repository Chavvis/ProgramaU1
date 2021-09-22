<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Captura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAlumnos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardad = New System.Windows.Forms.Button()
        Me.txtCalificacion = New System.Windows.Forms.TextBox()
        Me.cbMateria = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumnos:"
        '
        'cbAlumnos
        '
        Me.cbAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAlumnos.FormattingEnabled = True
        Me.cbAlumnos.Location = New System.Drawing.Point(15, 34)
        Me.cbAlumnos.Margin = New System.Windows.Forms.Padding(0)
        Me.cbAlumnos.Name = "cbAlumnos"
        Me.cbAlumnos.Size = New System.Drawing.Size(121, 21)
        Me.cbAlumnos.TabIndex = 1
        Me.cbAlumnos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Materia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calificacion:"
        '
        'btnGuardad
        '
        Me.btnGuardad.Location = New System.Drawing.Point(15, 137)
        Me.btnGuardad.Name = "btnGuardad"
        Me.btnGuardad.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardad.TabIndex = 4
        Me.btnGuardad.Text = "Guardar"
        Me.btnGuardad.UseVisualStyleBackColor = True
        '
        'txtCalificacion
        '
        Me.txtCalificacion.Location = New System.Drawing.Point(95, 100)
        Me.txtCalificacion.Name = "txtCalificacion"
        Me.txtCalificacion.Size = New System.Drawing.Size(121, 20)
        Me.txtCalificacion.TabIndex = 6
        '
        'cbMateria
        '
        Me.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMateria.FormattingEnabled = True
        Me.cbMateria.Location = New System.Drawing.Point(95, 68)
        Me.cbMateria.Margin = New System.Windows.Forms.Padding(0)
        Me.cbMateria.Name = "cbMateria"
        Me.cbMateria.Size = New System.Drawing.Size(121, 21)
        Me.cbMateria.TabIndex = 7
        Me.cbMateria.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(205, 137)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Captura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 206)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.cbMateria)
        Me.Controls.Add(Me.txtCalificacion)
        Me.Controls.Add(Me.btnGuardad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAlumnos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Captura"
        Me.Text = "Captura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbAlumnos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardad As Button
    Friend WithEvents txtCalificacion As TextBox
    Friend WithEvents cbMateria As ComboBox
    Friend WithEvents btnActualizar As Button
End Class
