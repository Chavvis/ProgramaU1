Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class Registro
    Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\BD\dbProgramN.accdb")
    Dim VariableAr As String
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim consulta As New OleDbCommand
        My.Computer.FileSystem.CopyFile(txtImagen.Text, "C:\IMG\" + VariableAr)
        txtNuevaRuta.Text = "C:\IMG\" + VariableAr
        consulta.Connection = conexion
        consulta.CommandType = CommandType.Text
        consulta.CommandText = ("INSERT INTO tbUsuarios (Usuario,Direccion,Correo,Telefono,Imagen,FechaNa,Contra) VALUES ('" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtCorreo.Text & "','" & txtTelefono.Text & "','" & txtNuevaRuta.Text & "','" & dtpFecha.Text & "', '" & txtContase.Text & "')")
        conexion.Open()
        consulta.ExecuteNonQuery()
        conexion.Close()
        MsgBox("Datos guardados ")
        Log.Show()
        Me.Hide()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtImagen.Text = ""
        dtpFecha.Text = ""
        txtContase.Text = ""
    End Sub

    Private Sub btnSelectImg_Click(sender As Object, e As EventArgs) Handles btnSelectImg.Click
        Dim dlAbrir As New System.Windows.Forms.OpenFileDialog
        dlAbrir.ShowDialog()
        txtImagen.Text = dlAbrir.FileName
        VariableAr = Path.GetFileName(dlAbrir.FileName)

    End Sub
End Class
