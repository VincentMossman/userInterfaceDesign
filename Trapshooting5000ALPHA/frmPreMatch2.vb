Public Class frmPreMatch2



    Private Sub listLocations_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listLocations.SelectedIndexChanged
        txtbxCurrentLocation.Text = listLocations.SelectedItem
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmPreMatch.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShooters.Click
        Me.Visible = False
        frmPreMatch.Visible = True
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlNext.Click
        Me.Visible = False
        frmScorekeeping.Visible = True
    End Sub

    Private Sub frmPreMatch2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdoNo.Checked = True
    End Sub
End Class