Imports System.Data.OleDb
Imports System.Data
Public Class Log
    Dim conexion As New OleDbConnection
    Dim mover As Boolean
    Dim px, py As Integer
    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BD\dbProgramN.accdb"
    End Sub
    Private Sub tbnEntrar_Click(sender As Object, e As EventArgs) Handles tbnEntrar.Click
        'If(txtUsua.getText().equals(""))
        If (txtUsua.Text = "" Or txtUsua.Text = "") Then
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim adaptador As New OleDbDataAdapter("SELECT * FROM tbUsuarios WHERE Usuario= '" & txtUsua.Text & "' AND Contra='" & txtContra.Text & "'", conexion)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        If (datos.Tables(0).Rows.Count) > 0 Then
            MsgBox("Datos correcto perro")
            'Registro sig = Registro()
            'sig.setVisible(True)
            MenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario no existente")
        End If


    End Sub

    Private Sub linklbregis_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbregis.LinkClicked
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub pbxHead_MouseDown(sender As Object, e As MouseEventArgs) Handles pbxHead.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub pbxHead_MouseUp(sender As Object, e As MouseEventArgs) Handles pbxHead.MouseUp
        mover = False
    End Sub

    Private Sub pbxHead_MouseMove(sender As Object, e As MouseEventArgs) Handles pbxHead.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub
End Class