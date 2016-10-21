Public Class frmSelectSquadShooters

    Private Sub listShooters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listShooters.SelectedIndexChanged
        Add(listShooters.SelectedItem)
    End Sub

    Private Sub Add(ByVal name)
        If frmSquads.txtbxShooter1.Text = "" Then
            frmSquads.txtbxShooter1.Text = name
        ElseIf frmSquads.txtbxShooter2.Text = "" Then
            frmSquads.txtbxShooter2.Text = name
        ElseIf frmSquads.txtbxShooter3.Text = "" Then
            frmSquads.txtbxShooter3.Text = name
        ElseIf frmSquads.txtbxShooter4.Text = "" Then
            frmSquads.txtbxShooter4.Text = name
        ElseIf frmSquads.txtbxShooter5.Text = "" Then
            frmSquads.txtbxShooter5.Text = name
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
    End Sub
End Class