Public Class frmAfterMatchNotes

    Private Sub FinishClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlFinishContainer.Click, lblFinish.Click, pnlFinishIcon.Click
        Me.Visible = False
        frmMainScreen.Visible = True

        'Reset Everything
        'PreMatch
        frmPreMatch.txtbxShooter1.Text = ""
        frmPreMatch.txtbxShooter2.Text = ""
        frmPreMatch.txtbxShooter3.Text = ""
        frmPreMatch.txtbxShooter4.Text = ""
        frmPreMatch.txtbxShooter5.Text = ""
        'PreMatch2
        frmPreMatch2.txtbxCurrentLocation.Text = ""
        frmPreMatch2.txtbxEventDescription.Text = ""
        frmPreMatch2.txtbxNotes.Text = ""
        frmPreMatch2.numNumRounds.Value = 2
        'Scorekeeping
        frmScorekeeping.cb0.Checked = False
        frmScorekeeping.cb1.Checked = False
        frmScorekeeping.cb2.Checked = False
        frmScorekeeping.cb3.Checked = False
        frmScorekeeping.cb4.Checked = False
        frmScorekeeping.cb5.Checked = False
        frmScorekeeping.cb6.Checked = False
        frmScorekeeping.cb7.Checked = False
        frmScorekeeping.cb8.Checked = False
        frmScorekeeping.cb9.Checked = False
        frmScorekeeping.cb10.Checked = False
        frmScorekeeping.cb11.Checked = False
        frmScorekeeping.cb12.Checked = False
        frmScorekeeping.cb12.Checked = False
        frmScorekeeping.cb13.Checked = False
        frmScorekeeping.cb14.Checked = False
        frmScorekeeping.cb15.Checked = False
        frmScorekeeping.cb16.Checked = False
        frmScorekeeping.cb17.Checked = False
        frmScorekeeping.cb18.Checked = False
        frmScorekeeping.cb19.Checked = False
        frmScorekeeping.cb20.Checked = False
        frmScorekeeping.cb21.Checked = False
        frmScorekeeping.cb22.Checked = False
        frmScorekeeping.cb23.Checked = False
        frmScorekeeping.cb24.Checked = False
        frmScorekeeping.chkbxAutoNext.Checked = False
        frmScorekeeping.lblHard.Visible = False
        frmScorekeeping.lblHitOrMiss.Visible = False
        frmScorekeeping.btnShooterPos1.BackColor = Color.FromArgb(0, 192, 0)
        frmScorekeeping.btnShooterPos2.BackColor = Color.Green
        frmScorekeeping.btnShooterPos3.BackColor = Color.Green
        frmScorekeeping.btnShooterPos4.BackColor = Color.Green
        frmScorekeeping.btnShooterPos5.BackColor = Color.Green
    End Sub

End Class