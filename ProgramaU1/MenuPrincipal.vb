Public Class MenuPrincipal
    Dim mover As Boolean
    Dim px, py As Integer

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventanas(RegisterAlumsXD)
    End Sub

    Private Sub Ventanas(ven As Form)
        ven.TopLevel = False
        ven.Dock = DockStyle.Fill
        PanelCentral.Controls.Add(ven)
        ven.Show()
    End Sub

    Private Sub btnCreden_Click(sender As Object, e As EventArgs) Handles btnCreden.Click
        CredencialesView.ShowDialog()
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        End
    End Sub
End Class