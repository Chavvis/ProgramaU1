Imports System.Data.OleDb
Imports System.Data
Public Class CredencialesView
    Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\BD\dbProgramN.accdb")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim adaptador As New OleDbDataAdapter("SELECT * FROM tbUsuarios WHERE ID= " & txtId.Text & "", conexion)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        If (datos.Tables(0).Rows.Count > 0) Then
            lbNombre.Text = datos.Tables(0).Rows(0).Item("Usuario")
            lbTelefono.Text = datos.Tables(0).Rows(0).Item("Telefono")
            lbDireccion.Text = datos.Tables(0).Rows(0).Item("Direccion")
            lbFechana.Text = datos.Tables(0).Rows(0).Item("FechaNa")
            PictureBox1.Image = Image.FromFile(datos.Tables(0).Rows(0).Item("Imagen"))
        End If
    End Sub

    Private Sub CredencialesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BD\dbProgramN.accdb"
    End Sub
End Class