Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class RegisterAlumsXD
    Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\BD\dbProgramN.accdb")
    Dim VariableaR, VariableC As String
    Private Sub RegisterAlumsXD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BD\dbProgramN.accdb"
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim consulta As New OleDbCommand
        Dim activo As Integer
        If (CheckBox1.Checked = True) Then
            activo = 1
        Else
            activo = 0
        End If
        If (rdAlumno.Checked = True) Then
            My.Computer.FileSystem.CopyFile(TextBox1.Text, "C:\IMG\" + VariableaR)
            txtNuevaRuta.Text = "C:\IMG\" + VariableaR
            consulta.Connection = conexion
            consulta.CommandType = CommandType.Text
            consulta.CommandText = ("INSERT INTO tbAlumnos (Nombre,Imagen,Carrera,Direccion,Telefono,FechaNa,FechaIns,Activo) VALUES ('" & txtNombre.Text & "','" & txtNuevaRuta.Text & "','" & txtCarrera.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "','" & dtpFechaNa.Text & "','" & dtpFechaIns.Text & "'," & activo & ")")
            conexion.Open()
            consulta.ExecuteNonQuery()
            conexion.Close()
        ElseIf (rdmDocente.Checked = True) Then
            My.Computer.FileSystem.CopyFile(TextBox1.Text, "C:\IMG\" + VariableaR)
            txtNuevaRuta.Text = "C:\IMG\" + VariableaR
            My.Computer.FileSystem.CopyFile(txtCedula.Text, "C:\IMG\" + VariableC)
            txtRutaNCed.Text = "C:\IMG\" + VariableC
            consulta.Connection = conexion
            consulta.CommandType = CommandType.Text
            consulta.CommandText = ("INSERT INTO tbProfesores (Nombre,Direccion,Telefono,Imagen,FechaNa,Carrera,CedulaPro,Activo) VALUES ('" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "','" & txtNuevaRuta.Text & "','" & dtpFechaNa.Text & "','" & txtCarrera.Text & "','" & txtRutaNCed.Text & "'," & activo & ")")
            conexion.Open()
            consulta.ExecuteNonQuery()
            conexion.Close()
        End If
        MsgBox("Datos Guardados con exito", MsgBoxStyle.Information, "UwU")
        txtNombre.Text = ""
        TextBox1.Text = ""
        txtCarrera.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCedula.Text = ""
        CheckBox1.Checked = False
    End Sub

    Private Sub txtImgBus_Click(sender As Object, e As EventArgs) Handles txtImgBus.Click
        Dim dlAbrir As New System.Windows.Forms.OpenFileDialog
        dlAbrir.ShowDialog()
        TextBox1.Text = dlAbrir.FileName
        VariableaR = Path.GetFileName(dlAbrir.FileName)
        PictureBox1.Image = Image.FromFile(TextBox1.Text)
    End Sub

    Private Sub rdAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles rdAlumno.CheckedChanged
        dtpFechaIns.Visible = True
        txtCedula.Visible = False
        lbInscripcion.Visible = True
        lbCedula.Visible = False
        btnCedBus.Visible = False
    End Sub

    Private Sub rdmDocente_CheckedChanged(sender As Object, e As EventArgs) Handles rdmDocente.CheckedChanged
        dtpFechaIns.Visible = False
        txtCedula.Visible = True
        lbInscripcion.Visible = False
        lbCedula.Visible = True
        btnCedBus.Visible = True
    End Sub

    Private Sub btnCedBus_Click(sender As Object, e As EventArgs) Handles btnCedBus.Click
        Dim dlAbrir As New System.Windows.Forms.OpenFileDialog
        dlAbrir.ShowDialog()
        txtCedula.Text = dlAbrir.FileName
        VariableC = Path.GetFileName(dlAbrir.FileName)
    End Sub
End Class