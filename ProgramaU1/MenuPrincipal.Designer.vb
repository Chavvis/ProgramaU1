<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.btnCreden = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxHead = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.LightBlue
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Location = New System.Drawing.Point(0, 74)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(1188, 631)
        Me.PanelCentral.TabIndex = 4
        '
        'btnCreden
        '
        Me.btnCreden.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCreden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreden.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.btnCreden.ForeColor = System.Drawing.Color.White
        Me.btnCreden.Location = New System.Drawing.Point(100, 33)
        Me.btnCreden.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCreden.Name = "btnCreden"
        Me.btnCreden.Size = New System.Drawing.Size(132, 41)
        Me.btnCreden.TabIndex = 0
        Me.btnCreden.Text = "Generar credencial"
        Me.btnCreden.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1188, 41)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pbxHead
        '
        Me.pbxHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pbxHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbxHead.Location = New System.Drawing.Point(0, 0)
        Me.pbxHead.Name = "pbxHead"
        Me.pbxHead.Size = New System.Drawing.Size(1188, 33)
        Me.pbxHead.TabIndex = 1
        Me.pbxHead.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pbCerrar.Image = Global.ProgramaU1.My.Resources.Resources.X
        Me.pbCerrar.Location = New System.Drawing.Point(1155, 0)
        Me.pbCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(33, 33)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCerrar.TabIndex = 0
        Me.pbCerrar.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 705)
        Me.Controls.Add(Me.pbCerrar)
        Me.Controls.Add(Me.btnCreden)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbxHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxHead As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents btnCreden As Button
    Friend WithEvents pbCerrar As PictureBox
End Class
