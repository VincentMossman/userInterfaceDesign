Public Class frmLocation

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub

    Private Sub btnShooter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooters.Click
        Me.Visible = False
        frmSShooters.Visible = True
    End Sub

    Private Sub btnSquads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquads.Click
        Me.Visible = False
        frmSquads.Visible = True
    End Sub

End Class