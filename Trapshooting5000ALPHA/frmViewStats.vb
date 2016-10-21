Public Class frmViewStats

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooterFilter.Click
        frmSelectSquadShooters.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmMainScreen.Visible = True
    End Sub
End Class