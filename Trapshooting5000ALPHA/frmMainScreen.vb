Public Class frmMainScreen

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try
            Dim newShooter As New TrapShootingDataSetTableAdapters.ShootersTableAdapter
            newShooter.Insert("sss", "sss", "ssss", "ssss", 3, "qqq", "qqq")
            TrapShootingDataSet1.Shooters.AcceptChanges()
            newShooter.Update(Me.TrapShootingDataSet1.Shooters)
            MsgBox("Update successful")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStartMatch.Click, pnlStartMatchIcon.Click, pnlStartMatchContainer.Click
        Me.Visible = False
        frmPreMatch.Visible = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblViewStats.Click, pnlViewStatsIcon.Click, pnlViewStatsContainer.Click
        Me.Visible = False
        frmViewStats.Visible = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSetup.Click, pnlSetupIcon.Click, pnlSetupContainer.Click
        Me.Visible = False
        frmSShooters.Visible = True
    End Sub
End Class
