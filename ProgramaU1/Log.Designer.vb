<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Me.txtUsua = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.tbnEntrar = New System.Windows.Forms.Button()
        Me.linklbregis = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbxHead = New System.Windows.Forms.PictureBox()
        CType(Me.pbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsua
        '
        Me.txtUsua.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtUsua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsua.ForeColor = System.Drawing.Color.Black
        Me.txtUsua.Location = New System.Drawing.Point(66, 98)
        Me.txtUsua.Name = "txtUsua"
        Me.txtUsua.Size = New System.Drawing.Size(158, 22)
        Me.txtUsua.TabIndex = 0
        Me.txtUsua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.ForeColor = System.Drawing.Color.Black
        Me.txtContra.Location = New System.Drawing.Point(66, 176)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(158, 22)
        Me.txtContra.TabIndex = 1
        Me.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbnEntrar
        '
        Me.tbnEntrar.Location = New System.Drawing.Point(173, 237)
        Me.tbnEntrar.Name = "tbnEntrar"
        Me.tbnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.tbnEntrar.TabIndex = 2
        Me.tbnEntrar.Text = "Entrar"
        Me.tbnEntrar.UseVisualStyleBackColor = True
        '
        'linklbregis
        '
        Me.linklbregis.AutoSize = True
        Me.linklbregis.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklbregis.LinkColor = System.Drawing.Color.White
        Me.linklbregis.Location = New System.Drawing.Point(27, 245)
        Me.linklbregis.Name = "linklbregis"
        Me.linklbregis.Size = New System.Drawing.Size(71, 15)
        Me.linklbregis.TabIndex = 3
        Me.linklbregis.TabStop = True
        Me.linklbregis.Text = "Registrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'pbxHead
        '
        Me.pbxHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pbxHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxHead.Location = New System.Drawing.Point(0, 0)
        Me.pbxHead.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxHead.Name = "pbxHead"
        Me.pbxHead.Size = New System.Drawing.Size(297, 29)
        Me.pbxHead.TabIndex = 6
        Me.pbxHead.TabStop = False
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 308)
        Me.Controls.Add(Me.pbxHead)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.linklbregis)
        Me.Controls.Add(Me.tbnEntrar)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsua)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Log"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log"
        CType(Me.pbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsua As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents tbnEntrar As Button
    Friend WithEvents linklbregis As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxHead As PictureBox
End Class
