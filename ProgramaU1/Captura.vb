Imports System.Data.OleDb
Imports System.Data
Public Class Captura
    Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\BD\dbProgramN.accdb")
    Private Sub Captura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adaptador As New OleDbDataAdapter("SELECT * FROM tbAlumnos", conexion)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        Dim adaptadore As New OleDbDataAdapter("SELECT * FROM tbMaterias", conexion)
        Dim dato As New DataSet
        adaptadore.Fill(dato)

        cbAlumnos.DataSource = datos.Tables(0)
        cbAlumnos.DisplayMember = "Nombre"
        cbAlumnos.ValueMember = "ID"

        cbMateria.DataSource = dato.Tables(0)
        cbMateria.DisplayMember = "Materia"
        cbMateria.ValueMember = "ID"
    End Sub

    Private Sub btnGuardad_Click(sender As Object, e As EventArgs) Handles btnGuardad.Click
        Dim consulta As New OleDbCommand
        consulta.Connection = conexion
        consulta.CommandType = CommandType.Text
        consulta.CommandText = ("INSERT INTO tbCalificaciones (IdAlumno,IdMateria,Calificacion) VALUES (" & cbAlumnos.SelectedValue & "," & cbMateria.SelectedValue & "," & txtCalificacion.Text & ")")
        conexion.Open()
        consulta.ExecuteNonQuery()
        conexion.Close()
        MsgBox("Datos agregados correctamente")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim consulta As New OleDbCommand
        consulta.Connection = conexion
        consulta.CommandType = CommandType.Text
        consulta.CommandText = ("UPDATE tbCalificaciones SET Calificacion= " & txtCalificacion.Text & " WHERE IdAlumno=" & cbAlumnos.SelectedValue & " AND IdMateria=" & cbMateria.SelectedValue & "")
        conexion.Open()
        consulta.ExecuteNonQuery()
        conexion.Close()
        MsgBox("Datos agregados correctamente")
    End Sub
End Class